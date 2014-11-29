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
    class SendPatchRequest
    {
        string password;
        string username;
        string encoded;

        public SendPatchRequest(string username, string password)
        {
            this.username = username;
            this.password = password;
            encoded = StringHelper.EncodeString(username, password);
        }

        public void patchUser(string url, User user)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/json";
            request.Method = "PATCH";
            string updateUser = JsonConvert.SerializeObject(user);
            byte[] toSend = System.Text.Encoding.ASCII.GetBytes(updateUser);
            Stream os = request.GetRequestStream();
            os.Write(toSend, 0, toSend.Length);
            WebResponse response;
            try
            {
                response = request.GetResponse();
            }
            catch (WebException ex)
            {
                response = ex.Response;
            }
            using (StreamReader sr = new StreamReader(response.GetResponseStream())) 
            {
                Trace.WriteLine(sr.ReadToEnd().Trim());
            }
        }
    }
}
