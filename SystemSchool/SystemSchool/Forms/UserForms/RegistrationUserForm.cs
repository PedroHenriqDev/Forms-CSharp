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
    public partial class RegistrationUserForm : Form
    {

        private readonly SearchEntitiesService _searchEntities;
        private readonly CreateEntitiesService<User> _createEntities;


        public RegistrationUserForm(SearchEntitiesService searchEntities, CreateEntitiesService<User> createEntities)
        {
            _searchEntities = searchEntities;
            _createEntities = createEntities;
            InitializeComponent();
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
    }
}
