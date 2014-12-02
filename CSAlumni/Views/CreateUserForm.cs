using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAlumni.Views {
    public partial class CreateUserForm : Form {
        public SendPostRequest sendPost;
        public CreateUserForm(SendPostRequest sendPost) {
            InitializeComponent();
            this.sendPost = sendPost;
        }

        private void btnCreateUser_Click(object sender, EventArgs e) {
            StringBuilder sb = new StringBuilder();
            int gradYear = 0;
            if (!Regex.IsMatch(txtPhone.Text, @"^\d+$")) {
                sb.Append("Phone needs to be a number. \n");
            }
            if (!Regex.IsMatch(txtGradYear.Text, @"^\d+$")){
                sb.Append("Grad Year needs to be a number \n");
            } else {
                gradYear = Convert.ToInt32(txtGradYear.Text);
                if (gradYear > 2014 || gradYear < 1970) {
                    sb.Append("Grad Year must be lower than 2014 and higher than 1970\n");
                }
            }
            if (!txtPassword.Text.Equals(txtConfirmPassword.Text)) {
                sb.Append("Passwords do not match \n");
            }
            if (sb.Length != 0) {
                MessageBox.Show(sb.ToString(), "Validation errors");
            } else {

                User user = new User(txtFirstName.Text, txtSurname.Text, txtPhone.Text,gradYear, chkJobs.Checked, txtEmail.Text, 0);
                sendPost.addNew(user);
                
                this.Close();

            }
            
        }
    }
}
