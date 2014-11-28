using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.IO;
using Newtonsoft.Json;
namespace CSAlumni
{
    class SendPatchRequest
    {
        string Password, Username;
        String encoded;

        public SendPatchRequest(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(Username + ":" + Password));
        }

        public void patchUser(string url, User user)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/json";

            request.Method = "PATCH";
            var updateUser = JsonConvert.SerializeObject(user);

            byte[] toSend = System.Text.Encoding.ASCII.GetBytes(updateUser);
            var os = request.GetRequestStream();
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
        }
    }
}
