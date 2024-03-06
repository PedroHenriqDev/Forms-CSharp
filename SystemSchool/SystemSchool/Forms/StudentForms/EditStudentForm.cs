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

namespace SystemSchool.Forms.StudentForms
{
    public partial class EditStudentForm : Form
    {
        SearchEntitiesBusiness SearchEntities = new SearchEntitiesBusiness();

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
           foreach(Student student in students) 
           {
                string displayName = $"{student.CompleteName.CutCompleteName()} - ({student.Classroom.ClassroomName})";
                listBoxSearch.Items.Add(new DisplayItem<Student>(student, displayName)); 
           }
        }

        private async void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                await LoadListBoxSearchAsync();
            }
        }
    }
}
