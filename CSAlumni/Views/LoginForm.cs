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
            SendGetRequest sendGet;
            string username = txtUsername.Text;
            if (StringHelper.isEmpty(password) || StringHelper.isEmpty(username)) {
                MessageBox.Show("Password or username fields cannot be empty", "Error");
            } else {
                sendGet = new SendGetRequest(username, password, "http://178.62.230.34/");
                int valid = sendGet.LoginIsValid();
                if (valid==401) {
                    MessageBox.Show("Incorrect username or password", "Authentication Error");
                } else {
                    new MainWindow(username, password, sendGet).Show();
                    this.Dispose(true);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e) {
        }
    }
}