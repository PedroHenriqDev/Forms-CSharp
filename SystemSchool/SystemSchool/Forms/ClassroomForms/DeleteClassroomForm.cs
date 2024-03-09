using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSchool.Controls;
using System.Windows.Forms;
using Entities.TransientClasses;
using Services;
using Autofac;

namespace SystemSchool.Forms.ClassroomForms
{
    public partial class DeleteClassroomForm : Form
    {
        private readonly SearchEntitiesService SearchEntities; 
        private readonly DeleteEntitiesService<Classroom> DeleteEntities;

        public DeleteClassroomForm(SearchEntitiesService searchEntities, DeleteEntitiesService<Classroom> deleteEntities)
        {
            DeleteEntities = deleteEntities;
            SearchEntities = searchEntities;
            InitializeComponent();
        }

        private async void DeleteClassroomForm_Load(object sender, EventArgs e)
        {
            await LoadComboBoxCourseAsync();
        }


        private async void ComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadListBoxClassroomsAsync();
            await LoadComboBoxCourseAsync();
        }

        private async Task LoadComboBoxCourseAsync()
        {
           IEnumerable<Course> courses = await SearchEntities.FindAllCoursesAsync();
           ComboBoxCourse.Items.Clear();
           ComboBoxCourse.Items.AddRange(courses.Select(c => new DisplayItem<Course>(c, c.CourseName)).ToArray());
        }

        private async Task LoadListBoxClassroomsAsync()
        {
            DisplayItem<Course> course = ComboBoxCourse.SelectedItem as DisplayItem<Course>;
            IEnumerable<Classroom> classrooms = await SearchEntities.FindClassroomsByCourseNameAsync(course.Value.CourseName); ;
            listBoxClassrooms.Items.Clear();
            foreach (Classroom classroom in classrooms)
            {
                listBoxClassrooms.Items.Add(new DisplayItem<Classroom>(classroom, classroom.ClassroomName));
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formClassroom = Program.Container.Resolve<RegistrationClassroomForm>();
            formClassroom.ShowDialog();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayItem<Classroom> classroom = listBoxClassrooms.SelectedItem as DisplayItem<Classroom>;
                await DeleteEntities.DeleteStudentsAsync(await SearchEntities.FindStudentsByClassroomNameAsync(classroom.Value.ClassroomName));
                ClassroomQuery classroomQuery = await DeleteEntities.DeleteClassroomAsync(classroom.Value);
                MessageBox.Show(classroomQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBoxClassrooms.Items.Clear();
                ComboBoxCourse.Focus();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
