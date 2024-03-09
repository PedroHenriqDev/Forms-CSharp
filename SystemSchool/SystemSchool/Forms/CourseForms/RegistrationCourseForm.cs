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
using Entities.TransientClasses;
using System.Linq.Expressions;
using Business.BusinessComponents.ConcreteClasses;
using Entities.Expections;
using Services;
using Autofac;

namespace SystemSchool.Forms.CourseForms
{
    public partial class RegistrationCourseForm : Form
    {

        private readonly CreateEntitiesService<Course> _createEntities;

        public RegistrationCourseForm(CreateEntitiesService<Course> createEntities)
        {
            _createEntities = createEntities;
            InitializeComponent();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            var deleteForm = Program.Container.Resolve<DeleteCourseForm>();
            deleteForm.ShowDialog();
        }

        private async void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                Course course = new Course(textBoxCourseName.Text, random.Next());
                CourseQuery courseQuery = await _createEntities.CreateCourseAsync(course);
                MessageBox.Show(courseQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
