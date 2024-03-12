using Autofac;
using Entities;
using Entities.Expections;
using Entities.TransientClasses;
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
using SystemSchool.Helpers;

namespace SystemSchool.Forms.UserForms
{
    public partial class DeleteUserForm : Form
    {
        private readonly SearchEntitiesService _searchEntities;
        private readonly DeleteEntitiesService<User> _deleteEntities;
        private readonly DataAccess _dataAccess;

        public DeleteUserForm(
            SearchEntitiesService searchEntities,
            DeleteEntitiesService<User> deleteEntities,
            DataAccess dataAccess)
        {
            _searchEntities = searchEntities;
            _deleteEntities = deleteEntities;
            _dataAccess = dataAccess;
            InitializeComponent();
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
            DisplayItem<Class> displayClass = ComboBoxClasses.SelectedItem as DisplayItem<Class>;
            IEnumerable<User> users = await _searchEntities.FindUsersByClassAsync(displayClass.Value);
            users = _dataAccess.RemoveCurrentUserFromSet(users);
            listBoxUsers.Items.Clear();
            listBoxUsers.Items.AddRange(users.Select(u => new DisplayItem<User>(u, u.Username)).ToArray());
        }

        private async void ComboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadListBoxUsersAsync();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayItem<User> user = listBoxUsers.SelectedItem as DisplayItem<User>;
                EntityQuery<User> userQuery = await _deleteEntities.DeleteUserAsync(user.Value);
                await LoadListBoxUsersAsync();
                MessageBox.Show(userQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(EntityException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userForm = Program.Container.Resolve<EditUserForm>();
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

        private void LabelEditStudent_Click(object sender, EventArgs e)
        {
            pictureBoxEdit_Click(sender, e);
        }

        private void LabelCreateUser_Click(object sender, EventArgs e)
        {
            pictureBoxStudent_Click(sender, e);
        }
    }
}
