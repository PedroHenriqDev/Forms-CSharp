using Business.Extensions;
using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemSchool.Forms.ClassroomForms;
using SystemSchool.Forms.StudentForms;
using SystemSchool.Forms.UserForms;
using SystemSchool.Helpers;

namespace SystemSchool.Controls
{
    public class LoadFormComponents
    {
        private readonly SearchEntitiesService _searchEntities;
        private readonly FillEntitiesService _fillEntities;
        private readonly DataAccess _dataAccess;

        public LoadFormComponents(
            SearchEntitiesService searchEntities,
            FillEntitiesService fillEntities,
            DataAccess dataAccess)
        {
            _searchEntities = searchEntities;
            _fillEntities = fillEntities;
            _dataAccess = dataAccess;
        }

        public async Task EditUserLoadComponentsAsync(EditUserForm editUserForm)
        {
            EditUserLoadComboBoxClass(editUserForm);
            EditUserLoadTextBoxUsername(editUserForm);
            EditUserLoadLabelUserShow(editUserForm);
            await EditUserLoadComboBoxClassAsync(editUserForm);
        }

        public void EditUserLoadComboBoxClass(EditUserForm editUserForm) 
        {
            DisplayItem<User> user = editUserForm.listBoxSearch.SelectedItem as DisplayItem<User>;
            editUserForm.ComboBoxClass.Text = user.Value.Class.NameClass;
        }

        public void EditUserLoadTextBoxUsername(EditUserForm editUserForm) 
        {
            editUserForm.textBoxUsername.Text = editUserForm.SelectedUser.Value.Username;
        }

        public void EditUserLoadLabelUserShow(EditUserForm editUserForm) 
        {
            editUserForm.LabelUserShow.ForeColor = Color.Black;
            editUserForm.LabelUserShow.Text = $"{editUserForm.SelectedUser.Value.Username} - {editUserForm.SelectedUser.Value.Class.NameClass}";
        }

        public async Task EditUserLoadComboBoxClassAsync(EditUserForm editUserForm)
        {
            IEnumerable<Class> classes = await _searchEntities.FindAllClassesAsync();
            editUserForm.ComboBoxClass.Items.Clear();
            editUserForm.ComboBoxClass.Items.AddRange(classes.Select(c => new DisplayItem<Class>(c, c.NameClass.CutCompleteName())).ToArray());
        }

        public async Task EditUserLoadListBoxSearchAsync(EditUserForm editUserForm)
        {
            IEnumerable<User> users = await _searchEntities.FindUsersByQueryAsync(editUserForm.Query);
            await _fillEntities.FillUsersWithClassAsync(users);
            users = _dataAccess.RemoveCurrentUserFromSet(users);
            editUserForm.listBoxSearch.Items.Clear();
            editUserForm.listBoxSearch.Items.AddRange(users.Select(c => new DisplayItem<User>(c, $"{c.Username.CutCompleteName()} - {c.Class.NameClass}")).ToArray());
        }

        public async Task EditUserLoadClassInUserAsync(EditUserForm editUserForm)
        {
            IEnumerable<Class> classes = await _searchEntities.FindAllClassesAsync();
            if (editUserForm.ComboBoxClass.SelectedItem == null && classes.Select(c => c.NameClass).Any(c => c == editUserForm.ComboBoxClass.Text))
            {
                Class cls = await _searchEntities.FindClassByNameAsync(editUserForm.ComboBoxClass.Text);
                editUserForm.SelectedUser.Value.ClassId = cls.Id;
                editUserForm.SelectedUser.Value.Class = cls;
            }
            else
            {
                DisplayItem<Class> cls = editUserForm.ComboBoxClass.SelectedItem as DisplayItem<Class>;
                editUserForm.SelectedUser.Value.ClassId = editUserForm.Cls.Value.Id;
                editUserForm.SelectedUser.Value.Class = editUserForm.Cls.Value;
            }
        }

        public async Task EditStudentLoadComponentsAsync(EditStudentForm editStudentForm) 
        {
            EditStudentLoadTextBoxStudentName(editStudentForm);
            await EditStudentLoadComboBoxClassroomAsync(editStudentForm);
            await EditStudentLoadLabelStudentAsync(editStudentForm);
        }

        public async Task EditStudentLoadListBoxSearchAsync(EditStudentForm editStudentForm)
        {
            IEnumerable<Student> students = await _searchEntities.FindStudentByQueryAsync(editStudentForm.textBoxSearch.Text);
            await _fillEntities.FillClassroomInStudentsAsync(students);
            editStudentForm.listBoxSearch.Items.Clear();
            foreach (Student student in students)
            {
                string displayName = $"{student.CompleteName.CutCompleteName()} - ({student.Classroom.ClassroomName})";
                editStudentForm.listBoxSearch.Items.Add(new DisplayItem<Student>(student, displayName));
            }
        }

        public void EditStudentLoadTextBoxStudentName(EditStudentForm editStudentForm)
        {
            editStudentForm.textBoxStudentName.Text = editStudentForm.SelectedStudent.Value.CompleteName;
        }

        public async Task EditStudentLoadLabelStudentAsync(EditStudentForm editStudentForm)
        {
            editStudentForm.LabelStudent.ForeColor = Color.Black;
            editStudentForm.SelectedStudent.Value.Classroom = await _searchEntities.FindEntityByIdAsync<Classroom>(editStudentForm.SelectedStudent.Value.ClassroomId);
            editStudentForm.SelectedStudent.Value.Classroom.Course = await _searchEntities.FindEntityByIdAsync<Course>(editStudentForm.SelectedStudent.Value.Classroom.CourseId);
            editStudentForm.LabelStudent.Text = $"{editStudentForm.SelectedStudent.Value.CompleteName} - {editStudentForm.SelectedStudent.Value.Classroom.Course.CourseName} - {editStudentForm.SelectedStudent.Value.Classroom.ClassroomName}";
        }

        public async Task EditStudentLoadClassroomInStudentAsync(EditStudentForm editStudentForm, Student student)
        {
            IEnumerable<Classroom> classrooms = await _searchEntities.FindAllEntitiesAsync<Classroom>();
            if (editStudentForm.ComboBoxClassroom.SelectedItem == null && classrooms.Select(c => c.ClassroomName).Any(c => c == editStudentForm.ComboBoxClassroom.Text))
            {
                _fillEntities.FillStudentWithClassroom(student, await _searchEntities.FindEntityByNameAsync<Classroom>(editStudentForm.ComboBoxClassroom.Text));
            }
            else
            {
                DisplayItem<Classroom> classroom = editStudentForm.ComboBoxClassroom.SelectedItem as DisplayItem<Classroom>;
                _fillEntities.FillStudentWithClassroom(student, await _searchEntities.FindEntityByNameAsync<Classroom>(classroom.Value.ClassroomName));
            }
        }

        public async Task EditStudentLoadComboBoxClassroomAsync(EditStudentForm editStudentForm)
        {
            editStudentForm.ComboBoxClassroom.Text = editStudentForm.SelectedStudent.Value.Classroom.ClassroomName;
            editStudentForm.ComboBoxClassroom.Items.Clear();
            IEnumerable<Classroom> classrooms = await _searchEntities.FindAllEntitiesAsync<Classroom>();
            await _fillEntities.FillCourseInClassroomAsync(classrooms);
            editStudentForm.ComboBoxClassroom.Items.AddRange(classrooms.Select(c => new DisplayItem<Classroom>(c, $"{c.ClassroomName} - {c.Course.CourseName}")).ToArray());
        }

        public async Task EditClassroomLoadComponentsAsync(EditClassroomForm editClassroomForm) 
        {
            await EditClassroomLoadComboBoxCourseAsync(editClassroomForm);
            EditClassroomLoadLabelClassroomShow(editClassroomForm);
        }

        public async Task EditClassroomLoadListBoxSearchAsync(EditClassroomForm editClassroomForm)
        {
            IEnumerable<Classroom> classrooms = await _searchEntities.FindAllEntitiesAsync<Classroom>();
            await _fillEntities.FillCourseInClassroomAsync(classrooms);
            classrooms = await _searchEntities.FindClassroomByQueryAsync(editClassroomForm.textBoxSearch.Text, classrooms);
            editClassroomForm.listBoxSearch.Items.Clear();
            editClassroomForm.listBoxSearch.Items.AddRange(classrooms.Select(c => new DisplayItem<Classroom>(c, $"{c.ClassroomName} - {c.Course.CourseName}")).ToArray());
        }


        public async Task EditClassroomLoadComboBoxCourseAsync(EditClassroomForm editClassroomForm)
        {
            IEnumerable<Course> courses = await _searchEntities.FindAllEntitiesAsync<Course>();
            DisplayItem<Classroom> classroom = editClassroomForm.listBoxSearch.SelectedItem as DisplayItem<Classroom>;
            editClassroomForm.ComboBoxCourse.Items.Clear();
            editClassroomForm.ComboBoxCourse.Text = classroom.Value.Course.CourseName;
            editClassroomForm.ComboBoxCourse.Items.AddRange(courses.Select(c => new DisplayItem<Course>(c, c.CourseName)).ToArray());
        }

        public void EditClassroomLoadLabelClassroomShow(EditClassroomForm editClassroomForm)
        {
            DisplayItem<Classroom> classroom = editClassroomForm.listBoxSearch.SelectedItem as DisplayItem<Classroom>;
            editClassroomForm.LabelClassroomShow.ForeColor = Color.Black;
            editClassroomForm.LabelClassroomShow.Text = $"{classroom.Value.ClassroomName} - {classroom.Value.Course.CourseName}";
        }

        public async Task DeleteStudentLoadComboBoxClassroomsAsync(DeleteStudentForm deleteStudentForm)
        {
            IEnumerable<Classroom> classrooms = await _searchEntities.FindAllEntitiesAsync<Classroom>();
            deleteStudentForm.ComboBoxClassroom.Items.AddRange(classrooms.Select(c => new DisplayItem<Classroom>(c, c.ClassroomName)).ToArray());
        }

        public async Task DeleteStudentLoadListBoxByIndexAsync(DeleteStudentForm deleteStudentForm)
        {
            IEnumerable<Student> students = await _searchEntities.FindEntitiesByReferenceIdAsync<Student, Classroom>(deleteStudentForm.SelectedClassroom.Value);
            deleteStudentForm.listBoxStudents.Items.Clear();
            foreach (Student student in students)
            {
                string displayName = $"{student.CompleteName} - ({deleteStudentForm.SelectedClassroom.Value.ClassroomName})";
                if (!deleteStudentForm.listBoxStudents.Items.Contains(student))
                {
                    deleteStudentForm.listBoxStudents.Items.Add(new DisplayItem<Student>(student, displayName));
                }
            }
        }

        public async Task DeleteUserLoadComboBoxClassAsync(DeleteUserForm deleteUserForm)
        {
            IEnumerable<Class> classes = await _searchEntities.FindAllClassesAsync();
            deleteUserForm.ComboBoxClasses.Items.Clear();
            deleteUserForm.ComboBoxClasses.Items.AddRange(classes.Select(c => new DisplayItem<Class>(c, c.NameClass)).ToArray());
        }

        public async Task DeleteUserLoadListBoxUsersAsync(DeleteUserForm deleteUserForm)
        {
            IEnumerable<User> users = await _searchEntities.FindUsersByClassAsync(deleteUserForm.SelectedClass.Value);
            users = _dataAccess.RemoveCurrentUserFromSet(users);
            deleteUserForm.listBoxUsers.Items.Clear();
            deleteUserForm.listBoxUsers.Items.AddRange(users.Select(u => new DisplayItem<User>(u, u.Username)).ToArray());
        }

        public async Task RegistrationStudentLoadComboBoxClassroomAsync(RegistrationStudentForm registrationStudentForm)
        {
            IEnumerable<Classroom> classrooms = await _searchEntities.FindEntitiesByReferenceIdAsync<Classroom, Course>(registrationStudentForm.SelectedCourse.Value);
            registrationStudentForm.ComboBoxClassroom.Items.Clear();
            registrationStudentForm.ComboBoxClassroom.Items.AddRange(classrooms.Select(c => new DisplayItem<Classroom>(c, c.ClassroomName)).ToArray());
        }

        public async Task RegistrationStudentLoadComboBoxCoursesAsync(RegistrationStudentForm registrationStudentForm)
        {
            IEnumerable<Course> courses = await _searchEntities.FindAllEntitiesAsync<Course>();
            registrationStudentForm.ComboBoxCourse.Items.AddRange(courses.Select(c => new DisplayItem<Course>(c, c.CourseName)).ToArray());
        }
    }
}
