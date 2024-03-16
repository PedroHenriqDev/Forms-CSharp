using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using SystemSchool.Helpers;
using SystemSchool.Expections;
using Services;
using Entities.TransientClasses;

namespace SystemSchool
{
    /// <summary>
    /// Represents the login form of the application.
    /// </summary>
    public partial class Login : Form
    {
        private readonly LoginService _loginService;
        static public User CurrentUser = new User();
        private readonly DataAccess _dataAccess;

        /// <summary>
        /// Initializes a new instance of the <see cref="Login"/> class.
        /// </summary>
        /// <param name="loginService">The login service dependency.</param>
        /// <param name="dataAccess">The data access dependency.</param>
        public Login(
            LoginService loginService,
            DataAccess dataAccess)
        {
            // Assign dependencies and initialize components of the Login form.
            _loginService = loginService;
            _dataAccess = dataAccess;
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click event of the login button.
        /// </summary>
        private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            await ButtonLogin_ClickAsync(sender, e);
        }

        /// <summary>
        /// Asynchronously handles the click event of the login button.
        /// </summary>
        private async Task ButtonLogin_ClickAsync(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            try
            {
                // Retrieve the username and password from the input fields.
                CurrentUser.Username = TextUsername.Text;
                CurrentUser.PasswordHash = TextPassword.Text;
                // Attempt to log in using the provided credentials.
                EntityQuery<User> userQuery = await _loginService.LoginAsync(CurrentUser);
                if (userQuery.Result)
                {
                    // If login successful, update the current user and display a success message.
                    CurrentUser = userQuery.Value;
                    MessageBox.Show(userQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Hide the login form and open the main form.
                    this.Hide();
                    _dataAccess.MainFormAccess(MainForm, CurrentUser);
                    MainForm.ShowDialog();
                }
                else
                {
                    // If login fails, display an error message.
                    MessageBox.Show(userQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MainFormException ex)
            {
                // If an exception related to the main form occurs, display an error message and exit the application.
                MessageBox.Show("Error in data access ", ex.Message, (MessageBoxButtons)MessageBoxIcon.Error);
                Application.Exit();
            }
            catch (Exception ex)
            {
                // If an unexpected error occurs, display an error message and exit the application.
                MessageBox.Show("Brutal error", ex.Message, (MessageBoxButtons)MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Handles the click event of the close button.
        /// </summary>
        private void pictureClose_Click(object sender, EventArgs e)
        {
            // Close the application.
            Application.Exit();
        }

        /// <summary>
        /// Handles the click event of the password privacy button to toggle password visibility.
        /// </summary>
        private void buttonPasswordPrivacy_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the password characters and update the button text accordingly.
            TextPassword.UseSystemPasswordChar = !TextPassword.UseSystemPasswordChar;
            if (TextPassword.UseSystemPasswordChar)
            {
                buttonPasswordPrivacy.Text = "Hide";
                TextPassword.Font = new System.Drawing.Font("Malgun Gothic", 5F);
            }
            else
            {
                buttonPasswordPrivacy.Text = "Show";
                TextPassword.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            }
        }
    }
}
