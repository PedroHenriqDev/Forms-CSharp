using Business.Extensions;
using Datas;
using Entities;
using Entities.Interfaces;
using Entities.TransientClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DeleteEntitiesService<T>
    {
        private readonly ConnectionDb _connectionDb;
        private readonly ValidationEntitiesService _validationEntities;
        private readonly SearchEntitiesService _searchService;

        public DeleteEntitiesService(ConnectionDb connectionDb, ValidationEntitiesService validationEntities, SearchEntitiesService searchService)
        {
            _connectionDb = connectionDb;
            _validationEntities = validationEntities;
            _searchService = searchService;
        }

        public async Task<EntityQuery<Student>> DeleteStudentAsync(Student student)
        {
            Student studentDb = await _searchService.FindStudentByIdAsync(student.Id);
            if (studentDb == null || !_validationEntities.EntityHasId(studentDb.Id))
            {
                return new EntityQuery<Student>(false, "An error occurred when recognizing the student " + student.CompleteName.CutCompleteName(), DateTime.Now, student);
            }
            await _connectionDb.DeleteRecordInTableByIdAsync<Student>(student.Id);
            return new EntityQuery<Student>(true, "Student " + student.CompleteName.CutCompleteName() + " deleted successfully", DateTime.Now, student);
        }

        public async Task<EntityQuery<Course>> DeleteCourseAsync(Course course)
        {
            if (course == null || !_validationEntities.EntityHasId(course.Id))
            {
                return new EntityQuery<Course>(false, "An error occurred when recognizing the course " + course.CourseName, DateTime.Now, course);
            }

            await _connectionDb.DeleteRecordInTableByIdAsync<Course>(course.Id);
            return new EntityQuery<Course>(true, "Course " + course.CourseName + " deleted successfully", DateTime.Now, course);
        }


        public async Task<EntityQuery<User>> DeleteUserAsync(User user)
        {
            if (user == null || !_validationEntities.EntityHasId(user.Id)) 
            {
                return new EntityQuery<User>(false, "An error ocurred when recognizing the user " + user.Username, DateTime.Now, user);
            }
            await _connectionDb.DeleteRecordInTableByIdAsync<User>(user.Id);
            return new EntityQuery<User>(true, "User " + user.Username + " deleted successfully", DateTime.Now, user);
        }

        public async Task<EntityQuery<Classroom>> DeleteClassroomAsync(Classroom classroom)
        {
            if (classroom == null || !_validationEntities.EntityHasId(classroom.Id))
            {
                return new EntityQuery<Classroom>(false, "An error occurred when recognizing the course " + classroom.ClassroomName, DateTime.Now, classroom);
            }

            await _connectionDb.DeleteRecordInTableByIdAsync<Classroom>(classroom.Id);
            return new EntityQuery<Classroom>(true, "Classroom " + classroom.ClassroomName + " deleted successfully", DateTime.Now, classroom);
        }

        public async Task DeleteStudentsAsync(IEnumerable<Student> students)
        {
            if (students.Any())
            {
                await _connectionDb.DeleteRecordsInTableByIdAsync<Student>(students
                    .Select(c => c.Id)
                    .ToList());
            }
        }

        public async Task DeleteClassromsByCourseIdAsync(IEnumerable<Classroom> classrooms, int courseId) 
        {
            if (classrooms.Any()) 
            {
                await _connectionDb.DeleteRecordsInTableByIdAsync<Classroom>(classrooms
               .Where(c => c.CourseId == courseId)
               .Select(c => c.Id)
               .ToList());
            }
        }
    }
}
