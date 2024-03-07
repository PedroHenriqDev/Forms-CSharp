namespace SystemSchool.Forms.CourseForms
{
    partial class DeleteCourseForm
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
            this.LabelRegisterCourse = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSchool = new System.Windows.Forms.PictureBox();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.LabelCourses = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.LabelRegisterCourse);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBoxSchool);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 643);
            this.panel1.TabIndex = 0;
            // 
            // LabelRegisterCourse
            // 
            this.LabelRegisterCourse.AutoSize = true;
            this.LabelRegisterCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelRegisterCourse.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegisterCourse.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabelRegisterCourse.Location = new System.Drawing.Point(39, 385);
            this.LabelRegisterCourse.Name = "LabelRegisterCourse";
            this.LabelRegisterCourse.Size = new System.Drawing.Size(128, 21);
            this.LabelRegisterCourse.TabIndex = 12;
            this.LabelRegisterCourse.Text = "Register Course";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::SystemSchool.Properties.Resources.icons8_course_64;
            this.pictureBox1.Location = new System.Drawing.Point(60, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxSchool
            // 
            this.pictureBoxSchool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSchool.Image = global::SystemSchool.Properties.Resources.icons8_school_80;
            this.pictureBoxSchool.Location = new System.Drawing.Point(60, 13);
            this.pictureBoxSchool.Name = "pictureBoxSchool";
            this.pictureBoxSchool.Size = new System.Drawing.Size(107, 91);
            this.pictureBoxSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSchool.TabIndex = 11;
            this.pictureBoxSchool.TabStop = false;
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDelete.Image = global::SystemSchool.Properties.Resources.icons8_delete_48;
            this.pictureBoxDelete.Location = new System.Drawing.Point(599, 12);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(107, 72);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDelete.TabIndex = 4;
            this.pictureBoxDelete.TabStop = false;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::SystemSchool.Properties.Resources.icons8_back_48;
            this.pictureBoxBack.Location = new System.Drawing.Point(991, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 13;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Black;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.Location = new System.Drawing.Point(591, 564);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(115, 37);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.BackColor = System.Drawing.Color.White;
            this.listBoxCourses.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCourses.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.ItemHeight = 21;
            this.listBoxCourses.Location = new System.Drawing.Point(483, 153);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(333, 361);
            this.listBoxCourses.TabIndex = 16;
            // 
            // LabelCourses
            // 
            this.LabelCourses.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCourses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelCourses.Location = new System.Drawing.Point(569, 111);
            this.LabelCourses.Name = "LabelCourses";
            this.LabelCourses.Size = new System.Drawing.Size(156, 51);
            this.LabelCourses.TabIndex = 15;
            this.LabelCourses.Text = "Courses";
            this.LabelCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 642);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.LabelCourses);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteCourseForm";
            this.Text = "DeleteCourseForm";
            this.Load += new System.EventHandler(this.DeleteCourseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxSchool;
        private System.Windows.Forms.Label LabelRegisterCourse;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.Label LabelCourses;
    }
}