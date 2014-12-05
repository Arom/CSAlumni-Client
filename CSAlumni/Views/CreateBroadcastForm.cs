using CSAlumni.Models;
using CSAlumni.Utils;
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

namespace CSAlumni.Views {
    /// <summary>
    /// Form used to create new Broadcasts, accessed through MainForm.
    /// </summary>
    public partial class CreateBroadcastForm : Form {
        SendPostRequest sendPost;
        public CreateBroadcastForm(SendPostRequest sendPost) {
            InitializeComponent();
            this.sendPost = sendPost;
        }
     /// <summary>
     /// Click event for 'Create Broadcast' button within the form.
     /// </summary>
        private void btnCreateBroadcast_Click(object sender, EventArgs e) {
            
            int atom = 0;
            int rss = 0;
            int facebook = 0;
            int twitter = 0;
            int email = 0;
            string csalumni = "";
           //See if any of the checkboxes within the form are checked. 
            if (chkAtom.Checked) {
                atom = 1;
            }
            if (chkEmail.Checked) {
                email = 1;
            }
            if (chkFacebook.Checked) {
                facebook = 1;
            }
            if (chkTwitter.Checked) {
                twitter = 1;
            }
            if (chkRss.Checked) {
                rss = 1;
            }
            //Radio buttons check.
            if (radioGeneral.Checked) {
                csalumni = "cs-alumni";
            } else if (radioJob.Checked) {
                csalumni= "cs-alumni-jobs";
            }
            //Cannot broadcast without content.
            if (StringHelper.isEmpty(rtxtContent.Text)) {
                MessageBox.Show("Content cannot be empty.");
            } else {
                Feeds feed = new Feeds(twitter, facebook, rss, atom, email, csalumni);
                BroadcastToSend broadcast = new BroadcastToSend(rtxtContent.Text, feed);
                sendPost.addNew(broadcast);
                this.Close();
            }
          
        }
    }
}
