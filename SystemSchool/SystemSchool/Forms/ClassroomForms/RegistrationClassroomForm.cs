using System;
using System.Drawing;
using System.Windows.Forms;
using Entities;
using Entities.TransientClasses;
using SystemSchool.Controls;
using Entities.Expections;
using Services;
using Autofac;

namespace SystemSchool.Forms.ClassroomForms
{
    public partial class RegistrationClassroomForm : Form
    {
        private readonly CreateEntitiesService<Classroom> _createEntities;
        private readonly CreateTransientEntities _createTransientEntities;
        private readonly LoadFormComponents _loadFormComponents;
        public DisplayItem<Course> Course => ComboBoxCourse.SelectedItem as DisplayItem<Course>;
        public string SchoolYear => ComboBoxSchoolYear.SelectedItem.ToString().Substring(0, 1);

        public RegistrationClassroomForm(
            CreateEntitiesService<Classroom> createEntities,
            CreateTransientEntities createTransientEntities,
            LoadFormComponents loadFormComponents)
        {
            _createEntities = createEntities;
            _createTransientEntities = createTransientEntities;
            _loadFormComponents = loadFormComponents;
            InitializeComponent();
        }

        private async void RegistrationClassroomForm_Load(object sender, EventArgs e)
        {
            await _loadFormComponents.RegistrationClassroomLoadComboBoxCourseAsync(this);
        }

        private async void ComboBoxSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _loadFormComponents.RegistrationClassroomLoadComboBoxLetterAsnyc(this);
            LabelClassroomNameShow.ForeColor = Color.White;
            LabelClassroomNameShow.Text = SchoolYear + "º";
        }

        private void ComboBoxLetter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string labelClassroomName = LabelClassroomNameShow.Text.Substring(0, 2);
            labelClassroomName += ComboBoxLetter.Text.ToString().Substring(0, 1);
            LabelClassroomNameShow.Text = labelClassroomName;
        }

        private void ComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelCourseNameShow.ForeColor = Color.White;
            LabelPreview.ForeColor = Color.White;
            LabelCourseNameShow.Text = ComboBoxCourse.SelectedItem.ToString();
        }

        private async void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Classroom classroom = _createTransientEntities.CreateClassroomTransient(this);
                EntityQuery<Classroom> classroomQuery = await _createEntities.CreateClassroomAsync(classroom);
                MessageBox.Show(classroomQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            var deleteForm = Program.Container.Resolve<DeleteClassroomForm>();
            deleteForm.ShowDialog();
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
            var classroomForm = Program.Container.Resolve<EditClassroomForm>();
            classroomForm.ShowDialog();
        }

        private void LabelDeleteClassroom_Click(object sender, EventArgs e)
        {
            pictureBoxDelete_Click(sender, e);
        }
    }
}

