using Entities;
using Entities.TransientClasses;
using Services;
using System;
using System.Windows.Forms;

namespace SystemSchool.Forms.PasswordForms
{
    /// <summary>
    /// Represents the form for changing the user's password.
    /// </summary>
    public partial class ChangePasswordForm : Form
    {
        private readonly EditEntitiesService<User> _editEntities;

        /// <summary>
        /// Gets the new password entered by the user.
        /// </summary>
        private string Password => textBoxNewPassword.Text;

        /// <summary>
        /// Gets the confirmation password entered by the user.
        /// </summary>
        private string PasswordConfirmation => textBoxConfirmationPassword.Text;

        /// <summary>
        /// Gets the current user.
        /// </summary>
        private User User => Login.CurrentUser;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordForm"/> class.
        /// </summary>
        /// <param name="editEntities">The service used for editing entities.</param>
        public ChangePasswordForm(EditEntitiesService<User> editEntities)
        {
            _editEntities = editEntities;
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the buttonChange control, allowing the user to change their password if the new password matches the confirmation password.
        /// </summary>
        private async void buttonChange_Click(object sender, EventArgs e)
        {
            if (Password.Equals(PasswordConfirmation))
            {
                try
                {
                    // Set the new password for the current user.
                    User.PasswordHash = Password;
                    // Edit the password in the database.
                    EntityQuery<User> entityQuery = await _editEntities.EditPasswordAsync(User);
                    MessageBox.Show(entityQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The fields must be the same", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Handles the Load event of the ChangePasswordForm, setting the labelUsername text to the current user's username.
        /// </summary>
        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            labelUsername.Text = User.Username;
        }

        /// <summary>
        /// Handles the Click event of the pictureBoxClose control, hiding the form and showing the main form.
        /// </summary>
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
