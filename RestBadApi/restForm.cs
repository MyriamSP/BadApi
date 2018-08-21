using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RestBadApi
{
    public partial class restForm : Form
    {
        public restForm()
        {
            InitializeComponent();
        }
        #region Events
        private void getData_Click(object sender, EventArgs e)
        {
            callRestClient();
            

        }
        #endregion
        #region RestClient Call
        private void callRestClient()
        {
            //Create Client and API Address
            RestClient client = new RestClient();
            client.webAPIaddress = "https://badapi.iqvia.io/api/v1/Tweets?";

            DateTime sd = datePickerStartDate.Value.ToUniversalTime();
            DateTime ed = datePickerEndDate.Value.ToUniversalTime();

            getNextTweets(sd, ed, client);

        }

        private void getNextTweets(DateTime startDate, DateTime endDate, RestClient client)
        {
            client.startDate = startDate.ToString();
            client.endDate = endDate.ToString();
            string json = client.Request();
            List<Tweet> tweetList = deserializeTweets(json);


            startDate = tweetList[tweetList.Count-1].stamp.ToUniversalTime().AddSeconds(1);

            while (json != string.Empty && json != "[]" && startDate < endDate)
            {
                client.startDate = startDate.ToString();
                json = client.Request();
                tweetList = tweetList.Concat(deserializeTweets(json)).ToList();
                startDate = tweetList[tweetList.Count-1].stamp.ToUniversalTime().AddSeconds(1);
            }

            //Populate the information
            printDataView(tweetList);
            //printJSON(json);

        }
        #endregion
        #region JSON Deserialization
        private List<Tweet> deserializeTweets(string twtJSON)
        {
            try
            {
                var jtweet = JsonConvert.DeserializeObject<List<Tweet>>(twtJSON);

                return jtweet;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
            return new List<Tweet>();
        }

        #endregion
        #region Handle Duplicate Records
        private List<Tweet> removeDuplicates (List<Tweet> lt)
        {
            IEnumerable<Tweet> noduplicates = lt.Distinct(new TweetComparer());
            return noduplicates.ToList();

        }
        #endregion
        #region Print Tweets
        // Unused Method, used to print in JSON Format.
        private void printJSON(string jsontxt)
        {
            textBoxResponse.Text = textBoxResponse.Text + jsontxt + Environment.NewLine;
            textBoxResponse.SelectionStart = textBoxResponse.TextLength;
            textBoxResponse.ScrollToCaret();
        }

        private void printDataView(List<Tweet> lt)
        {
            //Calculate the total tweets 
            int countTotal = lt.Count;
            List<Tweet> noDupList = removeDuplicates(lt);
            int countNoDup = noDupList.Count;

            textBoxTotalTweets.Text = countNoDup.ToString();
            textBoxDupTweets.Text = (countTotal - countNoDup).ToString();

            //Getting the duplicate tweets
           // List<Tweet> dups = lt.Except(noDupList).ToList();

            dataGridViewTweets.DataSource = lt;

        }
        #endregion
    }
}
