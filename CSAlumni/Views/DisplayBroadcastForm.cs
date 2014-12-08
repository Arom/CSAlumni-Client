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
            rtxtBroadcastContent.Text = broadcast.Content;
            foreach (Feed feed in broadcast.Feeds) {
                if(feed.Name.Equals("twitter")) {
                    picTwitter.Visible = true;
                } else if (feed.Name.Equals("email")) {
                   picMail.Visible = true;
                }
            }
        }
    }
}
