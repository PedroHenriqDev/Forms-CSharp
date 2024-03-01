namespace SystemSchool
{
    partial class StudentRegistrationForm
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
            this.ComboBoxClassroom = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelStateStudentForm = new System.Windows.Forms.Label();
            this.LabelClassroom = new System.Windows.Forms.Label();
            this.LabelStudentName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ComboBoxCourse = new System.Windows.Forms.ComboBox();
            this.labelStudentCourse = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.LabelEdit = new System.Windows.Forms.Label();
            this.LabelDelete = new System.Windows.Forms.Label();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureStudent = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxClassroom
            // 
            this.ComboBoxClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBoxClassroom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComboBoxClassroom.FormattingEnabled = true;
            this.ComboBoxClassroom.Location = new System.Drawing.Point(295, 345);
            this.ComboBoxClassroom.Name = "ComboBoxClassroom";
            this.ComboBoxClassroom.Size = new System.Drawing.Size(287, 29);
            this.ComboBoxClassroom.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LabelStateStudentForm);
            this.panel1.Controls.Add(this.pictureBoxBack);
            this.panel1.Location = new System.Drawing.Point(-7, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 87);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureStudent);
            this.panel2.Location = new System.Drawing.Point(-19, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 91);
            this.panel2.TabIndex = 2;
            // 
            // LabelStateStudentForm
            // 
            this.LabelStateStudentForm.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStateStudentForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelStateStudentForm.Location = new System.Drawing.Point(300, 13);
            this.LabelStateStudentForm.Name = "LabelStateStudentForm";
            this.LabelStateStudentForm.Size = new System.Drawing.Size(287, 61);
            this.LabelStateStudentForm.TabIndex = 0;
            this.LabelStateStudentForm.Text = "Student Registration";
            this.LabelStateStudentForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelClassroom
            // 
            this.LabelClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelClassroom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelClassroom.Location = new System.Drawing.Point(351, 299);
            this.LabelClassroom.Name = "LabelClassroom";
            this.LabelClassroom.Size = new System.Drawing.Size(171, 43);
            this.LabelClassroom.TabIndex = 3;
            this.LabelClassroom.Text = "Classroom";
            this.LabelClassroom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelStudentName
            // 
            this.LabelStudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelStudentName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelStudentName.Location = new System.Drawing.Point(353, 121);
            this.LabelStudentName.Name = "LabelStudentName";
            this.LabelStudentName.Size = new System.Drawing.Size(171, 43);
            this.LabelStudentName.TabIndex = 4;
            this.LabelStudentName.Text = "Student Complete Name";
            this.LabelStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(295, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 29);
            this.textBox1.TabIndex = 5;
            // 
            // ComboBoxCourse
            // 
            this.ComboBoxCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBoxCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComboBoxCourse.FormattingEnabled = true;
            this.ComboBoxCourse.Location = new System.Drawing.Point(295, 257);
            this.ComboBoxCourse.Name = "ComboBoxCourse";
            this.ComboBoxCourse.Size = new System.Drawing.Size(287, 29);
            this.ComboBoxCourse.TabIndex = 6;
            this.ComboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCourse_SelectedIndexChanged);
            // 
            // labelStudentCourse
            // 
            this.labelStudentCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelStudentCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStudentCourse.Location = new System.Drawing.Point(353, 211);
            this.labelStudentCourse.Name = "labelStudentCourse";
            this.labelStudentCourse.Size = new System.Drawing.Size(171, 43);
            this.labelStudentCourse.TabIndex = 7;
            this.labelStudentCourse.Text = "Course";
            this.labelStudentCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Black;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonRegister.Location = new System.Drawing.Point(384, 406);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(104, 32);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            // 
            // LabelEdit
            // 
            this.LabelEdit.BackColor = System.Drawing.Color.Black;
            this.LabelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelEdit.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEdit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LabelEdit.Location = new System.Drawing.Point(-4, 80);
            this.LabelEdit.Name = "LabelEdit";
            this.LabelEdit.Size = new System.Drawing.Size(109, 47);
            this.LabelEdit.TabIndex = 0;
            this.LabelEdit.Text = "Edit";
            this.LabelEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDelete
            // 
            this.LabelDelete.BackColor = System.Drawing.Color.Black;
            this.LabelDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelDelete.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDelete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LabelDelete.Location = new System.Drawing.Point(769, 75);
            this.LabelDelete.Name = "LabelDelete";
            this.LabelDelete.Size = new System.Drawing.Size(109, 57);
            this.LabelDelete.TabIndex = 1;
            this.LabelDelete.Text = "Delete";
            this.LabelDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelDelete.Click += new System.EventHandler(this.LabelDelete_Click);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::SystemSchool.Properties.Resources.icons8_back_48;
            this.pictureBoxBack.Location = new System.Drawing.Point(840, 13);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(28, 25);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 1;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // pictureStudent
            // 
            this.pictureStudent.Image = global::SystemSchool.Properties.Resources.icons8_student_male_100;
            this.pictureStudent.Location = new System.Drawing.Point(368, 7);
            this.pictureStudent.Name = "pictureStudent";
            this.pictureStudent.Size = new System.Drawing.Size(158, 73);
            this.pictureStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureStudent.TabIndex = 0;
            this.pictureStudent.TabStop = false;
            // 
            // StudentRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(873, 571);
            this.Controls.Add(this.LabelDelete);
            this.Controls.Add(this.labelStudentCourse);
            this.Controls.Add(this.LabelEdit);
            this.Controls.Add(this.ComboBoxCourse);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LabelStudentName);
            this.Controls.Add(this.LabelClassroom);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ComboBoxClassroom);
            this.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentRegistrationForm";
            this.Load += new System.EventHandler(this.StudentRegistrationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxClassroom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureStudent;
        private System.Windows.Forms.Label LabelClassroom;
        private System.Windows.Forms.Label LabelStudentName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox ComboBoxCourse;
        private System.Windows.Forms.Label labelStudentCourse;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Label LabelDelete;
        private System.Windows.Forms.Label LabelEdit;
        private System.Windows.Forms.Label LabelStateStudentForm;
    }
}