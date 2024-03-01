using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datas;
using Entities;
using Business;
using SystemSchool.Helpers;
using Business.BusinessComponents;
using Business.BusinessComponents.ConcreteClasses;
using SystemSchool.Expections;

namespace SystemSchool
{
    public partial class Login : Form
    {
        LoginBusiness BusinessCls = new LoginBusiness();
        static public User UserCls = new User();
        MainForm MainForm = new MainForm();
        DataAccess dataAccess = new DataAccess();
        public Login()
        {
            InitializeComponent();
        }

        private void Clean()
        {
            TextUsername.Text = string.Empty;
            TextPassword.Text = string.Empty;
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
                LoginQuery query = await BusinessCls.LoginAsync(UserCls);
                if (query.Result)
                {
                    MessageBox.Show("Welcome " + query.User.Username, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserCls = query.User;
                    dataAccess.MainFormAccess(MainForm, UserCls);
                    this.Hide();
                    MainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
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
