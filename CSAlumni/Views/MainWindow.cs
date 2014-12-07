using CSAlumni.Utils;
using CSAlumni.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CSAlumni {

    public partial class MainWindow : Form {

        public SendGetRequest SendGet;
        public SendPostRequest SendPost;
        public SendPatchRequest SendPatch;

        public string Url = "http://178.62.230.34/";
        public string Password;
        public string Username;
        private List<Broadcast> broadcastList;
        private SendDeleteRequest sendDelete;
        private List<User> userList;

        public MainWindow(string username, string password, SendGetRequest sendGet) {
            InitializeComponent();
            this.Username = username;
            this.Password = password;
            this.SendGet = sendGet;
        }

        private void btnCreateUser_Click(object sender, EventArgs e) {
            new CreateUserForm(SendPost).Show();
        }

        private void btnUpdateBroadcasts_Click(object sender, EventArgs e) {
            listView2.Items.Clear();
            buildBroadcastListView(SendGet.getBroadcastList());
        }

        private void btnUpdateUser_Click(object sender, EventArgs e) {
            listView1.Items.Clear();
            buildUserListView(SendGet.getUserList());
        }

        private void buildBroadcastListView(List<Broadcast> broadcasts) {
            this.broadcastList = broadcasts;
            StringBuilder sb = new StringBuilder();
            if (broadcasts != null) {
                foreach (Broadcast broadcast in broadcasts) {
                    ListViewItem item = new ListViewItem();
                    foreach (Feed feed in broadcast.Feeds) {
                        sb.Append(feed.Name + " ");
                    }
                    item.Text = sb.ToString();
                    sb.Clear();
                    item.SubItems.Add(broadcast.Content);
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
                item.SubItems.Add("" + user.Id);
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
            SendPatch = new SendPatchRequest(Username, Password, Url);
            SendPost = new SendPostRequest(Username, Password, Url);
            sendDelete = new SendDeleteRequest(Username, Password, Url);

            buildUserListView(SendGet.getUserList());
            buildBroadcastListView(SendGet.getBroadcastList());

        }

        private void btnCreateBroadcast_Click(object sender, EventArgs e) {
            new CreateBroadcastForm(SendPost).Show();
        }
     
        private void editToolStripMenuItem_Click(object sender, EventArgs e) {
            ListViewItem item = listView1.SelectedItems[0];
            int id = Convert.ToInt32(item.SubItems[5].Text);

            if (item != null) {
                new UpdateUserForm(SendPatch, sendDelete, Finder.findUserById(id, userList)).Show();
            }
        }

        private void displayBroadcastToolStripMenuItem_Click(object sender, EventArgs e) {
     
            ListViewItem item = listView2.SelectedItems[0];
            int id = Convert.ToInt32(item.SubItems[2].Text);
            if (item != null) {
                new DisplayBroadcastForm(Finder.findBroadcastById(id, broadcastList)).Show();
            }
        }

        private void btnFindUser_Click(object sender, EventArgs e) {
            User foundUser = null;
            string searchTerm = null;
            StringBuilder sb = new StringBuilder();
            if (!StringHelper.isEmpty(txtSearch.Text)) {
               searchTerm = txtSearch.Text;
               if (radioEmail.Checked) {
                   foundUser = Finder.findUserByEmail(searchTerm, userList);
               } else if (radioFirstname.Checked) {
                   foundUser = Finder.findUserByFirstname(searchTerm, userList);
               } else if (radioGradYear.Checked) {
                   if (!Regex.IsMatch(txtSearch.Text, @"^\d+$")) {
                       sb.Append("Grad Year search term needs to be a number. \n");
                   } else {
                       int gradYear = Convert.ToInt32(txtSearch.Text);
                       foundUser = Finder.findUserByGradYear(gradYear, userList);
                   }
               } else if (radioPhone.Checked) {
                   foundUser = Finder.findUserByPhone(searchTerm, userList);
               } else if (radioSurname.Checked) {
                   foundUser = Finder.findUserBySurname(searchTerm, userList);
               }
               if (foundUser != null) {
                   new UpdateUserForm(SendPatch,sendDelete, foundUser).Show();
               } else {
                   sb.Append("User not found.");
               }
            } else {
                sb.Append("I need a search term.");
            }
            if (!StringHelper.isEmpty(sb.ToString())) {
                MessageBox.Show(sb.ToString(), "Validation errors");
            }
           

        }
    }
}