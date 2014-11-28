using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

       

namespace CSAlumni
{
    
    public partial class Form1 : Form
    {
        private string url = "http://178.62.230.34:3000/users.json";
        private string chrisUser = "http://178.62.230.34:3000/users/41.json";
           private string broadcastUrl = "http://178.62.230.34:3000/broadcasts.json";
       private string username = "admin";
       private string password = "taliesin";
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

              SendPatchRequest patchRequest = new SendPatchRequest(username, password);
              SendPostRequest sendPost = new SendPostRequest(username, password);
              SendGetRequest get = new SendGetRequest(username, password, url);
              SendDeleteRequest delete = new SendDeleteRequest(username, password);
              User user = new User("Krzyso", "Ilkedsow", "07871534507", 2013, false, "a1rom11zorchris@hotmail.com");
              Feeds feeds = new Feeds(1, 0, 0, 0, 1, "cs-alumni");
              Broadcast broadcast = new Broadcast("Some22Content22", feeds);

              delete.delete("http://178.62.230.34:3000/broadcasts/53.json");
            //  sendPost.addNew(broadcastUrl,broadcast);
         // get.getUserList();
       //  patchRequest.patchUser(chrisUser, user);
        //   sendPost.addNewUser(url, user);
        //    sendPost.addNewBroadcast("http://178.62.230.34:3000/broadcasts.json", broadcast);

        }
    }
}
