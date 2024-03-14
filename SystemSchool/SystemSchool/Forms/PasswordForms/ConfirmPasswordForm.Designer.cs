namespace SystemSchool.Forms.PasswordForms
{
    partial class ConfirmPasswordForm
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelYourPassword = new System.Windows.Forms.Label();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.buttonAccess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(45, 116);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(271, 29);
            this.textBoxPassword.TabIndex = 0;
            // 
            // LabelYourPassword
            // 
            this.LabelYourPassword.AutoSize = true;
            this.LabelYourPassword.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelYourPassword.Location = new System.Drawing.Point(118, 92);
            this.LabelYourPassword.Name = "LabelYourPassword";
            this.LabelYourPassword.Size = new System.Drawing.Size(124, 21);
            this.LabelYourPassword.TabIndex = 1;
            this.LabelYourPassword.Text = "Your Password";
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = global::SystemSchool.Properties.Resources.icons8_password_48;
            this.pictureBoxPassword.Location = new System.Drawing.Point(130, 3);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(100, 90);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPassword.TabIndex = 2;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::SystemSchool.Properties.Resources.icons8_close_48__2_;
            this.pictureBoxClose.Location = new System.Drawing.Point(334, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(25, 23);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 3;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // buttonAccess
            // 
            this.buttonAccess.BackColor = System.Drawing.Color.White;
            this.buttonAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccess.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccess.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonAccess.Location = new System.Drawing.Point(141, 157);
            this.buttonAccess.Name = "buttonAccess";
            this.buttonAccess.Size = new System.Drawing.Size(79, 23);
            this.buttonAccess.TabIndex = 4;
            this.buttonAccess.Text = "Access";
            this.buttonAccess.UseVisualStyleBackColor = false;
            this.buttonAccess.Click += new System.EventHandler(this.buttonAccess_Click);
            // 
            // ConfirmPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 192);
            this.Controls.Add(this.buttonAccess);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.LabelYourPassword);
            this.Controls.Add(this.textBoxPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmPasswordForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label LabelYourPassword;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Button buttonAccess;
    }
}