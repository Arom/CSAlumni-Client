using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Web;
using System.Diagnostics;

namespace CSAlumni
{
    class SendGetRequest
    {
        private string username;
        private string password;
        private string url;
        private string encoded;
        public SendGetRequest(string username, string password, string url)
        {
            this.username = username;
            this.password = password;
            this.url = url;
            encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
        }

       public void getUserList()
       {
         
           try
           {
               WebRequest request;
               request = WebRequest.Create(url);
               request.Headers.Add("Authorization", "Basic " + encoded);
               using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream()))
               {
                   string line = sr.ReadLine();
                   List<User> users = JsonConvert.DeserializeObject<List<User>>(line);
                   Trace.WriteLine(users[0].Surname);
               }
         
           }
           catch (WebException ex)
           {
               Console.WriteLine(ex.ToString());
           }
       }
    }
}
