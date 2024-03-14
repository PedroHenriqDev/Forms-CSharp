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
        private readonly DeleteEntitiesService<User> _deleteEntities;
        private readonly LoadFormComponents _loadFormComponents;
        public DisplayItem<Class> SelectedClass => ComboBoxClasses.SelectedItem as DisplayItem<Class>;

        public DeleteUserForm(
            DeleteEntitiesService<User> deleteEntities,
            LoadFormComponents loadFormComponents)
        {
            _deleteEntities = deleteEntities;
            InitializeComponent();
            _loadFormComponents = loadFormComponents;
        }

        private async void DeleteUserForm_Load(object sender, EventArgs e)
        {
            await _loadFormComponents.DeleteUserLoadComboBoxClassAsync(this);
        }

        private async void ComboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _loadFormComponents.DeleteUserLoadListBoxUsersAsync(this);
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayItem<User> user = listBoxUsers.SelectedItem as DisplayItem<User>;
                EntityQuery<User> userQuery = await _deleteEntities.DeleteEntityAsync(user.Value);
                await _loadFormComponents.DeleteUserLoadListBoxUsersAsync(this);
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
