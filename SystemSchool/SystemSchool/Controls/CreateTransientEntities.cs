using Entities;
using System;
using SystemSchool.Forms.ClassroomForms;
using SystemSchool.Forms.CourseForms;
using SystemSchool.Forms.PasswordForms;
using SystemSchool.Forms.UserForms;

namespace SystemSchool.Controls
{
    /// <summary>
    /// Provides methods to create transient entities for registration forms.
    /// </summary>
    public class CreateTransientEntities
    {
        /// <summary>
        /// Creates a transient course entity based on the registration form data.
        /// </summary>
        /// <param name="courseForm">The registration course form.</param>
        /// <returns>The transient course entity.</returns>
        public Course CreateCourseTransient(RegistrationCourseForm courseForm)
        {
            Random random = new Random();
            return new Course(random.Next(), courseForm.CourseName, DateTime.Now);
        }

        /// <summary>
        /// Creates a transient user entity based on the confirm password form data.
        /// </summary>
        /// <param name="passwordForm">The confirm password form.</param>
        /// <returns>The transient user entity.</returns>
        public User CreateUserTransient(ConfirmPasswordForm passwordForm)
        {
            User user = new User();
            user.Username = passwordForm.Username;
            user.PasswordHash = passwordForm.Password;
            return user;
        }

        /// <summary>
        /// Creates a transient student entity based on the registration student form data.
        /// </summary>
        /// <param name="studentForm">The registration student form.</param>
        /// <returns>The transient student entity.</returns>
        public Student CreateStudentTransient(RegistrationStudentForm studentForm)
        {
            Random random = new Random();
            DisplayItem<Classroom> classroom = studentForm.ComboBoxClassroom.SelectedItem as DisplayItem<Classroom>;
            return new Student(random.Next(), classroom.Value.Id, studentForm.CompleteName, DateTime.Now);
        }

        /// <summary>
        /// Creates a transient classroom entity based on the registration classroom form data.
        /// </summary>
        /// <param name="classroomForm">The registration classroom form.</param>
        /// <returns>The transient classroom entity.</returns>
        public Classroom CreateClassroomTransient(RegistrationClassroomForm classroomForm)
        {
            string classroomName = classroomForm.ComboBoxSchoolYear.SelectedItem.ToString().Substring(0, 1)
                + classroomForm.ComboBoxLetter.SelectedItem.ToString();

            DisplayItem<Course> course = classroomForm.ComboBoxCourse.SelectedItem as DisplayItem<Course>;
            Random random = new Random();
            return new Classroom(random.Next(), classroomName, course.Value.Id, DateTime.Now);
        }

        /// <summary>
        /// Creates a transient user entity based on the registration user form data.
        /// </summary>
        /// <param name="userForm">The registration user form.</param>
        /// <returns>The transient user entity.</returns>
        public User CreateUserTransient(RegistrationUserForm userForm)
        {
            Random random = new Random();
            return new User(random.Next(), userForm.Username, userForm.Password, userForm.SelectedGroup.Value.Id, DateTime.Now);
        }
    }
}
