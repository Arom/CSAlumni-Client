using CSAlumni.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
       List<Broadcast> broadcastList;
       List<User> userList;
        public MainWindow()
        {
           
            InitializeComponent();

        }
        private void buildUserListView(List<User> users) {
            this.userList = users;
            foreach(User user in users){
                ListViewItem item = new ListViewItem();
                item.Text = user.Surname;
                item.SubItems.Add(user.Firstname);
                item.SubItems.Add(user.Email);
                item.SubItems.Add(""+user.Grad_year);
                listView1.Items.Add(item);
            }
        }
        private void buildBroadcastListView(List<Broadcast> broadcasts) {
            this.broadcastList = broadcasts;
            StringBuilder sb = new StringBuilder();
            if (broadcasts!=null) {
                foreach (Broadcast broadcast in broadcasts) {
                    ListViewItem item = new ListViewItem();
                    foreach (Feed feed in broadcast.Feeds) {
                        sb.Append(feed.name + ",");
                    }
                    item.Text=sb.ToString();
                    sb.Clear();
                    item.SubItems.Add(broadcast.content);
                    item.SubItems.Add(""+broadcast.id);
                    listView2.Items.Add(item);
                  }
                }
            }
            
        
        private void MainWindow_Load(object sender, EventArgs e)
        {
              sendPatch = new SendPatchRequest(username, password, url);
              sendPost = new SendPostRequest(username, password, url);
             sendGet = new SendGetRequest(username, password, url);
              sendDelete = new SendDeleteRequest(username, password, url);

              buildUserListView(sendGet.getUserList());
              buildBroadcastListView(sendGet.getBroadcastList());

        }

      
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) {
                e.Cancel = true;
            } 
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                if (listView2.FocusedItem.Bounds.Contains(e.Location) == true) {
                    popupMenuBroadcast.Show(Cursor.Position);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            ListViewItem item = listView2.SelectedItems[0];
            int id = Convert.ToInt32(item.SubItems[2].Text);
            
            if (item != null) {
                sendDelete.delete("broadcasts", id);
                listView2.Items.Remove(item);
               
            }
        }
    }
}
