﻿using System;
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
        public static string IdType;
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
            userCls.Username = TextUsername.Text;
            userCls.KeyPassword = TextPassword.Text;
            dt = userCls.N_Login(userCls);
        }
    }
}
