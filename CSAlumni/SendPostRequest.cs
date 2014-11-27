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
        public void addNewUser(string url, User user){
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(Username + ":" + Password));
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/json";

            request.Method = "POST";
            var updateUser = JsonConvert.SerializeObject(user);

            byte[] toSend = System.Text.Encoding.ASCII.GetBytes(updateUser);
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
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(Username + ":" + Password));
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/json";
            request.Method = "POST";
            
        }
    }


}
