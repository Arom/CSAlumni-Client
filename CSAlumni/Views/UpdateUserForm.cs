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
    public partial class UpdateUserForm : Form {
        public SendPatchRequest SendPatch;
        public ListViewItem Item;
        private User User;
        public UpdateUserForm(SendPatchRequest sendPatch, User user) {
            InitializeComponent();
            this.SendPatch = sendPatch;
            this.User = user;
            txtFirstName.Text = user.Firstname;
            txtSurname.Text = user.Surname;
            txtPhone.Text = user.Phone;
            txtGradYear.Text = Convert.ToString(user.Grad_year);
            txtEmail.Text = user.Email;
            if (user.Jobs) {
                chkJobs.Checked = true;
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e) {
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
            if (sb.Length != 0) {
                MessageBox.Show(sb.ToString(), "Validation errors");
            } else {
                User.Email = txtEmail.Text;
                User.Firstname = txtFirstName.Text;
                User.Surname = txtSurname.Text;
                User.Jobs = chkJobs.Checked;
                User.Phone = txtPhone.Text;
                User.Grad_year = User.Grad_year;

                SendPatch.patchUser(User);  
                this.Close();

            }
            
        }
    }
}
