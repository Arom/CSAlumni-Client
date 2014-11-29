using CSAlumni.Utils;
using System;
using System.Windows.Forms;

namespace CSAlumni.Views {

    public partial class LoginForm : Form {

        public LoginForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string password = txtPassword.Text;
            string username = txtUsername.Text;
            if (StringHelper.isEmpty(password) || StringHelper.isEmpty(username)) {
                MessageBox.Show("Password or username fields cannot be empty", "Error");
            } else {
                SendGetRequest get = new SendGetRequest(username, password, "http://178.62.230.34/");
                Boolean valid = get.LoginIsValid();
                if (!valid) {
                    MessageBox.Show("Incorrect username or password", "Authentication Error");
                } else {
                    new MainWindow().Show();
                    this.Hide();
                }
            }
        }
    }
}