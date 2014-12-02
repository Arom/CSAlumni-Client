namespace CSAlumni.Views {
    partial class CreateBroadcastForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.chkTwitter = new System.Windows.Forms.CheckBox();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.btnCreateBroadcast = new System.Windows.Forms.Button();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkFacebook = new System.Windows.Forms.CheckBox();
            this.chkAtom = new System.Windows.Forms.CheckBox();
            this.chkRss = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioJob = new System.Windows.Forms.RadioButton();
            this.radioGeneral = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Content";
            // 
            // chkTwitter
            // 
            this.chkTwitter.AutoSize = true;
            this.chkTwitter.Location = new System.Drawing.Point(33, 175);
            this.chkTwitter.Name = "chkTwitter";
            this.chkTwitter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkTwitter.Size = new System.Drawing.Size(58, 17);
            this.chkTwitter.TabIndex = 3;
            this.chkTwitter.Text = "Twitter";
            this.chkTwitter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTwitter.UseVisualStyleBackColor = true;
            // 
            // rtxtContent
            // 
            this.rtxtContent.Location = new System.Drawing.Point(1, 24);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(280, 95);
            this.rtxtContent.TabIndex = 4;
            this.rtxtContent.Text = "";
            // 
            // btnCreateBroadcast
            // 
            this.btnCreateBroadcast.Location = new System.Drawing.Point(61, 290);
            this.btnCreateBroadcast.Name = "btnCreateBroadcast";
            this.btnCreateBroadcast.Size = new System.Drawing.Size(162, 39);
            this.btnCreateBroadcast.TabIndex = 11;
            this.btnCreateBroadcast.Text = "Create Broadcast";
            this.btnCreateBroadcast.UseVisualStyleBackColor = true;
            this.btnCreateBroadcast.Click += new System.EventHandler(this.btnCreateBroadcast_Click);
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(40, 198);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkEmail.Size = new System.Drawing.Size(51, 17);
            this.chkEmail.TabIndex = 12;
            this.chkEmail.Text = "Email";
            this.chkEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // chkFacebook
            // 
            this.chkFacebook.AutoSize = true;
            this.chkFacebook.Location = new System.Drawing.Point(129, 175);
            this.chkFacebook.Name = "chkFacebook";
            this.chkFacebook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkFacebook.Size = new System.Drawing.Size(74, 17);
            this.chkFacebook.TabIndex = 13;
            this.chkFacebook.Text = "Facebook";
            this.chkFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkFacebook.UseVisualStyleBackColor = true;
            // 
            // chkAtom
            // 
            this.chkAtom.AutoSize = true;
            this.chkAtom.Location = new System.Drawing.Point(153, 198);
            this.chkAtom.Name = "chkAtom";
            this.chkAtom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAtom.Size = new System.Drawing.Size(50, 17);
            this.chkAtom.TabIndex = 14;
            this.chkAtom.Text = "Atom";
            this.chkAtom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAtom.UseVisualStyleBackColor = true;
            // 
            // chkRss
            // 
            this.chkRss.AutoSize = true;
            this.chkRss.Location = new System.Drawing.Point(43, 221);
            this.chkRss.Name = "chkRss";
            this.chkRss.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkRss.Size = new System.Drawing.Size(48, 17);
            this.chkRss.TabIndex = 15;
            this.chkRss.Text = "RSS";
            this.chkRss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkRss.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioGeneral);
            this.groupBox1.Controls.Add(this.radioJob);
            this.groupBox1.Location = new System.Drawing.Point(33, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 44);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // radioJob
            // 
            this.radioJob.AutoSize = true;
            this.radioJob.Location = new System.Drawing.Point(22, 15);
            this.radioJob.Name = "radioJob";
            this.radioJob.Size = new System.Drawing.Size(72, 17);
            this.radioJob.TabIndex = 0;
            this.radioJob.TabStop = true;
            this.radioJob.Text = "Job News";
            this.radioJob.UseVisualStyleBackColor = true;
            // 
            // radioGeneral
            // 
            this.radioGeneral.AutoSize = true;
            this.radioGeneral.Checked = true;
            this.radioGeneral.Location = new System.Drawing.Point(120, 15);
            this.radioGeneral.Name = "radioGeneral";
            this.radioGeneral.Size = new System.Drawing.Size(92, 17);
            this.radioGeneral.TabIndex = 1;
            this.radioGeneral.TabStop = true;
            this.radioGeneral.Text = "General News";
            this.radioGeneral.UseVisualStyleBackColor = true;
            // 
            // CreateBroadcastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 341);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkRss);
            this.Controls.Add(this.chkAtom);
            this.Controls.Add(this.chkFacebook);
            this.Controls.Add(this.chkEmail);
            this.Controls.Add(this.btnCreateBroadcast);
            this.Controls.Add(this.rtxtContent);
            this.Controls.Add(this.chkTwitter);
            this.Controls.Add(this.label1);
            this.Name = "CreateBroadcastForm";
            this.Text = "CreateBroadcastForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTwitter;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.Button btnCreateBroadcast;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkFacebook;
        private System.Windows.Forms.CheckBox chkAtom;
        private System.Windows.Forms.CheckBox chkRss;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioGeneral;
        private System.Windows.Forms.RadioButton radioJob;
    }
}