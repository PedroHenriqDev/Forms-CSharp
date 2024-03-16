using System;
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
        private readonly LoadFormComponents _loadFormComponents;
        private readonly CreateEntitiesService<Student> _createEntities;
        private readonly CreateTransientEntities _createTransientEntities;
        public string CompleteName => textBoxCompleteName.Text;
        public DisplayItem<Course> SelectedCourse => ComboBoxCourse.SelectedItem as DisplayItem<Course>;
        public DisplayItem<Classroom> SelectedClassroom => ComboBoxClassroom.SelectedItem as DisplayItem<Classroom>;

        public RegistrationStudentForm(
            SearchEntitiesService searchEntities,
            LoadFormComponents loadFormComponents,
            CreateEntitiesService<Student> createServices, 
            CreateTransientEntities createTransientEntities) 
        {
            _searchEntities = searchEntities;
            _loadFormComponents = loadFormComponents;
            _createEntities = createServices;
            _createTransientEntities = createTransientEntities;
            InitializeComponent();
        }

        private async void StudentRegistrationForm_Load(object sender, EventArgs e)
        {
            await _loadFormComponents.RegistrationStudentLoadComboBoxCoursesAsync(this);
        }

        private async void ComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _loadFormComponents.RegistrationStudentLoadComboBoxClassroomAsync(this);
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

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
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

        private void LabelDelete_Click(object sender, EventArgs e)
        {
            pictureBoxDelete_Click(sender, e);
        }

        private void LabelEditStudent_Click(object sender, EventArgs e)
        {
            pictureBoxEdit_Click(sender, e);
        }
    }
}
