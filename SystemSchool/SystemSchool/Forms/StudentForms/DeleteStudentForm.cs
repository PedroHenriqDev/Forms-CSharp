using System;
using System.Windows.Forms;
using Entities;
using Entities.TransientClasses;
using SystemSchool.Controls;
using Services;
using Autofac;

namespace SystemSchool.Forms.StudentForms
{
    /// <summary>
    /// Represents a form used for deleting student records in the school management system.
    /// </summary>
    public partial class DeleteStudentForm : Form
    {
        // Fields to store services needed for form functionality
        private readonly DeleteEntitiesService<Student> _deleteEntities;
        private readonly LoadFormComponents _loadFormComponents;

        /// <summary>
        /// Gets the selected classroom from the ComboBoxClassroom control.
        /// </summary>
        public DisplayItem<Classroom> SelectedClassroom => ComboBoxClassroom.SelectedItem as DisplayItem<Classroom>;

        /// <summary>
        /// Gets the selected student from the listBoxStudents control.
        /// </summary>
        public DisplayItem<Student> SelectedStudent => listBoxStudents.SelectedItem as DisplayItem<Student>;

        /// <summary>
        /// Initializes a new instance of the DeleteStudentForm class.
        /// </summary>
        /// <param name="deleteEntities">An instance of DeleteEntitiesService used for deleting student entities.</param>
        /// <param name="loadFormComponents">An instance of LoadFormComponents used for loading form components.</param>
        public DeleteStudentForm(
            DeleteEntitiesService<Student> deleteEntities,
            LoadFormComponents loadFormComponents)
        {
            // Initialize form components
            InitializeComponent();
            // Initialize fields with provided services
            _deleteEntities = deleteEntities;
            _loadFormComponents = loadFormComponents;
        }

        /// <summary>
        /// Handles the click event of the button used for deleting a student record.
        /// </summary>
        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Delete the selected student entity from the database
                EntityQuery<Student> studentQuery = await _deleteEntities.DeleteEntityAsync(SelectedStudent.Value);
                // Display a message box with the result of the operation
                MessageBox.Show(studentQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Reload the list of students based on the selected classroom
                await _loadFormComponents.DeleteStudentLoadListBoxByIndexAsync(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Load event of the DeleteStudentForm, loading the ComboBoxClassroom with available classrooms.
        /// </summary>
        private async void StudentDeleteForm_Load(object sender, EventArgs e)
        {
            await _loadFormComponents.DeleteStudentLoadComboBoxClassroomsAsync(this);
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the ComboBoxClassroom, loading the listBoxStudents with students from the selected classroom.
        /// </summary>
        private async void ComboBoxClassroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _loadFormComponents.DeleteStudentLoadListBoxByIndexAsync(this);
        }

        /// <summary>
        /// Handles the click event of the pictureBoxEdit control, opening the edit student form.
        /// </summary>
        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentForm = Program.Container.Resolve<EditStudentForm>();
            studentForm.ShowDialog();
        }

        /// <summary>
        /// Handles the click event of the pictureBoxBack control, returning to the previous form.
        /// </summary>
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentForm = Program.Container.Resolve<RegistrationStudentForm>();
            studentForm.ShowDialog();
        }

        /// <summary>
        /// Handles the click event of the pictureBoxStudent control, opening the registration student form.
        /// </summary>
        private void pictureBoxStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentForm = Program.Container.Resolve<RegistrationStudentForm>();
            studentForm.ShowDialog();
        }

        /// <summary>
        /// Handles the click event of the LabelEditStudent control, invoking the pictureBoxEdit control's click event.
        /// </summary>
        private void LabelEditStudent_Click(object sender, EventArgs e)
        {
            pictureBoxEdit_Click(sender, e);
        }

        /// <summary>
        /// Handles the click event of the LabelRegisterStudent control, invoking the pictureBoxStudent control's click event.
        /// </summary>
        private void LabelRegisterStudent_Click(object sender, EventArgs e)
        {
            pictureBoxStudent_Click(sender, e);
        }
    }
}
