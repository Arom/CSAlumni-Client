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
    
    public partial class MainWindow : Form
    {
        //178.62.230.34
        private string url = "http://178.62.230.34/";
       private string username = "admin";
       private string password = "taliesin";
       SendPatchRequest sendPatch;
       SendGetRequest sendGet;
       SendDeleteRequest sendDelete;
       SendPostRequest sendPost;
        public MainWindow()
        {
            InitializeComponent();

        }
        private void buildUserListView(List<User> users) {

        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            //    string[] user = new string[4];
            //ListViewItem itm;
            //user[0] = "Ilkow";
            //user[1] = "Krzys";
            //user[2] = "mail@mail.eu";
            //user[3] = "2014";
            //itm = new ListViewItem(user);
            //listView1.Items.Add(itm);
              sendPatch = new SendPatchRequest(username, password, url);
              sendPost = new SendPostRequest(username, password, url);
              sendGet = new SendGetRequest(username, password, url);
              sendDelete = new SendDeleteRequest(username, password, url);

              buildUserListView(sendGet.getUserList());
            //  User user = new User("Krzyso", "Ilkedsow", "078271534507", 2013, false, "a1rom11zordaschris@hotmail.com");
             // Feeds feeds = new Feeds(1, 0, 0, 0, 1, "cs-alumni");
             // Broadcast broadcast = new Broadcast("Some22Content22", feeds);
            //  get.getBroadcastList("http://178.62.230.34/");
           //   delete.fetchCSRF(chrisUser);
            //  delete.delete("http://192.168.0.19:3000/broadcasts/24.json");
            //  sendPost.addNew(broadcastUrl,broadcast);
         // get.getUserList();
       //  patchRequest.patchUser(chrisUser, user);
           //sendPost.addNew(url, user);
        //    sendPost.addNewBroadcast("http://178.62.230.34:3000/broadcasts.json", broadcast);

        }

      
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) {
                e.Cancel = true;
            } 
        }
    }
}
//ahMclX3MRwtlZcxZWkcVHbrFM5vNamhVX+p1qbPvgsM=
//ahMclX3MRwtlZcxZWkcVHbrFM5vNamhVX+p1qbPvgsM=
