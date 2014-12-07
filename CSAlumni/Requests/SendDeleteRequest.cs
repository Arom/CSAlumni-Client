using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace CSAlumni {
    /// <summary>
    /// This class is used to send delete requests to the server.
    /// </summary>
  public class SendDeleteRequest {

        string encoded;
        string password;
        string url;
        string username;
        HttpWebResponse response;


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
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(string.Format("{0}{1}/{2}.json", url, type, id));
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.Method = "DELETE";             
            byte[] toSend = System.Text.Encoding.ASCII.GetBytes("");
            Stream os = request.GetRequestStream();
            os.Write(toSend, 0, toSend.Length);
            response = (HttpWebResponse)request.GetResponse();
            response.Close();

           return (int)response.StatusCode;
        }
    }
}