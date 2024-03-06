using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemSchool.Forms.StudentForms;
using Entities;
using SystemSchool.Forms.ClassroomForms;
using SystemSchool.Forms.CourseForms;

namespace SystemSchool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LabelUsername.Text = Login.UserCls.Username;
            TimerDate.Start();
        }
        
        private void TimerDate_Tick(object sender, EventArgs e)
        {
            LabelHour.Text = DateTime.Now.ToString("HH:mm:ss");
            LabelDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void pictureStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationStudentForm formStudent = new RegistrationStudentForm();
            formStudent.ShowDialog();
        }

        private void pictureClassroom_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationClassroomForm formClassroom = new RegistrationClassroomForm();
            formClassroom.ShowDialog();
        }

        private void pictureCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationCourseForm formCourse = new RegistrationCourseForm();
            formCourse.ShowDialog();
        }

        private void LabelStudentRegistration_Click(object sender, EventArgs e)
        {
            pictureStudent_Click(sender, e);
        }

        private void LabelClassroomRegistration_Click(object sender, EventArgs e)
        {
            pictureClassroom_Click(sender, e);
        }

        private void LabelCourseRegistration_Click(object sender, EventArgs e)
        {
            pictureClassroom_Click(sender, e);
        }

        private void LabelClassroom_Click(object sender, EventArgs e)
        {

        }

        private void LabelCourse_Click(object sender, EventArgs e)
        {

        }
    } 
}
