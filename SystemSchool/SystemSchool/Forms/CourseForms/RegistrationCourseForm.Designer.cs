namespace SystemSchool.Forms.CourseForms
{
    partial class RegistrationCourseForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationCourseForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxSchool = new System.Windows.Forms.PictureBox();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.LabelDeleteCourse = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.LabelCouseName = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.LabelRegistrationCourse = new System.Windows.Forms.Label();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxCourse = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBoxSchool);
            this.panel1.Controls.Add(this.pictureBoxDelete);
            this.panel1.Controls.Add(this.LabelDeleteCourse);
            this.panel1.Location = new System.Drawing.Point(-11, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 692);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxSchool
            // 
            this.pictureBoxSchool.Image = global::SystemSchool.Properties.Resources.icons8_school_80;
            this.pictureBoxSchool.Location = new System.Drawing.Point(89, 9);
            this.pictureBoxSchool.Name = "pictureBoxSchool";
            this.pictureBoxSchool.Size = new System.Drawing.Size(88, 81);
            this.pictureBoxSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSchool.TabIndex = 19;
            this.pictureBoxSchool.TabStop = false;
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDelete.Image = global::SystemSchool.Properties.Resources.icons8_delete_48;
            this.pictureBoxDelete.Location = new System.Drawing.Point(89, 347);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(88, 57);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDelete.TabIndex = 18;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // LabelDeleteCourse
            // 
            this.LabelDeleteCourse.AutoSize = true;
            this.LabelDeleteCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelDeleteCourse.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeleteCourse.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabelDeleteCourse.Location = new System.Drawing.Point(74, 407);
            this.LabelDeleteCourse.Name = "LabelDeleteCourse";
            this.LabelDeleteCourse.Size = new System.Drawing.Size(115, 21);
            this.LabelDeleteCourse.TabIndex = 17;
            this.LabelDeleteCourse.Text = "Delete Course";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.BackColor = System.Drawing.Color.White;
            this.textBoxCourseName.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxCourseName.Location = new System.Drawing.Point(463, 372);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(346, 27);
            this.textBoxCourseName.TabIndex = 15;
            // 
            // LabelCouseName
            // 
            this.LabelCouseName.BackColor = System.Drawing.Color.Transparent;
            this.LabelCouseName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCouseName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelCouseName.Location = new System.Drawing.Point(556, 318);
            this.LabelCouseName.Name = "LabelCouseName";
            this.LabelCouseName.Size = new System.Drawing.Size(156, 44);
            this.LabelCouseName.TabIndex = 16;
            this.LabelCouseName.Text = "Course Name:";
            this.LabelCouseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.ForeColor = System.Drawing.Color.Green;
            this.buttonCreate.Location = new System.Drawing.Point(560, 580);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(139, 33);
            this.buttonCreate.TabIndex = 17;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // LabelRegistrationCourse
            // 
            this.LabelRegistrationCourse.AutoSize = true;
            this.LabelRegistrationCourse.BackColor = System.Drawing.Color.Transparent;
            this.LabelRegistrationCourse.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegistrationCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelRegistrationCourse.Location = new System.Drawing.Point(536, 88);
            this.LabelRegistrationCourse.Name = "LabelRegistrationCourse";
            this.LabelRegistrationCourse.Size = new System.Drawing.Size(211, 30);
            this.LabelRegistrationCourse.TabIndex = 17;
            this.LabelRegistrationCourse.Text = "Registration Course";
            this.LabelRegistrationCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::SystemSchool.Properties.Resources.icons8_back_48;
            this.pictureBoxBack.Location = new System.Drawing.Point(1006, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 18;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // pictureBoxCourse
            // 
            this.pictureBoxCourse.Image = global::SystemSchool.Properties.Resources.icons8_course_64;
            this.pictureBoxCourse.Location = new System.Drawing.Point(600, 4);
            this.pictureBoxCourse.Name = "pictureBoxCourse";
            this.pictureBoxCourse.Size = new System.Drawing.Size(88, 81);
            this.pictureBoxCourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCourse.TabIndex = 16;
            this.pictureBoxCourse.TabStop = false;
            // 
            // RegistrationCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1042, 681);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxCourse);
            this.Controls.Add(this.LabelRegistrationCourse);
            this.Controls.Add(this.LabelCouseName);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationCourseForm";
            this.Load += new System.EventHandler(this.RegistrationCourseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.PictureBox pictureBoxCourse;
        private System.Windows.Forms.Label LabelCouseName;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Label LabelDeleteCourse;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.PictureBox pictureBoxSchool;
        private System.Windows.Forms.Label LabelRegistrationCourse;
    }
}