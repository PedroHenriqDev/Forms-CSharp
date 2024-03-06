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
using Business.BusinessLogic;
using Entities;
using Entities.TransientClasses;
using SystemSchool.Controls;

namespace SystemSchool.Forms.StudentForms
{
    public partial class DeleteStudentForm : Form
    {
        SearchEntitiesBusiness SearchEntitiesBusiness = new SearchEntitiesBusiness();
        DeleteEntitiesBusiness<Student> DeleteEntities = new DeleteEntitiesBusiness<Student>();

        public DeleteStudentForm()
        {
            InitializeComponent();
        }

        private async void StudentDeleteForm_Load(object sender, EventArgs e)
        {
            await LoadComboBoxClassroomsAsync();
        }

        private async Task LoadComboBoxClassroomsAsync()
        {
            IEnumerable<Classroom> classrooms = await SearchEntitiesBusiness.FindAllClassroomsAsync();
            foreach (Classroom classroom in classrooms)
            {
                ComboBoxClassroom.Items.Add(classroom.ClassroomName);
            }
        }

        private async void ComboBoxClassroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadListBoxByIndexAsync(ComboBoxClassroom.SelectedItem.ToString());
        }

        private async Task LoadListBoxByIndexAsync(string classroomName)
        {
            IEnumerable<Student> students = await SearchEntitiesBusiness.FindStudentsByClassroomNameAsync(classroomName);
            listBoxStudents.DisplayMember = "CompleteName";
            listBoxStudents.Items.Clear();
            foreach (Student student in students)
            {
                string displayName = $"{student.CompleteName} - ({classroomName})";
                if (!listBoxStudents.Items.Contains(student))
                {
                    listBoxStudents.Items.Add(new ListBoxItem<Student>(student, displayName));
                }
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationStudentForm StudentRegistrationForm = new RegistrationStudentForm();
            StudentRegistrationForm.ShowDialog();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ListBoxItem<Student> student = (ListBoxItem<Student>)listBoxStudents.SelectedItem;
                StudentQuery studentQuery = await DeleteEntities.DeleteStudentAsync(student.Value);
                if (studentQuery.Result)
                {
                    MessageBox.Show(studentQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadListBoxByIndexAsync(ComboBoxClassroom.SelectedItem.ToString()));
                }
                else
                {
                    MessageBox.Show(studentQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
