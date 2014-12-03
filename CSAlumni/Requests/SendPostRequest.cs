using CSAlumni.Models;
using CSAlumni.Utils;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace CSAlumni {

    public class SendPostRequest {
        private HttpWebResponse response;
        private string encoded;
        private string password;
        private string url;
        private string username;

        public SendPostRequest(string username, string password, string url) {
            this.username = username;
            this.password = password;
            this.url = url;
            encoded = StringHelper.EncodeString(username, password);
        }

        //TODO : Auth, normal user not allowed
        public int addNew(Object myObject) {
            HttpWebRequest request = null;
            if (myObject is BroadcastToSend) {
               request =  (HttpWebRequest)WebRequest.Create(url + "/broadcasts.json");
            } else if (myObject is User) {
                request = (HttpWebRequest)WebRequest.Create(url + "/users.json");
            } else {
                url = null;
            }
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/json";
            request.Method = "POST";
            string newObject = JsonConvert.SerializeObject(myObject).ToLower();
            byte[] toSend = System.Text.Encoding.ASCII.GetBytes(newObject);
            Stream os = request.GetRequestStream();
            os.Write(toSend, 0, toSend.Length);
    
                response = (HttpWebResponse)request.GetResponse();
                Trace.WriteLine((int)response.StatusCode);
            
            return (int)response.StatusCode;
          
        }
    }
}