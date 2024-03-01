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

namespace SystemSchool
{
    public partial class Login : Form
    {
        BusinessClass BusinessCls = new BusinessClass();
        static public User UserCls = new User();
        MainForm MainForm = new MainForm();
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
            UserCls.Username = TextUsername.Text;
            UserCls.Password = TextPassword.Text;
            User User = await BusinessCls.LoginAsync(UserCls);
            if (User != null)
            {
                MessageBox.Show("Welcome " + User.Username, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserCls = User;
                this.Hide();
                MainForm.ShowDialog();
                Clean();
            }
            else 
            {
                MessageBox.Show("Incorrect username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean();            
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
