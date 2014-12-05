using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAlumni.Views {
    /// <summary>
    /// A simple form to display a selected Broadcast.
    /// </summary>
    public partial class DisplayBroadcastForm : Form {
        public DisplayBroadcastForm(Broadcast broadcast) {
            InitializeComponent();
            picTwitter.Visible = false;
            picMail.Visible = false;
            picFacebook.Visible = false;
            rtxtBroadcastContent.Text = broadcast.content;
            foreach (Feed feed in broadcast.Feeds) {
                if (feed.name.Equals("twitter")) {
                    picTwitter.Visible = true;
                } else if (feed.name.Equals("email")) {
                    picMail.Visible = true;
                }
            }
        }
    }
}
