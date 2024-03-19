namespace SystemSchool.Forms.PasswordForms
{
    partial class ChangePasswordForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelNewPassword = new System.Windows.Forms.Label();
            this.LabelConfirmationPassword = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmationPassword = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(30, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(382, 73);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "User";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemSchool.Properties.Resources.icons8_password_key_100;
            this.pictureBox1.Location = new System.Drawing.Point(171, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LabelNewPassword
            // 
            this.LabelNewPassword.AutoSize = true;
            this.LabelNewPassword.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNewPassword.Location = new System.Drawing.Point(152, 285);
            this.LabelNewPassword.Name = "LabelNewPassword";
            this.LabelNewPassword.Size = new System.Drawing.Size(127, 21);
            this.LabelNewPassword.TabIndex = 2;
            this.LabelNewPassword.Text = "New password:";
            // 
            // LabelConfirmationPassword
            // 
            this.LabelConfirmationPassword.AutoSize = true;
            this.LabelConfirmationPassword.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConfirmationPassword.Location = new System.Drawing.Point(121, 454);
            this.LabelConfirmationPassword.Name = "LabelConfirmationPassword";
            this.LabelConfirmationPassword.Size = new System.Drawing.Size(192, 21);
            this.LabelConfirmationPassword.TabIndex = 3;
            this.LabelConfirmationPassword.Text = "Confirmation Password:";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::SystemSchool.Properties.Resources.icons8_close_48__2_;
            this.pictureBoxClose.Location = new System.Drawing.Point(418, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 7;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword.Location = new System.Drawing.Point(90, 318);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(262, 29);
            this.textBoxNewPassword.TabIndex = 8;
            // 
            // textBoxConfirmationPassword
            // 
            this.textBoxConfirmationPassword.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmationPassword.Location = new System.Drawing.Point(90, 487);
            this.textBoxConfirmationPassword.Name = "textBoxConfirmationPassword";
            this.textBoxConfirmationPassword.Size = new System.Drawing.Size(262, 29);
            this.textBoxConfirmationPassword.TabIndex = 9;
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.White;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonChange.Location = new System.Drawing.Point(163, 583);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(116, 34);
            this.buttonChange.TabIndex = 10;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 642);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxConfirmationPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.LabelConfirmationPassword);
            this.Controls.Add(this.LabelNewPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordForm";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelNewPassword;
        private System.Windows.Forms.Label LabelConfirmationPassword;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxConfirmationPassword;
        private System.Windows.Forms.Button buttonChange;
    }
}