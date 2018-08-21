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
        private const string API_ENDPOINT = "https://badapi.iqvia.io/api/v1/Tweets?";

        public restForm()
        {
            InitializeComponent();
        }
        #region Events
        private void getData_Click(object sender, EventArgs e)
        {

            Cursor = Cursors.WaitCursor;
            callRestClient();
            Cursor = Cursors.Default;

        }
        #endregion

        #region RestClient Call

        // Perform the operation to call the underlying API  
        private void callRestClient()
        {
            //Create Client and API Address
            RestClient client = new RestClient();
            client.webAPIaddress = API_ENDPOINT;
            //Validation of Selection Dates
            if(datePickerStartDate.Value >= datePickerEndDate.Value)
            {
                string message = "You did not enter a valid StartDate or/and EndDate. \n\n *Please be sure that the Startdate ocurrs before the Enddate. \n *Select at least one day of difference between the StartDate and EndDate.";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);
                return;
            }
            DateTime sd = datePickerStartDate.Value.ToUniversalTime();
            DateTime ed = datePickerEndDate.Value.ToUniversalTime();

            getTweets(sd, ed, client);

        }

        // Call the API programatically to obtain all tweets inside the date range
        private void getTweets(DateTime startDate, DateTime endDate, RestClient client)
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
        // Convert the tweets in json format into Tweet objects
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
        // Remove duplicates from a tweet list
        private List<Tweet> removeDuplicates (List<Tweet> lt)
        {
            IEnumerable<Tweet> noduplicates = lt.Distinct(new TweetComparer());
            return noduplicates.ToList();

        }
        #endregion

        #region Print Tweets
        // Unused Method, used to print in JSON Format.
        //Message Textbox can be used to debug.
        private void printJSON(string jsontxt)
        {
            textBoxResponse.Text = textBoxResponse.Text + jsontxt + Environment.NewLine;
            textBoxResponse.SelectionStart = textBoxResponse.TextLength;
            textBoxResponse.ScrollToCaret();
        }

        // Update the dataView and show the tweets in the table UI
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
