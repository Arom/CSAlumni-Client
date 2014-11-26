using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace CSAlumni
{
    class SendGetRequest
    {
        private string Username;
        private string Password;
        private string Url;
        public SendGetRequest(string username, string password, string url)
        {
            this.Username = username;
            this.Password = password;
            this.Url = url;

        }

       public void getUserList()
       {
           WebRequest request;
           String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(Username + ":" + Password));
         
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
            
           }
           catch (WebException ex)
           {
               Console.WriteLine(ex.ToString());
           }
       }
    }
}
