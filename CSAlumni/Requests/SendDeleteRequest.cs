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
    class SendDeleteRequest
    {
        string username;
        string password;
        string encoded;
        string url;
        public SendDeleteRequest(string username, string password, string url)
        {
            this.username = username;
            this.password = password;
            this.url = url;
            encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
        }
 
        public void delete(string url)
        {
            WebRequest request = WebRequest.Create(url);
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.Headers.Add("X-CSRF-Token", "ahMclX3MRwtlZcxZWkcVHbrFM5vNamhVX+p1qbPvgsM=");

            request.Method = "DELETE";
            //try catch

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        }
    }
}
