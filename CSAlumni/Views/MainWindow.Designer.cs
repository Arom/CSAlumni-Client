namespace CSAlumni
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnCreateBroadcast = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBroadcasts = new System.Windows.Forms.TabPage();
            this.btnUpdateBroadcasts = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GradYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jobs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.popupMenuBroadcast = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popupMenuUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayBroadcastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabBroadcasts.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.popupMenuBroadcast.SuspendLayout();
            this.popupMenuUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(317, 241);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(278, 39);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Create User ";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnCreateBroadcast
            // 
            this.btnCreateBroadcast.Location = new System.Drawing.Point(12, 241);
            this.btnCreateBroadcast.Name = "btnCreateBroadcast";
            this.btnCreateBroadcast.Size = new System.Drawing.Size(299, 39);
            this.btnCreateBroadcast.TabIndex = 4;
            this.btnCreateBroadcast.Text = "Create Broadcast";
            this.btnCreateBroadcast.UseVisualStyleBackColor = true;
            this.btnCreateBroadcast.Click += new System.EventHandler(this.btnCreateBroadcast_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBroadcasts);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Location = new System.Drawing.Point(13, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 236);
            this.tabControl1.TabIndex = 6;
            // 
            // tabBroadcasts
            // 
            this.tabBroadcasts.Controls.Add(this.btnUpdateBroadcasts);
            this.tabBroadcasts.Controls.Add(this.listView2);
            this.tabBroadcasts.Location = new System.Drawing.Point(4, 22);
            this.tabBroadcasts.Name = "tabBroadcasts";
            this.tabBroadcasts.Padding = new System.Windows.Forms.Padding(3);
            this.tabBroadcasts.Size = new System.Drawing.Size(574, 210);
            this.tabBroadcasts.TabIndex = 0;
            this.tabBroadcasts.Text = "Broadcasts";
            this.tabBroadcasts.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBroadcasts
            // 
            this.btnUpdateBroadcasts.Location = new System.Drawing.Point(445, 0);
            this.btnUpdateBroadcasts.Name = "btnUpdateBroadcasts";
            this.btnUpdateBroadcasts.Size = new System.Drawing.Size(129, 23);
            this.btnUpdateBroadcasts.TabIndex = 10;
            this.btnUpdateBroadcasts.Text = "Update Broadcast List";
            this.btnUpdateBroadcasts.UseVisualStyleBackColor = true;
            this.btnUpdateBroadcasts.Click += new System.EventHandler(this.btnUpdateBroadcasts_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.id});
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(-4, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(582, 210);
            this.listView2.TabIndex = 9;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Feeds";
            this.columnHeader5.Width = 193;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Content";
            this.columnHeader6.Width = 382;
            // 
            // id
            // 
            this.id.Text = "#";
            this.id.Width = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.btnUpdateUser);
            this.tabUsers.Controls.Add(this.listView1);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(574, 210);
            this.tabUsers.TabIndex = 1;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(449, 0);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(125, 24);
            this.btnUpdateUser.TabIndex = 9;
            this.btnUpdateUser.Text = "Update User List";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Surname,
            this.FirstName,
            this.Email,
            this.Phone,
            this.GradYear,
            this.user_id,
            this.Jobs});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(-4, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(582, 210);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // Surname
            // 
            this.Surname.Text = "Surname";
            this.Surname.Width = 90;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 90;
            // 
            // Email
            // 
            this.Email.Text = "E-mail";
            this.Email.Width = 90;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            // 
            // GradYear
            // 
            this.GradYear.DisplayIndex = 5;
            this.GradYear.Text = "Grad Year";
            // 
            // user_id
            // 
            this.user_id.DisplayIndex = 4;
            this.user_id.Text = "#";
            this.user_id.Width = 0;
            // 
            // Jobs
            // 
            this.Jobs.Text = "Jobs";
            // 
            // popupMenuBroadcast
            // 
            this.popupMenuBroadcast.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayBroadcastToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.popupMenuBroadcast.Name = "popupMenuBroadcast";
            this.popupMenuBroadcast.Size = new System.Drawing.Size(168, 70);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deleteToolStripMenuItem.Text = "Delete Broadcast";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // popupMenuUser
            // 
            this.popupMenuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.popupMenuUser.Name = "popupMenuUser";
            this.popupMenuUser.Size = new System.Drawing.Size(134, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editToolStripMenuItem.Text = "Edit User";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // displayBroadcastToolStripMenuItem
            // 
            this.displayBroadcastToolStripMenuItem.Name = "displayBroadcastToolStripMenuItem";
            this.displayBroadcastToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.displayBroadcastToolStripMenuItem.Text = "Display Broadcast";
            this.displayBroadcastToolStripMenuItem.Click += new System.EventHandler(this.displayBroadcastToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 287);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCreateBroadcast);
            this.Controls.Add(this.btnCreateUser);
            this.Name = "MainWindow";
            this.Text = "CSAlumni";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBroadcasts.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.popupMenuBroadcast.ResumeLayout(false);
            this.popupMenuUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnCreateBroadcast;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBroadcasts;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader GradYear;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ContextMenuStrip popupMenuBroadcast;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ContextMenuStrip popupMenuUser;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader user_id;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnUpdateBroadcasts;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Jobs;
        private System.Windows.Forms.ToolStripMenuItem displayBroadcastToolStripMenuItem;
    }
}

