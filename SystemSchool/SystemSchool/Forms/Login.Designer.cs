using System.Threading.Tasks;

namespace SystemSchool
{    
    partial class Login
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
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.pictureBoxSchool = new System.Windows.Forms.PictureBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.TextUsername = new System.Windows.Forms.TextBox();
            this.picturePassword = new System.Windows.Forms.PictureBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.buttonPasswordPrivacy = new System.Windows.Forms.Button();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonLogin.BackColor = System.Drawing.Color.White;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonLogin.Location = new System.Drawing.Point(196, 533);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(87, 33);
            this.ButtonLogin.TabIndex = 2;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // pictureBoxSchool
            // 
            this.pictureBoxSchool.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxSchool.Image = global::SystemSchool.Properties.Resources.icons8_school_80;
            this.pictureBoxSchool.Location = new System.Drawing.Point(159, -3);
            this.pictureBoxSchool.Name = "pictureBoxSchool";
            this.pictureBoxSchool.Size = new System.Drawing.Size(156, 146);
            this.pictureBoxSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSchool.TabIndex = 0;
            this.pictureBoxSchool.TabStop = false;
            // 
            // TextPassword
            // 
            this.TextPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextPassword.BackColor = System.Drawing.Color.White;
            this.TextPassword.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.TextPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextPassword.Location = new System.Drawing.Point(73, 441);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(304, 29);
            this.TextPassword.TabIndex = 5;
            // 
            // TextUsername
            // 
            this.TextUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextUsername.BackColor = System.Drawing.Color.White;
            this.TextUsername.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextUsername.Location = new System.Drawing.Point(73, 270);
            this.TextUsername.Name = "TextUsername";
            this.TextUsername.Size = new System.Drawing.Size(350, 29);
            this.TextUsername.TabIndex = 9;
            // 
            // picturePassword
            // 
            this.picturePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picturePassword.Image = global::SystemSchool.Properties.Resources.icons8_password_48;
            this.picturePassword.Location = new System.Drawing.Point(205, 316);
            this.picturePassword.Name = "picturePassword";
            this.picturePassword.Size = new System.Drawing.Size(67, 81);
            this.picturePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picturePassword.TabIndex = 7;
            this.picturePassword.TabStop = false;
            // 
            // pictureUser
            // 
            this.pictureUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureUser.Image = global::SystemSchool.Properties.Resources.icons8_user_40;
            this.pictureUser.Location = new System.Drawing.Point(205, 160);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(67, 88);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureUser.TabIndex = 6;
            this.pictureUser.TabStop = false;
            // 
            // buttonPasswordPrivacy
            // 
            this.buttonPasswordPrivacy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPasswordPrivacy.BackColor = System.Drawing.Color.Transparent;
            this.buttonPasswordPrivacy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPasswordPrivacy.Location = new System.Drawing.Point(374, 441);
            this.buttonPasswordPrivacy.Name = "buttonPasswordPrivacy";
            this.buttonPasswordPrivacy.Size = new System.Drawing.Size(49, 29);
            this.buttonPasswordPrivacy.TabIndex = 10;
            this.buttonPasswordPrivacy.Text = "Show";
            this.buttonPasswordPrivacy.UseVisualStyleBackColor = false;
            this.buttonPasswordPrivacy.Click += new System.EventHandler(this.buttonPasswordPrivacy_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::SystemSchool.Properties.Resources.icons8_close_48__2_;
            this.pictureBoxClose.Location = new System.Drawing.Point(462, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(23, 25);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 29;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 618);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.pictureBoxSchool);
            this.Controls.Add(this.buttonPasswordPrivacy);
            this.Controls.Add(this.TextUsername);
            this.Controls.Add(this.picturePassword);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.ButtonLogin);
            this.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(416, 311);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.PictureBox picturePassword;
        private System.Windows.Forms.TextBox TextUsername;
        private System.Windows.Forms.PictureBox pictureBoxSchool;
        private System.Windows.Forms.Button buttonPasswordPrivacy;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}
