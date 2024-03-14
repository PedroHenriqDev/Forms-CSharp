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

        public void TeacherAccess(MainForm mainForm) 
        {
            mainForm.pictureUser.Enabled = false;
            mainForm.LabelUser.Enabled = false;
            mainForm.pictureStudent.Enabled = false;
            mainForm.LabelStudent.Enabled = false;
            mainForm.pictureClassroom.Enabled = false;
            mainForm.LabelClassroom.Enabled = false;
            mainForm.pictureCourse.Enabled = false;
            mainForm.LabelCourse.Enabled = false;
        }

        public void SecretaryAccess(MainForm mainForm) 
        {
            mainForm.pictureUser.Enabled = false;
            mainForm.LabelUser.Enabled = false;
        }

        public async Task UserFormLoadComponentsAsync(EditUserForm editUserForm)
        {
            UserFormLoadComboBoxClass(editUserForm);
            UserFormLoadTextBoxUsername(editUserForm);
            UserFormLoadLabelUserShow(editUserForm);
            await UserFormLoadComboBoxClassAsync(editUserForm);
        }

        public void UserFormLoadComboBoxClass(EditUserForm editUserForm) 
        {
            DisplayItem<User> user = editUserForm.listBoxSearch.SelectedItem as DisplayItem<User>;
            editUserForm.ComboBoxClass.Text = user.Value.Class.NameClass;
        }

        public void UserFormLoadTextBoxUsername(EditUserForm editUserForm) 
        {
            editUserForm.textBoxUsername.Text = editUserForm.SelectedUser.Value.Username;
        }

        public void UserFormLoadLabelUserShow(EditUserForm editUserForm) 
        {
            editUserForm.LabelUserShow.ForeColor = Color.Black;
            editUserForm.LabelUserShow.Text = $"{editUserForm.SelectedUser.Value.Username} - {editUserForm.SelectedUser.Value.Class.NameClass}";
        }

        public async Task UserFormLoadComboBoxClassAsync(EditUserForm editUserForm)
        {
            IEnumerable<Class> classes = await _searchEntities.FindAllClassesAsync();
            editUserForm.ComboBoxClass.Items.Clear();
            editUserForm.ComboBoxClass.Items.AddRange(classes.Select(c => new DisplayItem<Class>(c, c.NameClass.CutCompleteName())).ToArray());
        }

        public async Task UserFormLoadListBoxSearchAsync(EditUserForm editUserForm)
        {
            IEnumerable<User> users = await _searchEntities.FindUsersByQueryAsync(editUserForm.Query);
            await _fillEntities.FillUsersWithClassAsync(users);
            users = _dataAccess.RemoveCurrentUserFromSet(users);
            editUserForm.listBoxSearch.Items.Clear();
            editUserForm.listBoxSearch.Items.AddRange(users.Select(c => new DisplayItem<User>(c, $"{c.Username.CutCompleteName()} - {c.Class.NameClass}")).ToArray());
        }

        public async Task UserFormLoadClassInUserAsync(EditUserForm editUserForm)
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

        public async Task StudentFormLoadComponentsAsync(EditStudentForm editStudentForm) 
        {
            StudentFormLoadTextBoxStudentName(editStudentForm);
            await StudentFormLoadComboBoxClassroomAsync(editStudentForm);
            await StudentFormLoadLabelStudentAsync(editStudentForm);
        }

        public async Task StudentFormLoadListBoxSearchAsync(EditStudentForm editStudentForm)
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

        public void StudentFormLoadTextBoxStudentName(EditStudentForm editStudentForm)
        {
            DisplayItem<Student> student = editStudentForm.listBoxSearch.SelectedItem as DisplayItem<Student>;
            editStudentForm.textBoxStudentName.Text = student.Value.CompleteName;
        }

        public async Task StudentFormLoadLabelStudentAsync(EditStudentForm editStudentForm)
        {
            DisplayItem<Student> student = editStudentForm.listBoxSearch.SelectedItem as DisplayItem<Student>;
            editStudentForm.LabelStudent.ForeColor = Color.Black;
            student.Value.Classroom = await _searchEntities.FindEntityByIdAsync<Classroom>(student.Value.ClassroomId);
            student.Value.Classroom.Course = await _searchEntities.FindEntityByIdAsync<Course>(student.Value.Classroom.CourseId);
            editStudentForm.LabelStudent.Text = $"{student.Value.CompleteName} - {student.Value.Classroom.Course.CourseName} - {student.Value.Classroom.ClassroomName}";
        }

        public async Task StudentFormLoadClassroomInStudentAsync(EditStudentForm editStudentForm, Student student)
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

        public async Task StudentFormLoadComboBoxClassroomAsync(EditStudentForm editStudentForm)
        {
            DisplayItem<Student> student = editStudentForm.listBoxSearch.SelectedItem as DisplayItem<Student>;
            editStudentForm.ComboBoxClassroom.Text = student.Value.Classroom.ClassroomName;
            editStudentForm.ComboBoxClassroom.Items.Clear();
            IEnumerable<Classroom> classrooms = await _searchEntities.FindAllEntitiesAsync<Classroom>();
            await _fillEntities.FillCourseInClassroomAsync(classrooms);
            editStudentForm.ComboBoxClassroom.Items.AddRange(classrooms.Select(c => new DisplayItem<Classroom>(c, $"{c.ClassroomName} - {c.Course.CourseName}")).ToArray());
        }

        public async Task ClassroomFormLoadComponentsAsync(EditClassroomForm editClassroomForm) 
        {
            await ClassroomFormLoadComboBoxCourseAsync(editClassroomForm);
            ClassroomFormLoadLabelClassroomShow(editClassroomForm);
        }

        public async Task ClassroomFormLoadListBoxSearchAsync(EditClassroomForm editClassroomForm)
        {
            IEnumerable<Classroom> classrooms = await _searchEntities.FindAllEntitiesAsync<Classroom>();
            await _fillEntities.FillCourseInClassroomAsync(classrooms);
            classrooms = await _searchEntities.FindClassroomByQueryAsync(editClassroomForm.textBoxSearch.Text, classrooms);
            editClassroomForm.listBoxSearch.Items.Clear();
            editClassroomForm.listBoxSearch.Items.AddRange(classrooms.Select(c => new DisplayItem<Classroom>(c, $"{c.ClassroomName} - {c.Course.CourseName}")).ToArray());
        }


        public async Task ClassroomFormLoadComboBoxCourseAsync(EditClassroomForm editClassroomForm)
        {
            IEnumerable<Course> courses = await _searchEntities.FindAllEntitiesAsync<Course>();
            DisplayItem<Classroom> classroom = editClassroomForm.listBoxSearch.SelectedItem as DisplayItem<Classroom>;
            editClassroomForm.ComboBoxCourse.Items.Clear();
            editClassroomForm.ComboBoxCourse.Text = classroom.Value.Course.CourseName;
            editClassroomForm.ComboBoxCourse.Items.AddRange(courses.Select(c => new DisplayItem<Course>(c, c.CourseName)).ToArray());
        }

        public void ClassroomFormLoadLabelClassroomShow(EditClassroomForm editClassroomForm)
        {
            DisplayItem<Classroom> classroom = editClassroomForm.listBoxSearch.SelectedItem as DisplayItem<Classroom>;
            editClassroomForm.LabelClassroomShow.ForeColor = Color.Black;
            editClassroomForm.LabelClassroomShow.Text = $"{classroom.Value.ClassroomName} - {classroom.Value.Course.CourseName}";
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
    }
}
