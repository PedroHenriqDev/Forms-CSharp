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
    public partial class Login : Form
    {
        private readonly LoginService _loginService;
        static public User CurrentUser = new User();
        private readonly DataAccess _dataAccess; 

        public Login(
            LoginService loginService,
            DataAccess dataAccess) 
        {
            _loginService = loginService;
            _dataAccess = dataAccess;
            InitializeComponent();
        }

        private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            await ButtonLogin_ClickAsync(sender, e);
        }

        private async Task ButtonLogin_ClickAsync(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            try
            {
                CurrentUser.Username = TextUsername.Text;
                CurrentUser.PasswordHash = TextPassword.Text;
                EntityQuery<User> userQuery = await _loginService.LoginAsync(CurrentUser);
                if (userQuery.Result)
                {
                    CurrentUser = userQuery.Value;
                    MessageBox.Show(userQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    _dataAccess.MainFormAccess(MainForm, CurrentUser);
                    MainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show(userQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MainFormException ex)
            {
                MessageBox.Show("Error in data access ", ex.Message, (MessageBoxButtons)MessageBoxIcon.Error);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brutal error", ex.Message, (MessageBoxButtons)MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPasswordPrivacy_Click(object sender, EventArgs e)
        {
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
