using System.Diagnostics;
using System.IO;
using System.Net;

namespace CSAlumni {

  public class SendDeleteRequest {
      private HttpWebResponse Response;
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

        public int delete(string type, int id) {
            WebRequest request = WebRequest.Create(url + type + "/" + id + ".json");
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.Method = "DELETE";
            string remove = "";
            byte[] toSend = System.Text.Encoding.ASCII.GetBytes(remove);
            Stream os = request.GetRequestStream();
            os.Write(toSend, 0, toSend.Length);
            
                Response = (HttpWebResponse)request.GetResponse();
                Trace.WriteLine((int)Response.StatusCode);
   
            return (int)Response.StatusCode;
        }
    }
}