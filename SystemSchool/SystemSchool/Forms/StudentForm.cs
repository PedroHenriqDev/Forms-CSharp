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

namespace SystemSchool
{
    public partial class StudentForm : Form
    { 
        SearchEntitiesBusiness searchEntitiesBusiness = new SearchEntitiesBusiness();
        MainForm mainForm = new MainForm();

        public StudentForm()
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
            IEnumerable<Classroom> classroms = await searchEntitiesBusiness.FindClassroomByCourseNameAsync(courseName);
            foreach(Classroom classroom in classroms)
            {
                ComboBoxClassroom.Items.Add(classroom);
            }
        }

        private async Task LoadComboBoxCoursesAsync() 
        {
            IEnumerable<Course> courses = await searchEntitiesBusiness.FindAllCoursesAsync();
            foreach(Course course in courses) 
            {
                ComboBoxCourse.Items.Add(course.CourseName);
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.ShowDialog();
        }
    }
}
