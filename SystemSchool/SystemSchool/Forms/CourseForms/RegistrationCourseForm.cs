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
using Business.BusinessLogic;
using Entities.TransientClasses;
using System.Linq.Expressions;
using Business.BusinessComponents.ConcreteClasses;

namespace SystemSchool.Forms.CourseForms
{
    public partial class RegistrationCourseForm : Form
    {

        CreateEntitiesBusiness<Course> createEntities = new CreateEntitiesBusiness<Course>();

        public RegistrationCourseForm()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private async void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                Course course = new Course(textBoxCourseName.Text, random.Next());
                CreateCourseQuery courseQuery = await createEntities.CreateCourseAsync(course);
                if (courseQuery.Result)
                {
                    MessageBox.Show(courseQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(courseQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentNullException ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
