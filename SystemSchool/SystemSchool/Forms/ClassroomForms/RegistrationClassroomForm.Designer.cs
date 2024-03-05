namespace SystemSchool.Forms.ClassroomForms
{
    partial class RegistrationClassroomForm
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
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxClassroom = new System.Windows.Forms.PictureBox();
            this.LabelRegistrationClassroom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelDelete = new System.Windows.Forms.Label();
            this.LabelEdit = new System.Windows.Forms.Label();
            this.LabelClassroomName = new System.Windows.Forms.Label();
            this.LabelCourse = new System.Windows.Forms.Label();
            this.LabelSchoolYear = new System.Windows.Forms.Label();
            this.LabelClassroomLetter = new System.Windows.Forms.Label();
            this.ComboBoxSchoolYear = new System.Windows.Forms.ComboBox();
            this.ComboBoxLetter = new System.Windows.Forms.ComboBox();
            this.ComboBoxCourse = new System.Windows.Forms.ComboBox();
            this.LabelClassroomNameShow = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.LabelCourseNameShow = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClassroom)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBoxBack);
            this.panel1.Controls.Add(this.pictureBoxClassroom);
            this.panel1.Controls.Add(this.LabelRegistrationClassroom);
            this.panel1.Location = new System.Drawing.Point(-8, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 86);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::SystemSchool.Properties.Resources.icons8_back_48;
            this.pictureBoxBack.Location = new System.Drawing.Point(1032, 26);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(22, 19);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 2;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // pictureBoxClassroom
            // 
            this.pictureBoxClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClassroom.Image = global::SystemSchool.Properties.Resources.icons8_classroom_100;
            this.pictureBoxClassroom.Location = new System.Drawing.Point(9, 0);
            this.pictureBoxClassroom.Name = "pictureBoxClassroom";
            this.pictureBoxClassroom.Size = new System.Drawing.Size(75, 72);
            this.pictureBoxClassroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClassroom.TabIndex = 1;
            this.pictureBoxClassroom.TabStop = false;
            // 
            // LabelRegistrationClassroom
            // 
            this.LabelRegistrationClassroom.AutoSize = true;
            this.LabelRegistrationClassroom.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegistrationClassroom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelRegistrationClassroom.Location = new System.Drawing.Point(428, 26);
            this.LabelRegistrationClassroom.Name = "LabelRegistrationClassroom";
            this.LabelRegistrationClassroom.Size = new System.Drawing.Size(245, 30);
            this.LabelRegistrationClassroom.TabIndex = 0;
            this.LabelRegistrationClassroom.Text = "Registration Classroom";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.LabelDelete);
            this.panel2.Controls.Add(this.LabelEdit);
            this.panel2.Location = new System.Drawing.Point(-8, 639);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 108);
            this.panel2.TabIndex = 1;
            // 
            // LabelDelete
            // 
            this.LabelDelete.AutoSize = true;
            this.LabelDelete.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDelete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabelDelete.Location = new System.Drawing.Point(940, 29);
            this.LabelDelete.Name = "LabelDelete";
            this.LabelDelete.Size = new System.Drawing.Size(59, 21);
            this.LabelDelete.TabIndex = 0;
            this.LabelDelete.Text = "Delete";
            // 
            // LabelEdit
            // 
            this.LabelEdit.AutoSize = true;
            this.LabelEdit.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEdit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabelEdit.Location = new System.Drawing.Point(69, 29);
            this.LabelEdit.Name = "LabelEdit";
            this.LabelEdit.Size = new System.Drawing.Size(39, 21);
            this.LabelEdit.TabIndex = 9;
            this.LabelEdit.Text = "Edit";
            // 
            // LabelClassroomName
            // 
            this.LabelClassroomName.AutoSize = true;
            this.LabelClassroomName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClassroomName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelClassroomName.Location = new System.Drawing.Point(464, 343);
            this.LabelClassroomName.Name = "LabelClassroomName";
            this.LabelClassroomName.Size = new System.Drawing.Size(0, 21);
            this.LabelClassroomName.TabIndex = 2;
            // 
            // LabelCourse
            // 
            this.LabelCourse.AutoSize = true;
            this.LabelCourse.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelCourse.Location = new System.Drawing.Point(135, 364);
            this.LabelCourse.Name = "LabelCourse";
            this.LabelCourse.Size = new System.Drawing.Size(62, 21);
            this.LabelCourse.TabIndex = 3;
            this.LabelCourse.Text = "Course";
            // 
            // LabelSchoolYear
            // 
            this.LabelSchoolYear.AutoSize = true;
            this.LabelSchoolYear.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSchoolYear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelSchoolYear.Location = new System.Drawing.Point(821, 364);
            this.LabelSchoolYear.Name = "LabelSchoolYear";
            this.LabelSchoolYear.Size = new System.Drawing.Size(101, 21);
            this.LabelSchoolYear.TabIndex = 4;
            this.LabelSchoolYear.Text = "School Year";
            // 
            // LabelClassroomLetter
            // 
            this.LabelClassroomLetter.AutoSize = true;
            this.LabelClassroomLetter.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClassroomLetter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelClassroomLetter.Location = new System.Drawing.Point(502, 205);
            this.LabelClassroomLetter.Name = "LabelClassroomLetter";
            this.LabelClassroomLetter.Size = new System.Drawing.Size(54, 21);
            this.LabelClassroomLetter.TabIndex = 5;
            this.LabelClassroomLetter.Text = "Letter";
            // 
            // ComboBoxSchoolYear
            // 
            this.ComboBoxSchoolYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBoxSchoolYear.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxSchoolYear.ForeColor = System.Drawing.SystemColors.Window;
            this.ComboBoxSchoolYear.FormattingEnabled = true;
            this.ComboBoxSchoolYear.Items.AddRange(new object[] {
            "1º",
            "2º",
            "3º"});
            this.ComboBoxSchoolYear.Location = new System.Drawing.Point(730, 407);
            this.ComboBoxSchoolYear.Name = "ComboBoxSchoolYear";
            this.ComboBoxSchoolYear.Size = new System.Drawing.Size(290, 29);
            this.ComboBoxSchoolYear.TabIndex = 6;
            this.ComboBoxSchoolYear.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSchoolYear_SelectedIndexChanged);
            // 
            // ComboBoxLetter
            // 
            this.ComboBoxLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBoxLetter.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxLetter.ForeColor = System.Drawing.SystemColors.Window;
            this.ComboBoxLetter.FormattingEnabled = true;
            this.ComboBoxLetter.Location = new System.Drawing.Point(392, 255);
            this.ComboBoxLetter.Name = "ComboBoxLetter";
            this.ComboBoxLetter.Size = new System.Drawing.Size(290, 29);
            this.ComboBoxLetter.TabIndex = 7;
            this.ComboBoxLetter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLetter_SelectedIndexChanged);
            // 
            // ComboBoxCourse
            // 
            this.ComboBoxCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBoxCourse.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCourse.ForeColor = System.Drawing.SystemColors.Window;
            this.ComboBoxCourse.FormattingEnabled = true;
            this.ComboBoxCourse.Location = new System.Drawing.Point(32, 407);
            this.ComboBoxCourse.Name = "ComboBoxCourse";
            this.ComboBoxCourse.Size = new System.Drawing.Size(290, 29);
            this.ComboBoxCourse.TabIndex = 8;
            this.ComboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCourse_SelectedIndexChanged);
            // 
            // LabelClassroomNameShow
            // 
            this.LabelClassroomNameShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelClassroomNameShow.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClassroomNameShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelClassroomNameShow.Location = new System.Drawing.Point(380, 364);
            this.LabelClassroomNameShow.Name = "LabelClassroomNameShow";
            this.LabelClassroomNameShow.Size = new System.Drawing.Size(299, 111);
            this.LabelClassroomNameShow.TabIndex = 9;
            this.LabelClassroomNameShow.Text = "Classroom";
            this.LabelClassroomNameShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.ForeColor = System.Drawing.Color.Green;
            this.buttonCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreate.ImageKey = "(none)";
            this.buttonCreate.Location = new System.Drawing.Point(467, 541);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(124, 44);
            this.buttonCreate.TabIndex = 10;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = false;
            // 
            // LabelCourseNameShow
            // 
            this.LabelCourseNameShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelCourseNameShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelCourseNameShow.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCourseNameShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelCourseNameShow.Location = new System.Drawing.Point(412, 440);
            this.LabelCourseNameShow.Name = "LabelCourseNameShow";
            this.LabelCourseNameShow.Size = new System.Drawing.Size(225, 35);
            this.LabelCourseNameShow.TabIndex = 11;
            this.LabelCourseNameShow.Text = "Classroom";
            this.LabelCourseNameShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegistrationClassroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1058, 720);
            this.Controls.Add(this.LabelCourseNameShow);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.LabelClassroomNameShow);
            this.Controls.Add(this.ComboBoxCourse);
            this.Controls.Add(this.ComboBoxLetter);
            this.Controls.Add(this.ComboBoxSchoolYear);
            this.Controls.Add(this.LabelClassroomLetter);
            this.Controls.Add(this.LabelSchoolYear);
            this.Controls.Add(this.LabelCourse);
            this.Controls.Add(this.LabelClassroomName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationClassroomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationClassroom";
            this.Load += new System.EventHandler(this.RegistrationClassroomForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClassroom)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelRegistrationClassroom;
        private System.Windows.Forms.Label LabelClassroomName;
        private System.Windows.Forms.Label LabelCourse;
        private System.Windows.Forms.Label LabelSchoolYear;
        private System.Windows.Forms.Label LabelClassroomLetter;
        private System.Windows.Forms.ComboBox ComboBoxSchoolYear;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxClassroom;
        private System.Windows.Forms.Label LabelDelete;
        private System.Windows.Forms.Label LabelEdit;
        private System.Windows.Forms.ComboBox ComboBoxLetter;
        private System.Windows.Forms.ComboBox ComboBoxCourse;
        private System.Windows.Forms.Label LabelClassroomNameShow;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label LabelCourseNameShow;
    }
}