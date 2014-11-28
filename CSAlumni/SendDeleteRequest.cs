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
    class SendDeleteRequest
    {
        string Username, Password, encoded;
        public SendDeleteRequest(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(Username + ":" + Password));
        }

        public void delete(string url)
        {
            WebRequest request = WebRequest.Create(url);
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.Method = "DELETE";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        }
    }
}
