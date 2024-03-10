using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Extensions;
using SystemSchool.Controls;
using Entities.TransientClasses;
using SystemSchool.Expections;
using Autofac;
using Services;
using Services.Exceptions;

namespace SystemSchool.Forms.StudentForms
{
    public partial class EditStudentForm : Form
    {
        private readonly SearchEntitiesService _searchEntities;
        private readonly EditEntitiesService<Student> _editEntities; 
        private readonly FillEntitiesService _fillEntities;

        public EditStudentForm(
            SearchEntitiesService searchEntities,
            EditEntitiesService<Student> editEntities,
            FillEntitiesService fillEntities)
        {
            InitializeComponent();
            _searchEntities = searchEntities;
            _editEntities = editEntities;
            _fillEntities = fillEntities;
        }

        private async Task LoadListBoxSearchAsync()
        {
            IEnumerable<Student> students = await _searchEntities.FindStudentByQueryAsync(textBoxSearch.Text);
            await _fillEntities.FillClassroomInStudentsAsync(students);
            listBoxSearch.Items.Clear();
            foreach (Student student in students)
            {
                string displayName = $"{student.CompleteName.CutCompleteName()} - ({student.Classroom.ClassroomName})";
                listBoxSearch.Items.Add(new DisplayItem<Student>(student, displayName));
            }
        }

        private async Task LoadComboBoxClassroom()
        {
            DisplayItem<Student> student = listBoxSearch.SelectedItem as DisplayItem<Student>;
            ComboBoxClassroom.Text = student.Value.Classroom.ClassroomName;
            ComboBoxClassroom.Items.Clear();
            IEnumerable<Classroom> classrooms = await _searchEntities.FindAllClassroomsAsync();
            await _fillEntities.FillCourseInClassroomAsync(classrooms);
            ComboBoxClassroom.Items.AddRange(classrooms.Select(c => new DisplayItem<Classroom>(c, $"{c.ClassroomName} - {c.Course.CourseName}")).ToArray());
        }

        private async void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            await LoadListBoxSearchAsync();
            LabelSearchResult.Text = $"Result of search '{textBoxSearch.Text}'";
        }

        private async void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSearch.SelectedItem != null)
            {
                FillLabelStudent();
                FillTextBoxStudentName();
                await LoadComboBoxClassroom();
            }
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayItem<Student> student = listBoxSearch.SelectedItem as DisplayItem<Student>;
                student.Value.CompleteName = textBoxStudentName.Text;
                FillClassroomInStudent(student.Value);
                EntityQuery<Student> studentQuery = await _editEntities.EditStudentAsync(student.Value);
                if (studentQuery.Result)
                {
                    LabelStudent.Text = textBoxStudentName.Text;
                }
                MessageBox.Show(studentQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadListBoxSearchAsync();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FillTextBoxStudentName()
        {
            DisplayItem<Student> student = listBoxSearch.SelectedItem as DisplayItem<Student>;
            textBoxStudentName.Text = student.Value.CompleteName;
        }

        private async void FillLabelStudent()
        {
            DisplayItem<Student> student = listBoxSearch.SelectedItem as DisplayItem<Student>;
            LabelStudent.ForeColor = Color.Black;
            student.Value.Classroom = await _searchEntities.FindClassroomByIdAsync(student.Value.ClassroomId);
            student.Value.Classroom.Course = await _searchEntities.FindCourseByIdAsync(student.Value.Classroom.CourseId);
            LabelStudent.Text = $"{student.Value.CompleteName} - {student.Value.Classroom.Course.CourseName} - {student.Value.Classroom.ClassroomName}";
        }

        private async Task FillClassroomInStudent(Student student)
        {
            IEnumerable<Classroom> classrooms = await _searchEntities.FindAllClassroomsAsync();
            if (ComboBoxClassroom.SelectedItem == null && classrooms.Select(c => c.ClassroomName).Any(c => c == ComboBoxClassroom.Text))
            {
                _fillEntities.FillStudentWithClassroom(student, await _searchEntities.FindClassroomByNameAsync(ComboBoxClassroom.Text));
            }
            else
            {
                DisplayItem<Classroom> classroom = ComboBoxClassroom.SelectedItem as DisplayItem<Classroom>;
                _fillEntities.FillStudentWithClassroom(student, await _searchEntities.FindClassroomByNameAsync(classroom.Value.ClassroomName));
            }
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentForm = Program.Container.Resolve<DeleteStudentForm>();
            studentForm.ShowDialog();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            pictureBoxStudent_Click(sender, e);
        }

        private void pictureBoxStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentForm = Program.Container.Resolve<RegistrationStudentForm>();
            studentForm.ShowDialog();
        }

        private void LabelDeleteStudent_Click(object sender, EventArgs e)
        {
            pictureBoxDelete_Click(sender, e);
        }

        private void LabelStudent_Click(object sender, EventArgs e)
        {
            pictureBoxStudent_Click(sender, e);
        }
    }
}
