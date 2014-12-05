using CSAlumni.Models;
using CSAlumni.Utils;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace CSAlumni {
    /// <summary>
    /// This class is used to send POST requests to the server.
    /// </summary>
    public class SendPostRequest {
    
        private string encoded;
        private string password;
        private string url;
        private string username;
        HttpWebResponse Response;


        public SendPostRequest(string username, string password, string url) {
            this.username = username;
            this.password = password;
            this.url = url;
            encoded = StringHelper.EncodeString(username, password);
        }

        /// <summary>
        /// Adds a new object to the server, whether its User or Broadcast. Special case is determined during runtime.
        /// </summary>
        /// <param name="myObject">User or Broadcast object to be added.</param>
        /// <returns>Status code returned. 201 is expected. </returns>
        public int addNew(Object myObject) {
            HttpWebRequest request = null;

            //Determine what type the object is and set the URL appropriately.
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
            Response = (HttpWebResponse)request.GetResponse();
            Trace.WriteLine((int)Response.StatusCode);
            Response.Close();

            return (int)Response.StatusCode;
          
        }
    }
}