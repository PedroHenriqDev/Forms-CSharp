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

        private readonly SearchEntitiesService _searchEntities;

        public FillEntitiesService(SearchEntitiesService searchEntities)
        {
            _searchEntities = searchEntities;
        }

        public async Task FillCourseInClassroomAsync(IEnumerable<Classroom> classrooms) 
        {
            if (classrooms.Any()) 
            {
                foreach (var classroom in classrooms) 
                {
                    if (classroom.CourseId != null)
                    {
                        Course course = await _searchEntities.FindCourseByIdAsync(classroom.CourseId);
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
                    student.Classroom = await _searchEntities.FindClassroomByIdAsync(student.ClassroomId);
                }
            }
        }
    }
}
