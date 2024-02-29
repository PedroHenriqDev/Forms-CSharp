using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Business;

namespace SystemSchool
{
    public partial class MainForm : Form
    {

        EntityClass EntityObj = new EntityClass();
        BusinessClass BusinessObj = new BusinessClass();

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
            LabelUsername.Text = Login.Username;
            if (Login.UserId == "T0002") // Secretary
            {
                pictureUser.Enabled = false;
                LabelUserRegistration.ForeColor = Color.Gray;
            }
            else if (Login.UserId == "T0003") // Teachers
            {
                pictureClassroom.Enabled = false;
                LabelClassroomRegistration.ForeColor = Color.Gray;
                pictureUser.Enabled = false;
                LabelUserRegistration.ForeColor = Color.Gray;
                pictureStudent.Enabled = false;
                LabelStudentRegistration.ForeColor = Color.Gray;
                pictureCourse.Enabled = false;
                LabelCourseRegistration.ForeColor = Color.Gray;
            }
            TimerDate.Start();
        }

        private void TimerDate_Tick(object sender, EventArgs e)
        {
            LabelHour.Text = DateTime.Now.ToString("HH:mm:ss");
            LabelDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }
    }
}
