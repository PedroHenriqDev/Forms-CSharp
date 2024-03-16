using Entities;
using System;
using System.Windows.Forms;
using SystemSchool.Controls;
using Entities.TransientClasses;
using SystemSchool.Expections;
using Autofac;
using Services;
using Services.Exceptions;

namespace SystemSchool.Forms.StudentForms
{
    /// <summary>
    /// Represents a form used for editing student information in the school management system.
    /// </summary>
    public partial class EditStudentForm : Form
    {
        // Fields to store services needed for form functionality
        private readonly EditEntitiesService<Student> _editEntities;
        private readonly LoadFormComponents _loadFormComponents;

        /// <summary>
        /// Gets the selected student from the listBoxSearch control.
        /// </summary>
        public DisplayItem<Student> SelectedStudent => listBoxSearch.SelectedItem as DisplayItem<Student>;

        /// <summary>
        /// Gets or sets the complete name entered by the user in the form.
        /// </summary>
        public string CompleteName => textBoxStudentName.Text;

        /// <summary>
        /// Initializes a new instance of the EditStudentForm class.
        /// </summary>
        /// <param name="editEntities">An instance of EditEntitiesService used for editing student entities.</param>
        /// <param name="loadFormComponents">An instance of LoadFormComponents used for loading form components.</param>
        public EditStudentForm(
            EditEntitiesService<Student> editEntities,
            LoadFormComponents loadFormComponents)
        {
            // Initialize form components
            InitializeComponent();
            // Initialize fields with provided services
            _editEntities = editEntities;
            _loadFormComponents = loadFormComponents;
        }

        /// <summary>
        /// Handles the click event of the button used for editing student information.
        /// </summary>
        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the complete name of the selected student
                SelectedStudent.Value.CompleteName = CompleteName;

                // Load classroom information into the selected student
                await _loadFormComponents.EditStudentLoadClassroomInStudentAsync(this, SelectedStudent.Value);

                // Edit the student entity in the database
                EntityQuery<Student> studentQuery = await _editEntities.EditStudentAsync(SelectedStudent.Value);

                // Update the displayed student name if the operation was successful
                if (studentQuery.Result)
                {
                    LabelStudent.Text = textBoxStudentName.Text;
                }

                // Display a message box with the result of the operation
                MessageBox.Show(studentQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        /// <summary>
        /// Handles the KeyDown event of the textBoxSearch control, loading search results into the listBoxSearch control.
        /// </summary>
        private async void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            await _loadFormComponents.EditStudentLoadListBoxSearchAsync(this);
            LabelSearchResult.Text = $"Result of search '{textBoxSearch.Text}'";
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the listBoxSearch control, loading student details into the form components.
        /// </summary>
        private async void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSearch.SelectedItem != null)
            {
                await _loadFormComponents.EditStudentLoadComponentsAsync(this);
            }
        }

        /// <summary>
        /// Handles the click event of the pictureBoxDelete control, opening the delete student form.
        /// </summary>
        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentForm = Program.Container.Resolve<DeleteStudentForm>();
            studentForm.ShowDialog();
        }

        /// <summary>
        /// Handles the click event of the pictureBoxBack control, returning to the previous form.
        /// </summary>
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            pictureBoxStudent_Click(sender, e);
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
        /// Handles the click event of the LabelDeleteStudent control, invoking the pictureBoxDelete control's click event.
        /// </summary>
        private void LabelDeleteStudent_Click(object sender, EventArgs e)
        {
            pictureBoxDelete_Click(sender, e);
        }

        /// <summary>
        /// Handles the click event of the LabelStudent control, invoking the pictureBoxStudent control's click event.
        /// </summary>
        private void LabelStudent_Click(object sender, EventArgs e)
        {
            pictureBoxStudent_Click(sender, e);
        }
    }
}
