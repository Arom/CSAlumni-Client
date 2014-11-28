using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.IO;
using Newtonsoft.Json;

namespace CSAlumni
{
    class SendPostRequest
    {
        string Password, Username;
        string encoded;
        public SendPostRequest(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(Username + ":" + Password));
        }

        //TODO : Auth, normal user not allowed 
        public void addNew(string url, Object myObject)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/json";

            request.Method = "POST";
            var newObject = JsonConvert.SerializeObject(myObject);

            byte[] toSend = System.Text.Encoding.ASCII.GetBytes(newObject);
            var os = request.GetRequestStream();
            os.Write(toSend, 0, toSend.Length);

            WebResponse response;

            try
            {
                response = request.GetResponse();
            }
            catch (WebException ex)
            {
                response = ex.Response;
            }


            // StreamReader sr = new StreamReader(response.GetResponseStream());
            // Console.WriteLine(sr.ReadToEnd().Trim());

        }
    }


}
