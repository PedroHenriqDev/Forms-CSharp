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
using Services.Exceptions;
using Autofac;

namespace SystemSchool.Forms.ClassroomForms
{
    public partial class EditClassroomForm : Form
    {
        private readonly SearchEntitiesService _searchEntities;
        private readonly FillEntitiesService _fillEntities;
        private readonly EditEntitiesService<Classroom> _editEntities;

        public EditClassroomForm(
            SearchEntitiesService searchEntitiesService, 
            FillEntitiesService fillEntities,
            EditEntitiesService<Classroom> editEntities)
        {
            _searchEntities = searchEntitiesService;
            _fillEntities = fillEntities;
            _editEntities = editEntities;
            InitializeComponent();
        }

        private async void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            await LoadListBoxSearchAsync();
            LabelSearchResult.Text = $"Result of Search '{textBoxSearch.Text}'";
        }

        private async Task LoadListBoxSearchAsync() 
        {
            IEnumerable<Classroom> classrooms = await _searchEntities.FindAllEntitiesAsync<Classroom>();
            await _fillEntities.FillCourseInClassroomAsync(classrooms);
            classrooms = await _searchEntities.FindClassroomByQueryAsync(textBoxSearch.Text, classrooms);
            listBoxSearch.Items.Clear();
            listBoxSearch.Items.AddRange(classrooms.Select(c => new DisplayItem<Classroom>(c, $"{c.ClassroomName} - {c.Course.CourseName}")).ToArray());  
        }

        private async Task LoadComboBoxCourseAsync() 
        {
            IEnumerable<Course> courses = await _searchEntities.FindAllEntitiesAsync<Course>();
            DisplayItem<Classroom> classroom = listBoxSearch.SelectedItem as DisplayItem<Classroom>;
            ComboBoxCourse.Items.Clear();
            ComboBoxCourse.Text = classroom.Value.Course.CourseName;
            ComboBoxCourse.Items.AddRange(courses.Select(c => new DisplayItem<Course>(c, c.CourseName)).ToArray());
        }

        private async void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadComboBoxCourseAsync();
            FillLabelClassroomAndCourse();
        }

        private void FillLabelClassroomAndCourse() 
        {
            DisplayItem<Classroom> classroom = listBoxSearch.SelectedItem as DisplayItem<Classroom>;
            LabelClassroomAndCourse.ForeColor = Color.Black;
            LabelClassroomAndCourse.Text = $"{classroom.Value.ClassroomName} - {classroom.Value.Course.CourseName}";
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayItem<Course> course = ComboBoxCourse.SelectedItem as DisplayItem<Course>;
                DisplayItem<Classroom> classroom = listBoxSearch.SelectedItem as DisplayItem<Classroom>;
                _fillEntities.FillClassroomWithCourse(classroom.Value, course.Value);
                EntityQuery<Classroom> classroomQuery = await _editEntities.EditClassroomAsync(classroom.Value);
                MessageBox.Show(classroomQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadListBoxSearchAsync();
            }
            catch (FillException ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            var classroomForm = Program.Container.Resolve<DeleteClassroomForm>();
            classroomForm.ShowDialog();
        }

        private void pictureBoxStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            var classroomForm = Program.Container.Resolve<RegistrationClassroomForm>();
            classroomForm.ShowDialog();
        }
    }
}
