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
        BusinessClass businessCls = new BusinessClass();
        EntityClass userCls = new EntityClass();
        public static string Username;
        public static string IdClass;
        public static string User;
        public static string UserId;
        MainForm mainForm = new MainForm();
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

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            userCls.User = TextUsername.Text;
            userCls.KeyPassword = TextPassword.Text;
            dt = businessCls.N_Login(userCls);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Welcome " + dt.Rows[0][0].ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Username = dt.Rows[0][0].ToString();
                IdClass = dt.Rows[0][1].ToString();
                User = dt.Rows[0][2].ToString();
                UserId = dt.Rows[0][3].ToString();
                this.Hide();
                mainForm.ShowDialog();
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
            this.Close();
        }
    }
}
