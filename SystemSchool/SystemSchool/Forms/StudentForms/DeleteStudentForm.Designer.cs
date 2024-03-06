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
            this.LabelDeleteStudent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureDelete = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.LabelClassroom = new System.Windows.Forms.Label();
            this.ComboBoxClassroom = new System.Windows.Forms.ComboBox();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.LabelStudent = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LabelDeleteStudent);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureDelete);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 72);
            this.panel1.TabIndex = 0;
            // 
            // LabelDeleteStudent
            // 
            this.LabelDeleteStudent.AutoSize = true;
            this.LabelDeleteStudent.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeleteStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelDeleteStudent.Location = new System.Drawing.Point(417, 26);
            this.LabelDeleteStudent.Name = "LabelDeleteStudent";
            this.LabelDeleteStudent.Size = new System.Drawing.Size(146, 25);
            this.LabelDeleteStudent.TabIndex = 5;
            this.LabelDeleteStudent.Text = "Delete Student";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::SystemSchool.Properties.Resources.icons8_back_48;
            this.pictureBox1.Location = new System.Drawing.Point(989, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // pictureDelete
            // 
            this.pictureDelete.Image = global::SystemSchool.Properties.Resources.icons8_delete_100;
            this.pictureDelete.Location = new System.Drawing.Point(0, 0);
            this.pictureDelete.Name = "pictureDelete";
            this.pictureDelete.Size = new System.Drawing.Size(88, 81);
            this.pictureDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDelete.TabIndex = 7;
            this.pictureDelete.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Black;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.Location = new System.Drawing.Point(461, 513);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(115, 37);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // LabelClassroom
            // 
            this.LabelClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClassroom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelClassroom.Location = new System.Drawing.Point(725, 92);
            this.LabelClassroom.Name = "LabelClassroom";
            this.LabelClassroom.Size = new System.Drawing.Size(156, 51);
            this.LabelClassroom.TabIndex = 11;
            this.LabelClassroom.Text = "Classroom:";
            this.LabelClassroom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxClassroom
            // 
            this.ComboBoxClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBoxClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxClassroom.ForeColor = System.Drawing.Color.White;
            this.ComboBoxClassroom.FormattingEnabled = true;
            this.ComboBoxClassroom.Location = new System.Drawing.Point(683, 146);
            this.ComboBoxClassroom.Name = "ComboBoxClassroom";
            this.ComboBoxClassroom.Size = new System.Drawing.Size(249, 28);
            this.ComboBoxClassroom.TabIndex = 10;
            this.ComboBoxClassroom.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClassroom_SelectedIndexChanged);
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxStudents.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStudents.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 21;
            this.listBoxStudents.Location = new System.Drawing.Point(94, 146);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(333, 361);
            this.listBoxStudents.TabIndex = 9;
            // 
            // LabelStudent
            // 
            this.LabelStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelStudent.Location = new System.Drawing.Point(157, 92);
            this.LabelStudent.Name = "LabelStudent";
            this.LabelStudent.Size = new System.Drawing.Size(156, 51);
            this.LabelStudent.TabIndex = 8;
            this.LabelStudent.Text = "Students:";
            this.LabelStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1026, 642);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelDeleteStudent;
        private System.Windows.Forms.PictureBox pictureDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label LabelClassroom;
        private System.Windows.Forms.ComboBox ComboBoxClassroom;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Label LabelStudent;
    }
}