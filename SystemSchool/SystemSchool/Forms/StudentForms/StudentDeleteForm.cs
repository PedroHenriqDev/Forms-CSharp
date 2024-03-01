using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.BusinessLogic;
using Entities;

namespace SystemSchool.Forms.StudentForms
{
    public partial class StudentDeleteForm : Form
    {
        SearchEntitiesBusiness SearchEntitiesBusiness = new SearchEntitiesBusiness();

        public StudentDeleteForm()
        {
            InitializeComponent();
        }

        private async void StudentDeleteForm_Load(object sender, EventArgs e)
        {
            await LoadComboBoxClassroomsAsync();
            await LoadListBoxStudentsAsync();

        }

        private async Task LoadComboBoxClassroomsAsync() 
        {
            IEnumerable<Classroom> classrooms = await SearchEntitiesBusiness.FindAllClassroomsAsync();
            foreach (Classroom classroom in classrooms)
            {
                comboBoxClassroom.Items.Add(classroom.ClassroomName);
            }
        }

        private async Task LoadListBoxStudentsAsync() 
        {
            IEnumerable<Student> students = await SearchEntitiesBusiness.FindAllStudentsAsync();
            foreach (Student student in students) 
            {
                listBoxStudents.Items.Add(student);
            }
        }
    }
}
