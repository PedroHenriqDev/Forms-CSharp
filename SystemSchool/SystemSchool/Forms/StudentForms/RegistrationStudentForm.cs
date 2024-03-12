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
using Entities.Expections;
using Entities.TransientClasses;
using SystemSchool.Forms.StudentForms;
using Services;
using Autofac;
using SystemSchool.Controls;

namespace SystemSchool
{
    public partial class RegistrationStudentForm : Form
    {
        private readonly SearchEntitiesService _searchEntities;
        private readonly CreateEntitiesService<Student> _createEntities;
        private readonly CreateTransientEntities _createTransientEntities;

        public RegistrationStudentForm(
            SearchEntitiesService searchEntities, 
            CreateEntitiesService<Student> createServices, 
            CreateTransientEntities createTransientEntities) 
        {
            _searchEntities = searchEntities;
            _createEntities = createServices;
            _createTransientEntities = createTransientEntities;
            InitializeComponent();
        }

        private async void StudentRegistrationForm_Load(object sender, EventArgs e)
        {
            await LoadComboBoxCoursesAsync();
        }

        private async void ComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadComboBoxClassroomAsync();
        }

        private async Task LoadComboBoxClassroomAsync()
        {
            DisplayItem<Course> course = ComboBoxCourse.SelectedItem as DisplayItem<Course>;
            IEnumerable<Classroom> classrooms = await _searchEntities.FindClassroomsByCourseNameAsync(course.Value);
            ComboBoxClassroom.Items.Clear();
            ComboBoxClassroom.Items.AddRange(classrooms.Select(c => new DisplayItem<Classroom>(c, c.ClassroomName)).ToArray());
        }

        private async Task LoadComboBoxCoursesAsync()
        {
            IEnumerable<Course> courses = await _searchEntities.FindAllCoursesAsync();
            ComboBoxCourse.Items.AddRange(courses.Select(c => new DisplayItem<Course>(c, c.CourseName)).ToArray());
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void LabelDelete_Click(object sender, EventArgs e)
        {
            pictureBoxDelete_Click(sender, e);
        }

        private void LabelEditStudent_Click(object sender, EventArgs e)
        {
            pictureBoxEdit_Click(sender, e);
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentForm = Program.Container.Resolve<EditStudentForm>();
            studentForm.ShowDialog();
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentForm = Program.Container.Resolve<DeleteStudentForm>();
            studentForm.ShowDialog();
        }

        private async void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = _createTransientEntities.CreateStudentTransient(this);
                Classroom classroom = await _searchEntities.FindEntityByNameAsync<Classroom>(ComboBoxClassroom.SelectedItem.ToString());
                EntityQuery<Student> studentQuery = await _createEntities.CreateStudentAsync(student);
                MessageBox.Show(studentQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
