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
        public SendPostRequest(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
        //TODO : Auth, normal user not allowed 
        public void addNewUser(string url, User user)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(Username + ":" + Password));
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/json";

            request.Method = "POST";
            var newUser = JsonConvert.SerializeObject(user);

            byte[] toSend = System.Text.Encoding.ASCII.GetBytes(newUser);
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


            StreamReader sr = new StreamReader(response.GetResponseStream());
            Console.WriteLine(sr.ReadToEnd().Trim());


        }
        // Authorization not required
        public void addNewBroadcast(string url, Broadcast broadcast)
        {

           // string deserialized = JsonConvert.SerializeObject(broadcast);
          //  Console.WriteLine(deserialized);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(Username + ":" + Password));
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/json";
            request.Method = "POST";
          //  var createBroadcast = JsonConvert.SerializeObject(broadcast);
          //  string createBroadcast = "{\"broadcast\": {\"content\": \"Test45 \",\"feeds\": {\"twitter\": 1, \"alumni_email\":\"1\"}}}";
            string createBroadcast = "{\"broadcast\": {\"content\": \"Test45 \",\"feeds\": [1]}}";
            Console.WriteLine(createBroadcast);
            byte[] toSend = System.Text.Encoding.ASCII.GetBytes(createBroadcast);
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
        //    StreamReader sr = new StreamReader(response.GetResponseStream());
           // Console.WriteLine(sr.ReadToEnd().Trim());


        }
    }


}
