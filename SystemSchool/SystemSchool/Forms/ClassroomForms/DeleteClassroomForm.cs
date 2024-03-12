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
        private readonly SearchEntitiesService _searchEntities; 
        private readonly DeleteEntitiesService<Classroom> _deleteEntities;
        private readonly FillEntitiesService _fillEntities;

        public DeleteClassroomForm(
            SearchEntitiesService searchEntities, 
            DeleteEntitiesService<Classroom> deleteEntities,
            FillEntitiesService fillEntities)
        {
            _deleteEntities = deleteEntities;
            _searchEntities = searchEntities;
            _fillEntities = fillEntities;
            InitializeComponent();
        }

        private async void DeleteClassroomForm_Load(object sender, EventArgs e)
        {
            await LoadComboBoxCourseAsync();
        }


        private async void ComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadListBoxClassroomsAsync();
        }

        private async Task LoadComboBoxCourseAsync()
        {
           IEnumerable<Course> courses = await _searchEntities.FindAllCoursesAsync();
           ComboBoxCourse.Items.Clear();
           ComboBoxCourse.Items.AddRange(courses.Select(c => new DisplayItem<Course>(c, c.CourseName)).ToArray());
        }

        private async Task LoadListBoxClassroomsAsync()
        {
            DisplayItem<Course> course = ComboBoxCourse.SelectedItem as DisplayItem<Course>;
            IEnumerable<Classroom> classrooms = await _searchEntities.FindClassroomsByCourseNameAsync(course.Value);
            listBoxClassrooms.Items.Clear();
            await _fillEntities.FillClassroomsWithCourseAsync(classrooms);
            foreach (Classroom classroom in classrooms)
            {
                listBoxClassrooms.Items.Add(new DisplayItem<Classroom>(classroom, $"{classroom.ClassroomName} - {classroom.Course.CourseName}"));
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayItem<Classroom> classroom = listBoxClassrooms.SelectedItem as DisplayItem<Classroom>;
                await _deleteEntities.DeleteStudentsAsync(await _searchEntities.FindStudentsByClassroomNameAsync(classroom.Value));
                EntityQuery<Classroom> classroomQuery = await _deleteEntities.DeleteClassroomAsync(classroom.Value);
                MessageBox.Show(classroomQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadListBoxClassroomsAsync();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxRegisterClassroom_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formClassroom = Program.Container.Resolve<RegistrationClassroomForm>();
            formClassroom.ShowDialog();
        }

        private void pictureBoxEditClassroom_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formClassroom = Program.Container.Resolve<EditClassroomForm>();
            formClassroom.ShowDialog();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            pictureBoxRegisterClassroom_Click(sender, e);
        }

        private void LabelRegisterClassroom_Click(object sender, EventArgs e)
        {
            pictureBoxRegisterClassroom_Click(sender, e);
        }

        private void LabelEditClassroom_Click(object sender, EventArgs e)
        {
            pictureBoxEditClassroom_Click(sender, e);
        }
    }
}
