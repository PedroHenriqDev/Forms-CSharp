using Business.BusinessLogic;
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

namespace SystemSchool.Forms.ClassroomForms
{
    public partial class RegistrationClassroomForm : Form
    {
        private readonly SearchEntitiesBusiness SearchEntities = new SearchEntitiesBusiness();

        public RegistrationClassroomForm()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private async void RegistrationClassroomForm_Load(object sender, EventArgs e)
        {
            await LoadComboBoxCourseAsync();
        }

        private async Task LoadComboBoxLetterAsnyc(string schoolYear)
        {
            IEnumerable<char> availableLetters = await SearchEntities.FindLettersAvailableBySchoolYearAsync(schoolYear);
            foreach (var letter in availableLetters)
            {
                ComboBoxLetter.Items.Add(letter);
            }
        }

        private async Task LoadComboBoxCourseAsync()
        {
            IEnumerable<Course> courses = await SearchEntities.FindAllCoursesAsync();
            foreach (var course in courses) 
            {
                ComboBoxCourse.Items.Add(course.CourseName);
            }
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
            LabelCourseNameShow.Text = ComboBoxCourse.SelectedItem.ToString();
        }
    }
}
