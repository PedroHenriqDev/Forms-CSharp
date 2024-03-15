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
        private readonly LoadFormComponents _loadFormComponents;
        public DisplayItem<Course> SelectedCourse => listBoxCourses.SelectedItem as DisplayItem<Course>;


        public DeleteCourseForm(
            SearchEntitiesService searchEntities,
            DeleteEntitiesService<Course> deleteEntities,
            LoadFormComponents loadFormComponents)
        {
            _searchEntities = searchEntities;
            _deleteEntities = deleteEntities;
            _loadFormComponents = loadFormComponents;
            InitializeComponent();
        }

        private async void DeleteCourseForm_Load(object sender, EventArgs e)
        {
            await _loadFormComponents.DeleteCourseLoadListBoxCoursesAsync(this);
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedCourse.Value.Classrooms = (await _searchEntities.FindEntitiesByReferenceIdAsync<Classroom, Course>(SelectedCourse.Value)).ToList();
                await _deleteEntities.DeleteStudentsInClassroomsAsync(SelectedCourse.Value.Classrooms);
                await _deleteEntities.DeleteClassromsByCourseIdAsync(SelectedCourse.Value.Classrooms, SelectedCourse.Value.Id);

                EntityQuery<Course> courseQuery = await _deleteEntities.DeleteEntityAsync(SelectedCourse.Value);
                MessageBox.Show(courseQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await _loadFormComponents.DeleteCourseLoadListBoxCoursesAsync(this);
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
