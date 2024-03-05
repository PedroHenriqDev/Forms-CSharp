using Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessLogic
{
    public class ValidationEntitiesBusiness<T>
    {
        public bool IsValidNameCourse(string courseName, IEnumerable<Course> courses)
        {
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

            List<string> courseNames = courses.Select(c => c.CourseName).ToList();
            return !EqualEntityInSet(courseNames, courseName);
        }

        public bool EqualEntityInSet<T>(IEnumerable<T> entities, T entity) 
        {
            List<string> entitiesToLower = new List<string>();

            foreach(var ent in entities) 
            {
                entitiesToLower.Add(ent.ToString().ToLower());
            }

            if(entitiesToLower.Any(t => t.Equals(entity.ToString().ToLower())))
            {
                return true;
            }
            return false;
        }
    }
}
