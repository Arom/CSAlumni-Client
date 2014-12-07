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
        SendPatchRequest sendPatch;
        SendDeleteRequest sendDelete;
        private User user;
        public UpdateUserForm(SendPatchRequest sendPatch, SendDeleteRequest sendDelete, User user) {
            InitializeComponent();
            this.sendPatch = sendPatch;
            this.sendDelete = sendDelete;
            this.user = user;
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
                user.Email = txtEmail.Text;
                user.Firstname = txtFirstName.Text;
                user.Surname = txtSurname.Text;
                user.Jobs = chkJobs.Checked;
                user.Phone = txtPhone.Text;
                user.Grad_year = user.Grad_year;

                sendPatch.patchUser(user);  
                this.Close();

            }
            
        }

        private void btnDeleteUser_Click(object sender, EventArgs e) {
            sendDelete.delete("users", user.Id);
            //Closes the form
            this.Dispose(true);
        }
    }
}
