using Business.BusinessLogic;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using SystemSchool.Controls;
using System.Windows.Forms;
using Entities.TransientClasses;

namespace SystemSchool.Forms.CourseForms
{
    public partial class DeleteCourseForm : Form
    {

        SearchEntitiesBusiness SearchEntities = new SearchEntitiesBusiness();
        DeleteEntitiesBusiness<Course> DeleteEntities = new DeleteEntitiesBusiness<Course>();

        public DeleteCourseForm()
        {
            InitializeComponent();
        }

        private async void DeleteCourseForm_Load(object sender, EventArgs e)
        {
            await LoadListBoxCoursesAsync();
        }

        private async Task LoadListBoxCoursesAsync()
        {
            IEnumerable<Course> courses = await SearchEntities.FindAllCoursesAsync();
            listBoxCourses.Items.Clear();
            foreach (Course course in courses)
            {
                listBoxCourses.Items.Add(new DisplayItem<Course>(course, course.CourseName));
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayItem<Course> Course = listBoxCourses.SelectedItem as DisplayItem<Course>;
                CourseQuery courseQuery = await DeleteEntities.DeleteCourseAsync(Course.Value);
                MessageBox.Show(courseQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadListBoxCoursesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationCourseForm registrationForm = new RegistrationCourseForm();
            registrationForm.ShowDialog();
        }
    }
}
