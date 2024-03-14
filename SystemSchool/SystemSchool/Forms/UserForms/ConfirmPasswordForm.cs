using Autofac;
using Entities;
using Entities.TransientClasses;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemSchool.Controls;

namespace SystemSchool.Forms.PasswordForms
{
    public partial class ConfirmPasswordForm : Form
    {

        private readonly LoginService _loginService;
        private readonly CreateTransientEntities _createTransient;
        public string Username => Login.CurrentUser.Username;
        public string Password => textBoxPassword.Text;

        public ConfirmPasswordForm(LoginService loginService, CreateTransientEntities createTransient)
        {
            _loginService = loginService;
            _createTransient = createTransient;
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async void buttonAccess_Click(object sender, EventArgs e)
        {
            try
            {
                User user = _createTransient.CreateUserTransient(this);
                EntityQuery<User> userQuery = await _loginService.LoginAsync(user);
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
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
