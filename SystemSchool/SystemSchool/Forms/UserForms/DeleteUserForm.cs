using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemSchool.Controls;

namespace SystemSchool.Forms.UserForms
{
    public partial class DeleteUserForm : Form
    {

        private readonly SearchEntitiesService _searchEntities;

        public DeleteUserForm(SearchEntitiesService searchEntities)
        {
            _searchEntities = searchEntities;
            InitializeComponent();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private async void DeleteUserForm_Load(object sender, EventArgs e)
        {
            await LoadComboBoxClassAsync();
        }

        private async Task LoadComboBoxClassAsync() 
        {
            IEnumerable<Class> classes = await _searchEntities.FindAllClassesAsync();
            ComboBoxClasses.Items.Clear();
            ComboBoxClasses.Items.AddRange(classes.Select(c => new DisplayItem<Class>(c, c.NameClass)).ToArray());
        }

        private async Task LoadListBoxUsersAsync() 
        {
        }
    }
}
