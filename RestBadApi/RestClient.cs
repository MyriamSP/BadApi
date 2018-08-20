using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestBadApi
{
    //We only are using GET, but we can add another method in the future.
    public enum httpMethod
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class RestClient
    {
        //API address to connect
        public string webAPIaddress { get; set; }
        //Type of http method
        public httpMethod method { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }

        public RestClient()
        {
            //using GET method by default
            method = httpMethod.GET;
            webAPIaddress = string.Empty;

        }

        public string Request()
        {

            string responseString = string.Empty;
            string Webstring = webAPIaddress + "startDate=" + startDate + "&endDate=" + endDate;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Webstring);
            request.Method = method.ToString();
            
            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();

                //response stream in Json format. 
                //TODO: Parse the Json format.

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            responseString = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: ADD Error Numbers
                responseString = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }

            return responseString;
        }
    }
}
