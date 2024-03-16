using Autofac;
using System;
using System.Windows.Forms;

namespace SystemSchool.Forms
{
    /// <summary>
    /// Represents the loading form of the application.
    /// </summary>
    public partial class LoadForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadForm"/> class.
        /// </summary>
        public LoadForm()
        {
            // Initialize the components of the loading form.
            InitializeComponent();
        }

        /// <summary>
        /// Handles the tick event of the timer to update the progress bar.
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            // Increment the progress bar value until it reaches 100%.
            if (progressBar.Value < 100)
            {
                progressBar.Value += progressBar.Step;
            }
            // If the progress bar reaches 100%, hide the loading form and open the login form.
            if (progressBar.Value == 100)
            {
                this.Hide();
                var loginForm = Program.Container.Resolve<Login>();
                timer.Stop();
                loginForm.ShowDialog();
            }
        }
    }
}
