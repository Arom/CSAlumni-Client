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
    public class SendPatchRequest
    {
        private HttpWebResponse Response;
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

        public int patchUser( User user)
        {
           
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url+"/users/"+user.id+".json");
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/json";
            request.Method = "PATCH";
            string updateUser = JsonConvert.SerializeObject(user).ToLower();
            byte[] toSend = System.Text.Encoding.ASCII.GetBytes(updateUser);
            Stream os = request.GetRequestStream();
            os.Write(toSend, 0, toSend.Length);
            Response = (HttpWebResponse)request.GetResponse();
            Trace.WriteLine((int)Response.StatusCode);
            return (int)Response.StatusCode;
        }
    }
}
