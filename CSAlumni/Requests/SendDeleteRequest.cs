using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace CSAlumni {
    /// <summary>
    /// This class is used to send delete requests to the server.
    /// </summary>
  public class SendDeleteRequest {

        private string encoded;
        private string password;
        private string url;
        private string username;
        HttpWebResponse Response;


        public SendDeleteRequest(string username, string password, string url) {
            this.username = username;
            this.password = password;
            this.url = url;
            encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
        }
       /// <summary>
       /// This method deletes an object on the server by its ID.
       /// </summary>
       /// <param name="type">An object type, allowed options "users" and "broadcasts".</param>
       /// <param name="id">The ID of the object to be deleted. </param>
       /// <returns>Reponse status code. Excepted 204 for successful request.</returns>
        public int delete(string type, int id) {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + type + "/" + id + ".json");
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.Method = "DELETE";             
            byte[] toSend = System.Text.Encoding.ASCII.GetBytes("");
            Stream os = request.GetRequestStream();
            os.Write(toSend, 0, toSend.Length);
            Response = (HttpWebResponse)request.GetResponse();
            Response.Close();

           return (int)Response.StatusCode;
           // return 204;
        }
    }
}