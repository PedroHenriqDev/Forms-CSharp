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
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.LoginText = new System.Windows.Forms.Label();
            this.TextUsername = new System.Windows.Forms.TextBox();
            this.LabelManagerSchool = new System.Windows.Forms.Label();
            this.picturePassword = new System.Windows.Forms.PictureBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxSchool = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.Black;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonCancel.Location = new System.Drawing.Point(485, 344);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(94, 33);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel\r\n";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.Black;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonLogin.Location = new System.Drawing.Point(645, 344);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(87, 33);
            this.ButtonLogin.TabIndex = 2;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LabelManagerSchool);
            this.panel1.Controls.Add(this.pictureBoxSchool);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 458);
            this.panel1.TabIndex = 3;
            // 
            // TextPassword
            // 
            this.TextPassword.BackColor = System.Drawing.Color.White;
            this.TextPassword.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextPassword.Location = new System.Drawing.Point(485, 292);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(247, 29);
            this.TextPassword.TabIndex = 5;
            // 
            // LoginText
            // 
            this.LoginText.BackColor = System.Drawing.Color.Transparent;
            this.LoginText.Font = new System.Drawing.Font("Malgun Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginText.Location = new System.Drawing.Point(404, 9);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(376, 95);
            this.LoginText.TabIndex = 8;
            this.LoginText.Text = "Login";
            this.LoginText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextUsername
            // 
            this.TextUsername.BackColor = System.Drawing.Color.White;
            this.TextUsername.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextUsername.Location = new System.Drawing.Point(485, 173);
            this.TextUsername.Name = "TextUsername";
            this.TextUsername.Size = new System.Drawing.Size(247, 29);
            this.TextUsername.TabIndex = 9;
            // 
            // LabelManagerSchool
            // 
            this.LabelManagerSchool.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelManagerSchool.ForeColor = System.Drawing.Color.LightBlue;
            this.LabelManagerSchool.Location = new System.Drawing.Point(87, 28);
            this.LabelManagerSchool.Name = "LabelManagerSchool";
            this.LabelManagerSchool.Size = new System.Drawing.Size(230, 61);
            this.LabelManagerSchool.TabIndex = 1;
            this.LabelManagerSchool.Text = "Manager School";
            this.LabelManagerSchool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picturePassword
            // 
            this.picturePassword.Image = global::SystemSchool.Properties.Resources.icons8_password_48;
            this.picturePassword.Location = new System.Drawing.Point(412, 259);
            this.picturePassword.Name = "picturePassword";
            this.picturePassword.Size = new System.Drawing.Size(67, 62);
            this.picturePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picturePassword.TabIndex = 7;
            this.picturePassword.TabStop = false;
            // 
            // pictureUser
            // 
            this.pictureUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureUser.Image = global::SystemSchool.Properties.Resources.icons8_user_40;
            this.pictureUser.Location = new System.Drawing.Point(412, 137);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(67, 65);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureUser.TabIndex = 6;
            this.pictureUser.TabStop = false;
            // 
            // pictureBoxSchool
            // 
            this.pictureBoxSchool.Image = global::SystemSchool.Properties.Resources.icons8_school_80;
            this.pictureBoxSchool.Location = new System.Drawing.Point(119, 137);
            this.pictureBoxSchool.Name = "pictureBoxSchool";
            this.pictureBoxSchool.Size = new System.Drawing.Size(156, 146);
            this.pictureBoxSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSchool.TabIndex = 0;
            this.pictureBoxSchool.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextUsername);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.picturePassword);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.ButtonCancel);
            this.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.PictureBox picturePassword;
        private System.Windows.Forms.Label LoginText;
        private System.Windows.Forms.TextBox TextUsername;
        private System.Windows.Forms.PictureBox pictureBoxSchool;
        private System.Windows.Forms.Label LabelManagerSchool;
    }
}
