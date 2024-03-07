using Business.BusinessLogic;
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

namespace SystemSchool.Forms.StudentForms
{
    public partial class EditStudentForm : Form
    {
        SearchEntitiesBusiness SearchEntities = new SearchEntitiesBusiness();
        EditEntitiesBusiness<Student> EditEntities = new EditEntitiesBusiness<Student>();

        public EditStudentForm()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private async Task LoadListBoxSearchAsync()
        {
            IEnumerable<Student> students = await SearchEntities.FindStudentByQueryAsync(textBoxSearch.Text);
            listBoxSearch.Items.Clear();
            foreach (Student student in students)
            {
                string displayName = $"{student.CompleteName.CutCompleteName()} - ({student.Classroom.ClassroomName})";
                listBoxSearch.Items.Add(new DisplayItem<Student>(student, displayName));
            }
        }

        private async void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await LoadListBoxSearchAsync();
            }
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

        private void FillTextBoxStudentName()
        {
            DisplayItem<Student> student = listBoxSearch.SelectedItem as DisplayItem<Student>;
            textBoxStudentName.Text = student.Value.CompleteName;
        }

        private async Task LoadComboBoxClassroom()
        {
            DisplayItem<Student> student = listBoxSearch.SelectedItem as DisplayItem<Student>;
            ComboBoxClassroom.Text = student.Value.Classroom.ClassroomName;
            ComboBoxClassroom.Items.Clear();
            IEnumerable<Classroom> classrooms = await SearchEntities.FindAllClassroomsAsync();
            ComboBoxClassroom.Items.AddRange(classrooms.Select(c => c.ClassroomName).ToArray());
        }

        private void FillLabelStudent()
        {
            DisplayItem<Student> student = listBoxSearch.SelectedItem as DisplayItem<Student>;
            LabelStudent.ForeColor = Color.Black;
            LabelStudent.Text = student.Value.CompleteName;
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayItem<Student> student = listBoxSearch.SelectedItem as DisplayItem<Student>;
                student.Value.CompleteName = textBoxStudentName.Text;
                FillStudent(student.Value);
                StudentQuery studentQuery = await EditEntities.EditStudentAsync(student.Value);
                MessageBox.Show(studentQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadListBoxSearchAsync();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(EntityException ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task FillStudent(Student student)
        {
            IEnumerable<Classroom> classrooms = await SearchEntities.FindAllClassroomsAsync();
            if (ComboBoxClassroom.SelectedItem == null && classrooms.Select(c => c.ClassroomName).Any(c => c == student.Classroom.ClassroomName))
            {
                student.Classroom.ClassroomName = ComboBoxClassroom.Text;
            }
            else
            {
                student.Classroom.ClassroomName = ComboBoxClassroom.SelectedItem.ToString();
            }
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteStudentForm deleteForm = new DeleteStudentForm();
            deleteForm.ShowDialog();
        }

        private void pictureBoxStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationStudentForm registerForm = new RegistrationStudentForm();
            registerForm.ShowDialog();
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
