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
        private readonly ConnectionDb _connectionDb;
        private readonly ValidationEntitiesService<T> _validationEntities;
        private readonly SearchEntitiesService _searchService;

        public DeleteEntitiesService(ConnectionDb connectionDb, ValidationEntitiesService<T> validationEntities, SearchEntitiesService searchService)
        {
            _connectionDb = connectionDb;
            _validationEntities = validationEntities;
            _searchService = searchService;
        }

        public async Task<StudentQuery> DeleteStudentAsync(Student student)
        {
            Student studentDb = await _searchService.FindStudentByIdAsync(student.Id);
            if (studentDb == null || !_validationEntities.EntityHasId(studentDb.Id))
            {
                return new StudentQuery(false, "An error occurred when recognizing the student " + student.CompleteName.CutCompleteName(), DateTime.Now, student);
            }
            await _connectionDb.DeleteRecordInTableByIdAsync(student.Id, "Students");
            return new StudentQuery(true, "Student " + student.CompleteName.CutCompleteName() + " deleted successfully", DateTime.Now, student);
        }

        public async Task<CourseQuery> DeleteCourseAsync(Course course)
        {
            if (course == null || !_validationEntities.EntityHasId(course.Id))
            {
                return new CourseQuery(false, "An error occurred when recognizing the course " + course.CourseName, DateTime.Now, course);
            }

            await _connectionDb.DeleteRecordInTableByIdAsync(course.Id, "Courses");
            return new CourseQuery(true, "Course " + course.CourseName + " deleted successfully", DateTime.Now, course);
        }

        public async Task<ClassroomQuery> DeleteClassroomAsync(Classroom classroom)
        {
            if (classroom == null || !_validationEntities.EntityHasId(classroom.Id))
            {
                return new ClassroomQuery(false, "An error occurred when recognizing the course " + classroom.ClassroomName, DateTime.Now, classroom);
            }

            await _connectionDb.DeleteRecordInTableByIdAsync(classroom.Id, "Classrooms");
            return new ClassroomQuery(true, "Classroom " + classroom.ClassroomName + " deleted successfully", DateTime.Now, classroom);
        }

        public async Task DeleteStudentsAsync(IEnumerable<Student> students) 
        {
            if (students.Any())
            {
                await _connectionDb.DeleteRecordsInTableByIdAsync(students
                    .Select(c => c.Id)
                    .ToList(), "Students");
            }
        }

        public async Task DeleteClassromsByCourseIdAsync(IEnumerable<Classroom> classrooms, int courseId) 
        {
            if (classrooms.Any()) 
            {
                await _connectionDb.DeleteRecordsInTableByIdAsync(classrooms
               .Where(c => c.CourseId == courseId)
               .Select(c => c.Id)
               .ToList(), "Classrooms");
            }
        }
    }
}
