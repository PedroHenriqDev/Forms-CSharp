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

        public RegistrationClassroomForm(SearchEntitiesService searchEntities, CreateEntitiesService<Classroom> createEntities)
        {
            InitializeComponent();
            _searchEntities = searchEntities;
            _createEntities = createEntities;
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
            IEnumerable<Course> courses = await _searchEntities.FindAllCoursesAsync();
            ComboBoxCourse.Items.AddRange(courses.Select(c => c.CourseName).ToArray());
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
                string classroomName = ComboBoxSchoolYear.SelectedItem.ToString().Substring(0, 1) + ComboBoxLetter.SelectedItem.ToString();
                Course course = await _searchEntities.FindCourseByNameAsync(ComboBoxCourse.SelectedItem.ToString());
                Random random = new Random();
                Classroom classroom = new Classroom(random.Next(), classroomName, course.Id);
                ClassroomQuery createClassroomQuery = await _createEntities.CreateClassroomAsync(classroom);
                MessageBox.Show(createClassroomQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

