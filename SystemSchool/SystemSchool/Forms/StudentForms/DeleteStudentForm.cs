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
        private readonly SearchEntitiesService SearchEntities;
        private readonly DeleteEntitiesService<Student> DeleteEntities;

        public DeleteStudentForm(SearchEntitiesService searchEntities, DeleteEntitiesService<Student> deleteEntities)
        {
            InitializeComponent();
            SearchEntities= searchEntities;
            DeleteEntities = deleteEntities;
        }

        private async void StudentDeleteForm_Load(object sender, EventArgs e)
        {
            await LoadComboBoxClassroomsAsync();
        }

        private async void ComboBoxClassroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadListBoxByIndexAsync(ComboBoxClassroom.SelectedItem.ToString());
        }

        private async Task LoadComboBoxClassroomsAsync()
        {
            IEnumerable<Classroom> classrooms = await SearchEntities.FindAllClassroomsAsync();
            ComboBoxClassroom.Items.AddRange(classrooms.Select(c => c.ClassroomName).ToArray());
        }

        private async Task LoadListBoxByIndexAsync(string classroomName)
        {
            IEnumerable<Student> students = await SearchEntities.FindStudentsByClassroomNameAsync(classroomName);
            listBoxStudents.Items.Clear();
            foreach (Student student in students)
            {
                string displayName = $"{student.CompleteName} - ({classroomName})";
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
                StudentQuery studentQuery = await DeleteEntities.DeleteStudentAsync(student.Value);
                MessageBox.Show(studentQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadListBoxByIndexAsync(ComboBoxClassroom.SelectedItem.ToString());
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
