using Autofac;
using Entities;
using Entities.TransientClasses;
using Services;
using System;
using System.Windows.Forms;
using SystemSchool.Controls;

namespace SystemSchool.Forms.PasswordForms
{
    /// <summary>
    /// Represents the form for confirming the password before changing it.
    /// </summary>
    public partial class ConfirmPasswordForm : Form
    {
        private readonly LoginService _loginService;
        private readonly CreateTransientEntities _createTransient;

        /// <summary>
        /// Gets the username of the current user.
        /// </summary>
        public string Username => Login.CurrentUser.Username;

        /// <summary>
        /// Gets the password entered by the user.
        /// </summary>
        public string Password => textBoxPassword.Text;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmPasswordForm"/> class.
        /// </summary>
        /// <param name="loginService">The service used for login operations.</param>
        /// <param name="createTransient">The service used to create transient entities.</param>
        public ConfirmPasswordForm(LoginService loginService, CreateTransientEntities createTransient)
        {
            _loginService = loginService;
            _createTransient = createTransient;
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the buttonAccess control, allowing access to change the password if the provided password is correct.
        /// </summary>
        private async void buttonAccess_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a transient user object with the entered username and password.
                User user = _createTransient.CreateUserTransient(this);
                // Attempt to login with the provided credentials.
                EntityQuery<User> userQuery = await _loginService.LoginAsync(user);
                // If login is successful, navigate to the change password form.
                if (userQuery.Result)
                {
                    this.Hide();
                    var passwordForm = Program.Container.Resolve<ChangePasswordForm>();
                    passwordForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show(userQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Click event of the pictureBoxClose control, hiding the form.
        /// </summary>
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
