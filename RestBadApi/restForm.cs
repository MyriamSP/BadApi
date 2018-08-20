using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestBadApi
{
    public partial class restForm : Form
    {
        public restForm()
        {
            InitializeComponent();
        }

        private void getData_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient();
            client.webAPIaddress = "https://badapi.iqvia.io/api/v1/Tweets?";
            client.startDate = "2016-03-20T04%3A07%3A56.271Z";
            client.endDate = "2016-03-21T04%3A07%3A56.271Z";
            string strJSON = string.Empty;
            strJSON = client.Request();
            //https://badapi.iqvia.io/api/v1/Tweets?startDate=2016-03-20T04%3A07%3A56.271Z&endDate=2016-03-21T04%3A07%3A56.271Z
            try
            {
                textBoxResponse.Text = textBoxResponse.Text + strJSON + Environment.NewLine;
                textBoxResponse.SelectionStart = textBoxResponse.TextLength;
                textBoxResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }

        }
    }
}
