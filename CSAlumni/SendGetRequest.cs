using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Web;

namespace CSAlumni
{
    class SendGetRequest
    {
        private string Username;
        private string Password;
        private string Url;
        private string encoded;
        public SendGetRequest(string username, string password, string url)
        {
            this.Username = username;
            this.Password = password;
            this.Url = url;
            encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(Username + ":" + Password));
        }

       public void getUserList()
       {
           WebRequest request;
           request = WebRequest.Create(Url);
           request.Headers.Add("Authorization", "Basic " + encoded);
           
           try
           {
            Stream stream = request.GetResponse().GetResponseStream();
               StreamReader reader = new StreamReader(stream);
               string line = "";
               line = reader.ReadLine();
               //Parses fetched JSON string to User objects.
              List<User> users = JsonConvert.DeserializeObject<List<User>>(line);
              Console.WriteLine(users[0].url);
           }
           catch (WebException ex)
           {
               Console.WriteLine(ex.ToString());
           }
       }
    }
}
