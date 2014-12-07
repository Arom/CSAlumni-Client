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
    /// <summary>
    /// This is a form used to create new Users called from within MainWindow.
    /// </summary>
    public partial class CreateUserForm : Form {
        SendPostRequest sendPost;
        public CreateUserForm(SendPostRequest sendPost) {
            InitializeComponent();
            this.sendPost = sendPost;
        }
        /// <summary>
        /// Click event for 'Create User' button within the form.
        /// </summary>
        private void btnCreateUser_Click(object sender, EventArgs e) {
            //Used to build a string of possible errors so that only one MessageBox is displayed
            //instead of many.
            StringBuilder sb = new StringBuilder();
            int gradYear = 0;
            //Regex to check if entered text is a number.
            if (!Regex.IsMatch(txtPhone.Text, @"^\d+$")) {
                sb.Append("Phone needs to be a number. \n");
            }
            if (!Regex.IsMatch(txtGradYear.Text, @"^\d+$")){
                sb.Append("Grad Year needs to be a number \n");
            } else {
                gradYear = Convert.ToInt32(txtGradYear.Text);
                //Graduate year cannot be higher than 2014 and lower than 1970.
                if (gradYear > 2014 || gradYear < 1970) {
                    sb.Append("Grad Year must be lower than 2014 and higher than 1970\n");
                }
            }
            //See if both passwords match.
            if (!txtPassword.Text.Equals(txtConfirmPassword.Text)) {
                sb.Append("Passwords do not match \n");
            }
            //Empty StringBuilder means there were no validation errors, so we can proceed.
            if (sb.Length != 0) {
                MessageBox.Show(sb.ToString(), "Validation errors");
            } else {
                User user = new User(txtFirstName.Text, txtSurname.Text, txtPhone.Text,gradYear, chkJobs.Checked, txtEmail.Text, 0);
                sendPost.addNew(user);
                this.Dispose(true);

            }
            
        }
    }
}
