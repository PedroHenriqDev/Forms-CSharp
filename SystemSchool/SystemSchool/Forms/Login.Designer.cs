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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxSchool = new System.Windows.Forms.PictureBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.TextUsername = new System.Windows.Forms.TextBox();
            this.picturePassword = new System.Windows.Forms.PictureBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.buttonPasswordPrivacy = new System.Windows.Forms.Button();
            this.labelManagerSchool = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonLogin.BackColor = System.Drawing.Color.White;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonLogin.Location = new System.Drawing.Point(194, 516);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(87, 33);
            this.ButtonLogin.TabIndex = 2;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.labelManagerSchool);
            this.panel1.Location = new System.Drawing.Point(-33, 572);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 85);
            this.panel1.TabIndex = 3;
            // 
            // pictureBoxSchool
            // 
            this.pictureBoxSchool.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxSchool.Image = global::SystemSchool.Properties.Resources.icons8_school_80;
            this.pictureBoxSchool.Location = new System.Drawing.Point(159, -11);
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
            this.picturePassword.Size = new System.Drawing.Size(67, 119);
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
            this.pictureUser.Size = new System.Drawing.Size(67, 126);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureUser.TabIndex = 6;
            this.pictureUser.TabStop = false;
            // 
            // buttonPasswordPrivacy
            // 
            this.buttonPasswordPrivacy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPasswordPrivacy.BackColor = System.Drawing.Color.Transparent;
            this.buttonPasswordPrivacy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPasswordPrivacy.Location = new System.Drawing.Point(349, 441);
            this.buttonPasswordPrivacy.Name = "buttonPasswordPrivacy";
            this.buttonPasswordPrivacy.Size = new System.Drawing.Size(49, 29);
            this.buttonPasswordPrivacy.TabIndex = 10;
            this.buttonPasswordPrivacy.Text = "Show";
            this.buttonPasswordPrivacy.UseVisualStyleBackColor = false;
            this.buttonPasswordPrivacy.Click += new System.EventHandler(this.buttonPasswordPrivacy_Click);
            // 
            // labelManagerSchool
            // 
            this.labelManagerSchool.AutoSize = true;
            this.labelManagerSchool.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagerSchool.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelManagerSchool.Location = new System.Drawing.Point(179, 31);
            this.labelManagerSchool.Name = "labelManagerSchool";
            this.labelManagerSchool.Size = new System.Drawing.Size(175, 30);
            this.labelManagerSchool.TabIndex = 0;
            this.labelManagerSchool.Text = "School Manager";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 656);
            this.Controls.Add(this.pictureBoxSchool);
            this.Controls.Add(this.buttonPasswordPrivacy);
            this.Controls.Add(this.TextUsername);
            this.Controls.Add(this.picturePassword);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonLogin);
            this.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(416, 311);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.PictureBox picturePassword;
        private System.Windows.Forms.TextBox TextUsername;
        private System.Windows.Forms.PictureBox pictureBoxSchool;
        private System.Windows.Forms.Button buttonPasswordPrivacy;
        private System.Windows.Forms.Label labelManagerSchool;
    }
}
