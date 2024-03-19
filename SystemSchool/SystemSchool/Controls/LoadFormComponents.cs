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
    /// <summary>
    /// Class responsible for loading components in various forms of the school system.
    /// </summary>
    public class LoadFormComponents
    {
        private readonly SearchEntitiesService _searchEntities;
        private readonly FillEntitiesService _fillEntities;
        private readonly DataAccess _dataAccess;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadFormComponents"/> class.
        /// </summary>
        /// <param name="searchEntities">The service used for entity search.</param>
        /// <param name="fillEntities">The service used for filling entities.</param>
        /// <param name="dataAccess">The data access.</param>
        public LoadFormComponents(
            SearchEntitiesService searchEntities,
            FillEntitiesService fillEntities,
            DataAccess dataAccess)
        {
            _searchEntities = searchEntities;
            _fillEntities = fillEntities;
            _dataAccess = dataAccess;
        }

        /// <summary>
        /// Loads the available groups into a ComboBox in the registration user form.
        /// </summary>
        /// <param name="registrationUserForm">The registration user form.</param>
        public async Task RegistrationUserLoadComboBoxClass(RegistrationUserForm registrationUserForm)
        {
            IEnumerable<Group> groups = await _searchEntities.FindAllEntitiesAsync<Group>();
            registrationUserForm.ComboBoxClass.Items.Clear();
            registrationUserForm.ComboBoxClass.Items.AddRange(groups.Select(c => new DisplayItem<Group>(c, c.GroupName)).ToArray());
        }

        /// <summary>
        /// Loads the components required for editing a user asynchronously.
        /// </summary>
        /// <param name="editUserForm">The edit user form.</param>
        public async Task EditUserLoadComponentsAsync(EditUserForm editUserForm)
        {
            EditUserLoadComboBoxClass(editUserForm);
            EditUserLoadTextBoxUsername(editUserForm);
            EditUserLoadLabelUserShow(editUserForm);
            await EditUserLoadComboBoxClassAsync(editUserForm);
        }

        /// <summary>
        /// Loads the ComboBoxClass in the EditUserForm.
        /// </summary>
        /// <param name="editUserForm">The edit user form.</param>
        public void EditUserLoadComboBoxClass(EditUserForm editUserForm)
        {
            DisplayItem<User> user = editUserForm.listBoxSearch.SelectedItem as DisplayItem<User>;
            editUserForm.ComboBoxClass.Text = user.Value.Group.GroupName;
        }

        /// <summary>
        /// Loads the TextBoxUsername in the EditUserForm.
        /// </summary>
        /// <param name="editUserForm">The edit user form.</param>
        public void EditUserLoadTextBoxUsername(EditUserForm editUserForm)
        {
            editUserForm.textBoxUsername.Text = editUserForm.SelectedUser.Value.Username;
        }

        /// <summary>
        /// Loads the LabelUserShow in the EditUserForm.
        /// </summary>
        /// <param name="editUserForm">The edit user form.</param>
        public void EditUserLoadLabelUserShow(EditUserForm editUserForm)
        {
            editUserForm.LabelUserShow.ForeColor = Color.Black;
            editUserForm.LabelUserShow.Text = $"{editUserForm.SelectedUser.Value.Username} - {editUserForm.SelectedUser.Value.Group.GroupName}";
        }

        /// <summary>
        /// Loads the ComboBoxClass asynchronously in the EditUserForm.
        /// </summary>
        /// <param name="editUserForm">The edit user form.</param>
        public async Task EditUserLoadComboBoxClassAsync(EditUserForm editUserForm)
        {
            IEnumerable<Group> groups = await _searchEntities.FindAllEntitiesAsync<Group>();
            editUserForm.ComboBoxClass.Items.Clear();
            editUserForm.ComboBoxClass.Items.AddRange(groups.Select(c => new DisplayItem<Group>(c, c.GroupName.CutCompleteName())).ToArray());
        }

        /// <summary>
        /// Loads the ListBoxSearch asynchronously in the EditUserForm.
        /// </summary>
        /// <param name="editUserForm">The edit user form.</param>
        public async Task EditUserLoadListBoxSearchAsync(EditUserForm editUserForm)
        {
            IEnumerable<User> users = await _searchEntities.FindUsersByQueryAsync(editUserForm.Query);
            await _fillEntities.FillUsersWithGroupAsync(users);
            users = _dataAccess.RemoveCurrentUserFromSet(users);
            editUserForm.listBoxSearch.Items.Clear();
            editUserForm.listBoxSearch.Items.AddRange(users.Select(c => new DisplayItem<User>(c, $"{c.Username.CutCompleteName()} - {c.Group.GroupName}")).ToArray());
        }

        /// <summary>
        /// Loads the class of the user asynchronously in the EditUserForm.
        /// </summary>
        /// <param name="editUserForm">The edit user form.</param>
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

        /// <summary>
        /// Loads the components of the EditStudentForm asynchronously.
        /// </summary>
        /// <param name="editStudentForm">The EditStudentForm to load components into.</param>
        public async Task EditStudentLoadComponentsAsync(EditStudentForm editStudentForm)
        {
            EditStudentLoadTextBoxStudentName(editStudentForm);

            await EditStudentLoadComboBoxClassroomAsync(editStudentForm);

            await EditStudentLoadLabelStudentAsync(editStudentForm);
        }


        /// <summary>
        /// Loads the ListBoxSearch asynchronously in the EditStudentForm.
        /// </summary>
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

        /// <summary>
        /// Loads the TextBoxStudentName in the EditStudentForm.
        /// </summary>
        public void EditStudentLoadTextBoxStudentName(EditStudentForm editStudentForm)
        {
            editStudentForm.textBoxStudentName.Text = editStudentForm.SelectedStudent.Value.CompleteName;
        }

        /// <summary>
        /// Loads the LabelStudent asynchronously in the EditStudentForm.
        /// </summary>
        public async Task EditStudentLoadLabelStudentAsync(EditStudentForm editStudentForm)
        {
            editStudentForm.LabelStudent.ForeColor = Color.Black;
            editStudentForm.SelectedStudent.Value.Classroom = await _searchEntities.FindEntityByIdAsync<Classroom>(editStudentForm.SelectedStudent.Value.ClassroomId);
            editStudentForm.SelectedStudent.Value.Classroom.Course = await _searchEntities.FindEntityByIdAsync<Course>(editStudentForm.SelectedStudent.Value.Classroom.CourseId);
            editStudentForm.LabelStudent.Text = $"{editStudentForm.SelectedStudent.Value.CompleteName} - {editStudentForm.SelectedStudent.Value.Classroom.Course.CourseName} - {editStudentForm.SelectedStudent.Value.Classroom.ClassroomName}";
        }

        /// <summary>
        /// Loads the classroom in the student asynchronously in the EditStudentForm.
        /// </summary>
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

        /// <summary>
        /// Loads the ComboBoxClassroom asynchronously in the EditStudentForm.
        /// </summary>
        public async Task EditStudentLoadComboBoxClassroomAsync(EditStudentForm editStudentForm)
        {
            editStudentForm.ComboBoxClassroom.Text = editStudentForm.SelectedStudent.Value.Classroom.ClassroomName;
            editStudentForm.ComboBoxClassroom.Items.Clear();
            IEnumerable<Classroom> classrooms = await _searchEntities.FindAllEntitiesAsync<Classroom>();
            await _fillEntities.FillCourseInClassroomAsync(classrooms);
            editStudentForm.ComboBoxClassroom.Items.AddRange(classrooms.Select(c => new DisplayItem<Classroom>(c, $"{c.ClassroomName} - {c.Course.CourseName}")).ToArray());
        }

        /// <summary>
        /// Loads the ComboBoxLetter asynchronously in the RegistrationClassroomForm.
        /// </summary>
        public async Task RegistrationClassroomLoadComboBoxLetterAsnyc(RegistrationClassroomForm registrationClassroomForm)
        {
            IEnumerable<char> availableLetters = await _searchEntities.FindLettersAvailableBySchoolYearAsync(registrationClassroomForm.SchoolYear);
            registrationClassroomForm.ComboBoxLetter.Items.Clear();
            foreach (char letter in availableLetters)
            {
                registrationClassroomForm.ComboBoxLetter.Items.Add(letter);
            }
        }

        /// <summary>
        /// Loads the ComboBoxCourse asynchronously in the RegistrationClassroomForm.
        /// </summary>
        public async Task RegistrationClassroomLoadComboBoxCourseAsync(RegistrationClassroomForm registrationClassroomForm)
        {
            IEnumerable<Course> courses = await _searchEntities.FindAllEntitiesAsync<Course>();
            registrationClassroomForm.ComboBoxCourse.Items.AddRange(courses.Select(c => new DisplayItem<Course>(c, c.CourseName)).ToArray());
        }

        /// <summary>
        /// Loads the components in the EditClassroomForm asynchronously.
        /// </summary>
        public async Task EditClassroomLoadComponentsAsync(EditClassroomForm editClassroomForm)
        {
            await EditClassroomLoadComboBoxCourseAsync(editClassroomForm);
            EditClassroomLoadLabelClassroomShow(editClassroomForm);
        }

        /// <summary>
        /// Loads the ListBoxSearch in the EditClassroomForm asynchronously.
        /// </summary>
        public async Task EditClassroomLoadListBoxSearchAsync(EditClassroomForm editClassroomForm)
        {
            IEnumerable<Classroom> classrooms = await _searchEntities.FindAllEntitiesAsync<Classroom>();
            await _fillEntities.FillCourseInClassroomAsync(classrooms);
            classrooms = await _searchEntities.FindClassroomsByQueryAsync(editClassroomForm.Query, classrooms);
            editClassroomForm.listBoxSearch.Items.Clear();
            editClassroomForm.listBoxSearch.Items.AddRange(classrooms.Select(c => new DisplayItem<Classroom>(c, $"{c.ClassroomName} - {c.Course.CourseName}")).ToArray());
        }

        /// <summary>
        /// Loads the ComboBoxCourse in the EditClassroomForm asynchronously.
        /// </summary>
        public async Task EditClassroomLoadComboBoxCourseAsync(EditClassroomForm editClassroomForm)
        {
            IEnumerable<Course> courses = await _searchEntities.FindAllEntitiesAsync<Course>();
            editClassroomForm.ComboBoxCourse.Items.Clear();
            editClassroomForm.ComboBoxCourse.Text = editClassroomForm.SelectedClassroom.Value.Course.CourseName;
            editClassroomForm.ComboBoxCourse.Items.AddRange(courses.Select(c => new DisplayItem<Course>(c, c.CourseName)).ToArray());
        }

        /// <summary>
        /// Loads the LabelClassroomShow in the EditClassroomForm.
        /// </summary>
        public void EditClassroomLoadLabelClassroomShow(EditClassroomForm editClassroomForm)
        {
            editClassroomForm.LabelClassroomShow.ForeColor = Color.Black;
            editClassroomForm.LabelClassroomShow.Text = $"{editClassroomForm.SelectedClassroom.Value.ClassroomName} - {editClassroomForm.SelectedClassroom.Value.Course.CourseName}";
        }
        /// <summary>
        /// Loads the ComboBoxCourse asynchronously in the DeleteClassroomForm.
        /// </summary>
        public async Task DeleteClassroomLoadComboBoxCourseAsync(DeleteClassroomForm deleteClassroomForm)
        {
            IEnumerable<Course> courses = await _searchEntities.FindAllEntitiesAsync<Course>();
            deleteClassroomForm.ComboBoxCourse.Items.Clear();
            deleteClassroomForm.ComboBoxCourse.Items.AddRange(courses.Select(c => new DisplayItem<Course>(c, c.CourseName)).ToArray());
        }

        /// <summary>
        /// Loads the ListBoxClassrooms in the DeleteClassroomForm asynchronously.
        /// </summary>
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

        /// <summary>
        /// Loads the ComboBoxClassrooms asynchronously in the DeleteStudentForm.
        /// </summary>
        public async Task DeleteStudentLoadComboBoxClassroomsAsync(DeleteStudentForm deleteStudentForm)
        {
            IEnumerable<Classroom> classrooms = await _searchEntities.FindAllEntitiesAsync<Classroom>();
            deleteStudentForm.ComboBoxClassroom.Items.AddRange(classrooms.Select(c => new DisplayItem<Classroom>(c, c.ClassroomName)).ToArray());
        }

        /// <summary>
        /// Loads the ListBoxStudents by index asynchronously in the DeleteStudentForm.
        /// </summary>
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

        /// <summary>
        /// Loads the ComboBoxClasses asynchronously in the DeleteUserForm.
        /// </summary>
        public async Task DeleteUserLoadComboBoxClassAsync(DeleteUserForm deleteUserForm)
        {
            IEnumerable<Group> groups = await _searchEntities.FindAllEntitiesAsync<Group>();
            deleteUserForm.ComboBoxClasses.Items.Clear();
            deleteUserForm.ComboBoxClasses.Items.AddRange(groups.Select(c => new DisplayItem<Group>(c, c.GroupName)).ToArray());
        }

        /// <summary>
        /// Loads the ListBoxUsers asynchronously in the DeleteUserForm.
        /// </summary>
        public async Task DeleteUserLoadListBoxUsersAsync(DeleteUserForm deleteUserForm)
        {
            IEnumerable<User> users = await _searchEntities.FindEntitiesByReferenceIdAsync<User, Group>(deleteUserForm.SelectedClass.Value);
            users = _dataAccess.RemoveCurrentUserFromSet(users);
            deleteUserForm.listBoxUsers.Items.Clear();
            deleteUserForm.listBoxUsers.Items.AddRange(users.Select(u => new DisplayItem<User>(u, u.Username)).ToArray());
        }

        /// <summary>
        /// Loads the ComboBoxClassroom asynchronously in the RegistrationStudentForm.
        /// </summary>
        public async Task RegistrationStudentLoadComboBoxClassroomAsync(RegistrationStudentForm registrationStudentForm)
        {
            IEnumerable<Classroom> classrooms = await _searchEntities.FindEntitiesByReferenceIdAsync<Classroom, Course>(registrationStudentForm.SelectedCourse.Value);
            registrationStudentForm.ComboBoxClassroom.Items.Clear();
            registrationStudentForm.ComboBoxClassroom.Items.AddRange(classrooms.Select(c => new DisplayItem<Classroom>(c, c.ClassroomName)).ToArray());
        }

        /// <summary>
        /// Loads the ComboBoxCourses asynchronously in the RegistrationStudentForm.
        /// </summary>
        public async Task RegistrationStudentLoadComboBoxCoursesAsync(RegistrationStudentForm registrationStudentForm)
        {
            IEnumerable<Course> courses = await _searchEntities.FindAllEntitiesAsync<Course>();
            registrationStudentForm.ComboBoxCourse.Items.AddRange(courses.Select(c => new DisplayItem<Course>(c, c.CourseName)).ToArray());
        }

        /// <summary>
        /// Loads the ListBoxCourses asynchronously in the DeleteCourseForm.
        /// </summary>
        public async Task DeleteCourseLoadListBoxCoursesAsync(DeleteCourseForm deleteCourseForm)
        {
            IEnumerable<Course> courses = await _searchEntities.FindAllEntitiesAsync<Course>();
            deleteCourseForm.listBoxCourses.Items.Clear();
            deleteCourseForm.listBoxCourses.Items.AddRange(courses.Select(c => new DisplayItem<Course>(c, c.CourseName)).ToArray());
        }
    }
}
