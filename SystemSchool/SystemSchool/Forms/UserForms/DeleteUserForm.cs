using Autofac;
using Entities;
using Entities.Expections;
using Entities.TransientClasses;
using Services;
using System;
using System.Windows.Forms;
using SystemSchool.Controls;

namespace SystemSchool.Forms.UserForms
{
    /// <summary>
    /// Represents the form for deleting user information.
    /// </summary>
    public partial class DeleteUserForm : Form
    {
        private readonly DeleteEntitiesService<User> _deleteEntities;
        private readonly LoadFormComponents _loadFormComponents;

        /// <summary>
        /// Gets the selected class from the ComboBox.
        /// </summary>
        public DisplayItem<Group> SelectedClass => ComboBoxClasses.SelectedItem as DisplayItem<Group>;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteUserForm"/> class.
        /// </summary>
        /// <param name="deleteEntities">The service used to delete entities.</param>
        /// <param name="loadFormComponents">The service used to load form components.</param>
        public DeleteUserForm(
            DeleteEntitiesService<User> deleteEntities,
            LoadFormComponents loadFormComponents)
        {
            _deleteEntities = deleteEntities;
            InitializeComponent();
            _loadFormComponents = loadFormComponents;
        }

        /// <summary>
        /// Handles the Click event of the buttonDelete control, allowing deletion of the selected user.
        /// </summary>
        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected user from the ListBox.
                DisplayItem<User> user = listBoxUsers.SelectedItem as DisplayItem<User>;
                // Delete the selected user from the database.
                EntityQuery<User> userQuery = await _deleteEntities.DeleteEntityAsync(user.Value);
                // Reload the list of users after deletion.
                await _loadFormComponents.DeleteUserLoadListBoxUsersAsync(this);
                // Display a message indicating the success or failure of the deletion operation.
                MessageBox.Show(userQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// Handles the Load event of the DeleteUserForm, loading the ComboBox with available classes.
        /// </summary>
        private async void DeleteUserForm_Load(object sender, EventArgs e)
        {
            // Load the ComboBox with available classes.
            await _loadFormComponents.DeleteUserLoadComboBoxClassAsync(this);
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the ComboBoxClasses, loading the ListBox with users from the selected class.
        /// </summary>
        private async void ComboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load the ListBox with users from the selected class.
            await _loadFormComponents.DeleteUserLoadListBoxUsersAsync(this);
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
        /// Handles the Click event of the pictureBoxStudent control, navigating to the registration user form.
        /// </summary>
        private void pictureBoxStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userForm = Program.Container.Resolve<RegistrationUserForm>();
            userForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the pictureBoxBack control, navigating back to the registration user form.
        /// </summary>
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            pictureBoxStudent_Click(sender, e);
        }

        /// <summary>
        /// Handles the Click event of the LabelEditStudent control, invoking the pictureBoxEdit_Click event.
        /// </summary>
        private void LabelEditStudent_Click(object sender, EventArgs e)
        {
            pictureBoxEdit_Click(sender, e);
        }

        /// <summary>
        /// Handles the Click event of the LabelCreateUser control, invoking the pictureBoxStudent_Click event.
        /// </summary>
        private void LabelCreateUser_Click(object sender, EventArgs e)
        {
            pictureBoxStudent_Click(sender, e);
        }
    }
}
