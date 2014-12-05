using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace CSAlumni {
    /// <summary>
    /// This class is used to send GET requests to the server.
    /// </summary>
    public class SendGetRequest {
        private string encoded;
        private string password;
        private string url;
        private string username;
        HttpWebResponse Response;


        public SendGetRequest(string username, string password, string url) {
            this.username = username;
            this.password = password;
            this.url = url;
            encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
        }
        /// <summary>
        /// Fetches a current list of broadcasts from the server.
        /// </summary>
        /// <returns>List<Broadcast> object containing current broadcasts.</returns>
        public List<Broadcast> getBroadcastList() {
            List<Broadcast> broadcasts = null;
            WebRequest request = WebRequest.Create(url + "broadcasts.json?per_page=200");
            request.Headers.Add("Authorization", "Basic " + encoded);
            try {
                Response = (HttpWebResponse)request.GetResponse();
                using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream())) {
                    string line = sr.ReadLine();
                    //Deserialziing received JSON string into a List of Broadcasts.
                    broadcasts = JsonConvert.DeserializeObject<List<Broadcast>>(line);
                }
            } catch (WebException ex) {
                Response = (HttpWebResponse)ex.Response;
                int responseCode = (int)Response.StatusCode;
                Trace.WriteLine("Error occured, Status Code " + responseCode);
            }
            Response.Close();

            return broadcasts;
        }
        /// <summary>
        /// Fetches a current list of users from the server.
        /// </summary>
        /// <returns>List<User> object containing current broadcasts.</returns>
        public List<User> getUserList() {
            List<User> users = null;
            WebRequest request = WebRequest.Create(url + "/users.json?per_page=20");
            request.Headers.Add("Authorization", "Basic " + encoded);
            try {
                Response = (HttpWebResponse)request.GetResponse();
                using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream())) {
                    //Deserialziing received JSON string into a List of Users.
                    users = JsonConvert.DeserializeObject<List<User>>(sr.ReadLine());
                
                }
             
            } catch (WebException ex) {
                Response = (HttpWebResponse)ex.Response;
                int responseCode = (int)Response.StatusCode;
                Trace.WriteLine("Error. Status Code : " + responseCode);
            }
            Response.Close();

            return users;
        }
        /// <summary>
        /// Returns whether username/password combination is valid through a basic GET request.
        /// </summary>
        /// <returns>Login is valid or not.</returns>
        public Boolean LoginIsValid() {
            Boolean isValid = false;
            //Basic GET request to determine whether logging user is an admin.
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "/users.json");
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/json";
            request.Method = "GET";
            try {
                Response = (HttpWebResponse)request.GetResponse();
                //If we receive a response, validation succeeded.
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
            if (Response != null) {
                Response.Close();
            }
            return isValid;
        }
    }
}