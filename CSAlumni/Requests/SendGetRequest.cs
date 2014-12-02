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
        private HttpWebResponse response;
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
                response = (HttpWebResponse)request.GetResponse();
                using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream())) {
                    string line = sr.ReadLine();
                    // Trace.WriteLine(line);
                    broadcasts = JsonConvert.DeserializeObject<List<Broadcast>>(line);
                }
            } catch (WebException ex) {
                response = (HttpWebResponse)ex.Response;
                int responseCode = (int)response.StatusCode;
                Trace.WriteLine("Error occured, Status Code " + responseCode);
            }
            return broadcasts;
        }

        public List<User> getUserList() {
            List<User> users = null;
            WebRequest request = WebRequest.Create(url + "/users.json?per_page=200");
            request.Headers.Add("Authorization", "Basic " + encoded);
            try {
                response = (HttpWebResponse)request.GetResponse();
                using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream())) {
                    string line = sr.ReadLine();
                    users = JsonConvert.DeserializeObject<List<User>>(line);
                }
            } catch (WebException ex) {
                response = (HttpWebResponse)ex.Response;
                int responseCode = (int)response.StatusCode;
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
                response = (HttpWebResponse)request.GetResponse();

                using (StreamReader sr = new StreamReader(response.GetResponseStream())) {
                    isValid = true;
                }
            } catch (WebException ex) {
                response = (HttpWebResponse)ex.Response;
                if (response != null) {
                    int responseCode = (int)response.StatusCode;
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