using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Entities.TransientClasses;
using SystemSchool.Controls;
using Services;
using Autofac;

namespace SystemSchool.Forms.StudentForms
{
    public partial class DeleteStudentForm : Form
    {
        private readonly SearchEntitiesService _searchEntities;
        private readonly DeleteEntitiesService<Student> _deleteEntities;

        public DeleteStudentForm(SearchEntitiesService searchEntities, DeleteEntitiesService<Student> deleteEntities)
        {
            InitializeComponent();
            _searchEntities= searchEntities;
            _deleteEntities = deleteEntities;
        }

        private async void StudentDeleteForm_Load(object sender, EventArgs e)
        {
            await LoadComboBoxClassroomsAsync();
        }

        private async void ComboBoxClassroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadListBoxByIndexAsync();
        }

        private async Task LoadComboBoxClassroomsAsync()
        {
            IEnumerable<Classroom> classrooms = await _searchEntities.FindAllClassroomsAsync();
            ComboBoxClassroom.Items.AddRange(classrooms.Select(c => new DisplayItem<Classroom>(c, c.ClassroomName)).ToArray());
        }

        private async Task LoadListBoxByIndexAsync()
        {
            DisplayItem<Classroom> classroom = ComboBoxClassroom.SelectedItem as DisplayItem<Classroom>;
            IEnumerable<Student> students = await _searchEntities.FindStudentsByClassroomNameAsync(classroom.Value);
            listBoxStudents.Items.Clear();
            foreach (Student student in students)
            {
                string displayName = $"{student.CompleteName} - ({classroom.Value.ClassroomName})";
                if (!listBoxStudents.Items.Contains(student))
                {
                    listBoxStudents.Items.Add(new DisplayItem<Student>(student, displayName));
                }
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayItem<Student> student = (DisplayItem<Student>)listBoxStudents.SelectedItem;
                EntityQuery<Student> studentQuery = await _deleteEntities.DeleteStudentAsync(student.Value);
                MessageBox.Show(studentQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadListBoxByIndexAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentForm = Program.Container. Resolve<EditStudentForm>();
            studentForm.ShowDialog();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentForm = Program.Container.Resolve<RegistrationStudentForm>();
            studentForm.ShowDialog();
        }

        private void pictureBoxStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentForm = Program.Container.Resolve<RegistrationStudentForm>();
            studentForm.ShowDialog();
        }

        private void LabelEditStudent_Click(object sender, EventArgs e)
        {
            pictureBoxEdit_Click(sender, e);
        }

        private void LabelRegisterStudent_Click(object sender, EventArgs e)
        {
            pictureBoxStudent_Click(sender, e);
        }
    }
}
