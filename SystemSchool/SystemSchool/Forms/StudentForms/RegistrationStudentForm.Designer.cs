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
            this.LabelEdit = new System.Windows.Forms.Label();
            this.LabelDelete = new System.Windows.Forms.Label();
            this.ComboBoxClassroom = new System.Windows.Forms.ComboBox();
            this.ComboBoxCourse = new System.Windows.Forms.ComboBox();
            this.textBoxCompleteName = new System.Windows.Forms.TextBox();
            this.LabelStudentName = new System.Windows.Forms.Label();
            this.LabelCourse = new System.Windows.Forms.Label();
            this.LabelClassroom = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureStudent = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LabelRegistrationStudent = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.LabelDelete);
            this.panel1.Controls.Add(this.LabelEdit);
            this.panel1.Location = new System.Drawing.Point(-6, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 695);
            this.panel1.TabIndex = 0;
            // 
            // LabelEdit
            // 
            this.LabelEdit.AutoSize = true;
            this.LabelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelEdit.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEdit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabelEdit.Location = new System.Drawing.Point(139, 234);
            this.LabelEdit.Name = "LabelEdit";
            this.LabelEdit.Size = new System.Drawing.Size(39, 21);
            this.LabelEdit.TabIndex = 18;
            this.LabelEdit.Text = "Edit";
            // 
            // LabelDelete
            // 
            this.LabelDelete.AutoSize = true;
            this.LabelDelete.BackColor = System.Drawing.Color.Black;
            this.LabelDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelDelete.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDelete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabelDelete.Location = new System.Drawing.Point(139, 490);
            this.LabelDelete.Name = "LabelDelete";
            this.LabelDelete.Size = new System.Drawing.Size(59, 21);
            this.LabelDelete.TabIndex = 17;
            this.LabelDelete.Text = "Delete";
            this.LabelDelete.Click += new System.EventHandler(this.LabelDelete_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::SystemSchool.Properties.Resources.icons8_back_48;
            this.pictureBox1.Location = new System.Drawing.Point(1007, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBoxBack_Click);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SystemSchool.Properties.Resources.icons8_edit_40;
            this.pictureBox2.Location = new System.Drawing.Point(0, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SystemSchool.Properties.Resources.icons8_delete_48;
            this.pictureBox3.Location = new System.Drawing.Point(0, 468);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SystemSchool.Properties.Resources.icons8_school_96__1_;
            this.pictureBox4.Location = new System.Drawing.Point(90, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(88, 81);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
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
            // RegistrationStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1042, 681);
            this.Controls.Add(this.LabelRegistrationStudent);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ComboBoxClassroom;
        private System.Windows.Forms.ComboBox ComboBoxCourse;
        private System.Windows.Forms.TextBox textBoxCompleteName;
        private System.Windows.Forms.Label LabelStudentName;
        private System.Windows.Forms.Label LabelCourse;
        private System.Windows.Forms.Label LabelClassroom;
        private System.Windows.Forms.PictureBox pictureStudent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelEdit;
        private System.Windows.Forms.Label LabelDelete;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LabelRegistrationStudent;
    }
}