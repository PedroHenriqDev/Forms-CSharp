using Datas;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FillEntitiesService
    {

        private readonly SearchEntitiesService SearchEntities = new SearchEntitiesService();
        private readonly ConnectionDb ConnectionDb = new ConnectionDb();

        public async Task FillCourseInClassroomAsync(IEnumerable<Classroom> classrooms) 
        {
            if (classrooms.Any()) 
            {
                foreach (var classroom in classrooms) 
                {
                    if (classroom.CourseId != null)
                    {
                        Course course = await SearchEntities.FindCourseByIdAsync(classroom.CourseId);
                        classroom.Course = course;
                    }
                }
            }
        }

        public async Task FillClassroomInStudentAsync(IEnumerable<Student> students) 
        {
            if(students != null) 
            {
                foreach (Student student in students)
                {
                    student.Classroom = await ConnectionDb.ReturnEntityByIdAsync<Classroom>(student.ClassroomId);
                }
            }
        }
    }
}
