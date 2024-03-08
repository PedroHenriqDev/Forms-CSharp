using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessLogic
{
    public class FillEntitiesBusiness
    {

        SearchEntitiesBusiness SearchEntities = new SearchEntitiesBusiness();

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
