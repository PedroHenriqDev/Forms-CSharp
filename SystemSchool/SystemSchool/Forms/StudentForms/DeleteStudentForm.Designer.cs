namespace SystemSchool.Forms.StudentForms
{
    partial class DeleteStudentForm
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
            this.LabelEditStudent = new System.Windows.Forms.Label();
            this.LabelRegisterStudent = new System.Windows.Forms.Label();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.pictureBoxSchool = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.LabelClassroom = new System.Windows.Forms.Label();
            this.ComboBoxClassroom = new System.Windows.Forms.ComboBox();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.LabelStudent = new System.Windows.Forms.Label();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureDelete = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LabelEditStudent);
            this.panel1.Controls.Add(this.LabelRegisterStudent);
            this.panel1.Controls.Add(this.pictureBoxEdit);
            this.panel1.Controls.Add(this.pictureBoxStudent);
            this.panel1.Controls.Add(this.pictureBoxSchool);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 646);
            this.panel1.TabIndex = 0;
            // 
            // LabelEditStudent
            // 
            this.LabelEditStudent.AutoSize = true;
            this.LabelEditStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelEditStudent.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEditStudent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelEditStudent.Location = new System.Drawing.Point(66, 316);
            this.LabelEditStudent.Name = "LabelEditStudent";
            this.LabelEditStudent.Size = new System.Drawing.Size(93, 20);
            this.LabelEditStudent.TabIndex = 22;
            this.LabelEditStudent.Text = "Edit Student";
            this.LabelEditStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelEditStudent.Click += new System.EventHandler(this.LabelEditStudent_Click);
            // 
            // LabelRegisterStudent
            // 
            this.LabelRegisterStudent.AutoSize = true;
            this.LabelRegisterStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelRegisterStudent.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegisterStudent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelRegisterStudent.Location = new System.Drawing.Point(53, 493);
            this.LabelRegisterStudent.Name = "LabelRegisterStudent";
            this.LabelRegisterStudent.Size = new System.Drawing.Size(121, 20);
            this.LabelRegisterStudent.TabIndex = 12;
            this.LabelRegisterStudent.Text = "Register Student";
            this.LabelRegisterStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelRegisterStudent.Click += new System.EventHandler(this.LabelRegisterStudent_Click);
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEdit.Image = global::SystemSchool.Properties.Resources.icons8_edit_40;
            this.pictureBoxEdit.Location = new System.Drawing.Point(70, 236);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(88, 77);
            this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEdit.TabIndex = 21;
            this.pictureBoxEdit.TabStop = false;
            this.pictureBoxEdit.Click += new System.EventHandler(this.pictureBoxEdit_Click);
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxStudent.Image = global::SystemSchool.Properties.Resources.icons8_student_48;
            this.pictureBoxStudent.Location = new System.Drawing.Point(70, 417);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(88, 73);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxStudent.TabIndex = 20;
            this.pictureBoxStudent.TabStop = false;
            this.pictureBoxStudent.Click += new System.EventHandler(this.pictureBoxStudent_Click);
            // 
            // pictureBoxSchool
            // 
            this.pictureBoxSchool.Image = global::SystemSchool.Properties.Resources.icons8_school_80;
            this.pictureBoxSchool.Location = new System.Drawing.Point(70, 16);
            this.pictureBoxSchool.Name = "pictureBoxSchool";
            this.pictureBoxSchool.Size = new System.Drawing.Size(88, 81);
            this.pictureBoxSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSchool.TabIndex = 19;
            this.pictureBoxSchool.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.Location = new System.Drawing.Point(577, 593);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(115, 37);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // LabelClassroom
            // 
            this.LabelClassroom.AutoSize = true;
            this.LabelClassroom.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClassroom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelClassroom.Location = new System.Drawing.Point(582, 96);
            this.LabelClassroom.Name = "LabelClassroom";
            this.LabelClassroom.Size = new System.Drawing.Size(92, 21);
            this.LabelClassroom.TabIndex = 11;
            this.LabelClassroom.Text = "Classroom:";
            this.LabelClassroom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxClassroom
            // 
            this.ComboBoxClassroom.BackColor = System.Drawing.Color.White;
            this.ComboBoxClassroom.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxClassroom.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxClassroom.FormattingEnabled = true;
            this.ComboBoxClassroom.Location = new System.Drawing.Point(501, 129);
            this.ComboBoxClassroom.Name = "ComboBoxClassroom";
            this.ComboBoxClassroom.Size = new System.Drawing.Size(249, 29);
            this.ComboBoxClassroom.TabIndex = 10;
            this.ComboBoxClassroom.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClassroom_SelectedIndexChanged);
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.BackColor = System.Drawing.Color.White;
            this.listBoxStudents.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStudents.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 21;
            this.listBoxStudents.Location = new System.Drawing.Point(464, 214);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(333, 361);
            this.listBoxStudents.TabIndex = 9;
            // 
            // LabelStudent
            // 
            this.LabelStudent.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelStudent.Location = new System.Drawing.Point(550, 160);
            this.LabelStudent.Name = "LabelStudent";
            this.LabelStudent.Size = new System.Drawing.Size(156, 51);
            this.LabelStudent.TabIndex = 8;
            this.LabelStudent.Text = "Students:";
            this.LabelStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::SystemSchool.Properties.Resources.icons8_back_48;
            this.pictureBoxBack.Location = new System.Drawing.Point(984, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 6;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // pictureDelete
            // 
            this.pictureDelete.Image = global::SystemSchool.Properties.Resources.icons8_delete_48;
            this.pictureDelete.Location = new System.Drawing.Point(586, 12);
            this.pictureDelete.Name = "pictureDelete";
            this.pictureDelete.Size = new System.Drawing.Size(88, 72);
            this.pictureDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureDelete.TabIndex = 7;
            this.pictureDelete.TabStop = false;
            // 
            // DeleteStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1026, 642);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.pictureDelete);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.LabelClassroom);
            this.Controls.Add(this.ComboBoxClassroom);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.LabelStudent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteStudentForm";
            this.Load += new System.EventHandler(this.StudentDeleteForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureDelete;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label LabelClassroom;
        private System.Windows.Forms.ComboBox ComboBoxClassroom;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Label LabelStudent;
        private System.Windows.Forms.PictureBox pictureBoxSchool;
        private System.Windows.Forms.PictureBox pictureBoxEdit;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.Label LabelEditStudent;
        private System.Windows.Forms.Label LabelRegisterStudent;
    }
}