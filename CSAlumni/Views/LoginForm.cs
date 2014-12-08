using CSAlumni.Utils;
using System;
using System.Windows.Forms;

namespace CSAlumni.Views {

    public partial class LoginForm : Form {
        SendGetRequest sendGet;
        string password;
        string username;
        public LoginForm() {
            InitializeComponent();
        }
        /// <summary>
        /// Login button method. If successful, creates a new MainWindow form.
        /// </summary>
        private void button1_Click(object sender, EventArgs e) {
             password = txtPassword.Text;
             username = txtUsername.Text;
            //Fields cannot be empty.
            if (StringHelper.isEmpty(password) || StringHelper.isEmpty(username)) {
                MessageBox.Show("Password or username fields cannot be empty", "Error");
            } else {
                //Sending a get request to see if authentication successful.
                sendGet = new SendGetRequest(username, password, "http://178.62.230.34/");
                int valid = sendGet.LoginIsValid();
                //401 means that the request was unsuccessful. 
                if (valid==401) {
                    MessageBox.Show("Incorrect username or password", "Authentication Error");
                } else {
                    new MainWindow(username, password, sendGet).Show();
                    this.Hide();
                }
            }
        }
    }
}