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

        private async Task LoadListBoxSearchAsync() 
        {
            IEnumerable<User> users = await _searchEntities.FindUsersByQueryAsync(textBoxSearch.Text);
            await _fillEntities.FillUsersWithClassAsync(users);
            listBoxSearch.Items.Clear();
            listBoxSearch.Items.AddRange(users.Select(c => new DisplayItem<User>(c, $"{c.Username} - {c.Class.NameClass}")).ToArray());
        }
    }
}
