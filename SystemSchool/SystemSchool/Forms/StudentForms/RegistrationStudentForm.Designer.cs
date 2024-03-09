namespace SystemSchool
{
    partial class RegistrationStudentForm
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
            this.LabelEditStudent = new System.Windows.Forms.Label();
            this.ComboBoxClassroom = new System.Windows.Forms.ComboBox();
            this.ComboBoxCourse = new System.Windows.Forms.ComboBox();
            this.textBoxCompleteName = new System.Windows.Forms.TextBox();
            this.LabelStudentName = new System.Windows.Forms.Label();
            this.LabelCourse = new System.Windows.Forms.Label();
            this.LabelClassroom = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.LabelRegistrationStudent = new System.Windows.Forms.Label();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureStudent = new System.Windows.Forms.PictureBox();
            this.pictureBoxSchool = new System.Windows.Forms.PictureBox();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBoxSchool);
            this.panel1.Controls.Add(this.pictureBoxDelete);
            this.panel1.Controls.Add(this.pictureBoxEdit);
            this.panel1.Controls.Add(this.LabelDeleteStudent);
            this.panel1.Controls.Add(this.LabelEditStudent);
            this.panel1.Location = new System.Drawing.Point(-6, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 695);
            this.panel1.TabIndex = 0;
            // 
            // LabelDeleteStudent
            // 
            this.LabelDeleteStudent.AutoSize = true;
            this.LabelDeleteStudent.BackColor = System.Drawing.Color.Black;
            this.LabelDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelDeleteStudent.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeleteStudent.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabelDeleteStudent.Location = new System.Drawing.Point(76, 532);
            this.LabelDeleteStudent.Name = "LabelDeleteStudent";
            this.LabelDeleteStudent.Size = new System.Drawing.Size(122, 21);
            this.LabelDeleteStudent.TabIndex = 17;
            this.LabelDeleteStudent.Text = "Delete Student";
            this.LabelDeleteStudent.Click += new System.EventHandler(this.LabelDelete_Click);
            // 
            // LabelEditStudent
            // 
            this.LabelEditStudent.AutoSize = true;
            this.LabelEditStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelEditStudent.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEditStudent.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabelEditStudent.Location = new System.Drawing.Point(86, 277);
            this.LabelEditStudent.Name = "LabelEditStudent";
            this.LabelEditStudent.Size = new System.Drawing.Size(102, 21);
            this.LabelEditStudent.TabIndex = 18;
            this.LabelEditStudent.Text = "Edit Student";
            this.LabelEditStudent.Click += new System.EventHandler(this.LabelEditStudent_Click);
            // 
            // ComboBoxClassroom
            // 
            this.ComboBoxClassroom.BackColor = System.Drawing.Color.White;
            this.ComboBoxClassroom.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxClassroom.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ComboBoxClassroom.FormattingEnabled = true;
            this.ComboBoxClassroom.Location = new System.Drawing.Point(464, 479);
            this.ComboBoxClassroom.Name = "ComboBoxClassroom";
            this.ComboBoxClassroom.Size = new System.Drawing.Size(346, 28);
            this.ComboBoxClassroom.TabIndex = 16;
            // 
            // ComboBoxCourse
            // 
            this.ComboBoxCourse.BackColor = System.Drawing.Color.White;
            this.ComboBoxCourse.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCourse.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ComboBoxCourse.FormattingEnabled = true;
            this.ComboBoxCourse.Location = new System.Drawing.Point(464, 346);
            this.ComboBoxCourse.Name = "ComboBoxCourse";
            this.ComboBoxCourse.Size = new System.Drawing.Size(346, 28);
            this.ComboBoxCourse.TabIndex = 15;
            this.ComboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCourse_SelectedIndexChanged);
            // 
            // textBoxCompleteName
            // 
            this.textBoxCompleteName.BackColor = System.Drawing.Color.White;
            this.textBoxCompleteName.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCompleteName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxCompleteName.Location = new System.Drawing.Point(464, 217);
            this.textBoxCompleteName.Name = "textBoxCompleteName";
            this.textBoxCompleteName.Size = new System.Drawing.Size(346, 27);
            this.textBoxCompleteName.TabIndex = 14;
            // 
            // LabelStudentName
            // 
            this.LabelStudentName.AutoSize = true;
            this.LabelStudentName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudentName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelStudentName.Location = new System.Drawing.Point(565, 193);
            this.LabelStudentName.Name = "LabelStudentName";
            this.LabelStudentName.Size = new System.Drawing.Size(139, 21);
            this.LabelStudentName.TabIndex = 13;
            this.LabelStudentName.Text = "Complete Name:";
            // 
            // LabelCourse
            // 
            this.LabelCourse.AutoSize = true;
            this.LabelCourse.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelCourse.Location = new System.Drawing.Point(598, 322);
            this.LabelCourse.Name = "LabelCourse";
            this.LabelCourse.Size = new System.Drawing.Size(62, 21);
            this.LabelCourse.TabIndex = 12;
            this.LabelCourse.Text = "Course";
            // 
            // LabelClassroom
            // 
            this.LabelClassroom.AutoSize = true;
            this.LabelClassroom.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClassroom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelClassroom.Location = new System.Drawing.Point(587, 455);
            this.LabelClassroom.Name = "LabelClassroom";
            this.LabelClassroom.Size = new System.Drawing.Size(88, 21);
            this.LabelClassroom.TabIndex = 11;
            this.LabelClassroom.Text = "Classroom";
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.Black;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.ForeColor = System.Drawing.Color.Green;
            this.buttonCreate.Location = new System.Drawing.Point(569, 574);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(121, 35);
            this.buttonCreate.TabIndex = 17;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // LabelRegistrationStudent
            // 
            this.LabelRegistrationStudent.AutoSize = true;
            this.LabelRegistrationStudent.BackColor = System.Drawing.Color.Transparent;
            this.LabelRegistrationStudent.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegistrationStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelRegistrationStudent.Location = new System.Drawing.Point(522, 96);
            this.LabelRegistrationStudent.Name = "LabelRegistrationStudent";
            this.LabelRegistrationStudent.Size = new System.Drawing.Size(221, 30);
            this.LabelRegistrationStudent.TabIndex = 18;
            this.LabelRegistrationStudent.Text = "Registration Student";
            this.LabelRegistrationStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::SystemSchool.Properties.Resources.icons8_back_48;
            this.pictureBoxBack.Location = new System.Drawing.Point(1007, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 10;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // pictureStudent
            // 
            this.pictureStudent.Image = global::SystemSchool.Properties.Resources.icons8_student_48;
            this.pictureStudent.Location = new System.Drawing.Point(591, 12);
            this.pictureStudent.Name = "pictureStudent";
            this.pictureStudent.Size = new System.Drawing.Size(88, 81);
            this.pictureStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureStudent.TabIndex = 8;
            this.pictureStudent.TabStop = false;
            // 
            // pictureBoxSchool
            // 
            this.pictureBoxSchool.Image = global::SystemSchool.Properties.Resources.icons8_school_80;
            this.pictureBoxSchool.Location = new System.Drawing.Point(90, 14);
            this.pictureBoxSchool.Name = "pictureBoxSchool";
            this.pictureBoxSchool.Size = new System.Drawing.Size(88, 81);
            this.pictureBoxSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSchool.TabIndex = 18;
            this.pictureBoxSchool.TabStop = false;
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDelete.Image = global::SystemSchool.Properties.Resources.icons8_delete_48;
            this.pictureBoxDelete.Location = new System.Drawing.Point(90, 466);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(88, 63);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDelete.TabIndex = 20;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEdit.Image = global::SystemSchool.Properties.Resources.icons8_edit_40;
            this.pictureBoxEdit.Location = new System.Drawing.Point(90, 204);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(88, 70);
            this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEdit.TabIndex = 19;
            this.pictureBoxEdit.TabStop = false;
            this.pictureBoxEdit.Click += new System.EventHandler(this.pictureBoxEdit_Click);
            // 
            // RegistrationStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1042, 681);
            this.Controls.Add(this.LabelRegistrationStudent);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.ComboBoxClassroom);
            this.Controls.Add(this.pictureStudent);
            this.Controls.Add(this.ComboBoxCourse);
            this.Controls.Add(this.textBoxCompleteName);
            this.Controls.Add(this.LabelStudentName);
            this.Controls.Add(this.LabelCourse);
            this.Controls.Add(this.LabelClassroom);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStudent";
            this.Load += new System.EventHandler(this.StudentRegistrationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox ComboBoxClassroom;
        private System.Windows.Forms.ComboBox ComboBoxCourse;
        public System.Windows.Forms.TextBox textBoxCompleteName;
        private System.Windows.Forms.Label LabelStudentName;
        private System.Windows.Forms.Label LabelCourse;
        private System.Windows.Forms.Label LabelClassroom;
        private System.Windows.Forms.PictureBox pictureStudent;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Label LabelEditStudent;
        private System.Windows.Forms.Label LabelDeleteStudent;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.PictureBox pictureBoxSchool;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.PictureBox pictureBoxEdit;
        private System.Windows.Forms.Label LabelRegistrationStudent;
    }
}