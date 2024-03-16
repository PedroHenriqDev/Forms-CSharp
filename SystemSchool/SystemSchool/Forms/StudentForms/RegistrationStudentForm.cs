using System;
using System.Windows.Forms;
using Entities;
using Entities.Expections;
using Entities.TransientClasses;
using SystemSchool.Forms.StudentForms;
using Services;
using Autofac;
using SystemSchool.Controls;

namespace SystemSchool
{
    /// <summary>
    /// Represents a form used for registering new students in the school management system.
    /// </summary>
    public partial class RegistrationStudentForm : Form
    {
        // Fields to store services and components needed for form functionality
        private readonly SearchEntitiesService _searchEntities;
        private readonly LoadFormComponents _loadFormComponents;
        private readonly CreateEntitiesService<Student> _createEntities;
        private readonly CreateTransientEntities _createTransientEntities;

        /// <summary>
        /// Gets the complete name entered by the user in the form.
        /// </summary>
        public string CompleteName => textBoxCompleteName.Text;

        /// <summary>
        /// Gets the selected course from the ComboBoxCourse control.
        /// </summary>
        public DisplayItem<Course> SelectedCourse => ComboBoxCourse.SelectedItem as DisplayItem<Course>;

        /// <summary>
        /// Gets the selected classroom from the ComboBoxClassroom control.
        /// </summary>
        public DisplayItem<Classroom> SelectedClassroom => ComboBoxClassroom.SelectedItem as DisplayItem<Classroom>;

        /// <summary>
        /// Initializes a new instance of the RegistrationStudentForm class.
        /// </summary>
        /// <param name="searchEntities">An instance of SearchEntitiesService used for searching entities.</param>
        /// <param name="loadFormComponents">An instance of LoadFormComponents used for loading form components.</param>
        /// <param name="createServices">An instance of CreateEntitiesService for Student entities used for creating new students.</param>
        /// <param name="createTransientEntities">An instance of CreateTransientEntities used for creating transient entities.</param>
        public RegistrationStudentForm(
            SearchEntitiesService searchEntities,
            LoadFormComponents loadFormComponents,
            CreateEntitiesService<Student> createServices,
            CreateTransientEntities createTransientEntities)
        {
            // Initialize fields with provided services and components
            _searchEntities = searchEntities;
            _loadFormComponents = loadFormComponents;
            _createEntities = createServices;
            _createTransientEntities = createTransientEntities;

            // Initialize form components
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click event of the button used for creating a new student.
        /// </summary>
        private async void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new student object using transient data from the form
                Student student = _createTransientEntities.CreateStudentTransient(this);
                // Retrieve the selected classroom object based on the ComboBox selection
                Classroom classroom = await _searchEntities.FindEntityByNameAsync<Classroom>(ComboBoxClassroom.SelectedItem.ToString());
                // Create the student entity in the database
                EntityQuery<Student> studentQuery = await _createEntities.CreateStudentAsync(student);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the form load event, loading data into ComboBox controls.
        /// </summary>
        private async void StudentRegistrationForm_Load(object sender, EventArgs e)
        {
            await _loadFormComponents.RegistrationStudentLoadComboBoxCoursesAsync(this);
        }

        /// <summary>
        /// Handles the selection change event of the ComboBoxCourse control, loading data into related controls.
        /// </summary>
        private async void ComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _loadFormComponents.RegistrationStudentLoadComboBoxClassroomAsync(this);
        }

        /// <summary>
        /// Handles the click event of the back button, returning to the main form.
        /// </summary>
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        /// <summary>
        /// Handles the click event of the edit button, opening the edit student form.
        /// </summary>
        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentForm = Program.Container.Resolve<EditStudentForm>();
            studentForm.ShowDialog();
        }

        /// <summary>
        /// Handles the click event of the delete button, opening the delete student form.
        /// </summary>
        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentForm = Program.Container.Resolve<DeleteStudentForm>();
            studentForm.ShowDialog();
        }

        /// <summary>
        /// Handles the click event of the delete label, invoking the delete button's click event.
        /// </summary>
        private void LabelDelete_Click(object sender, EventArgs e)
        {
            pictureBoxDelete_Click(sender, e);
        }

        /// <summary>
        /// Handles the click event of the edit student label, invoking the edit button's click event.
        /// </summary>
        private void LabelEditStudent_Click(object sender, EventArgs e)
        {
            pictureBoxEdit_Click(sender, e);
        }
    }
}
