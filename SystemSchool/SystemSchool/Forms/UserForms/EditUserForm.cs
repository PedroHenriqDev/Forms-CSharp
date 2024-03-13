using Autofac;
using Business.Extensions;
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
    public partial class EditUserForm : Form
    {

        private readonly SearchEntitiesService _searchEntities;
        private readonly EditEntitiesService<User> _editEntities;
        private readonly CreateTransientEntities _createTransient;
        private readonly FillEntitiesService _fillEntities;

        public EditUserForm(
            SearchEntitiesService searchEntities, 
            EditEntitiesService<User> editEntities, 
            CreateTransientEntities createTransient,
            FillEntitiesService fillEntities)
        {
            _searchEntities = searchEntities;
            _editEntities = editEntities;
            _createTransient = createTransient;
            _fillEntities = fillEntities;
            InitializeComponent();
        }

        private async void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            await LoadListBoxSearchAsync();
            LabelSearchResult.Text = $"Result of search '{textBoxSearch.Text}'";
        }

        private async Task LoadComboBoxClassAsync()
        {
            IEnumerable<Class> classes = await _searchEntities.FindAllClassesAsync();
            ComboBoxClass.Items.Clear();
            ComboBoxClass.Items.AddRange(classes.Select(c => new DisplayItem<Class>(c, c.NameClass.CutCompleteName())).ToArray());
        }

        private async Task LoadListBoxSearchAsync() 
        {
            IEnumerable<User> users = await _searchEntities.FindUsersByQueryAsync(textBoxSearch.Text);
            await _fillEntities.FillUsersWithClassAsync(users);
            listBoxSearch.Items.Clear();
            listBoxSearch.Items.AddRange(users.Select(c => new DisplayItem<User>(c, $"{c.Username} - {c.Class.NameClass}")).ToArray());
        }

        private async void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTextBoxUsername();
            FillComboBoxClass();
            await LoadComboBoxClassAsync();
            await FillLabelUserShowAsync();
        }

        private void FillComboBoxClass() 
        {
            DisplayItem<User> user = listBoxSearch.SelectedItem as DisplayItem<User>;
            ComboBoxClass.Text = user.Value.Class.NameClass;
        }

        private void FillTextBoxUsername() 
        {
            DisplayItem<User> user = listBoxSearch.SelectedItem as DisplayItem<User>;
            textBoxUsername.Text = user.Value.Username;
        }

        private async Task FillLabelUserShowAsync() 
        {
            DisplayItem<User> user = listBoxSearch.SelectedItem as DisplayItem<User>;
            await _fillEntities.FillUserWithClassByIdAsync(user.Value, user.Value.ClassId);
            LabelUserShow.ForeColor = Color.Black;
            LabelUserShow.Text = $"{user.Value.Username} - {user.Value.Class.NameClass}";         
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userForm = Program.Container.Resolve<DeleteUserForm>();
            userForm.ShowDialog();
        }

        private void pictureBoxStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userForm = Program.Container.Resolve<RegistrationUserForm>();
            userForm.ShowDialog();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            pictureBoxStudent_Click(sender, e);
        }

        private void LabelRegisterUser_Click(object sender, EventArgs e)
        {
            pictureBoxStudent_Click(sender, e);
        }

        private void LabelDeleteUser_Click(object sender, EventArgs e)
        {
            pictureBoxDelete_Click(sender, e);
        }
    }
}
