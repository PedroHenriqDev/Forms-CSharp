using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Expections;
using Datas;

namespace Services
{
    public class ValidationEntitiesService
    {

        private readonly ConnectionDb _connectionDb;
        
        public ValidationEntitiesService(ConnectionDb connectionDb) 
        {
            _connectionDb = connectionDb;
        }

        public async Task<bool> IsValidCourseAsync(Course course)
        {
            IEnumerable<Course> courses = await _connectionDb.ReturnAllEntitiesAsync<Course>();
            if(course == null || string.IsNullOrWhiteSpace(course.CourseName)) 
            {
                throw new ArgumentNullException("The course cannot be empty!");
            }

            return !EqualEntityInSet(courses.Select(c => c.CourseName).ToList(), course.CourseName)
                && !HasNumbersInString(course.CourseName)
                && EntityHasId(course.Id);
        }

        public async Task<bool> IsValidUserAsync(User user) 
        {
            IEnumerable<User> users = await _connectionDb.ReturnAllEntitiesAsync<User>();

            if (user == null|| string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrEmpty(user.PasswordHash))
            {
                throw new ArgumentNullException("User credentials cannot be empty");
            }

            return !EqualEntityInSet(users.Select(u => u.Username).ToList(), user.Username)
                && EntityHasId(user.Id)
                && EntityHasId(user.GroupId)
                && !HasNumbersInString(user.Username);
        }

        public bool IsValidStudent(Student student) 
        {
            if (student == null || string.IsNullOrEmpty(student.CompleteName)) 
            {
                throw new ArgumentNullException("The student cannot be empty!");
            }

            return !HasNumbersInString(student.CompleteName)
                && EntityHasId(student.Id);
        }

        public async Task<bool> IsValidClassroomAsync(Classroom classroom)
        {
            IEnumerable<Classroom> classrooms = await _connectionDb.ReturnAllEntitiesAsync<Classroom>();

            if (classroom == null || string.IsNullOrEmpty(classroom.ClassroomName))
            {
                throw new ArgumentNullException("The classroom cannot be empty!");
            }

            return !EqualEntityInSet(classrooms.Select(c => c.ClassroomName).ToList(), classroom.ClassroomName)
                && ClassroomNameIsInCorrectOrder(classroom.ClassroomName)
                && EntityHasId(classroom.Id);
        }

        public bool EntityHasId(int id) 
        {
            if(id == 0 || id <= 0) 
            {
                throw new EntityException("The attempt to create an object failed, due to a lack of Identification (Id)!");
            }
            return true;
        }

        public bool ClassroomNameIsInCorrectOrder(string entity) 
        {
            if(entity == null || entity.Length > 2) 
            {
                throw new ArgumentNullException("The classroom name cannot be null, and must be 2 characters long");
            }

            if (!char.IsNumber(entity[0]) || !char.IsLetter(entity[1]))
            {
                return false;
            }
            return true;
        }

        public bool HasNumbersInString(string entity)
        {
           foreach(char c in entity) 
           {
               if(!char.IsLetter(c) && !char.IsWhiteSpace(c)) 
               {
                    throw new EntityException("You cannot have numbers in the field");
               }          
           }

            return false;
        }

        public bool EqualEntityInSet<T>(IEnumerable<T> entities, T entity)
        {
            if (entity is string) 
            {
                List<string> entitiesToLower = new List<string>();
                foreach (var ent in entities)
                {
                    entitiesToLower.Add(ent.ToString().ToLower());
                }

                if (entity == null || entitiesToLower.Any(e => e.Equals(entity.ToString().ToLower())))
                {
                    return true;
                }
                return false;
            }
            else if(entity is int)
            {
                if (entity == null || entities.Any(e => e.Equals(entity)))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
