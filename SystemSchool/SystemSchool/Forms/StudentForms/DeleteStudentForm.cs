using System;
using System.Windows.Forms;
using Entities;
using Entities.TransientClasses;
using SystemSchool.Controls;
using Services;
using Autofac;

namespace SystemSchool.Forms.StudentForms
{
    public partial class DeleteStudentForm : Form
    {
        private readonly DeleteEntitiesService<Student> _deleteEntities;
        private readonly LoadFormComponents _loadFormComponents;
        public DisplayItem<Classroom> SelectedClassroom => ComboBoxClassroom.SelectedItem as DisplayItem<Classroom>;
        public DisplayItem<Student> SelectedStudent => listBoxStudents.SelectedItem as DisplayItem<Student>;

        public DeleteStudentForm(
            DeleteEntitiesService<Student> deleteEntities,
            LoadFormComponents loadFormComponents)
        {
            _deleteEntities = deleteEntities;
            _loadFormComponents = loadFormComponents;
            InitializeComponent();
        }

        private async void StudentDeleteForm_Load(object sender, EventArgs e)
        {
            await _loadFormComponents.DeleteStudentLoadComboBoxClassroomsAsync(this);
        }

        private async void ComboBoxClassroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _loadFormComponents.DeleteStudentLoadListBoxByIndexAsync(this);
        }
  

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                EntityQuery<Student> studentQuery = await _deleteEntities.DeleteEntityAsync(SelectedStudent.Value);
                MessageBox.Show(studentQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await _loadFormComponents.DeleteStudentLoadListBoxByIndexAsync(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentForm = Program.Container. Resolve<EditStudentForm>();
            studentForm.ShowDialog();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentForm = Program.Container.Resolve<RegistrationStudentForm>();
            studentForm.ShowDialog();
        }

        private void pictureBoxStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentForm = Program.Container.Resolve<RegistrationStudentForm>();
            studentForm.ShowDialog();
        }

        private void LabelEditStudent_Click(object sender, EventArgs e)
        {
            pictureBoxEdit_Click(sender, e);
        }

        private void LabelRegisterStudent_Click(object sender, EventArgs e)
        {
            pictureBoxStudent_Click(sender, e);
        }
    }
}
