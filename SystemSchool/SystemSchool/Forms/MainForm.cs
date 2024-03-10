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
using Autofac;
using Services;
using SystemSchool.Forms.UserForms;

namespace SystemSchool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
            var studentForm = Program.Container.Resolve<RegistrationStudentForm>();
            studentForm.ShowDialog();
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureClassroom_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registrationClassroomForm = Program.Container.Resolve<RegistrationClassroomForm>();
            registrationClassroomForm.ShowDialog();
        }

        private void pictureCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registrationCourseForm = Program.Container.Resolve<RegistrationCourseForm>();
            registrationCourseForm.ShowDialog();
        }

        private void pictureUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registrationUserForm = Program.Container.Resolve<RegistrationUserForm>();
            registrationUserForm.ShowDialog();
        }

        private void LabelStudentRegistration_Click(object sender, EventArgs e)
        {
            pictureStudent_Click(sender, e);
        }

        private void LabelClassroomRegistration_Click(object sender, EventArgs e)
        {
            pictureClassroom_Click(sender, e);
        }

        private void LabelClassroom_Click(object sender, EventArgs e)
        {
            pictureClassroom_Click(sender, e);
        }

        private void LabelCourseRegistration_Click(object sender, EventArgs e)
        {
            pictureCourse_Click(sender, e);
        }

        private void LabelCourse_Click(object sender, EventArgs e)
        {
            pictureCourse_Click(sender, e);
        }

        private void LabelUser_Click(object sender, EventArgs e)
        {
            pictureUser_Click(sender, e);
        }
    } 
}
