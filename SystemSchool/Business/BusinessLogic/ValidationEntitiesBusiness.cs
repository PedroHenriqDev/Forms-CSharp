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
            return !EqualEntityInSet(courses.Select(c => c.CourseName).ToList(), courseName) 
                && !HasNumbersInString(courseName) 
                && !string.IsNullOrWhiteSpace(courseName);
        }

        public bool HasNumbersInString(string entity)
        {
            for (int i = 0; i < entity.Length; i++)
            {
                if (!char.IsLetter(entity[i]))
                {
                    return true;
                }
            }
            return false;
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
