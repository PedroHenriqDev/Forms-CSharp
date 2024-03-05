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

        public async Task<IEnumerable<Classroom>> FindClassroomsByCourseNameAsync(string courseName) 
        {
            Course course = await FindCourseByNameAsync(courseName);
            return await ConnectionDb.ReturnClassroomsByCourseIdAsync(course.CourseId);
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
            return await ConnectionDb.FindCourseByNameAsync(courseName);
        }

        public async Task<IEnumerable<Student>> FindStudentsByClassroomNameAsync(string ClassroomName) 
        {
            Classroom classroom = await ConnectionDb.FindClassroomByNameAsync(ClassroomName);
            return await ConnectionDb.ReturnStudentsByClassroomIdAsync(classroom.ClassroomId);
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
