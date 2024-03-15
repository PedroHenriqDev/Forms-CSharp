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
        private readonly LoadFormComponents _loadFormComponents;
        public DisplayItem<Course> SelectedCourse => ComboBoxCourse.SelectedItem as DisplayItem<Course>; 

        public DeleteClassroomForm(
            SearchEntitiesService searchEntities, 
            DeleteEntitiesService<Classroom> deleteEntities,
            LoadFormComponents loadFormComponents)
        {
            _deleteEntities = deleteEntities;
            _searchEntities = searchEntities;
            _loadFormComponents = loadFormComponents;
            InitializeComponent();
        }

        private async void DeleteClassroomForm_Load(object sender, EventArgs e)
        {
            await _loadFormComponents.DeleteClassroomLoadComboBoxCourseAsync(this);
        }


        private async void ComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _loadFormComponents.DeleteClassroomLoadListBoxClassroomsAsync(this);
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayItem<Classroom> classroom = listBoxClassrooms.SelectedItem as DisplayItem<Classroom>;
                await _deleteEntities.DeleteEntitiesAsync<Student>(await _searchEntities.FindEntitiesByReferenceIdAsync<Student, Classroom>(classroom.Value));
                EntityQuery<Classroom> classroomQuery = await _deleteEntities.DeleteEntityAsync(classroom.Value);
                MessageBox.Show(classroomQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await _loadFormComponents.DeleteClassroomLoadListBoxClassroomsAsync(this);
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
