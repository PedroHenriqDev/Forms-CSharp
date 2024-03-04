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
        }

        private async void ComboBoxLetter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void ComboBoxSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadComboBoxLetterAsnyc(ComboBoxSchoolYear.SelectedIndex.ToString().Substring(0, 1));
        }

        private async Task LoadComboBoxLetterAsnyc(string schoolYear) 
        {
            await SearchEntities.FindLettersAvailableBySchoolYearAsync(schoolYear);
        }

    }
}
