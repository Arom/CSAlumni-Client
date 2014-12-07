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
        string encoded;
        string password;
        string url;
        string username;
        HttpWebResponse response;


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
            WebRequest request = WebRequest.Create(string.Format("{0}broadcasts.json?per_page=200", url));
            request.Headers.Add("Authorization", "Basic " + encoded);
            try {
                response = (HttpWebResponse)request.GetResponse();
                using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream())) {
                    string line = sr.ReadLine();
                    //Deserialziing received JSON string into a List of Broadcasts.
                    broadcasts = JsonConvert.DeserializeObject<List<Broadcast>>(line);
                }
            } catch (WebException ex) {
                response = (HttpWebResponse)ex.Response;
                int responseCode = (int)response.StatusCode;
                Trace.WriteLine("Error occured, Status Code " + responseCode);
            }
            response.Close();

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
                response = (HttpWebResponse)request.GetResponse();
                using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream())) {
                    //Deserialziing received JSON string into a List of Users.
                    users = JsonConvert.DeserializeObject<List<User>>(sr.ReadLine());

                }
                response.Close();

            } catch (WebException ex) {
                if (ex.Response != null) {
                    response = (HttpWebResponse)ex.Response;
                    int responseCode = (int)response.StatusCode;
                    Trace.WriteLine("Error. Status Code : " + responseCode);
                    response.Close();

                } else {
                    Trace.WriteLine("Server unreachable.");
                }
             
            }

            return users;
        }
        /// <summary>
        /// Returns whether username/password combination is valid through a basic GET request.
        /// </summary>
        /// <returns>Login is valid or not.</returns>
        public int LoginIsValid() {
            int responseCode = 0;
            //Basic GET request to determine whether logging user is an admin.
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "/users.json");
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/json";
            request.Method = "GET";
            try {
                response = (HttpWebResponse)request.GetResponse();
                //If we receive a response, validation succeeded.
                using (StreamReader sr = new StreamReader(response.GetResponseStream())) {
                    responseCode = (int)response.StatusCode;
                    Trace.WriteLine((int)response.StatusCode);
                }
            } catch (WebException ex) {
                response = (HttpWebResponse)ex.Response;
                if (response != null) {
                    responseCode = (int)response.StatusCode;
                    if (responseCode == 41) {
                        Trace.WriteLine("Invalid login credentials. Status code: " + responseCode);
                    } else {
                        Trace.WriteLine(responseCode);
                    }
                }

            }
            if (response != null) {
                response.Close();

            }
            return responseCode;

        }
    }
}