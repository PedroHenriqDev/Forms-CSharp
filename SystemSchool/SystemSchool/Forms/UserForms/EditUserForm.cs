using Autofac;
using Entities;
using Entities.Expections;
using Entities.TransientClasses;
using Services;
using System;
using System.Windows.Forms;
using SystemSchool.Controls;

namespace SystemSchool.Forms.UserForms
{
    public partial class EditUserForm : Form
    {

        private readonly EditEntitiesService<User> _editEntities;
        private readonly LoadFormComponents _loadFormComponents;
        public DisplayItem<Group> SelectedGroup => ComboBoxClass.SelectedItem as DisplayItem<Group>;
        public DisplayItem<User> SelectedUser => listBoxSearch.SelectedItem as DisplayItem<User>;
        public string Query => textBoxSearch.Text;

        public EditUserForm(
            EditEntitiesService<User> editEntities,
            LoadFormComponents loadFormComponents)
        {
            _editEntities = editEntities;
            _loadFormComponents = loadFormComponents;
            InitializeComponent();
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                await _loadFormComponents.EditUserLoadClassInUserAsync(this);
                EntityQuery<User> userQuery = await _editEntities.EditUserAsync(SelectedUser.Value);
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

        private async void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            await _loadFormComponents.EditUserLoadListBoxSearchAsync(this);
            LabelSearchResult.Text = $"Result of search '{textBoxSearch.Text}'";
        }

        private async void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedUser != null)
            {
                await _loadFormComponents.EditUserLoadComponentsAsync(this);
            }
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
