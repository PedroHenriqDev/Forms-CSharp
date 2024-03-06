using Business.Extensions;
using Datas;
using Entities;
using Entities.TransientClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessLogic
{
    public class CreateEntitiesBusiness<T>
    {
        private readonly ConnectionDb ConnectionDb = new ConnectionDb();
        private readonly ValidationEntitiesBusiness<T> ValidationEntities = new ValidationEntitiesBusiness<T>();
        
        public async Task<CourseQuery> CreateCourseAsync(Course course)
        {
            if (ValidationEntities.IsValidNameCourse(course, await ConnectionDb.ReturnAllCoursesAsync()))
            {
                await ConnectionDb.CreateCourseInDbAsync(course);
                return new CourseQuery(true, "Course " + course.CourseName + " created successfully!", DateTime.Now, course);
            }
            return new CourseQuery(false, course.CourseName + " course already exists", DateTime.Now, course);
        }

        public async Task<StudentQuery> CreateStudentAsync(Student student) 
        {
            if (ValidationEntities.IsValidStudent(student)) 
            {
                await ConnectionDb.CreateStudentInDbAsync(student);
                return new StudentQuery(true, "Student " + student.CompleteName.CutCompleteName() + " created successfully!", DateTime.Now, student);
            }
                return new StudentQuery(false, "Student " + student.CompleteName.CutCompleteName() + " student already exists!", DateTime.Now, student);
        }

        public async Task<ClassroomQuery> CreateClassroomAsync(Classroom classroom) 
        {
            if (ValidationEntities.IsValidClassroomName(classroom, await ConnectionDb.ReturnAllClassromsAsync()))
            {
                await ConnectionDb.CreateClassroomInDbAsync(classroom);
                return new ClassroomQuery(true, "Classroom " + classroom.ClassroomName + " created successfully!", DateTime.Now, classroom);
            }
            return new ClassroomQuery(false, "Classroom " + classroom.ClassroomName + " classroom already exist!", DateTime.Now, classroom);
        }
    }
}
 