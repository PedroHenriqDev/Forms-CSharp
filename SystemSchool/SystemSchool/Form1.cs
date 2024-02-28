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
    public partial class Form1 : Form
    {
        BusinessClass businessCls = new BusinessClass();
        EntityClass entitiesCls = new EntityClass();
        public static string Username;
        public static string IdType;
        public static string User;
        public static string UserId;

        MainForm mainForm = new MainForm();
        public Form1()
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
    }
}
