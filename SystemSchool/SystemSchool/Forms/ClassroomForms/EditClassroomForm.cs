using Entities;
using Entities.TransientClasses;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemSchool.Controls;
using Services.Exceptions;
using Autofac;

namespace SystemSchool.Forms.ClassroomForms
{
    public partial class EditClassroomForm : Form
    {
        private readonly FillEntitiesService _fillEntities;
        private readonly EditEntitiesService<Classroom> _editEntities;
        private readonly LoadFormComponents _loadFormComponents;
        public DisplayItem<Course> SelectedCourse => ComboBoxCourse.SelectedItem as DisplayItem<Course>;
        public DisplayItem<Classroom> SelectedClassroom => listBoxSearch.SelectedItem as DisplayItem<Classroom>;
        public string Query => textBoxSearch.Text;

        public EditClassroomForm(
            FillEntitiesService fillEntities,
            EditEntitiesService<Classroom> editEntities,
            LoadFormComponents loadFormComponents)
        {
            _fillEntities = fillEntities;
            _editEntities = editEntities;
            InitializeComponent();
            _loadFormComponents = loadFormComponents;
        }

        private async void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            await _loadFormComponents.EditClassroomLoadListBoxSearchAsync(this);
            LabelSearchResult.Text = $"Result of Search '{textBoxSearch.Text}'";
        }

        private async void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _loadFormComponents.EditClassroomLoadComponentsAsync(this);
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                _fillEntities.FillClassroomWithCourse(SelectedClassroom.Value, SelectedCourse.Value);
                EntityQuery<Classroom> classroomQuery = await _editEntities.EditClassroomAsync(SelectedClassroom.Value);
                MessageBox.Show(classroomQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FillException ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            var classroomForm = Program.Container.Resolve<DeleteClassroomForm>();
            classroomForm.ShowDialog();
        }

        private void pictureBoxStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            var classroomForm = Program.Container.Resolve<RegistrationClassroomForm>();
            classroomForm.ShowDialog();
        }
    }
}
