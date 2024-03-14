namespace SystemSchool.Forms.UserForms
{
    partial class RegistrationUserForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelEditStudent = new System.Windows.Forms.Label();
            this.LabelDeleteUser = new System.Windows.Forms.Label();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.pictureBoxSchool = new System.Windows.Forms.PictureBox();
            this.ComboBoxClass = new System.Windows.Forms.ComboBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelClass = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LabelEditStudent);
            this.panel1.Controls.Add(this.LabelDeleteUser);
            this.panel1.Controls.Add(this.pictureBoxEdit);
            this.panel1.Controls.Add(this.pictureBoxStudent);
            this.panel1.Controls.Add(this.pictureBoxSchool);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 646);
            this.panel1.TabIndex = 1;
            // 
            // LabelEditStudent
            // 
            this.LabelEditStudent.AutoSize = true;
            this.LabelEditStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelEditStudent.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEditStudent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelEditStudent.Location = new System.Drawing.Point(76, 316);
            this.LabelEditStudent.Name = "LabelEditStudent";
            this.LabelEditStudent.Size = new System.Drawing.Size(70, 20);
            this.LabelEditStudent.TabIndex = 22;
            this.LabelEditStudent.Text = "Edit User";
            this.LabelEditStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelEditStudent.Click += new System.EventHandler(this.LabelEditStudent_Click);
            // 
            // LabelDeleteUser
            // 
            this.LabelDeleteUser.AutoSize = true;
            this.LabelDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelDeleteUser.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeleteUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelDeleteUser.Location = new System.Drawing.Point(71, 493);
            this.LabelDeleteUser.Name = "LabelDeleteUser";
            this.LabelDeleteUser.Size = new System.Drawing.Size(88, 20);
            this.LabelDeleteUser.TabIndex = 12;
            this.LabelDeleteUser.Text = "Delete User";
            this.LabelDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelDeleteUser.Click += new System.EventHandler(this.LabelDeleteUser_Click);
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEdit.Image = global::SystemSchool.Properties.Resources.icons8_edit_40;
            this.pictureBoxEdit.Location = new System.Drawing.Point(71, 258);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(88, 55);
            this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEdit.TabIndex = 21;
            this.pictureBoxEdit.TabStop = false;
            this.pictureBoxEdit.Click += new System.EventHandler(this.pictureBoxEdit_Click);
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxStudent.Image = global::SystemSchool.Properties.Resources.icons8_delete_48;
            this.pictureBoxStudent.Location = new System.Drawing.Point(71, 439);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(88, 51);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxStudent.TabIndex = 20;
            this.pictureBoxStudent.TabStop = false;
            this.pictureBoxStudent.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // pictureBoxSchool
            // 
            this.pictureBoxSchool.Image = global::SystemSchool.Properties.Resources.icons8_school_80;
            this.pictureBoxSchool.Location = new System.Drawing.Point(71, 16);
            this.pictureBoxSchool.Name = "pictureBoxSchool";
            this.pictureBoxSchool.Size = new System.Drawing.Size(88, 81);
            this.pictureBoxSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSchool.TabIndex = 19;
            this.pictureBoxSchool.TabStop = false;
            // 
            // ComboBoxClass
            // 
            this.ComboBoxClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBoxClass.BackColor = System.Drawing.Color.White;
            this.ComboBoxClass.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxClass.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ComboBoxClass.FormattingEnabled = true;
            this.ComboBoxClass.Location = new System.Drawing.Point(433, 485);
            this.ComboBoxClass.Name = "ComboBoxClass";
            this.ComboBoxClass.Size = new System.Drawing.Size(346, 28);
            this.ComboBoxClass.TabIndex = 21;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.BackColor = System.Drawing.Color.White;
            this.textBoxUsername.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxUsername.Location = new System.Drawing.Point(433, 197);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(346, 27);
            this.textBoxUsername.TabIndex = 20;
            // 
            // LabelUsername
            // 
            this.LabelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelUsername.Location = new System.Drawing.Point(562, 164);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(91, 21);
            this.LabelUsername.TabIndex = 19;
            this.LabelUsername.Text = "Username:";
            // 
            // LabelClass
            // 
            this.LabelClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelClass.AutoSize = true;
            this.LabelClass.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelClass.Location = new System.Drawing.Point(585, 439);
            this.LabelClass.Name = "LabelClass";
            this.LabelClass.Size = new System.Drawing.Size(47, 21);
            this.LabelClass.TabIndex = 18;
            this.LabelClass.Text = "Class";
            // 
            // LabelPassword
            // 
            this.LabelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelPassword.Location = new System.Drawing.Point(571, 292);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(82, 21);
            this.LabelPassword.TabIndex = 17;
            this.LabelPassword.Text = "Password";
            // 
            // pictureUser
            // 
            this.pictureUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureUser.Image = global::SystemSchool.Properties.Resources.icons8_user_40;
            this.pictureUser.Location = new System.Drawing.Point(565, 42);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(88, 81);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureUser.TabIndex = 23;
            this.pictureUser.TabStop = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCreate.BackColor = System.Drawing.Color.White;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.ForeColor = System.Drawing.Color.Green;
            this.buttonCreate.Location = new System.Drawing.Point(541, 575);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(121, 35);
            this.buttonCreate.TabIndex = 24;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxPassword.Location = new System.Drawing.Point(433, 329);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(346, 27);
            this.textBoxPassword.TabIndex = 25;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::SystemSchool.Properties.Resources.icons8_back_48;
            this.pictureBoxBack.Location = new System.Drawing.Point(991, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 23;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // RegistrationUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1026, 642);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.ComboBoxClass);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.LabelClass);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RegistrationUserForm";
            this.Load += new System.EventHandler(this.RegistrationUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelEditStudent;
        private System.Windows.Forms.Label LabelDeleteUser;
        private System.Windows.Forms.PictureBox pictureBoxEdit;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.PictureBox pictureBoxSchool;
        public System.Windows.Forms.ComboBox ComboBoxClass;
        public System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelClass;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Button buttonCreate;
        public System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}