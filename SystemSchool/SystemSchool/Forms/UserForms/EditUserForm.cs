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

        private readonly EditEntitiesService<User> _editEntities;
        private readonly LoadFormComponents _loadFormComponents;

        public EditUserForm(
            EditEntitiesService<User> editEntities, 
            LoadFormComponents loadFormComponents)
        {
            _editEntities = editEntities;
            _loadFormComponents = loadFormComponents;
            InitializeComponent();
        }

        private async void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        { 
            await _loadFormComponents.UserFormLoadListBoxSearchAsync(this);
            LabelSearchResult.Text = $"Result of search '{textBoxSearch.Text}'";
        }

        private async void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _loadFormComponents.UserFormLoadComponentsAsync(this);
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
