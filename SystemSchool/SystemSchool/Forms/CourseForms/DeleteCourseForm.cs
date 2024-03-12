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
using Services;
using Autofac;


namespace SystemSchool.Forms.CourseForms
{
    public partial class DeleteCourseForm : Form
    {

        private readonly SearchEntitiesService _searchEntities;
        private readonly DeleteEntitiesService<Course> _deleteEntities;

        public DeleteCourseForm(SearchEntitiesService searchEntities, DeleteEntitiesService<Course> deleteEntities)
        {
            _searchEntities = searchEntities;
            _deleteEntities = deleteEntities;
            InitializeComponent();
        }

        private async void DeleteCourseForm_Load(object sender, EventArgs e)
        {
            await LoadListBoxCoursesAsync();
        }

        private async Task LoadListBoxCoursesAsync()
        {
            IEnumerable<Course> courses = await _searchEntities.FindAllCoursesAsync();
            listBoxCourses.Items.Clear();
            listBoxCourses.Items.AddRange(courses.Select(c => new DisplayItem<Course>(c, c.CourseName)).ToArray());
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayItem<Course> course = listBoxCourses.SelectedItem as DisplayItem<Course>;
                course.Value.Classrooms = (await _searchEntities.FindClassroomsByCourseNameAsync(course.Value)).ToList(); 
                foreach (var classroom in course.Value.Classrooms) 
                {
                    IEnumerable<Student> students = await _searchEntities.FindStudentsByClassroomNameAsync(classroom);
                    await _deleteEntities.DeleteStudentsAsync(students);
                }

                await _deleteEntities.DeleteClassromsByCourseIdAsync(course.Value.Classrooms, course.Value.Id);

                EntityQuery<Course> courseQuery = await _deleteEntities.DeleteCourseAsync(course.Value);
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
            var formCourse = Program.Container.Resolve<RegistrationCourseForm>();
            formCourse.ShowDialog();
        }
    }
}
