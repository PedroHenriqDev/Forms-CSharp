using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Business;

namespace SystemSchool
{
    public partial class MainForm : Form
    {

        EntityClass EntityObj = new EntityClass();
        BusinessClass BusinessObj = new BusinessClass();

        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LabelUsername.Text = Login.Username;
            if (Login.UserId == "T0002") 
            {
                pictureUser.Enabled = false;
            }
        }
    }
}
