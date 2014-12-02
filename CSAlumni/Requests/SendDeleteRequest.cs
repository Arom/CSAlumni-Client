using System.Diagnostics;
using System.IO;
using System.Net;

namespace CSAlumni {

    internal class SendDeleteRequest {
        private string encoded;
        private string password;
        private string url;
        private string username;

        public SendDeleteRequest(string username, string password, string url) {
            this.username = username;
            this.password = password;
            this.url = url;
            encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
        }

        public void delete(string type, int id) {
            WebRequest request = WebRequest.Create(url + type + "/" + id + ".json");
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.Method = "DELETE";
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