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
        string Username, Password, encoded;
        public SendDeleteRequest(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(Username + ":" + Password));
        }
        public void fetchCSRF(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/json";
            
            request.Method = "GET";
            request.Headers.Add("X-CSRF-Token", "Fetch");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string token = response.Headers.Get("X-CSRF-Token");
            response.Close();
            Trace.WriteLine(token);
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
