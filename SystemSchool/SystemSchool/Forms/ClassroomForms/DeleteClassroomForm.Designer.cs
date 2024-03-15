namespace SystemSchool.Forms.ClassroomForms
{
    partial class DeleteClassroomForm
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxClassrooms = new System.Windows.Forms.ListBox();
            this.LabelClassroom = new System.Windows.Forms.Label();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelEditClassroom = new System.Windows.Forms.Label();
            this.pictureBoxEditClassroom = new System.Windows.Forms.PictureBox();
            this.LabelRegisterClassroom = new System.Windows.Forms.Label();
            this.pictureBoxRegisterClassroom = new System.Windows.Forms.PictureBox();
            this.pictureBoxSchool = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxCourse = new System.Windows.Forms.ComboBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditClassroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegisterClassroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.Location = new System.Drawing.Point(602, 593);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(115, 37);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listBoxClassrooms
            // 
            this.listBoxClassrooms.BackColor = System.Drawing.Color.White;
            this.listBoxClassrooms.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxClassrooms.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listBoxClassrooms.FormattingEnabled = true;
            this.listBoxClassrooms.ItemHeight = 21;
            this.listBoxClassrooms.Location = new System.Drawing.Point(491, 226);
            this.listBoxClassrooms.Name = "listBoxClassrooms";
            this.listBoxClassrooms.Size = new System.Drawing.Size(333, 340);
            this.listBoxClassrooms.TabIndex = 20;
            // 
            // LabelClassroom
            // 
            this.LabelClassroom.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClassroom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelClassroom.Location = new System.Drawing.Point(582, 186);
            this.LabelClassroom.Name = "LabelClassroom";
            this.LabelClassroom.Size = new System.Drawing.Size(156, 51);
            this.LabelClassroom.TabIndex = 19;
            this.LabelClassroom.Text = "Classrooms:";
            this.LabelClassroom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDelete.Image = global::SystemSchool.Properties.Resources.icons8_delete_48;
            this.pictureBoxDelete.Location = new System.Drawing.Point(610, 21);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(107, 72);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDelete.TabIndex = 17;
            this.pictureBoxDelete.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.LabelEditClassroom);
            this.panel1.Controls.Add(this.pictureBoxEditClassroom);
            this.panel1.Controls.Add(this.LabelRegisterClassroom);
            this.panel1.Controls.Add(this.pictureBoxRegisterClassroom);
            this.panel1.Controls.Add(this.pictureBoxSchool);
            this.panel1.Location = new System.Drawing.Point(-10, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 652);
            this.panel1.TabIndex = 21;
            // 
            // LabelEditClassroom
            // 
            this.LabelEditClassroom.AutoSize = true;
            this.LabelEditClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelEditClassroom.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEditClassroom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelEditClassroom.Location = new System.Drawing.Point(65, 316);
            this.LabelEditClassroom.Name = "LabelEditClassroom";
            this.LabelEditClassroom.Size = new System.Drawing.Size(110, 20);
            this.LabelEditClassroom.TabIndex = 26;
            this.LabelEditClassroom.Text = "Edit Classroom";
            this.LabelEditClassroom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelEditClassroom.Click += new System.EventHandler(this.LabelEditClassroom_Click);
            // 
            // pictureBoxEditClassroom
            // 
            this.pictureBoxEditClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEditClassroom.Image = global::SystemSchool.Properties.Resources.icons8_edit_40;
            this.pictureBoxEditClassroom.Location = new System.Drawing.Point(69, 236);
            this.pictureBoxEditClassroom.Name = "pictureBoxEditClassroom";
            this.pictureBoxEditClassroom.Size = new System.Drawing.Size(88, 77);
            this.pictureBoxEditClassroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEditClassroom.TabIndex = 25;
            this.pictureBoxEditClassroom.TabStop = false;
            this.pictureBoxEditClassroom.Click += new System.EventHandler(this.pictureBoxEditClassroom_Click);
            // 
            // LabelRegisterClassroom
            // 
            this.LabelRegisterClassroom.AutoSize = true;
            this.LabelRegisterClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelRegisterClassroom.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegisterClassroom.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabelRegisterClassroom.Location = new System.Drawing.Point(48, 527);
            this.LabelRegisterClassroom.Name = "LabelRegisterClassroom";
            this.LabelRegisterClassroom.Size = new System.Drawing.Size(153, 21);
            this.LabelRegisterClassroom.TabIndex = 24;
            this.LabelRegisterClassroom.Text = "Register Classroom";
            this.LabelRegisterClassroom.Click += new System.EventHandler(this.LabelRegisterClassroom_Click);
            // 
            // pictureBoxRegisterClassroom
            // 
            this.pictureBoxRegisterClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRegisterClassroom.Image = global::SystemSchool.Properties.Resources.icons8_classroom_48;
            this.pictureBoxRegisterClassroom.Location = new System.Drawing.Point(69, 449);
            this.pictureBoxRegisterClassroom.Name = "pictureBoxRegisterClassroom";
            this.pictureBoxRegisterClassroom.Size = new System.Drawing.Size(107, 75);
            this.pictureBoxRegisterClassroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxRegisterClassroom.TabIndex = 22;
            this.pictureBoxRegisterClassroom.TabStop = false;
            this.pictureBoxRegisterClassroom.Click += new System.EventHandler(this.pictureBoxRegisterClassroom_Click);
            // 
            // pictureBoxSchool
            // 
            this.pictureBoxSchool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSchool.Image = global::SystemSchool.Properties.Resources.icons8_school_80;
            this.pictureBoxSchool.Location = new System.Drawing.Point(69, 30);
            this.pictureBoxSchool.Name = "pictureBoxSchool";
            this.pictureBoxSchool.Size = new System.Drawing.Size(107, 91);
            this.pictureBoxSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSchool.TabIndex = 23;
            this.pictureBoxSchool.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(582, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 51);
            this.label1.TabIndex = 22;
            this.label1.Text = "Courses";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxCourse
            // 
            this.ComboBoxCourse.BackColor = System.Drawing.Color.White;
            this.ComboBoxCourse.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCourse.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ComboBoxCourse.FormattingEnabled = true;
            this.ComboBoxCourse.Location = new System.Drawing.Point(546, 140);
            this.ComboBoxCourse.Name = "ComboBoxCourse";
            this.ComboBoxCourse.Size = new System.Drawing.Size(222, 29);
            this.ComboBoxCourse.TabIndex = 23;
            this.ComboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCourse_SelectedIndexChanged);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::SystemSchool.Properties.Resources.icons8_back_48;
            this.pictureBoxBack.Location = new System.Drawing.Point(991, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 24;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // DeleteClassroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 642);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.ComboBoxCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxClassrooms);
            this.Controls.Add(this.LabelClassroom);
            this.Controls.Add(this.pictureBoxDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteClassroomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteClassroomForm";
            this.Load += new System.EventHandler(this.DeleteClassroomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditClassroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegisterClassroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.ListBox listBoxClassrooms;
        private System.Windows.Forms.Label LabelClassroom;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelRegisterClassroom;
        private System.Windows.Forms.PictureBox pictureBoxRegisterClassroom;
        private System.Windows.Forms.PictureBox pictureBoxSchool;
        private System.Windows.Forms.Label LabelEditClassroom;
        private System.Windows.Forms.PictureBox pictureBoxEditClassroom;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox ComboBoxCourse;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}