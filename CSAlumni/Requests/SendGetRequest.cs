using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace CSAlumni {

    internal class SendGetRequest {
        private string encoded;
        private string password;
        private string url;
        private string username;
        private HttpWebResponse response;


        public SendGetRequest(string username, string password, string url) {
            this.username = username;
            this.password = password;
            this.url = url;
            encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
        }
        public void getBroadcastList() {
            WebRequest request = WebRequest.Create(url + "/broadcasts.json");
            request.Headers.Add("Authorization", "Basic " + encoded);
            try {
                response = (HttpWebResponse)request.GetResponse();
                using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream())) {
                    string line = sr.ReadLine();
                    List<Broadcast> broadcasts = JsonConvert.DeserializeObject<List<Broadcast>>(line);
                }
            } catch (WebException ex) {
                response = (HttpWebResponse)ex.Response;
                int responseCode = (int)response.StatusCode;
                Trace.WriteLine("Error occured, Status Code " + responseCode);
            }
        }
        public List<User> getUserList() {
            url = url + "/users.json";
            List<User> users = null;
            WebRequest request = WebRequest.Create(url);
            request.Headers.Add("Authorization", "Basic " + encoded);
            try {
                response = (HttpWebResponse)request.GetResponse();
                using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream())) {
                    string line = sr.ReadLine();
                    Trace.WriteLine(line);
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
            url = url + "/users.json";
            Boolean isValid = false;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/json";
            request.Method = "GET";
            try {
                response = (HttpWebResponse)request.GetResponse();

                using (StreamReader sr = new StreamReader(response.GetResponseStream())) {
                    Trace.WriteLine(sr.ReadToEnd().Trim());
                    isValid = true;
                }
            } catch (WebException ex) {
                response = (HttpWebResponse)ex.Response;
                int responseCode = (int)response.StatusCode;
                if (responseCode == 41) {
                    Trace.WriteLine("Invalid login credentials. Status code: "+ responseCode);
                } else {
                    Trace.WriteLine(responseCode);
                }
            }
            return isValid;
        }
    }
}