﻿using System;
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
       private string chrisUser = "http://192.168.0.19:3000/users/41.json";
       private string username = "admin";
       private string password = "taliesin";
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        //  SendGetRequest get = new SendGetRequest(username, password, chrisUser);
       //    get.getUserList();
    //    SendPatchRequest patchRequest = new SendPatchRequest(username, password);
       //  patchRequest.patchUser(chrisUser, user);
            SendPostRequest sendPost = new SendPostRequest(username, password);
        //    User user = new User("Krzys", "Ilkow", "07871534507", 2013, false, "aromchris@hotmail.com");
          // sendPost.addNewUser("http://192.168.0.19:3000/users.json", user);
            Broadcast broadcast = new Broadcast("SomeContent", "witter");
            sendPost.addNewBroadcast("http://192.168.0.19:3000/broadcasts.json", broadcast);
          
          
        }
    }
}
