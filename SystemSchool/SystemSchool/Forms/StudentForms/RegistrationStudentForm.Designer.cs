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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelRegistrationStudent = new System.Windows.Forms.Label();
            this.pictureStudent = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ComboBoxClassroom = new System.Windows.Forms.ComboBox();
            this.ComboBoxCourse = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelStudentName = new System.Windows.Forms.Label();
            this.LabelCourse = new System.Windows.Forms.Label();
            this.LabelClassroom = new System.Windows.Forms.Label();
            this.LabelDelete = new System.Windows.Forms.Label();
            this.LabelEdit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LabelRegistrationStudent);
            this.panel1.Controls.Add(this.pictureStudent);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 75);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::SystemSchool.Properties.Resources.icons8_back_48;
            this.pictureBox1.Location = new System.Drawing.Point(999, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // LabelRegistrationStudent
            // 
            this.LabelRegistrationStudent.AutoSize = true;
            this.LabelRegistrationStudent.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegistrationStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelRegistrationStudent.Location = new System.Drawing.Point(425, 24);
            this.LabelRegistrationStudent.Name = "LabelRegistrationStudent";
            this.LabelRegistrationStudent.Size = new System.Drawing.Size(198, 25);
            this.LabelRegistrationStudent.TabIndex = 9;
            this.LabelRegistrationStudent.Text = "Student Registration";
            // 
            // pictureStudent
            // 
            this.pictureStudent.Image = global::SystemSchool.Properties.Resources.icons8_student_male_100;
            this.pictureStudent.Location = new System.Drawing.Point(0, -6);
            this.pictureStudent.Name = "pictureStudent";
            this.pictureStudent.Size = new System.Drawing.Size(88, 81);
            this.pictureStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureStudent.TabIndex = 8;
            this.pictureStudent.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.LabelEdit);
            this.panel2.Controls.Add(this.LabelDelete);
            this.panel2.Location = new System.Drawing.Point(-43, 602);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 79);
            this.panel2.TabIndex = 1;
            // 
            // ComboBoxClassroom
            // 
            this.ComboBoxClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBoxClassroom.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxClassroom.ForeColor = System.Drawing.SystemColors.Window;
            this.ComboBoxClassroom.FormattingEnabled = true;
            this.ComboBoxClassroom.Location = new System.Drawing.Point(348, 476);
            this.ComboBoxClassroom.Name = "ComboBoxClassroom";
            this.ComboBoxClassroom.Size = new System.Drawing.Size(346, 28);
            this.ComboBoxClassroom.TabIndex = 16;
            // 
            // ComboBoxCourse
            // 
            this.ComboBoxCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBoxCourse.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCourse.ForeColor = System.Drawing.SystemColors.Window;
            this.ComboBoxCourse.FormattingEnabled = true;
            this.ComboBoxCourse.Location = new System.Drawing.Point(348, 335);
            this.ComboBoxCourse.Name = "ComboBoxCourse";
            this.ComboBoxCourse.Size = new System.Drawing.Size(346, 28);
            this.ComboBoxCourse.TabIndex = 15;
            this.ComboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCourse_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(348, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 27);
            this.textBox1.TabIndex = 14;
            // 
            // LabelStudentName
            // 
            this.LabelStudentName.AutoSize = true;
            this.LabelStudentName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudentName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelStudentName.Location = new System.Drawing.Point(452, 164);
            this.LabelStudentName.Name = "LabelStudentName";
            this.LabelStudentName.Size = new System.Drawing.Size(139, 21);
            this.LabelStudentName.TabIndex = 13;
            this.LabelStudentName.Text = "Complete Name:";
            // 
            // LabelCourse
            // 
            this.LabelCourse.AutoSize = true;
            this.LabelCourse.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelCourse.Location = new System.Drawing.Point(490, 300);
            this.LabelCourse.Name = "LabelCourse";
            this.LabelCourse.Size = new System.Drawing.Size(62, 21);
            this.LabelCourse.TabIndex = 12;
            this.LabelCourse.Text = "Course";
            // 
            // LabelClassroom
            // 
            this.LabelClassroom.AutoSize = true;
            this.LabelClassroom.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClassroom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelClassroom.Location = new System.Drawing.Point(474, 452);
            this.LabelClassroom.Name = "LabelClassroom";
            this.LabelClassroom.Size = new System.Drawing.Size(88, 21);
            this.LabelClassroom.TabIndex = 11;
            this.LabelClassroom.Text = "Classroom";
            // 
            // LabelDelete
            // 
            this.LabelDelete.AutoSize = true;
            this.LabelDelete.BackColor = System.Drawing.Color.Black;
            this.LabelDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelDelete.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDelete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabelDelete.Location = new System.Drawing.Point(997, 31);
            this.LabelDelete.Name = "LabelDelete";
            this.LabelDelete.Size = new System.Drawing.Size(59, 21);
            this.LabelDelete.TabIndex = 17;
            this.LabelDelete.Text = "Delete";
            this.LabelDelete.Click += new System.EventHandler(this.LabelDelete_Click);
            // 
            // LabelEdit
            // 
            this.LabelEdit.AutoSize = true;
            this.LabelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelEdit.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEdit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabelEdit.Location = new System.Drawing.Point(55, 31);
            this.LabelEdit.Name = "LabelEdit";
            this.LabelEdit.Size = new System.Drawing.Size(39, 21);
            this.LabelEdit.TabIndex = 18;
            this.LabelEdit.Text = "Edit";
            // 
            // RegistrationStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1042, 681);
            this.Controls.Add(this.ComboBoxClassroom);
            this.Controls.Add(this.ComboBoxCourse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LabelStudentName);
            this.Controls.Add(this.LabelCourse);
            this.Controls.Add(this.LabelClassroom);
            this.Controls.Add(this.panel2);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ComboBoxClassroom;
        private System.Windows.Forms.ComboBox ComboBoxCourse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabelStudentName;
        private System.Windows.Forms.Label LabelCourse;
        private System.Windows.Forms.Label LabelClassroom;
        private System.Windows.Forms.PictureBox pictureStudent;
        private System.Windows.Forms.Label LabelRegistrationStudent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelEdit;
        private System.Windows.Forms.Label LabelDelete;
    }
}