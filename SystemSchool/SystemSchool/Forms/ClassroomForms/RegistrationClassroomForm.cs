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
using Datas;
using Entities.TransientClasses;
using SystemSchool.Controls;
using Entities.Expections;
using Services;
using Autofac;

namespace SystemSchool.Forms.ClassroomForms
{
    public partial class RegistrationClassroomForm : Form
    {
        private readonly SearchEntitiesService _searchEntities;
        private readonly CreateEntitiesService<Classroom> _createEntities;
        private readonly CreateTransientEntities _createTransientEntities;

        public RegistrationClassroomForm(
            SearchEntitiesService searchEntities, 
            CreateEntitiesService<Classroom> createEntities,
            CreateTransientEntities createTransientEntities)
        {
            InitializeComponent();
            _searchEntities = searchEntities;
            _createEntities = createEntities;
            _createTransientEntities = createTransientEntities;
        }

        private async void RegistrationClassroomForm_Load(object sender, EventArgs e)
        {
            await LoadComboBoxCourseAsync();
        }

        private async Task LoadComboBoxLetterAsnyc(string schoolYear)
        {
            IEnumerable<char> availableLetters = await _searchEntities.FindLettersAvailableBySchoolYearAsync(schoolYear);
            ComboBoxLetter.Items.Clear();
            foreach (char letter in availableLetters)
            {
                ComboBoxLetter.Items.Add(letter);
            }
        }

        private async Task LoadComboBoxCourseAsync()
        {
            IEnumerable<Course> courses = await _searchEntities.FindAllEntitiesAsync<Course>();
            ComboBoxCourse.Items.AddRange(courses.Select(c => new DisplayItem<Course>(c, c.CourseName)).ToArray());
        }

        private async void ComboBoxSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            string schoolYear = ComboBoxSchoolYear.SelectedItem.ToString().Substring(0, 1);
            await LoadComboBoxLetterAsnyc(schoolYear);
            LabelClassroomNameShow.ForeColor = Color.White;
            LabelClassroomNameShow.Text = schoolYear + "º";
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

        private void LabelDeleteClassroom_Click(object sender, EventArgs e)
        {
            pictureBoxDelete_Click(sender, e);
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var classroomForm = Program.Container.Resolve<EditClassroomForm>();
            classroomForm.ShowDialog();
        }
    }
}

