namespace SystemSchool
{
    partial class StudentForm
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
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureStudent = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabelDelete = new System.Windows.Forms.LinkLabel();
            this.linkLabelEdit = new System.Windows.Forms.LinkLabel();
            this.LabelClassroom = new System.Windows.Forms.Label();
            this.LabelStudentName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ComboBoxCourse = new System.Windows.Forms.ComboBox();
            this.labelStudentCourse = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxClassroom
            // 
            this.ComboBoxClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBoxClassroom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComboBoxClassroom.FormattingEnabled = true;
            this.ComboBoxClassroom.Location = new System.Drawing.Point(297, 313);
            this.ComboBoxClassroom.Name = "ComboBoxClassroom";
            this.ComboBoxClassroom.Size = new System.Drawing.Size(287, 29);
            this.ComboBoxClassroom.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBoxBack);
            this.panel1.Controls.Add(this.pictureStudent);
            this.panel1.Location = new System.Drawing.Point(-7, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 87);
            this.panel1.TabIndex = 1;
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
            this.pictureStudent.Location = new System.Drawing.Point(364, 3);
            this.pictureStudent.Name = "pictureStudent";
            this.pictureStudent.Size = new System.Drawing.Size(158, 73);
            this.pictureStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureStudent.TabIndex = 0;
            this.pictureStudent.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.linkLabelDelete);
            this.panel2.Controls.Add(this.linkLabelEdit);
            this.panel2.Location = new System.Drawing.Point(-19, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 91);
            this.panel2.TabIndex = 2;
            // 
            // linkLabelDelete
            // 
            this.linkLabelDelete.AutoSize = true;
            this.linkLabelDelete.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelDelete.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelDelete.Location = new System.Drawing.Point(58, 33);
            this.linkLabelDelete.Name = "linkLabelDelete";
            this.linkLabelDelete.Size = new System.Drawing.Size(58, 21);
            this.linkLabelDelete.TabIndex = 1;
            this.linkLabelDelete.TabStop = true;
            this.linkLabelDelete.Text = "Delete\r\n";
            // 
            // linkLabelEdit
            // 
            this.linkLabelEdit.AutoSize = true;
            this.linkLabelEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelEdit.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabelEdit.Location = new System.Drawing.Point(771, 33);
            this.linkLabelEdit.Name = "linkLabelEdit";
            this.linkLabelEdit.Size = new System.Drawing.Size(38, 21);
            this.linkLabelEdit.TabIndex = 0;
            this.linkLabelEdit.TabStop = true;
            this.linkLabelEdit.Text = "Edit";
            // 
            // LabelClassroom
            // 
            this.LabelClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelClassroom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelClassroom.Location = new System.Drawing.Point(353, 267);
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
            this.LabelStudentName.Location = new System.Drawing.Point(355, 89);
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
            this.textBox1.Location = new System.Drawing.Point(297, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 29);
            this.textBox1.TabIndex = 5;
            // 
            // ComboBoxCourse
            // 
            this.ComboBoxCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBoxCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComboBoxCourse.FormattingEnabled = true;
            this.ComboBoxCourse.Location = new System.Drawing.Point(297, 225);
            this.ComboBoxCourse.Name = "ComboBoxCourse";
            this.ComboBoxCourse.Size = new System.Drawing.Size(287, 29);
            this.ComboBoxCourse.TabIndex = 6;
            this.ComboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCourse_SelectedIndexChanged);
            // 
            // labelStudentCourse
            // 
            this.labelStudentCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelStudentCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStudentCourse.Location = new System.Drawing.Point(355, 179);
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
            // StudentRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(873, 571);
            this.Controls.Add(this.labelStudentCourse);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.LinkLabel linkLabelDelete;
        private System.Windows.Forms.LinkLabel linkLabelEdit;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}