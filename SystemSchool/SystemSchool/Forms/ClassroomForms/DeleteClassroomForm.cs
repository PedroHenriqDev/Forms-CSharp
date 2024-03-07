﻿using Business.BusinessLogic;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSchool.Controls;
using System.Windows.Forms;

namespace SystemSchool.Forms.ClassroomForms
{
    public partial class DeleteClassroomForm : Form
    {
        SearchEntitiesBusiness SearchEntities = new SearchEntitiesBusiness();
        DeleteEntitiesBusiness<Classroom> DeleteEntities = new DeleteEntitiesBusiness<Classroom>();

        public DeleteClassroomForm()
        {
            InitializeComponent();
        }

        private async void DeleteClassroomForm_Load(object sender, EventArgs e)
        {
            await LoadComboBoxCourseAsync();
        }


        private async void ComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadListBoxClassroomsAsync();
            await LoadComboBoxCourseAsync();
        }

        private async Task LoadComboBoxCourseAsync()
        {
           IEnumerable<Course> courses = await SearchEntities.FindAllCoursesAsync();
           ComboBoxCourse.Items.Clear();
           ComboBoxCourse.Items.AddRange(courses.Select(c => c.CourseName).ToArray());
        }

        private async Task LoadListBoxClassroomsAsync()
        {
            IEnumerable<Classroom> classrooms = await SearchEntities.FindClassroomsByCourseNameAsync(ComboBoxCourse.SelectedItem.ToString());
            listBoxClassrooms.Items.Clear();
            foreach (Classroom classroom in classrooms)
            {
                listBoxClassrooms.Items.Add(new DisplayItem<Classroom>(classroom, classroom.ClassroomName));
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationClassroomForm registrationForm = new RegistrationClassroomForm();
            registrationForm.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DisplayItem<Course> course = DeleteEntities.
        }
    }
}