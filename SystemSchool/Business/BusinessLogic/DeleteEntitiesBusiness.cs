using Business.Extensions;
using Datas;
using Entities;
using Entities.Interfaces;
using Entities.TransientClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessLogic
{
    public class DeleteEntitiesBusiness<T>
    {
        private readonly ConnectionDb ConnectionDb = new ConnectionDb();
        private readonly ValidationEntitiesBusiness<T> ValidationEntities = new ValidationEntitiesBusiness<T>();
        private readonly SearchEntitiesBusiness SearchEntities = new SearchEntitiesBusiness();

        public async Task<StudentQuery> DeleteStudentAsync(Student student)
        {
            Student studentDb = await ConnectionDb.ReturnStudentByIdAsync(student.Id);
            if (studentDb == null || !ValidationEntities.EntityHasId(studentDb.Id))
            {
                return new StudentQuery(false, "An error occurred when recognizing the student " + student.CompleteName.CutCompleteName(), DateTime.Now, student);
            }
            await ConnectionDb.DeleteStudentByIdAsync(student.Id);
            return new StudentQuery(true, "Student " + student.CompleteName.CutCompleteName() + " deleted successfully", DateTime.Now, student);
        }

        public async Task<CourseQuery> DeleteCourseAsync(Course course)
        {
            if (course == null || !ValidationEntities.EntityHasId(course.Id))
            {
                return new CourseQuery(false, "An error occurred when recognizing the course " + course.CourseName, DateTime.Now, course);
            }

            await ConnectionDb.DeleteCourseByIdAsync(course.Id);
            return new CourseQuery(true, "Course " + course.CourseName + " deleted successfully", DateTime.Now, course);
        }

        public async Task<ClassroomQuery> DeleteClassroomAsync(Classroom classroom)
        {
            if (classroom == null || !ValidationEntities.EntityHasId(classroom.Id))
            {
                return new ClassroomQuery(false, "An error occurred when recognizing the course " + classroom.ClassroomName, DateTime.Now, classroom);
            }
            IEnumerable<Student> students = await ConnectionDb.ReturnAllStudentsAsync();
            await ConnectionDb.DeleteRecordsInTableAsync(students
                .Where(c => c.ClassroomId == classroom.Id)
                .Select(c => c.ClassroomId)
                .ToList(), "Classrooms", "Id");

            await ConnectionDb.DeleteClassroomAsync(classroom.Id);
            return new ClassroomQuery(true, "Classroom " + classroom.ClassroomName + " deleted successfully", DateTime.Now, classroom);
        }

        public async Task DeleteStudentsAsync(IEnumerable<Student> students) 
        {
            if (students.Any())
            {
                await ConnectionDb.DeleteRecordsInTableAsync(students
                    .Select(c => c.Id)
                    .ToList(), "Students", "Id");
            }
        }

        public async Task DeleteClassromsByCourseIdAsync(IEnumerable<Classroom> classrooms, int courseId) 
        {
            if (classrooms.Any()) 
            {
                await ConnectionDb.DeleteRecordsInTableAsync(classrooms
               .Where(c => c.CourseId == courseId)
               .Select(c => c.Id)
               .ToList(), "Classrooms", "Id");
            }
        }
    }
}
