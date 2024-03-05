using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.BusinessLogic;
using Entities;
using SystemSchool.Forms.StudentForms;

namespace SystemSchool
{
    public partial class RegistrationStudentForm : Form
    {
        SearchEntitiesBusiness searchEntitiesBusiness = new SearchEntitiesBusiness();

        public RegistrationStudentForm()
        {
            InitializeComponent();
        }

        private async void StudentRegistrationForm_Load(object sender, EventArgs e)
        {
            await LoadComboBoxCoursesAsync();
        }

        private async void ComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadComboBoxClassroomAsync(ComboBoxCourse.SelectedItem.ToString());
        }

        private async Task LoadComboBoxClassroomAsync(string courseName)
        {
            IEnumerable<Classroom> classrooms = await searchEntitiesBusiness.FindClassroomsByCourseNameAsync(courseName);
            foreach (Classroom classroom in classrooms)
            {
                ComboBoxClassroom.Items.Add(classroom.ClassroomName);
            }
        }

        private async Task LoadComboBoxCoursesAsync()
        {
            IEnumerable<Course> courses = await searchEntitiesBusiness.FindAllCoursesAsync();
            foreach (Course course in courses)
            {
                ComboBoxCourse.Items.Add(course.CourseName);
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void LabelDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteStudentForm studentDeleteForm = new DeleteStudentForm();
            studentDeleteForm.ShowDialog();
        }
    }
}
