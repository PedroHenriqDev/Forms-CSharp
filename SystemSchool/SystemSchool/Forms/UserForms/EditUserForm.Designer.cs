namespace SystemSchool.Forms.UserForms
{
    partial class EditUserForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.listBoxSearch = new System.Windows.Forms.ListBox();
            this.LabelSearchResult = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.LabelUserShow = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.LabelClass = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.ComboBoxClass = new System.Windows.Forms.ComboBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelEditUser = new System.Windows.Forms.Label();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelRegisterUser = new System.Windows.Forms.Label();
            this.LabelDeleteUser = new System.Windows.Forms.Label();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.pictureBoxSchool = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBoxBack);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.LabelSearch);
            this.panel2.Controls.Add(this.listBoxSearch);
            this.panel2.Controls.Add(this.LabelSearchResult);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Location = new System.Drawing.Point(786, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 646);
            this.panel2.TabIndex = 26;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::SystemSchool.Properties.Resources.icons8_back_48;
            this.pictureBoxBack.Location = new System.Drawing.Point(205, 16);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 34;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SystemSchool.Properties.Resources.icons8_search_64;
            this.pictureBox4.Location = new System.Drawing.Point(93, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 67);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelSearch.Location = new System.Drawing.Point(51, 191);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(142, 21);
            this.LabelSearch.TabIndex = 26;
            this.LabelSearch.Text = "Search by Name:";
            // 
            // listBoxSearch
            // 
            this.listBoxSearch.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBoxSearch.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxSearch.FormattingEnabled = true;
            this.listBoxSearch.ItemHeight = 17;
            this.listBoxSearch.Location = new System.Drawing.Point(27, 338);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.Size = new System.Drawing.Size(187, 225);
            this.listBoxSearch.TabIndex = 28;
            this.listBoxSearch.SelectedIndexChanged += new System.EventHandler(this.listBoxSearch_SelectedIndexChanged);
            // 
            // LabelSearchResult
            // 
            this.LabelSearchResult.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearchResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelSearchResult.Location = new System.Drawing.Point(3, 267);
            this.LabelSearchResult.Name = "LabelSearchResult";
            this.LabelSearchResult.Size = new System.Drawing.Size(234, 68);
            this.LabelSearchResult.TabIndex = 29;
            this.LabelSearchResult.Text = "Result Search";
            this.LabelSearchResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxSearch.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxSearch.Location = new System.Drawing.Point(27, 215);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(187, 25);
            this.textBoxSearch.TabIndex = 27;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // LabelUserShow
            // 
            this.LabelUserShow.BackColor = System.Drawing.Color.Transparent;
            this.LabelUserShow.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserShow.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LabelUserShow.Location = new System.Drawing.Point(405, 189);
            this.LabelUserShow.Name = "LabelUserShow";
            this.LabelUserShow.Size = new System.Drawing.Size(216, 65);
            this.LabelUserShow.TabIndex = 42;
            this.LabelUserShow.Text = "Student";
            this.LabelUserShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.White;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEdit.Location = new System.Drawing.Point(423, 575);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(181, 34);
            this.buttonEdit.TabIndex = 41;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // LabelClass
            // 
            this.LabelClass.AutoSize = true;
            this.LabelClass.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClass.Location = new System.Drawing.Point(488, 481);
            this.LabelClass.Name = "LabelClass";
            this.LabelClass.Size = new System.Drawing.Size(51, 21);
            this.LabelClass.TabIndex = 40;
            this.LabelClass.Text = "Class:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxUsername.Location = new System.Drawing.Point(405, 365);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(216, 26);
            this.textBoxUsername.TabIndex = 37;
            // 
            // ComboBoxClass
            // 
            this.ComboBoxClass.BackColor = System.Drawing.Color.White;
            this.ComboBoxClass.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxClass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ComboBoxClass.FormattingEnabled = true;
            this.ComboBoxClass.Location = new System.Drawing.Point(405, 505);
            this.ComboBoxClass.Name = "ComboBoxClass";
            this.ComboBoxClass.Size = new System.Drawing.Size(216, 29);
            this.ComboBoxClass.TabIndex = 38;
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(472, 341);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(91, 21);
            this.LabelUsername.TabIndex = 39;
            this.LabelUsername.Text = "Username:";
            // 
            // LabelEditUser
            // 
            this.LabelEditUser.AutoSize = true;
            this.LabelEditUser.BackColor = System.Drawing.Color.Transparent;
            this.LabelEditUser.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEditUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelEditUser.Location = new System.Drawing.Point(458, 133);
            this.LabelEditUser.Name = "LabelEditUser";
            this.LabelEditUser.Size = new System.Drawing.Size(103, 30);
            this.LabelEditUser.TabIndex = 36;
            this.LabelEditUser.Text = "Edit User";
            this.LabelEditUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.Image = global::SystemSchool.Properties.Resources.icons8_edit_40;
            this.pictureBoxEdit.Location = new System.Drawing.Point(463, 33);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(100, 97);
            this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEdit.TabIndex = 35;
            this.pictureBoxEdit.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LabelRegisterUser);
            this.panel1.Controls.Add(this.LabelDeleteUser);
            this.panel1.Controls.Add(this.pictureBoxStudent);
            this.panel1.Controls.Add(this.pictureBoxDelete);
            this.panel1.Controls.Add(this.pictureBoxSchool);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 650);
            this.panel1.TabIndex = 43;
            // 
            // LabelRegisterUser
            // 
            this.LabelRegisterUser.AutoSize = true;
            this.LabelRegisterUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelRegisterUser.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegisterUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelRegisterUser.Location = new System.Drawing.Point(69, 467);
            this.LabelRegisterUser.Name = "LabelRegisterUser";
            this.LabelRegisterUser.Size = new System.Drawing.Size(98, 20);
            this.LabelRegisterUser.TabIndex = 24;
            this.LabelRegisterUser.Text = "Register User";
            this.LabelRegisterUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelRegisterUser.Click += new System.EventHandler(this.LabelRegisterUser_Click);
            // 
            // LabelDeleteUser
            // 
            this.LabelDeleteUser.AutoSize = true;
            this.LabelDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelDeleteUser.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeleteUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelDeleteUser.Location = new System.Drawing.Point(75, 245);
            this.LabelDeleteUser.Name = "LabelDeleteUser";
            this.LabelDeleteUser.Size = new System.Drawing.Size(88, 20);
            this.LabelDeleteUser.TabIndex = 23;
            this.LabelDeleteUser.Text = "Delete User";
            this.LabelDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelDeleteUser.Click += new System.EventHandler(this.LabelDeleteUser_Click);
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxStudent.Image = global::SystemSchool.Properties.Resources.icons8_user_40;
            this.pictureBoxStudent.Location = new System.Drawing.Point(69, 413);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(104, 51);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxStudent.TabIndex = 2;
            this.pictureBoxStudent.TabStop = false;
            this.pictureBoxStudent.Click += new System.EventHandler(this.pictureBoxStudent_Click);
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDelete.Image = global::SystemSchool.Properties.Resources.icons8_delete_48;
            this.pictureBoxDelete.Location = new System.Drawing.Point(73, 191);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(100, 51);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDelete.TabIndex = 1;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // pictureBoxSchool
            // 
            this.pictureBoxSchool.Image = global::SystemSchool.Properties.Resources.icons8_school_80;
            this.pictureBoxSchool.Location = new System.Drawing.Point(73, 19);
            this.pictureBoxSchool.Name = "pictureBoxSchool";
            this.pictureBoxSchool.Size = new System.Drawing.Size(100, 97);
            this.pictureBoxSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSchool.TabIndex = 0;
            this.pictureBoxSchool.TabStop = false;
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1026, 642);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelUserShow);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.LabelClass);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.ComboBoxClass);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.LabelEditUser);
            this.Controls.Add(this.pictureBoxEdit);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUserForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label LabelSearch;
        public System.Windows.Forms.ListBox listBoxSearch;
        private System.Windows.Forms.Label LabelSearchResult;
        private System.Windows.Forms.TextBox textBoxSearch;
        public System.Windows.Forms.Label LabelUserShow;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label LabelClass;
        public System.Windows.Forms.TextBox textBoxUsername;
        public System.Windows.Forms.ComboBox ComboBoxClass;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelEditUser;
        private System.Windows.Forms.PictureBox pictureBoxEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelRegisterUser;
        private System.Windows.Forms.Label LabelDeleteUser;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.PictureBox pictureBoxSchool;
    }
}