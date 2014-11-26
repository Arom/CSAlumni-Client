using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

       

namespace CSAlumni
{
    
    public partial class Form1 : Form
    {
       private string url = "http://192.168.0.19:3000/users.json";
       private string username = "admin";
       private string password = "taliesin";
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

            SendGetRequest get = new SendGetRequest(username, password);
            get.getUserList(url);
            
          
          
        }
    }
}
