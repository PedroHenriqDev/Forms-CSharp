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

        private async void ComboBoxSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            string schoolYear = ComboBoxSchoolYear.SelectedItem.ToString().Substring(0, 1);
            await LoadComboBoxLetterAsnyc(schoolYear);
            LabelClassroomNameShow.Enabled = true;
            LabelClassroomNameShow.Text = schoolYear + "º";
        }

        private async Task LoadComboBoxLetterAsnyc(string schoolYear) 
        {
            IEnumerable<char> availableLetters = await SearchEntities.FindLettersAvailableBySchoolYearAsync(schoolYear);
            foreach(var letter in availableLetters) 
            {
                ComboBoxLetter.Items.Add(letter);
            }
        }

        private void ComboBoxLetter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string labelClassroomName = LabelClassroomNameShow.Text.Substring(0, 2);
            labelClassroomName += ComboBoxLetter.Text.ToString().Substring(0, 1);
            LabelClassroomNameShow.Text = labelClassroomName;
        }
    }
}
