using Entities;
using System;
using SystemSchool.Forms.ClassroomForms;
using SystemSchool.Forms.CourseForms;
using SystemSchool.Forms.PasswordForms;
using SystemSchool.Forms.UserForms;

namespace SystemSchool.Controls
{
    public class CreateTransientEntities 
    {
    
        public Course CreateCourseTransient(RegistrationCourseForm courseForm) 
        {
            Random random = new Random();
            return new Course(random.Next(), courseForm.CourseName, DateTime.Now);
        }

        public User CreateUserTransient(ConfirmPasswordForm passwordForm) 
        {
            User user = new User();
            user.Username = passwordForm.Username;
            user.PasswordHash = passwordForm.Password;
            return user;
        }

        public Student CreateStudentTransient(RegistrationStudentForm studentForm) 
        {
            Random random = new Random();
            DisplayItem<Classroom> classroom = studentForm.ComboBoxClassroom.SelectedItem as DisplayItem<Classroom>;
            return new Student(random.Next(), classroom.Value.Id, studentForm.CompleteName, DateTime.Now);
        }

        public Classroom CreateClassroomTransient(RegistrationClassroomForm classroomForm) 
        {
            string classroomName = classroomForm.ComboBoxSchoolYear.SelectedItem.ToString().Substring(0, 1) 
                + classroomForm.ComboBoxLetter.SelectedItem.ToString();

            DisplayItem<Course> course = classroomForm.ComboBoxCourse.SelectedItem as DisplayItem<Course>;
            Random random = new Random();
            return new Classroom(random.Next(), classroomName, course.Value.Id, DateTime.Now);
        }

        public User CreateUserTransient(RegistrationUserForm userForm) 
        {
            Random random = new Random();
            return new User(random.Next(), userForm.Username, userForm.Password, userForm.SelectedGroup.Value.Id, DateTime.Now);
        }
    }
}
