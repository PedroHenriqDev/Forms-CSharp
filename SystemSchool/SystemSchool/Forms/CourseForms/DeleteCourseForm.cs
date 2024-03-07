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
using System.Linq;

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
                DisplayItem<Course> course = listBoxCourses.SelectedItem as DisplayItem<Course>;
                course.Value.Classrooms = (await SearchEntities.FindClassroomsByCourseNameAsync(course.Value.CourseName)).ToList(); 
                foreach (var classroom in course.Value.Classrooms) 
                {
                    IEnumerable<Student> students = await SearchEntities.FindStudentsByClassroomNameAsync(classroom.ClassroomName);
                    await DeleteEntities.DeleteStudentsAsync(students);
                }

                await DeleteEntities.DeleteClassromsByCourseIdAsync(course.Value.Classrooms, course.Value.Id);

                CourseQuery courseQuery = await DeleteEntities.DeleteCourseAsync(course.Value);
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
