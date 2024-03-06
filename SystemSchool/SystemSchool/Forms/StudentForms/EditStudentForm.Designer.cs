namespace SystemSchool.Forms.StudentForms
{
    partial class EditStudentForm
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
            this.LabelDeleteStudent = new System.Windows.Forms.Label();
            this.LabelRegisterStudent = new System.Windows.Forms.Label();
            this.LabelEditStudent = new System.Windows.Forms.Label();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listBoxSearch = new System.Windows.Forms.ListBox();
            this.LabelSearchResult = new System.Windows.Forms.Label();
            this.LabelStudentName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSchool = new System.Windows.Forms.PictureBox();
            this.ComboBoxSchoolYear = new System.Windows.Forms.ComboBox();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LabelClassroom = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LabelRegisterStudent);
            this.panel1.Controls.Add(this.LabelDeleteStudent);
            this.panel1.Controls.Add(this.pictureBoxStudent);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBoxSchool);
            this.panel1.Location = new System.Drawing.Point(-3, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 650);
            this.panel1.TabIndex = 0;
            // 
            // LabelDeleteStudent
            // 
            this.LabelDeleteStudent.AutoSize = true;
            this.LabelDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelDeleteStudent.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeleteStudent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelDeleteStudent.Location = new System.Drawing.Point(116, 228);
            this.LabelDeleteStudent.Name = "LabelDeleteStudent";
            this.LabelDeleteStudent.Size = new System.Drawing.Size(111, 20);
            this.LabelDeleteStudent.TabIndex = 23;
            this.LabelDeleteStudent.Text = "Delete Student";
            this.LabelDeleteStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelRegisterStudent
            // 
            this.LabelRegisterStudent.AutoSize = true;
            this.LabelRegisterStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelRegisterStudent.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegisterStudent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelRegisterStudent.Location = new System.Drawing.Point(116, 428);
            this.LabelRegisterStudent.Name = "LabelRegisterStudent";
            this.LabelRegisterStudent.Size = new System.Drawing.Size(121, 20);
            this.LabelRegisterStudent.TabIndex = 24;
            this.LabelRegisterStudent.Text = "Register Student";
            this.LabelRegisterStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelEditStudent
            // 
            this.LabelEditStudent.AutoSize = true;
            this.LabelEditStudent.BackColor = System.Drawing.Color.Transparent;
            this.LabelEditStudent.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEditStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelEditStudent.Location = new System.Drawing.Point(445, 112);
            this.LabelEditStudent.Name = "LabelEditStudent";
            this.LabelEditStudent.Size = new System.Drawing.Size(137, 30);
            this.LabelEditStudent.TabIndex = 25;
            this.LabelEditStudent.Text = "Edit Student";
            this.LabelEditStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelSearch.Location = new System.Drawing.Point(43, 191);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(142, 21);
            this.LabelSearch.TabIndex = 26;
            this.LabelSearch.Text = "Search by Name:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxSearch.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxSearch.Location = new System.Drawing.Point(19, 215);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(187, 25);
            this.textBoxSearch.TabIndex = 27;
            // 
            // listBoxSearch
            // 
            this.listBoxSearch.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBoxSearch.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxSearch.FormattingEnabled = true;
            this.listBoxSearch.ItemHeight = 17;
            this.listBoxSearch.Location = new System.Drawing.Point(19, 338);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.Size = new System.Drawing.Size(187, 225);
            this.listBoxSearch.TabIndex = 28;
            // 
            // LabelSearchResult
            // 
            this.LabelSearchResult.AutoSize = true;
            this.LabelSearchResult.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearchResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelSearchResult.Location = new System.Drawing.Point(52, 303);
            this.LabelSearchResult.Name = "LabelSearchResult";
            this.LabelSearchResult.Size = new System.Drawing.Size(113, 21);
            this.LabelSearchResult.TabIndex = 29;
            this.LabelSearchResult.Text = "Result Search";
            // 
            // LabelStudentName
            // 
            this.LabelStudentName.AutoSize = true;
            this.LabelStudentName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudentName.Location = new System.Drawing.Point(450, 237);
            this.LabelStudentName.Name = "LabelStudentName";
            this.LabelStudentName.Size = new System.Drawing.Size(126, 21);
            this.LabelStudentName.TabIndex = 31;
            this.LabelStudentName.Text = "Student Name:";
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
            this.panel2.Location = new System.Drawing.Point(787, -7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 650);
            this.panel2.TabIndex = 25;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SystemSchool.Properties.Resources.icons8_search_64;
            this.pictureBox4.Location = new System.Drawing.Point(56, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 97);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.Image = global::SystemSchool.Properties.Resources.icons8_edit_40;
            this.pictureBoxEdit.Location = new System.Drawing.Point(463, 12);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(100, 97);
            this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEdit.TabIndex = 3;
            this.pictureBoxEdit.TabStop = false;
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Image = global::SystemSchool.Properties.Resources.icons8_student_48;
            this.pictureBoxStudent.Location = new System.Drawing.Point(15, 383);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(100, 97);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxStudent.TabIndex = 2;
            this.pictureBoxStudent.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SystemSchool.Properties.Resources.icons8_delete_48;
            this.pictureBox2.Location = new System.Drawing.Point(15, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxSchool
            // 
            this.pictureBoxSchool.Image = global::SystemSchool.Properties.Resources.icons8_school_96__1_;
            this.pictureBoxSchool.Location = new System.Drawing.Point(56, 19);
            this.pictureBoxSchool.Name = "pictureBoxSchool";
            this.pictureBoxSchool.Size = new System.Drawing.Size(100, 97);
            this.pictureBoxSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSchool.TabIndex = 0;
            this.pictureBoxSchool.TabStop = false;
            // 
            // ComboBoxSchoolYear
            // 
            this.ComboBoxSchoolYear.BackColor = System.Drawing.Color.White;
            this.ComboBoxSchoolYear.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxSchoolYear.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ComboBoxSchoolYear.FormattingEnabled = true;
            this.ComboBoxSchoolYear.Items.AddRange(new object[] {
            "1º",
            "2º",
            "3º"});
            this.ComboBoxSchoolYear.Location = new System.Drawing.Point(405, 444);
            this.ComboBoxSchoolYear.Name = "ComboBoxSchoolYear";
            this.ComboBoxSchoolYear.Size = new System.Drawing.Size(216, 29);
            this.ComboBoxSchoolYear.TabIndex = 30;
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxStudentName.Location = new System.Drawing.Point(405, 271);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(216, 26);
            this.textBoxStudentName.TabIndex = 30;
            // 
            // LabelClassroom
            // 
            this.LabelClassroom.AutoSize = true;
            this.LabelClassroom.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClassroom.Location = new System.Drawing.Point(434, 406);
            this.LabelClassroom.Name = "LabelClassroom";
            this.LabelClassroom.Size = new System.Drawing.Size(154, 21);
            this.LabelClassroom.TabIndex = 32;
            this.LabelClassroom.Text = "Student Classroom";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Black;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEdit.Location = new System.Drawing.Point(423, 554);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(181, 34);
            this.buttonEdit.TabIndex = 33;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::SystemSchool.Properties.Resources.icons8_back_48;
            this.pictureBoxBack.Location = new System.Drawing.Point(214, 13);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 34;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1026, 642);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.LabelClassroom);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.ComboBoxSchoolYear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LabelStudentName);
            this.Controls.Add(this.LabelEditStudent);
            this.Controls.Add(this.pictureBoxEdit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditStudentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxSchool;
        private System.Windows.Forms.PictureBox pictureBoxEdit;
        private System.Windows.Forms.Label LabelRegisterStudent;
        private System.Windows.Forms.Label LabelDeleteStudent;
        private System.Windows.Forms.Label LabelEditStudent;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListBox listBoxSearch;
        private System.Windows.Forms.Label LabelSearchResult;
        private System.Windows.Forms.Label LabelStudentName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox ComboBoxSchoolYear;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label LabelClassroom;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}