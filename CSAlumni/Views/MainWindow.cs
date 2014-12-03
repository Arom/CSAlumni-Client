using CSAlumni.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CSAlumni {

    public partial class MainWindow : Form {
        public string password;

        public SendGetRequest sendGet;
        public SendPostRequest sendPost;
        public SendPatchRequest sendPatch;

        //178.62.230.34
        public string url = "http://178.62.230.34/";
        public string username;
        private List<Broadcast> broadcastList;
        private SendDeleteRequest sendDelete;
        private List<User> userList;

        public MainWindow(string username, string password, SendGetRequest sendGet) {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.sendGet = sendGet;
        }

        private void btnCreateUser_Click(object sender, EventArgs e) {
            new CreateUserForm(sendPost).Show();
        }

        private void btnUpdateBroadcasts_Click(object sender, EventArgs e) {
            listView2.Items.Clear();
            buildBroadcastListView(sendGet.getBroadcastList());
        }

        private void btnUpdateUser_Click(object sender, EventArgs e) {
            listView1.Items.Clear();
            buildUserListView(sendGet.getUserList());
        }

        private void buildBroadcastListView(List<Broadcast> broadcasts) {
            this.broadcastList = broadcasts;
            StringBuilder sb = new StringBuilder();
            if (broadcasts != null) {
                foreach (Broadcast broadcast in broadcasts) {
                    ListViewItem item = new ListViewItem();
                    foreach (Feed feed in broadcast.Feeds) {
                        sb.Append(feed.name + " ");
                    }
                    item.Text = sb.ToString();
                    sb.Clear();
                    item.SubItems.Add(broadcast.content);
                    item.SubItems.Add("" + broadcast.id);
                    listView2.Items.Add(item);
                }
            }
        }

        private void buildUserListView(List<User> users) {
            this.userList = users;
            foreach (User user in users) {
                ListViewItem item = new ListViewItem();
                item.Text = user.Surname;
                item.SubItems.Add(user.Firstname);  
                item.SubItems.Add(user.Email);
                item.SubItems.Add(user.Phone);
                item.SubItems.Add("" + user.Grad_year);
                item.SubItems.Add("" + user.id);
                item.SubItems.Add(user.Jobs.ToString());
                listView1.Items.Add(item);
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

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e) {
            ListViewItem item = listView1.SelectedItems[0];
            int id = Convert.ToInt32(item.SubItems[5].Text);
            if (item != null) {
                sendDelete.delete("users", id);
                listView1.Items.Remove(item);
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                if (listView1.FocusedItem.Bounds.Contains(e.Location) == true) {
                    popupMenuUser.Show(Cursor.Position);
                }
            }
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                if (listView2.FocusedItem.Bounds.Contains(e.Location) == true) {
                    popupMenuBroadcast.Show(Cursor.Position);
                }
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) {
                e.Cancel = true;
            } 
        }

        private void MainWindow_Load(object sender, EventArgs e) {
            sendPatch = new SendPatchRequest(username, password, url);
            sendPost = new SendPostRequest(username, password, url);
            sendDelete = new SendDeleteRequest(username, password, url);

            buildUserListView(sendGet.getUserList());
            buildBroadcastListView(sendGet.getBroadcastList());

        }

        private void btnCreateBroadcast_Click(object sender, EventArgs e) {
            new CreateBroadcastForm(sendPost).Show();
        }
        private User findUser(int id) {
            User FoundUser = null;
            foreach (User user in userList) {
                if (user.id == id) {
                    FoundUser = user;
                    break;
                }
            }
            return FoundUser;
        }

        private Broadcast findBroadcast(int id) {
            Broadcast foundBroadcast = null;
            foreach (Broadcast broadcast in broadcastList) {
                if (broadcast.id == id) {
                    foundBroadcast = broadcast;
                }
            }
            return foundBroadcast;
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e) {
            ListViewItem item = listView1.SelectedItems[0];
            int id = Convert.ToInt32(item.SubItems[5].Text);

            if (item != null) {
                new UpdateUserForm(sendPatch, findUser(id)).Show();
            }
        }

        private void displayBroadcastToolStripMenuItem_Click(object sender, EventArgs e) {
     
            ListViewItem item = listView2.SelectedItems[0];
            int id = Convert.ToInt32(item.SubItems[2].Text);
            if (item != null) {
                new DisplayBroadcastForm(findBroadcast(id)).Show();
            }
        }
    }
}