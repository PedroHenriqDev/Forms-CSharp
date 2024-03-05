using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessLogic
{
    public class ValidationEntitiesBusiness
    {
        public bool IsValidNameCourse(string courseName, IEnumerable<Course> courses)
        {
            if (courses.Any(c => c.CourseName == courseName))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(courseName))
            {
                throw new NullReferenceException("Course name cannot be null or empty.");
            }

            for (int i = 0; i < courseName.Length; i++)
            {
                if (!char.IsLetter(courseName[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
