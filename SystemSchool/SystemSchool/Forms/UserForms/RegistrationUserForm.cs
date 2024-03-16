using Autofac;
using Entities;
using Entities.Expections;
using Entities.TransientClasses;
using Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemSchool.Controls;

namespace SystemSchool.Forms.UserForms
{
    public partial class RegistrationUserForm : Form
    {

        private readonly SearchEntitiesService _searchEntities;
        private readonly CreateEntitiesService<User> _createEntities;
        private readonly CreateTransientEntities _createTransientEntities;
        public string Username => textBoxUsername.Text;
        public string Password => textBoxPassword.Text;
        public DisplayItem<Group> SelectedGroup => ComboBoxClass.SelectedItem as DisplayItem<Group>;

        public RegistrationUserForm(
            SearchEntitiesService searchEntities,
            CreateEntitiesService<User> createEntities,
            CreateTransientEntities createTransientEntities)
        {
            _searchEntities = searchEntities;
            _createEntities = createEntities;
            InitializeComponent();
            _createTransientEntities = createTransientEntities;
        }

        private async void RegistrationUserForm_Load(object sender, EventArgs e)
        {
            await LoadComboBoxClass();
        }

        private async Task LoadComboBoxClass()
        {
            IEnumerable<Group> groups = await _searchEntities.FindAllEntitiesAsync<Group>();
            ComboBoxClass.Items.Clear();
            ComboBoxClass.Items.AddRange(groups.Select(c => new DisplayItem<Group>(c, c.GroupName)).ToArray());
        }

        private async void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                User user = _createTransientEntities.CreateUserTransient(this);
                EntityQuery<User> userQuery = await _createEntities.CreateUserAsync(user);
                MessageBox.Show(userQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(EntityException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userForm = Program.Container.Resolve<EditUserForm>();
            userForm.ShowDialog();
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userForm = Program.Container.Resolve<DeleteUserForm>();
            userForm.ShowDialog();
        }

        private void LabelDeleteUser_Click(object sender, EventArgs e)
        {
            pictureBoxDelete_Click(sender, e);
        }

        private void LabelEditStudent_Click(object sender, EventArgs e)
        {
            pictureBoxEdit_Click(sender, e);
        }
    }
}
