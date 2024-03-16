using Business.Extensions;
using Entities;
using Services;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using SystemSchool.Forms.ClassroomForms;
using SystemSchool.Forms.CourseForms;
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
            editUserForm.ComboBoxClass.Text = user.Value.Group.GroupName;
        }

        public void EditUserLoadTextBoxUsername(EditUserForm editUserForm) 
        {
            editUserForm.textBoxUsername.Text = editUserForm.SelectedUser.Value.Username;
        }

        public void EditUserLoadLabelUserShow(EditUserForm editUserForm) 
        {
            editUserForm.LabelUserShow.ForeColor = Color.Black;
            editUserForm.LabelUserShow.Text = $"{editUserForm.SelectedUser.Value.Username} - {editUserForm.SelectedUser.Value.Group.GroupName}";
        }

        public async Task EditUserLoadComboBoxClassAsync(EditUserForm editUserForm)
        {
            IEnumerable<Group> groups = await _searchEntities.FindAllEntitiesAsync<Group>();
            editUserForm.ComboBoxClass.Items.Clear();
            editUserForm.ComboBoxClass.Items.AddRange(groups.Select(c => new DisplayItem<Group>(c, c.GroupName.CutCompleteName())).ToArray());
        }

        public async Task EditUserLoadListBoxSearchAsync(EditUserForm editUserForm)
        {
            IEnumerable<User> users = await _searchEntities.FindUsersByQueryAsync(editUserForm.Query);
            await _fillEntities.FillUsersWithGroupAsync(users);
            users = _dataAccess.RemoveCurrentUserFromSet(users);
            editUserForm.listBoxSearch.Items.Clear();
            editUserForm.listBoxSearch.Items.AddRange(users.Select(c => new DisplayItem<User>(c, $"{c.Username.CutCompleteName()} - {c.Group.GroupName}")).ToArray());
        }

        public async Task EditUserLoadClassInUserAsync(EditUserForm editUserForm)
        {
            IEnumerable<Group> groups = await _searchEntities.FindAllEntitiesAsync<Group>();
            if (editUserForm.ComboBoxClass.SelectedItem == null && groups.Select(c => c.GroupName).Any(c => c == editUserForm.ComboBoxClass.Text))
            {
                Group group = await _searchEntities.FindEntityByNameAsync<Group>(editUserForm.ComboBoxClass.Text);
                editUserForm.SelectedUser.Value.GroupId = group.Id;
                editUserForm.SelectedUser.Value.Group = group;
            }
            else
            {
                editUserForm.SelectedUser.Value.GroupId = editUserForm.SelectedGroup.Value.Id;
                editUserForm.SelectedUser.Value.Group = editUserForm.SelectedGroup.Value;
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

        public async Task RegistrationClassroomLoadComboBoxLetterAsnyc(RegistrationClassroomForm registrationClassroomForm)
        {
            IEnumerable<char> availableLetters = await _searchEntities.FindLettersAvailableBySchoolYearAsync(registrationClassroomForm.SchoolYear);
            registrationClassroomForm.ComboBoxLetter.Items.Clear();
            foreach (char letter in availableLetters)
            {
                registrationClassroomForm.ComboBoxLetter.Items.Add(letter);
            }
        }

        public async Task RegistrationClassroomLoadComboBoxCourseAsync(RegistrationClassroomForm registrationClassroomForm)
        {
            IEnumerable<Course> courses = await _searchEntities.FindAllEntitiesAsync<Course>();
            registrationClassroomForm.ComboBoxCourse.Items.AddRange(courses.Select(c => new DisplayItem<Course>(c, c.CourseName)).ToArray());
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
            classrooms = await _searchEntities.FindClassroomsByQueryAsync(editClassroomForm.Query, classrooms);
            editClassroomForm.listBoxSearch.Items.Clear();
            editClassroomForm.listBoxSearch.Items.AddRange(classrooms.Select(c => new DisplayItem<Classroom>(c, $"{c.ClassroomName} - {c.Course.CourseName}")).ToArray());
        }

        public async Task EditClassroomLoadComboBoxCourseAsync(EditClassroomForm editClassroomForm)
        {
            IEnumerable<Course> courses = await _searchEntities.FindAllEntitiesAsync<Course>();
            editClassroomForm.ComboBoxCourse.Items.Clear();
            editClassroomForm.ComboBoxCourse.Text = editClassroomForm.SelectedClassroom.Value.Course.CourseName;
            editClassroomForm.ComboBoxCourse.Items.AddRange(courses.Select(c => new DisplayItem<Course>(c, c.CourseName)).ToArray());
        }

        public void EditClassroomLoadLabelClassroomShow(EditClassroomForm editClassroomForm)
        {
            editClassroomForm.LabelClassroomShow.ForeColor = Color.Black;
            editClassroomForm.LabelClassroomShow.Text = $"{editClassroomForm.SelectedClassroom.Value.ClassroomName} - {editClassroomForm.SelectedClassroom.Value.Course.CourseName}";
        }


        public async Task DeleteClassroomLoadComboBoxCourseAsync(DeleteClassroomForm deleteClassroomForm)
        {
            IEnumerable<Course> courses = await _searchEntities.FindAllEntitiesAsync<Course>();
            deleteClassroomForm.ComboBoxCourse.Items.Clear();
            deleteClassroomForm.ComboBoxCourse.Items.AddRange(courses.Select(c => new DisplayItem<Course>(c, c.CourseName)).ToArray());
        }

        public async Task DeleteClassroomLoadListBoxClassroomsAsync(DeleteClassroomForm deleteClassroomForm)
        {
            IEnumerable<Classroom> classrooms = await _searchEntities.FindEntitiesByReferenceIdAsync<Classroom, Course>(deleteClassroomForm.SelectedCourse.Value);
            deleteClassroomForm.listBoxClassrooms.Items.Clear();
            await _fillEntities.FillClassroomsWithCourseAsync(classrooms);
            foreach (Classroom classroom in classrooms)
            {
                deleteClassroomForm.listBoxClassrooms.Items.Add(new DisplayItem<Classroom>(classroom, $"{classroom.ClassroomName} - {classroom.Course.CourseName}"));
            }
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
            IEnumerable<Group> groups = await _searchEntities.FindAllEntitiesAsync<Group>();
            deleteUserForm.ComboBoxClasses.Items.Clear();
            deleteUserForm.ComboBoxClasses.Items.AddRange(groups.Select(c => new DisplayItem<Group>(c, c.GroupName)).ToArray());
        }

        public async Task DeleteUserLoadListBoxUsersAsync(DeleteUserForm deleteUserForm)
        {
            IEnumerable<User> users = await _searchEntities.FindEntitiesByReferenceIdAsync<User, Group>(deleteUserForm.SelectedClass.Value);
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

        public async Task DeleteCourseLoadListBoxCoursesAsync(DeleteCourseForm deleteCourseForm)
        {
            IEnumerable<Course> courses = await _searchEntities.FindAllEntitiesAsync<Course>();
            deleteCourseForm.listBoxCourses.Items.Clear();
            deleteCourseForm.listBoxCourses.Items.AddRange(courses.Select(c => new DisplayItem<Course>(c, c.CourseName)).ToArray());
        }
    }
}
