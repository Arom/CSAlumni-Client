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

        public SendGetRequest(string username, string password, string url) {
            this.username = username;
            this.password = password;
            this.url = url;
            encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
        }
        public void getBroadcastList(string url) {
            WebRequest request = WebRequest.Create(url + "/broadcasts.json");

        }
        public void getUserList(string url) {
            try {
                WebRequest request = WebRequest.Create(url);
                request.Headers.Add("Authorization", "Basic " + encoded);
                using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream())) {
                    string line = sr.ReadLine();
                    List<User> users = JsonConvert.DeserializeObject<List<User>>(line);
                }
            } catch (WebException ex) {
                Console.WriteLine(ex.ToString());
            }
        }

        public Boolean LoginIsValid(string url) {
            url = url + "/users.json";
            Boolean isValid = false;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/json";
            request.Method = "GET";
            HttpWebResponse response;
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
                    Trace.WriteLine("Invalid login credentials");
                } else {
                    Trace.WriteLine((int)response.StatusCode);
                }
            }
            return isValid;
        }
    }
}