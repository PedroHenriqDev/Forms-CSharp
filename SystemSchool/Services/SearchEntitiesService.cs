using Datas;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SearchEntitiesService
    {
        private readonly ConnectionDb _connectionDb;

        public SearchEntitiesService(ConnectionDb connectionDb)
        {
            _connectionDb = connectionDb;
        }

        public async Task<IEnumerable<Course>> FindAllCoursesAsync()
        {
            return await _connectionDb.ReturnAllEntitiesAsync<Course>();
        }

        public async Task<Classroom> FindClassroomByNameAsync(string classroomName)
        {
            return await _connectionDb.ReturnClassroomByNameAsync(classroomName);
        }

        public async Task<Classroom> FindClassroomByIdAsync(int classroomId)
        {
            return await _connectionDb.ReturnEntityByIdAsync<Classroom>(classroomId);
        }

        public async Task<IEnumerable<Student>> FindStudentByQueryAsync(string query)
        {
            IEnumerable<Student> students = await _connectionDb.ReturnAllEntitiesAsync<Student>();

            if (query == null)
            {
                return students;
            }

            return students.Where(s => s.CompleteName.ToLower().Contains(query.ToLower())).ToList();
        }

        public async Task<IEnumerable<User>> FindUsersByClassAsync(Class displayClass) 
        {
            return await _connectionDb.ReturnEntitiesByReferenceIdAsync<User, Class>(displayClass);
        }

        public async Task<Student> FindStudentByIdAsync(int id)
        {
            return await _connectionDb.ReturnEntityByIdAsync<Student>(id);
        }

        public async Task<IEnumerable<Classroom>> FindClassroomsByCourseNameAsync(Course course)
        {
            return await _connectionDb.ReturnEntitiesByReferenceIdAsync<Classroom, Course>(course);
        }

        public async Task<IEnumerable<Classroom>> FindAllClassroomsAsync()
        {
            return await _connectionDb.ReturnAllEntitiesAsync<Classroom>();
        }

        public async Task<IEnumerable<Classroom>> FindClassroomByQueryAsync(string query, IEnumerable<Classroom> classrooms)
        {
            if (classrooms == null)
            {
                return classrooms;
            }

            return classrooms.Where(c => c.ClassroomName.ToLower().Contains(query.ToLower()) || c.Course.CourseName.ToLower().Contains(query.ToLower()));
        }

        public async Task<IEnumerable<Student>> FindAllStudentsAsync()
        {
            return await _connectionDb.ReturnAllEntitiesAsync<Student>();
        }

        public async Task<IEnumerable<Class>> FindAllClassesAsync()
        {
            return await _connectionDb.ReturnAllClassesAsync();
        }

        public async Task<Course> FindCourseByNameAsync(string courseName)
        {
            return await _connectionDb.ReturnCourseByNameAsync(courseName);
        }

        public async Task<Course> FindCourseByIdAsync(int courseId)
        {
            return await _connectionDb.ReturnEntityByIdAsync<Course>(courseId);
        }

        public async Task<IEnumerable<Student>> FindStudentsByClassroomNameAsync(Classroom classroom)
        {
            return await _connectionDb.ReturnEntitiesByReferenceIdAsync<Student, Classroom>(classroom);
        }

        public async Task<IEnumerable<char>> FindLettersAvailableBySchoolYearAsync(string schoolYear)
        {
            IEnumerable<Classroom> classrooms = await _connectionDb.ReturnAllEntitiesAsync<Classroom>();

            IEnumerable<char> existingLetters = classrooms.Where(c => c.ClassroomName[0] == schoolYear[0]).Select(c => c.ClassroomName[1])
                .Where(letter => char.IsLetter(letter) && letter < 'E');

            return Enumerable.Range('A', 'D' - 'A' + 1)
                .Select(letter => (char)letter)
                .Except(existingLetters);
        }
    }
}
