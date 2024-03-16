using Autofac;
using Entities;
using Entities.Expections;
using Entities.TransientClasses;
using Services;
using System;
using System.Data;
using System.Windows.Forms;
using SystemSchool.Controls;

namespace SystemSchool.Forms.UserForms
{
    /// <summary>
    /// Represents the form for registering a new user.
    /// </summary>
    public partial class RegistrationUserForm : Form
    {
        private readonly SearchEntitiesService _searchEntities;
        private readonly CreateEntitiesService<User> _createEntities;
        private readonly CreateTransientEntities _createTransientEntities;
        private readonly LoadFormComponents _loadFormComponents;

        /// <summary>
        /// Gets the username entered by the user.
        /// </summary>
        public string Username => textBoxUsername.Text;

        /// <summary>
        /// Gets the password entered by the user.
        /// </summary>
        public string Password => textBoxPassword.Text;

        /// <summary>
        /// Gets the selected group from the ComboBox.
        /// </summary>
        public DisplayItem<Group> SelectedGroup => ComboBoxClass.SelectedItem as DisplayItem<Group>;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationUserForm"/> class.
        /// </summary>
        /// <param name="searchEntities">The service used to search for entities.</param>
        /// <param name="createEntities">The service used to create entities.</param>
        /// <param name="createTransientEntities">The service used to create transient entities.</param>
        /// <param name="loadFormComponents">The service used to load form components.</param>
        public RegistrationUserForm(
            SearchEntitiesService searchEntities,
            CreateEntitiesService<User> createEntities,
            CreateTransientEntities createTransientEntities,
            LoadFormComponents loadFormComponents)
        {
            _searchEntities = searchEntities;
            _createEntities = createEntities;
            _createTransientEntities = createTransientEntities;
            _loadFormComponents = loadFormComponents;
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the buttonCreate control.
        /// </summary>
        private async void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a user from the entered data.
                User user = _createTransientEntities.CreateUserTransient(this);
                // Attempt to create the user in the database.
                EntityQuery<User> userQuery = await _createEntities.CreateUserAsync(user);
                // Display a message indicating the success or failure of the operation.
                MessageBox.Show(userQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Handles the Load event of the RegistrationUserForm, loading form components.
        /// </summary>
        private async void RegistrationUserForm_Load(object sender, EventArgs e)
        {
            // Load ComboBoxClass with available groups.
            await _loadFormComponents.RegistrationUserLoadComboBoxClass(this);
        }

        /// <summary>
        /// Handles the Click event of the pictureBoxBack control, navigating back to the main form.
        /// </summary>
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the pictureBoxEdit control, navigating to the edit user form.
        /// </summary>
        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userForm = Program.Container.Resolve<EditUserForm>();
            userForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the pictureBoxDelete control, navigating to the delete user form.
        /// </summary>
        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userForm = Program.Container.Resolve<DeleteUserForm>();
            userForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the LabelDeleteUser control, invoking the pictureBoxDelete_Click event.
        /// </summary>
        private void LabelDeleteUser_Click(object sender, EventArgs e)
        {
            pictureBoxDelete_Click(sender, e);
        }

        /// <summary>
        /// Handles the Click event of the LabelEditStudent control, invoking the pictureBoxEdit_Click event.
        /// </summary>
        private void LabelEditStudent_Click(object sender, EventArgs e)
        {
            pictureBoxEdit_Click(sender, e);
        }
    }
}
