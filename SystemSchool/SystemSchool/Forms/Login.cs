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
        static public User UserCls = new User();
        MainForm MainForm = new MainForm();
        DataAccess DataAccess = new DataAccess();

        public Login(LoginService loginService) 
        {
            _loginService = loginService;
            InitializeComponent();
        }

        private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            await ButtonLogin_ClickAsync(sender, e);
        }

        private async Task ButtonLogin_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                UserCls.Username = TextUsername.Text;
                UserCls.PasswordHash = TextPassword.Text;
                EntityQuery<User> userQuery = await _loginService.LoginAsync(UserCls);
                if (userQuery.Result)
                {
                    UserCls = userQuery.Value;
                    MessageBox.Show(userQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    DataAccess.MainFormAccess(MainForm, UserCls);
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

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
