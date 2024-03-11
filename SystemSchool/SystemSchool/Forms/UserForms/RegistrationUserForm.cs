using Entities;
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

namespace SystemSchool.Forms.UserForms
{
    public partial class RegistrationUserForm : Form
    {

        private readonly SearchEntitiesService _searchEntities;
        private readonly CreateEntitiesService<User> _createEntities;
        private readonly CreateTransientEntities _createTransientEntities;

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
            IEnumerable<Class> classes = await _searchEntities.FindAllClassesAsync();
            ComboBoxClass.Items.Clear();
            ComboBoxClass.Items.AddRange(classes.Select(c => new DisplayItem<Class>(c, c.NameClass)).ToArray());
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
    }
}
