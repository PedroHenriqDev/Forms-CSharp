using Datas;
using Entities;
using Entities.TransientClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessLogic
{
    public class CreateEntitiesBusiness
    {
        private readonly ConnectionDb ConnectionDb = new ConnectionDb();

        public async Task<CreateCourseQuery> CreateCourseAsync(Course course)
        {
            if (await ConnectionDb.ExistThatCourseAsync(course.CourseName))
            {
                return new CreateCourseQuery(false, course.CourseName + " course already exists", DateTime.Now, course);
            }
            else
            {
                await ConnectionDb.CreateCourseInDbAsync(course);
                CreateCourseQuery courseQuery = new CreateCourseQuery(true, "Course " + course.CourseName + " created successfully!", DateTime.Now, course);
                return courseQuery;
            }
        }
    }
}
