﻿using System.Windows.Forms;

namespace SystemSchool
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelSchoolManager = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelTextDate = new System.Windows.Forms.Label();
            this.LabelTextHour = new System.Windows.Forms.Label();
            this.LabelHour = new System.Windows.Forms.Label();
            this.LabelStatistics = new System.Windows.Forms.Label();
            this.LabelClassroom = new System.Windows.Forms.Label();
            this.LabelReports = new System.Windows.Forms.Label();
            this.LabelLogout = new System.Windows.Forms.Label();
            this.LabelUser = new System.Windows.Forms.Label();
            this.LabelCourse = new System.Windows.Forms.Label();
            this.LabelChangePassword = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LabelStudent = new System.Windows.Forms.Label();
            this.TimerDate = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSchooolManager = new System.Windows.Forms.Label();
            this.pictureBoxSchool = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureChangePassword = new System.Windows.Forms.PictureBox();
            this.pictureStatistics = new System.Windows.Forms.PictureBox();
            this.pictureReports = new System.Windows.Forms.PictureBox();
            this.pictureLogout = new System.Windows.Forms.PictureBox();
            this.pictureStudent = new System.Windows.Forms.PictureBox();
            this.pictureClassroom = new System.Windows.Forms.PictureBox();
            this.pictureCourse = new System.Windows.Forms.PictureBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChangePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClassroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelUsername
            // 
            this.LabelUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LabelUsername.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.ForeColor = System.Drawing.Color.Black;
            this.LabelUsername.Location = new System.Drawing.Point(93, 645);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(243, 34);
            this.LabelUsername.TabIndex = 16;
            this.LabelUsername.Text = "LabelUsername";
            this.LabelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelSchoolManager
            // 
            this.LabelSchoolManager.AutoSize = true;
            this.LabelSchoolManager.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSchoolManager.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LabelSchoolManager.Location = new System.Drawing.Point(529, 306);
            this.LabelSchoolManager.Name = "LabelSchoolManager";
            this.LabelSchoolManager.Size = new System.Drawing.Size(0, 21);
            this.LabelSchoolManager.TabIndex = 10;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LabelDate.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelDate.Location = new System.Drawing.Point(177, 16);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(78, 21);
            this.LabelDate.TabIndex = 17;
            this.LabelDate.Text = "00/00/00";
            // 
            // LabelTextDate
            // 
            this.LabelTextDate.AutoSize = true;
            this.LabelTextDate.BackColor = System.Drawing.Color.Transparent;
            this.LabelTextDate.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTextDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelTextDate.Location = new System.Drawing.Point(130, 16);
            this.LabelTextDate.Name = "LabelTextDate";
            this.LabelTextDate.Size = new System.Drawing.Size(50, 21);
            this.LabelTextDate.TabIndex = 15;
            this.LabelTextDate.Text = "Date:";
            // 
            // LabelTextHour
            // 
            this.LabelTextHour.AutoSize = true;
            this.LabelTextHour.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LabelTextHour.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTextHour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelTextHour.Location = new System.Drawing.Point(127, 658);
            this.LabelTextHour.Name = "LabelTextHour";
            this.LabelTextHour.Size = new System.Drawing.Size(52, 21);
            this.LabelTextHour.TabIndex = 11;
            this.LabelTextHour.Text = "Hour:";
            // 
            // LabelHour
            // 
            this.LabelHour.AutoSize = true;
            this.LabelHour.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LabelHour.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelHour.Location = new System.Drawing.Point(181, 658);
            this.LabelHour.Name = "LabelHour";
            this.LabelHour.Size = new System.Drawing.Size(72, 21);
            this.LabelHour.TabIndex = 13;
            this.LabelHour.Text = "00:00:00";
            // 
            // LabelStatistics
            // 
            this.LabelStatistics.AutoSize = true;
            this.LabelStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelStatistics.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatistics.ForeColor = System.Drawing.Color.Blue;
            this.LabelStatistics.Location = new System.Drawing.Point(50, 234);
            this.LabelStatistics.Name = "LabelStatistics";
            this.LabelStatistics.Size = new System.Drawing.Size(75, 21);
            this.LabelStatistics.TabIndex = 12;
            this.LabelStatistics.Text = "Statistics";
            // 
            // LabelClassroom
            // 
            this.LabelClassroom.AutoSize = true;
            this.LabelClassroom.BackColor = System.Drawing.Color.Transparent;
            this.LabelClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelClassroom.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClassroom.ForeColor = System.Drawing.Color.Blue;
            this.LabelClassroom.Location = new System.Drawing.Point(268, 231);
            this.LabelClassroom.Name = "LabelClassroom";
            this.LabelClassroom.Size = new System.Drawing.Size(86, 21);
            this.LabelClassroom.TabIndex = 14;
            this.LabelClassroom.Text = "Classroom";
            this.LabelClassroom.Click += new System.EventHandler(this.LabelClassroom_Click);
            // 
            // LabelReports
            // 
            this.LabelReports.AutoSize = true;
            this.LabelReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelReports.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReports.ForeColor = System.Drawing.Color.Blue;
            this.LabelReports.Location = new System.Drawing.Point(268, 234);
            this.LabelReports.Name = "LabelReports";
            this.LabelReports.Size = new System.Drawing.Size(68, 21);
            this.LabelReports.TabIndex = 16;
            this.LabelReports.Text = "Reports";
            // 
            // LabelLogout
            // 
            this.LabelLogout.AutoSize = true;
            this.LabelLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelLogout.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogout.ForeColor = System.Drawing.Color.Blue;
            this.LabelLogout.Location = new System.Drawing.Point(273, 523);
            this.LabelLogout.Name = "LabelLogout";
            this.LabelLogout.Size = new System.Drawing.Size(63, 21);
            this.LabelLogout.TabIndex = 17;
            this.LabelLogout.Text = "Logout";
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelUser.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUser.ForeColor = System.Drawing.Color.Blue;
            this.LabelUser.Location = new System.Drawing.Point(289, 523);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(43, 21);
            this.LabelUser.TabIndex = 18;
            this.LabelUser.Text = "User";
            // 
            // LabelCourse
            // 
            this.LabelCourse.AutoSize = true;
            this.LabelCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelCourse.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCourse.ForeColor = System.Drawing.Color.Blue;
            this.LabelCourse.Location = new System.Drawing.Point(52, 523);
            this.LabelCourse.Name = "LabelCourse";
            this.LabelCourse.Size = new System.Drawing.Size(61, 21);
            this.LabelCourse.TabIndex = 19;
            this.LabelCourse.Text = "Course";
            this.LabelCourse.Click += new System.EventHandler(this.LabelCourse_Click);
            // 
            // LabelChangePassword
            // 
            this.LabelChangePassword.AutoSize = true;
            this.LabelChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelChangePassword.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChangePassword.ForeColor = System.Drawing.Color.Blue;
            this.LabelChangePassword.Location = new System.Drawing.Point(19, 523);
            this.LabelChangePassword.Name = "LabelChangePassword";
            this.LabelChangePassword.Size = new System.Drawing.Size(140, 21);
            this.LabelChangePassword.TabIndex = 21;
            this.LabelChangePassword.Text = "Change Password";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.LabelDate);
            this.panel4.Controls.Add(this.LabelStudent);
            this.panel4.Controls.Add(this.LabelTextDate);
            this.panel4.Controls.Add(this.pictureStudent);
            this.panel4.Controls.Add(this.LabelTextHour);
            this.panel4.Controls.Add(this.pictureClassroom);
            this.panel4.Controls.Add(this.LabelHour);
            this.panel4.Controls.Add(this.LabelClassroom);
            this.panel4.Controls.Add(this.pictureCourse);
            this.panel4.Controls.Add(this.LabelUser);
            this.panel4.Controls.Add(this.LabelCourse);
            this.panel4.Controls.Add(this.pictureUser);
            this.panel4.Location = new System.Drawing.Point(0, -7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 697);
            this.panel4.TabIndex = 22;
            // 
            // LabelStudent
            // 
            this.LabelStudent.AutoSize = true;
            this.LabelStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelStudent.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudent.ForeColor = System.Drawing.Color.Blue;
            this.LabelStudent.Location = new System.Drawing.Point(52, 231);
            this.LabelStudent.Name = "LabelStudent";
            this.LabelStudent.Size = new System.Drawing.Size(68, 21);
            this.LabelStudent.TabIndex = 24;
            this.LabelStudent.Text = "Student";
            this.LabelStudent.Click += new System.EventHandler(this.LabelClassroom_Click);
            // 
            // TimerDate
            // 
            this.TimerDate.Tick += new System.EventHandler(this.TimerDate_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.pictureBoxClose);
            this.panel2.Controls.Add(this.labelSchooolManager);
            this.panel2.Controls.Add(this.pictureChangePassword);
            this.panel2.Controls.Add(this.LabelUsername);
            this.panel2.Controls.Add(this.LabelChangePassword);
            this.panel2.Controls.Add(this.pictureStatistics);
            this.panel2.Controls.Add(this.pictureReports);
            this.panel2.Controls.Add(this.LabelReports);
            this.panel2.Controls.Add(this.pictureLogout);
            this.panel2.Controls.Add(this.LabelLogout);
            this.panel2.Controls.Add(this.LabelStatistics);
            this.panel2.Location = new System.Drawing.Point(634, -7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 697);
            this.panel2.TabIndex = 23;
            // 
            // labelSchooolManager
            // 
            this.labelSchooolManager.AutoSize = true;
            this.labelSchooolManager.BackColor = System.Drawing.Color.Transparent;
            this.labelSchooolManager.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchooolManager.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSchooolManager.Location = new System.Drawing.Point(141, 16);
            this.labelSchooolManager.Name = "labelSchooolManager";
            this.labelSchooolManager.Size = new System.Drawing.Size(135, 21);
            this.labelSchooolManager.TabIndex = 27;
            this.labelSchooolManager.Text = "Manager School";
            // 
            // pictureBoxSchool
            // 
            this.pictureBoxSchool.Image = global::SystemSchool.Properties.Resources.icons8_school_80;
            this.pictureBoxSchool.Location = new System.Drawing.Point(440, 264);
            this.pictureBoxSchool.Name = "pictureBoxSchool";
            this.pictureBoxSchool.Size = new System.Drawing.Size(170, 153);
            this.pictureBoxSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSchool.TabIndex = 24;
            this.pictureBoxSchool.TabStop = false;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::SystemSchool.Properties.Resources.icons8_close_48__2_;
            this.pictureBoxClose.Location = new System.Drawing.Point(370, 11);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 28;
            this.pictureBoxClose.TabStop = false;
            // 
            // pictureChangePassword
            // 
            this.pictureChangePassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureChangePassword.Image = global::SystemSchool.Properties.Resources.icons8_password_key_100;
            this.pictureChangePassword.Location = new System.Drawing.Point(23, 443);
            this.pictureChangePassword.Name = "pictureChangePassword";
            this.pictureChangePassword.Size = new System.Drawing.Size(136, 77);
            this.pictureChangePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureChangePassword.TabIndex = 7;
            this.pictureChangePassword.TabStop = false;
            // 
            // pictureStatistics
            // 
            this.pictureStatistics.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureStatistics.Image = global::SystemSchool.Properties.Resources.icons8_graph_report_64;
            this.pictureStatistics.Location = new System.Drawing.Point(241, 151);
            this.pictureStatistics.Name = "pictureStatistics";
            this.pictureStatistics.Size = new System.Drawing.Size(136, 80);
            this.pictureStatistics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureStatistics.TabIndex = 5;
            this.pictureStatistics.TabStop = false;
            // 
            // pictureReports
            // 
            this.pictureReports.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureReports.Image = global::SystemSchool.Properties.Resources.icons8_reports_58;
            this.pictureReports.Location = new System.Drawing.Point(23, 151);
            this.pictureReports.Name = "pictureReports";
            this.pictureReports.Size = new System.Drawing.Size(136, 80);
            this.pictureReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureReports.TabIndex = 6;
            this.pictureReports.TabStop = false;
            // 
            // pictureLogout
            // 
            this.pictureLogout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLogout.Image = global::SystemSchool.Properties.Resources.icons8_logout_100;
            this.pictureLogout.Location = new System.Drawing.Point(241, 443);
            this.pictureLogout.Name = "pictureLogout";
            this.pictureLogout.Size = new System.Drawing.Size(136, 77);
            this.pictureLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureLogout.TabIndex = 4;
            this.pictureLogout.TabStop = false;
            // 
            // pictureStudent
            // 
            this.pictureStudent.BackColor = System.Drawing.Color.Transparent;
            this.pictureStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureStudent.Image = global::SystemSchool.Properties.Resources.icons8_student_48;
            this.pictureStudent.Location = new System.Drawing.Point(21, 151);
            this.pictureStudent.Name = "pictureStudent";
            this.pictureStudent.Size = new System.Drawing.Size(136, 77);
            this.pictureStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureStudent.TabIndex = 23;
            this.pictureStudent.TabStop = false;
            this.pictureStudent.Click += new System.EventHandler(this.pictureStudent_Click);
            // 
            // pictureClassroom
            // 
            this.pictureClassroom.BackColor = System.Drawing.Color.Transparent;
            this.pictureClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClassroom.Image = global::SystemSchool.Properties.Resources.icons8_classroom_48;
            this.pictureClassroom.Location = new System.Drawing.Point(246, 151);
            this.pictureClassroom.Name = "pictureClassroom";
            this.pictureClassroom.Size = new System.Drawing.Size(131, 77);
            this.pictureClassroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureClassroom.TabIndex = 1;
            this.pictureClassroom.TabStop = false;
            this.pictureClassroom.Click += new System.EventHandler(this.pictureClassroom_Click);
            // 
            // pictureCourse
            // 
            this.pictureCourse.BackColor = System.Drawing.Color.Transparent;
            this.pictureCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureCourse.Image = global::SystemSchool.Properties.Resources.icons8_course_64;
            this.pictureCourse.Location = new System.Drawing.Point(21, 443);
            this.pictureCourse.Name = "pictureCourse";
            this.pictureCourse.Size = new System.Drawing.Size(136, 77);
            this.pictureCourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureCourse.TabIndex = 2;
            this.pictureCourse.TabStop = false;
            this.pictureCourse.Click += new System.EventHandler(this.pictureCourse_Click);
            // 
            // pictureUser
            // 
            this.pictureUser.BackColor = System.Drawing.Color.Transparent;
            this.pictureUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureUser.Image = global::SystemSchool.Properties.Resources.icons8_user_40;
            this.pictureUser.Location = new System.Drawing.Point(241, 443);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(136, 77);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureUser.TabIndex = 3;
            this.pictureUser.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1042, 681);
            this.Controls.Add(this.pictureBoxSchool);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.LabelSchoolManager);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChangePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClassroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureClassroom;
        public System.Windows.Forms.PictureBox pictureCourse;
        public System.Windows.Forms.PictureBox pictureUser;
        public System.Windows.Forms.PictureBox pictureLogout;
        public System.Windows.Forms.PictureBox pictureStatistics;
        public System.Windows.Forms.PictureBox pictureReports;
        public System.Windows.Forms.PictureBox pictureChangePassword;
        public System.Windows.Forms.Label LabelSchoolManager;
        private System.Windows.Forms.Label LabelDate;
        public System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelTextDate;
        private System.Windows.Forms.Label LabelTextHour;
        private System.Windows.Forms.Label LabelHour;
        public System.Windows.Forms.Label LabelStatistics;
        public System.Windows.Forms.Label LabelClassroom;
        public System.Windows.Forms.Label LabelReports;
        private System.Windows.Forms.Label LabelLogout;
        public System.Windows.Forms.Label LabelUser;
        public System.Windows.Forms.Label LabelCourse;
        private System.Windows.Forms.Label LabelChangePassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer TimerDate;
        public System.Windows.Forms.PictureBox pictureStudent;
        public System.Windows.Forms.Label LabelStudent;
        private Panel panel2;
        private Label labelSchooolManager;
        private PictureBox pictureBoxSchool;
        private PictureBox pictureBoxClose;
    }
}