namespace SystemSchool.Forms.ClassroomForms
{
    partial class EditClassroomForm
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.listBoxSearch = new System.Windows.Forms.ListBox();
            this.LabelSearchResult = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelRegisterClassroom = new System.Windows.Forms.Label();
            this.LabelDeleteClassroom = new System.Windows.Forms.Label();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.pictureBoxSchool = new System.Windows.Forms.PictureBox();
            this.LabelClassroomAndCourse = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.LabelCourse = new System.Windows.Forms.Label();
            this.ComboBoxCourse = new System.Windows.Forms.ComboBox();
            this.LabelEditClassroom = new System.Windows.Forms.Label();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SystemSchool.Properties.Resources.icons8_search_64;
            this.pictureBox4.Location = new System.Drawing.Point(97, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 67);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // LabelSearch
            // 
            this.LabelSearch.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelSearch.Location = new System.Drawing.Point(22, 149);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(214, 45);
            this.LabelSearch.TabIndex = 31;
            this.LabelSearch.Text = "Search by Course or Classroom:";
            this.LabelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxSearch
            // 
            this.listBoxSearch.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBoxSearch.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxSearch.FormattingEnabled = true;
            this.listBoxSearch.ItemHeight = 17;
            this.listBoxSearch.Location = new System.Drawing.Point(36, 354);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.Size = new System.Drawing.Size(187, 225);
            this.listBoxSearch.TabIndex = 33;
            // 
            // LabelSearchResult
            // 
            this.LabelSearchResult.AutoSize = true;
            this.LabelSearchResult.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearchResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelSearchResult.Location = new System.Drawing.Point(62, 310);
            this.LabelSearchResult.Name = "LabelSearchResult";
            this.LabelSearchResult.Size = new System.Drawing.Size(113, 21);
            this.LabelSearchResult.TabIndex = 34;
            this.LabelSearchResult.Text = "Result Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxSearch.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxSearch.Location = new System.Drawing.Point(36, 197);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(187, 25);
            this.textBoxSearch.TabIndex = 32;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.listBoxSearch);
            this.panel1.Controls.Add(this.LabelSearch);
            this.panel1.Controls.Add(this.LabelSearchResult);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Location = new System.Drawing.Point(764, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 644);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.LabelRegisterClassroom);
            this.panel2.Controls.Add(this.LabelDeleteClassroom);
            this.panel2.Controls.Add(this.pictureBoxStudent);
            this.panel2.Controls.Add(this.pictureBoxDelete);
            this.panel2.Controls.Add(this.pictureBoxSchool);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 644);
            this.panel2.TabIndex = 35;
            // 
            // LabelRegisterClassroom
            // 
            this.LabelRegisterClassroom.AutoSize = true;
            this.LabelRegisterClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelRegisterClassroom.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegisterClassroom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelRegisterClassroom.Location = new System.Drawing.Point(71, 467);
            this.LabelRegisterClassroom.Name = "LabelRegisterClassroom";
            this.LabelRegisterClassroom.Size = new System.Drawing.Size(138, 20);
            this.LabelRegisterClassroom.TabIndex = 24;
            this.LabelRegisterClassroom.Text = "Register Classroom";
            this.LabelRegisterClassroom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDeleteClassroom
            // 
            this.LabelDeleteClassroom.AutoSize = true;
            this.LabelDeleteClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelDeleteClassroom.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeleteClassroom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelDeleteClassroom.Location = new System.Drawing.Point(71, 245);
            this.LabelDeleteClassroom.Name = "LabelDeleteClassroom";
            this.LabelDeleteClassroom.Size = new System.Drawing.Size(128, 20);
            this.LabelDeleteClassroom.TabIndex = 23;
            this.LabelDeleteClassroom.Text = "Delete Classroom";
            this.LabelDeleteClassroom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxStudent.Image = global::SystemSchool.Properties.Resources.icons8_student_48;
            this.pictureBoxStudent.Location = new System.Drawing.Point(85, 413);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(100, 51);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxStudent.TabIndex = 2;
            this.pictureBoxStudent.TabStop = false;
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDelete.Image = global::SystemSchool.Properties.Resources.icons8_delete_48;
            this.pictureBoxDelete.Location = new System.Drawing.Point(85, 191);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(100, 51);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDelete.TabIndex = 1;
            this.pictureBoxDelete.TabStop = false;
            // 
            // pictureBoxSchool
            // 
            this.pictureBoxSchool.Image = global::SystemSchool.Properties.Resources.icons8_classroom_48;
            this.pictureBoxSchool.Location = new System.Drawing.Point(85, 19);
            this.pictureBoxSchool.Name = "pictureBoxSchool";
            this.pictureBoxSchool.Size = new System.Drawing.Size(100, 97);
            this.pictureBoxSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSchool.TabIndex = 0;
            this.pictureBoxSchool.TabStop = false;
            // 
            // LabelClassroomAndCourse
            // 
            this.LabelClassroomAndCourse.BackColor = System.Drawing.Color.Transparent;
            this.LabelClassroomAndCourse.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClassroomAndCourse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LabelClassroomAndCourse.Location = new System.Drawing.Point(405, 182);
            this.LabelClassroomAndCourse.Name = "LabelClassroomAndCourse";
            this.LabelClassroomAndCourse.Size = new System.Drawing.Size(216, 65);
            this.LabelClassroomAndCourse.TabIndex = 42;
            this.LabelClassroomAndCourse.Text = "Student";
            this.LabelClassroomAndCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Black;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEdit.Location = new System.Drawing.Point(424, 545);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(181, 34);
            this.buttonEdit.TabIndex = 41;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // LabelCourse
            // 
            this.LabelCourse.AutoSize = true;
            this.LabelCourse.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCourse.Location = new System.Drawing.Point(472, 354);
            this.LabelCourse.Name = "LabelCourse";
            this.LabelCourse.Size = new System.Drawing.Size(62, 21);
            this.LabelCourse.TabIndex = 40;
            this.LabelCourse.Text = "Course";
            // 
            // ComboBoxCourse
            // 
            this.ComboBoxCourse.BackColor = System.Drawing.Color.White;
            this.ComboBoxCourse.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCourse.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ComboBoxCourse.FormattingEnabled = true;
            this.ComboBoxCourse.Location = new System.Drawing.Point(405, 413);
            this.ComboBoxCourse.Name = "ComboBoxCourse";
            this.ComboBoxCourse.Size = new System.Drawing.Size(216, 29);
            this.ComboBoxCourse.TabIndex = 38;
            // 
            // LabelEditClassroom
            // 
            this.LabelEditClassroom.AutoSize = true;
            this.LabelEditClassroom.BackColor = System.Drawing.Color.Transparent;
            this.LabelEditClassroom.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEditClassroom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelEditClassroom.Location = new System.Drawing.Point(433, 126);
            this.LabelEditClassroom.Name = "LabelEditClassroom";
            this.LabelEditClassroom.Size = new System.Drawing.Size(161, 30);
            this.LabelEditClassroom.TabIndex = 36;
            this.LabelEditClassroom.Text = "Edit Classroom";
            this.LabelEditClassroom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.Image = global::SystemSchool.Properties.Resources.icons8_edit_40;
            this.pictureBoxEdit.Location = new System.Drawing.Point(463, 26);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(100, 97);
            this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEdit.TabIndex = 35;
            this.pictureBoxEdit.TabStop = false;
            // 
            // EditClassroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1026, 642);
            this.Controls.Add(this.LabelClassroomAndCourse);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelCourse);
            this.Controls.Add(this.pictureBoxEdit);
            this.Controls.Add(this.LabelEditClassroom);
            this.Controls.Add(this.ComboBoxCourse);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditClassroomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditClassroomForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.ListBox listBoxSearch;
        private System.Windows.Forms.Label LabelSearchResult;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelRegisterClassroom;
        private System.Windows.Forms.Label LabelDeleteClassroom;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.PictureBox pictureBoxSchool;
        private System.Windows.Forms.Label LabelClassroomAndCourse;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label LabelCourse;
        private System.Windows.Forms.ComboBox ComboBoxCourse;
        private System.Windows.Forms.Label LabelEditClassroom;
        private System.Windows.Forms.PictureBox pictureBoxEdit;
    }
}