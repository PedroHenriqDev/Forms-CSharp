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

namespace Services
{
    public class DeleteEntitiesService<T>
    {
        private readonly ConnectionDb ConnectionDb = new ConnectionDb();
        private readonly ValidationEntitiesService<T> ValidationEntities = new ValidationEntitiesService<T>();
        private readonly SearchEntitiesService SearchEntities = new SearchEntitiesService();

        public async Task<StudentQuery> DeleteStudentAsync(Student student)
        {
            Student studentDb = await ConnectionDb.ReturnEntityByIdAsync<Student>(student.Id);
            if (studentDb == null || !ValidationEntities.EntityHasId(studentDb.Id))
            {
                return new StudentQuery(false, "An error occurred when recognizing the student " + student.CompleteName.CutCompleteName(), DateTime.Now, student);
            }
            await ConnectionDb.DeleteRecordInTableByIdAsync(student.Id, "Students");
            return new StudentQuery(true, "Student " + student.CompleteName.CutCompleteName() + " deleted successfully", DateTime.Now, student);
        }

        public async Task<CourseQuery> DeleteCourseAsync(Course course)
        {
            if (course == null || !ValidationEntities.EntityHasId(course.Id))
            {
                return new CourseQuery(false, "An error occurred when recognizing the course " + course.CourseName, DateTime.Now, course);
            }

            await ConnectionDb.DeleteRecordInTableByIdAsync(course.Id, "Courses");
            return new CourseQuery(true, "Course " + course.CourseName + " deleted successfully", DateTime.Now, course);
        }

        public async Task<ClassroomQuery> DeleteClassroomAsync(Classroom classroom)
        {
            if (classroom == null || !ValidationEntities.EntityHasId(classroom.Id))
            {
                return new ClassroomQuery(false, "An error occurred when recognizing the course " + classroom.ClassroomName, DateTime.Now, classroom);
            }

            await ConnectionDb.DeleteRecordInTableByIdAsync(classroom.Id, "Classrooms");
            return new ClassroomQuery(true, "Classroom " + classroom.ClassroomName + " deleted successfully", DateTime.Now, classroom);
        }

        public async Task DeleteStudentsAsync(IEnumerable<Student> students) 
        {
            if (students.Any())
            {
                await ConnectionDb.DeleteRecordsInTableByIdAsync(students
                    .Select(c => c.Id)
                    .ToList(), "Students");
            }
        }

        public async Task DeleteClassromsByCourseIdAsync(IEnumerable<Classroom> classrooms, int courseId) 
        {
            if (classrooms.Any()) 
            {
                await ConnectionDb.DeleteRecordsInTableByIdAsync(classrooms
               .Where(c => c.CourseId == courseId)
               .Select(c => c.Id)
               .ToList(), "Classrooms");
            }
        }
    }
}
