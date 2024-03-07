using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.BusinessLogic;
using Entities;
using Entities.TransientClasses;
using SystemSchool.Forms.StudentForms;

namespace SystemSchool
{
    public partial class RegistrationStudentForm : Form
    {
        SearchEntitiesBusiness SearchEntities = new SearchEntitiesBusiness();
        CreateEntitiesBusiness<Student> CreateEntities = new CreateEntitiesBusiness<Student>();

        public RegistrationStudentForm()
        {
            InitializeComponent();
        }

        private async void StudentRegistrationForm_Load(object sender, EventArgs e)
        {
            await LoadComboBoxCoursesAsync();
        }

        private async void ComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadComboBoxClassroomAsync(ComboBoxCourse.SelectedItem.ToString());
        }

        private async Task LoadComboBoxClassroomAsync(string courseName)
        {
            IEnumerable<Classroom> classrooms = await SearchEntities.FindClassroomsByCourseNameAsync(courseName);
            ComboBoxClassroom.Items.Clear();
            ComboBoxClassroom.Items.AddRange(classrooms.Select(c => c.ClassroomName).ToArray());
        }

        private async Task LoadComboBoxCoursesAsync()
        {
            IEnumerable<Course> courses = await SearchEntities.FindAllCoursesAsync();
            ComboBoxCourse.Items.AddRange(courses.Select(c => c.CourseName).ToArray());
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
            EditStudentForm editForm = new EditStudentForm();
            editForm.ShowDialog();
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteStudentForm deleteForm = new DeleteStudentForm();
            deleteForm.ShowDialog();
        }

        private async void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                Classroom classroom = await SearchEntities.FindClassroomByNameAsync(ComboBoxClassroom.SelectedItem.ToString());
                Student student = new Student(random.Next(), classroom.ClassroomId, textBoxCompleteName.Text);
                StudentQuery createStudentQuery = await CreateEntities.CreateStudentAsync(student);
                MessageBox.Show(createStudentQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
