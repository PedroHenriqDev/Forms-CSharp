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

        SearchEntitiesService SearchEntities = new SearchEntitiesService();

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
    }
}
