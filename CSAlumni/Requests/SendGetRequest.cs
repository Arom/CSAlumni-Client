using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace CSAlumni {

    public class SendGetRequest {
        private string encoded;
        private string password;
        private HttpWebResponse Response;
        private string url;
        private string username;

        public SendGetRequest(string username, string password, string url) {
            this.username = username;
            this.password = password;
            this.url = url;
            encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
        }

        public List<Broadcast> getBroadcastList() {
            List<Broadcast> broadcasts = null;
            WebRequest request = WebRequest.Create(url + "broadcasts.json?per_page=200");
            request.Headers.Add("Authorization", "Basic " + encoded);
            try {
                Response = (HttpWebResponse)request.GetResponse();
                using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream())) {
                    string line = sr.ReadLine();
                    broadcasts = JsonConvert.DeserializeObject<List<Broadcast>>(line);
                }
            } catch (WebException ex) {
                Response = (HttpWebResponse)ex.Response;
                int responseCode = (int)Response.StatusCode;
                Trace.WriteLine("Error occured, Status Code " + responseCode);
            }
            return broadcasts;
        }

        public List<User> getUserList() {
            List<User> users = null;
            WebRequest request = WebRequest.Create(url + "/users.json?per_page=200");
            request.Headers.Add("Authorization", "Basic " + encoded);
            try {
                Response = (HttpWebResponse)request.GetResponse();
                using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream())) {
                   
                    users = JsonConvert.DeserializeObject<List<User>>(sr.ReadLine());
                }
            } catch (WebException ex) {
                Response = (HttpWebResponse)ex.Response;
                int responseCode = (int)Response.StatusCode;
                Trace.WriteLine("Error. Status Code : " + responseCode);
            }
            return users;
        }

        public Boolean LoginIsValid() {
            Boolean isValid = false;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "/users.json");
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/json";
            request.Method = "GET";
            try {
                Response = (HttpWebResponse)request.GetResponse();

                using (StreamReader sr = new StreamReader(Response.GetResponseStream())) {
                    isValid = true;
                }
            } catch (WebException ex) {
                Response = (HttpWebResponse)ex.Response;
                if (Response != null) {
                    int responseCode = (int)Response.StatusCode;
                    if (responseCode == 41) {
                        Trace.WriteLine("Invalid login credentials. Status code: " + responseCode);
                    } else {
                        Trace.WriteLine(responseCode);
                    }
                }
               
            }
            return isValid;
        }
    }
}