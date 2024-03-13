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
        private readonly EditEntitiesService<Student> _editEntities; 
        private readonly LoadFormComponents _loadFormComponents;

        public EditStudentForm(
            EditEntitiesService<Student> editEntities,
            LoadFormComponents loadFormComponents)
        {
            InitializeComponent();
            _editEntities = editEntities;
            _loadFormComponents = loadFormComponents;
        }

        private async void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            await _loadFormComponents.StudentFormLoadListBoxSearchAsync(this);
            LabelSearchResult.Text = $"Result of search '{textBoxSearch.Text}'";
        }

        private async void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSearch.SelectedItem != null)
            {
                await _loadFormComponents.StudentFormLoadComponentsAsync(this);
            }
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayItem<Student> student = listBoxSearch.SelectedItem as DisplayItem<Student>;
                student.Value.CompleteName = textBoxStudentName.Text;
                await _loadFormComponents.StudentFormLoadClassroomInStudentAsync(this, student.Value);
                EntityQuery<Student> studentQuery = await _editEntities.EditStudentAsync(student.Value);
                if (studentQuery.Result)
                {
                    LabelStudent.Text = textBoxStudentName.Text;
                }
                MessageBox.Show(studentQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
