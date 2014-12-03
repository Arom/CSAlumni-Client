namespace CSAlumni.Views {
    partial class DisplayBroadcastForm {
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
            this.rtxtBroadcastContent = new System.Windows.Forms.RichTextBox();
            this.picFacebook = new System.Windows.Forms.PictureBox();
            this.picTwitter = new System.Windows.Forms.PictureBox();
            this.picMail = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMail)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtBroadcastContent
            // 
            this.rtxtBroadcastContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtBroadcastContent.Location = new System.Drawing.Point(2, 1);
            this.rtxtBroadcastContent.Name = "rtxtBroadcastContent";
            this.rtxtBroadcastContent.ReadOnly = true;
            this.rtxtBroadcastContent.Size = new System.Drawing.Size(289, 96);
            this.rtxtBroadcastContent.TabIndex = 0;
            this.rtxtBroadcastContent.Text = "";
            // 
            // picFacebook
            // 
            this.picFacebook.Image = global::CSAlumni.Properties.Resources.fb;
            this.picFacebook.Location = new System.Drawing.Point(133, 103);
            this.picFacebook.Name = "picFacebook";
            this.picFacebook.Size = new System.Drawing.Size(32, 32);
            this.picFacebook.TabIndex = 1;
            this.picFacebook.TabStop = false;
            // 
            // picTwitter
            // 
            this.picTwitter.Image = global::CSAlumni.Properties.Resources.twitter;
            this.picTwitter.Location = new System.Drawing.Point(57, 103);
            this.picTwitter.Name = "picTwitter";
            this.picTwitter.Size = new System.Drawing.Size(32, 32);
            this.picTwitter.TabIndex = 2;
            this.picTwitter.TabStop = false;
            // 
            // picMail
            // 
            this.picMail.Image = global::CSAlumni.Properties.Resources.email;
            this.picMail.Location = new System.Drawing.Point(95, 103);
            this.picMail.Name = "picMail";
            this.picMail.Size = new System.Drawing.Size(32, 32);
            this.picMail.TabIndex = 3;
            this.picMail.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Feeds:";
            // 
            // DisplayBroadcastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 141);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picMail);
            this.Controls.Add(this.picTwitter);
            this.Controls.Add(this.picFacebook);
            this.Controls.Add(this.rtxtBroadcastContent);
            this.Name = "DisplayBroadcastForm";
            this.Text = "Display Broadcast";
            ((System.ComponentModel.ISupportInitialize)(this.picFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtBroadcastContent;
        private System.Windows.Forms.PictureBox picFacebook;
        private System.Windows.Forms.PictureBox picTwitter;
        private System.Windows.Forms.PictureBox picMail;
        private System.Windows.Forms.Label label1;

    }
}