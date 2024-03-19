using System;
using System.Windows.Forms;
using Entities;
using Entities.TransientClasses;
using Entities.Expections;
using Services;
using Autofac;
using SystemSchool.Controls;

namespace SystemSchool.Forms.CourseForms
{
    public partial class RegistrationCourseForm : Form
    {

        private readonly CreateEntitiesService<Course> _createEntities;
        private readonly CreateTransientEntities _createTransientEntities;
        public string CourseName => textBoxCourseName.Text;

        public RegistrationCourseForm(
            CreateEntitiesService<Course> createEntities,
            CreateTransientEntities createTransientEntities)
        {
            _createEntities = createEntities;
            _createTransientEntities = createTransientEntities;
            InitializeComponent();
        }

        private async void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Course course = _createTransientEntities.CreateCourseTransient(this);
                EntityQuery<Course> courseQuery = await _createEntities.CreateCourseAsync(course);
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

        private void RegistrationCourseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
