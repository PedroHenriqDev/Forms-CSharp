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

namespace SystemSchool
{
    public partial class MainForm : Form
    {
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
            LabelUsername.Text = Login.UserCls.Username;
            TimerDate.Start();
        }
        
        private void TimerDate_Tick(object sender, EventArgs e)
        {
            LabelHour.Text = DateTime.Now.ToString("HH:mm:ss");
            LabelDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void pictureStudent_Click(object sender, EventArgs e)
        {

        }
    } 
}
