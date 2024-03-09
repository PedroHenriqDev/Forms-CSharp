using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemSchool.Forms.ClassroomForms;
using SystemSchool.Forms.CourseForms;

namespace SystemSchool.Controls
{
    public class CreateTransientEntities 
    {
    
        public Course CreateCourseTransient(RegistrationCourseForm courseForm) 
        {
            Random random = new Random();
            return new Course(courseForm.textBoxCourseName.Text, random.Next());
        }

        public Student CreateStudentTransient(RegistrationStudentForm studentForm) 
        {
            Random random = new Random();
            DisplayItem<Classroom> classroom = studentForm.ComboBoxClassroom.SelectedItem as DisplayItem<Classroom>;
            return new Student(random.Next(), classroom.Value.Id, studentForm.textBoxCompleteName.Text);
        }

        public Classroom CreateClassroomTransient(RegistrationClassroomForm classroomForm) 
        {
            string classroomName = classroomForm.ComboBoxSchoolYear.SelectedItem.ToString().Substring(0, 1) 
                + classroomForm.ComboBoxLetter.SelectedItem.ToString();

            DisplayItem<Course> course = classroomForm.ComboBoxCourse.SelectedItem as DisplayItem<Course>;
            Random random = new Random();
            return new Classroom(random.Next(), classroomName, course.Value.Id);
        }
    }
}
