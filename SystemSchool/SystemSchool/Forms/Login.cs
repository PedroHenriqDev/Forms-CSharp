using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using SystemSchool.Helpers;
using Business.BusinessComponents.ConcreteClasses;
using SystemSchool.Expections;

namespace SystemSchool
{
    public partial class Login : Form
    {
        Business.LoginBusiness BusinessCls = new Business.LoginBusiness();
        static public User UserCls = new User();
        MainForm MainForm = new MainForm();
        DataAccess dataAccess = new DataAccess();

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                LoginQuery loginQuery = await BusinessCls.LoginAsync(UserCls);
                if (loginQuery.Result)
                {
                    UserCls = loginQuery.User;
                    MessageBox.Show(loginQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    dataAccess.MainFormAccess(MainForm, UserCls);
                    MainForm.Show();
                }
                else
                {
                    MessageBox.Show(loginQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
