using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.IO;
using Newtonsoft.Json;
using CSAlumni.Utils;
using System.Diagnostics;
namespace CSAlumni
{
    /// <summary>
    /// This class is used to send PATCH requests to the server.
    /// </summary>
    public class SendPatchRequest
    {
        HttpWebResponse response;
        string password;
        string username;
        string encoded;
        string url;

        public SendPatchRequest(string username, string password, string url)
        {
            this.username = username;
            this.password = password;
            this.url = url;
            encoded = StringHelper.EncodeString(username, password);
        }
        /// <summary>
        /// This method patches a User (The only PATCHable object in this solution so far).
        /// </summary>
        /// <param name="user"> User object to be patched.</param>
        /// <returns>Status code of the request. 204 is expected. </returns>
        public int patchUser(User user)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(string.Format("{0}/users/{1}.json", url, user.Id));
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/json";
            request.Method = "PATCH";
            //Using toLower() because JSON likes to serialize capital letters used in C# var naming style.
            string updateUser = JsonConvert.SerializeObject(user).ToLower();
            byte[] toSend = System.Text.Encoding.ASCII.GetBytes(updateUser);
            Stream os = request.GetRequestStream();
            os.Write(toSend, 0, toSend.Length);
            response = (HttpWebResponse)request.GetResponse();
            response.Close();

            return (int)response.StatusCode;
        }
    }
}
