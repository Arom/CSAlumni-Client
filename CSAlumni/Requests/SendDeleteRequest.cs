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
 
        public void delete(string type, int id)
        {            
            Trace.WriteLine(type + " " + id);
            Trace.WriteLine(url + type + "/" + id + ".json");
            WebRequest request = WebRequest.Create(url + type + "/" + id + ".json");
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.Method = "DELETE";
            //string remove = JsonConvert.SerializeObject(id);
            string remove = "";
            byte[] toSend = System.Text.Encoding.ASCII.GetBytes(remove);
            Stream os = request.GetRequestStream();
            os.Write(toSend, 0, toSend.Length);
            WebResponse response;
            try {
                response = request.GetResponse();
            } catch (WebException ex) {
                response = ex.Response;
            }
            using (StreamReader sr = new StreamReader(response.GetResponseStream())) {
                Trace.WriteLine(sr.ReadToEnd().Trim());
            }
        }
    }
}
