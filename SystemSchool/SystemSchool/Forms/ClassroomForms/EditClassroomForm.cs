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

namespace SystemSchool.Forms.ClassroomForms
{
    public partial class EditClassroomForm : Form
    {
        private readonly SearchEntitiesService _searchEntities;
        private readonly FillEntitiesService _fillEntities;

        public EditClassroomForm(SearchEntitiesService searchEntitiesService, FillEntitiesService fillEntities) 
        {
            _searchEntities = searchEntitiesService;
            _fillEntities = fillEntities;
            InitializeComponent();
        }

        private async void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            await LoadListBoxSearchAsync();
            LabelSearchResult.Text = $"Result of Search '{textBoxSearch.Text}'";
        }

        private async Task LoadListBoxSearchAsync() 
        {
            IEnumerable<Classroom> classrooms = await _searchEntities.FindAllClassroomsAsync();
            await _fillEntities.FillCourseInClassroomAsync(classrooms);
            classrooms = await _searchEntities.FindClassroomByQueryAsync(textBoxSearch.Text, classrooms);
            listBoxSearch.Items.Clear();
            listBoxSearch.Items.AddRange(classrooms.Select(c => new DisplayItem<Classroom>(c, $"{c.ClassroomName} - {c.Course.CourseName}")).ToArray());  
        }
    }
}
