using Datas;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessLogic
{
    public class SearchEntitiesBusiness
    {
        private readonly ConnectionDb ConnectionDb = new ConnectionDb();

        public async Task<IEnumerable<Course>> FindAllCoursesAsync() 
        {
            return await ConnectionDb.ReturnAllCoursesAsync();
        }

        public async Task<Classroom> FindClassroomByNameAsync(string classroomName) 
        {
            return await ConnectionDb.ReturnClassroomByNameAsync(classroomName);
        }

        public async Task<Classroom> FindClassroomByIdAsync(int classroomId) 
        {
            return await ConnectionDb.ReturnClassroomByIdAsync(classroomId);
        }

        public async Task<IEnumerable<Student>> FindStudentByQueryAsync(string query) 
        {
            IEnumerable<Student> students =  await ConnectionDb.ReturnAllStudentsAsync();

            if (query == null) 
            {
                return students;
            }

            foreach (Student student in students)
            {
                student.Classroom = await ConnectionDb.ReturnClassroomByIdAsync(student.ClassroomId);
            }

            return students.Where(s => s.CompleteName.ToLower().Contains(query.ToLower())).ToList();
        }

        public async Task<Student> FindStudentByIdAsync(int id) 
        {
            return await ConnectionDb.ReturnStudentByIdAsync(id);
        }

        public async Task<IEnumerable<Classroom>> FindClassroomsByCourseNameAsync(string courseName) 
        {
            Course course = await FindCourseByNameAsync(courseName);
            return await ConnectionDb.ReturnClassroomsByCourseIdAsync(course.Id);
        }

        public async Task<IEnumerable<Classroom>> FindAllClassroomsAsync() 
        {
            return await ConnectionDb.ReturnAllClassromsAsync();
        }

        public async Task<IEnumerable<Student>> FindAllStudentsAsync() 
        {
            return await ConnectionDb.ReturnAllStudentsAsync();
        }

        public async Task<Course> FindCourseByNameAsync(string courseName) 
        {
            return await ConnectionDb.ReturnCourseByNameAsync(courseName);
        }

        public async Task<Course> FindCourseByIdAsync(int courseId) 
        {
            return await ConnectionDb.ReturnCourseByIdAsync(courseId);
        }

        public async Task<IEnumerable<Student>> FindStudentsByClassroomNameAsync(string ClassroomName) 
        {
            Classroom classroom = await ConnectionDb.ReturnClassroomByNameAsync(ClassroomName);
            return await ConnectionDb.ReturnStudentsByClassroomIdAsync(classroom.Id);
        }

        public async Task<IEnumerable<char>> FindLettersAvailableBySchoolYearAsync(string schoolYear) 
        {
            IEnumerable<Classroom> classrooms = await ConnectionDb.ReturnAllClassromsAsync();
            
            IEnumerable<char> existingLetters = classrooms.Where(c => c.ClassroomName[0] == schoolYear[0]).Select(c => c.ClassroomName[1])
                .Where(letter => char.IsLetter(letter) && letter < 'E');

            return Enumerable.Range('A', 'D' - 'A' + 1)
                .Select(letter => (char)letter)
                .Except(existingLetters);
        }
    }
}
