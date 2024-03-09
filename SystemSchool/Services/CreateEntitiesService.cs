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

namespace Services
{
    public class CreateEntitiesService<T>
    {
        private readonly ConnectionDb _connectionDb;
        private readonly ValidationEntitiesService<T> _validationEntities;
        
        public CreateEntitiesService(ConnectionDb connectionDb, ValidationEntitiesService<T> validationEntities) 
        {
            _connectionDb = connectionDb;
            _validationEntities = validationEntities;
        }

        public async Task<CourseQuery> CreateCourseAsync(Course course)
        {
            if (_validationEntities.IsValidNameCourse(course, await _connectionDb.ReturnAllCoursesAsync()))
            {
                await _connectionDb.CreateCourseInDbAsync(course);
                return new CourseQuery(true, "Course " + course.CourseName + " created successfully!", DateTime.Now, course);
            }
            return new CourseQuery(false, course.CourseName + " course already exists", DateTime.Now, course);
        }

        public async Task<StudentQuery> CreateStudentAsync(Student student) 
        {
            if (_validationEntities.IsValidStudent(student)) 
            {
                await _connectionDb.CreateStudentInDbAsync(student);
                return new StudentQuery(true, "Student " + student.CompleteName.CutCompleteName() + " created successfully!", DateTime.Now, student);
            }
                return new StudentQuery(false, "Student " + student.CompleteName.CutCompleteName() + " student already exists!", DateTime.Now, student);
        }

        public async Task<ClassroomQuery> CreateClassroomAsync(Classroom classroom) 
        {
            if (_validationEntities.IsValidClassroomName(classroom, await _connectionDb.ReturnAllClassromsAsync()))
            {
                await _connectionDb.CreateClassroomInDbAsync(classroom);
                return new ClassroomQuery(true, "Classroom " + classroom.ClassroomName + " created successfully!", DateTime.Now, classroom);
            }
            return new ClassroomQuery(false, "Classroom " + classroom.ClassroomName + " classroom already exist!", DateTime.Now, classroom);
        }
    }
}
 