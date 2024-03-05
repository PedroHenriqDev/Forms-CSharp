using Datas;
using Entities;
using Entities.TransientClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessLogic
{
    public class CreateEntitiesBusiness<T>
    {
        private readonly ConnectionDb ConnectionDb = new ConnectionDb();
        private readonly ValidationEntitiesBusiness<T> validationEntities = new ValidationEntitiesBusiness<T>();
        
        public async Task<CreateCourseQuery> CreateCourseAsync(Course course)
        {
            if (validationEntities.IsValidNameCourse(course.CourseName, await ConnectionDb.ReturnAllCoursesAsync()))
            {
                await ConnectionDb.CreateCourseInDbAsync(course);
                return new CreateCourseQuery(true, "Course " + course.CourseName + " created successfully!", DateTime.Now, course);
            }
            return new CreateCourseQuery(false, course.CourseName + " course already exists", DateTime.Now, course);
        }
    }
}
