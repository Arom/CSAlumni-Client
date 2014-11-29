using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.IO;
using Newtonsoft.Json;
using CSAlumni.Utils;
using System.Diagnostics;

namespace CSAlumni
{
    class SendPostRequest
    {
        string password;
        string username;
        string encoded;
        string url;
        public SendPostRequest(string username, string password, string url)
        {
            this.username = username;
            this.password = password;
            this.url = url;
            encoded = StringHelper.EncodeString(username, password);
        }
       
        //TODO : Auth, normal user not allowed 
        public void addNew(Object myObject)
        {
            if (myObject is Broadcast) {
                url = url + "/broadcasts.json";
            } else if (myObject is User) {
                url = url + "/users.json";
            } else {
                url = null;
            }
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/json";
            request.Method = "POST";
            string newObject = JsonConvert.SerializeObject(myObject).ToLower();
            byte[] toSend = System.Text.Encoding.ASCII.GetBytes(newObject);
            Stream os = request.GetRequestStream();
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
            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                Trace.WriteLine(sr.ReadToEnd().Trim());
            }
          
        }
    }


}
