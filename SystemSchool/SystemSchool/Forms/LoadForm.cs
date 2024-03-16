using Autofac;
using System;
using System.Windows.Forms;

namespace SystemSchool.Forms
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value += progressBar.Step;
            }
            if(progressBar.Value == 100) 
            {
                this.Hide();
                var loginForm = Program.Container.Resolve<Login>();
                timer.Stop();
                loginForm.ShowDialog();
            }
        }
    }
}
