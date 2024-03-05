using Datas;
using Entities;
using Entities.TransientClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessLogic
{
    public class CreateEntitiesBusiness
    {
        private readonly ConnectionDb ConnectionDb = new ConnectionDb();

        public async Task<CreateCourseQuery> CreateCourseAsync(Course course)
        {
            IEnumerable<Course> courses = await ConnectionDb.ReturnAllCoursesAsync();

            if (courses.Any(c => c.CourseName == course.CourseName))
            {
                return new CreateCourseQuery(false, course.CourseName + " course already exists", DateTime.Now, course);
            }
            else
            {
                await ConnectionDb.CreateCourseInDbAsync(course);
                return new CreateCourseQuery(true, "Course " + course.CourseName + " created successfully!", DateTime.Now, course);
            }
        }

    }
}
