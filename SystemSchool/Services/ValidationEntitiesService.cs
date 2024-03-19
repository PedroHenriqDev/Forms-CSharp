using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Expections;
using Datas;

namespace Services
{
    /// <summary>
    /// Provides methods to validate entities before saving them to the database.
    /// </summary>
    public class ValidationEntitiesService
    {
        private readonly ConnectionDb _connectionDb;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationEntitiesService"/> class.
        /// </summary>
        /// <param name="connectionDb">The database connection.</param>
        public ValidationEntitiesService(ConnectionDb connectionDb)
        {
            _connectionDb = connectionDb ?? throw new ArgumentNullException(nameof(connectionDb));
        }

        /// <summary>
        /// Validates if the provided course is valid.
        /// </summary>
        /// <param name="course">The course to validate.</param>
        /// <returns>A task representing the asynchronous operation and indicating whether the course is valid or not.</returns>
        public async Task<bool> IsValidCourseAsync(Course course)
        {
            IEnumerable<Course> courses = await _connectionDb.ReturnAllEntitiesAsync<Course>();

            if (course == null || string.IsNullOrWhiteSpace(course.CourseName))
            {
                throw new ArgumentNullException("The course cannot be empty!");
            }

            return !EqualEntityInSet(courses.Select(c => c.CourseName).ToList(), course.CourseName)
                && !HasNumbersInString(course.CourseName)
                && EntityHasId(course.Id);
        }

        /// <summary>
        /// Validates if the provided user is valid.
        /// </summary>
        /// <param name="user">The user to validate.</param>
        /// <returns>A task representing the asynchronous operation and indicating whether the user is valid or not.</returns>
        public async Task<bool> IsValidUserAsync(User user)
        {
            IEnumerable<User> users = await _connectionDb.ReturnAllEntitiesAsync<User>();

            if (user == null || string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrEmpty(user.PasswordHash))
            {
                throw new ArgumentNullException("User credentials cannot be empty");
            }

            return !EqualEntityInSet(users.Select(u => u.Username).ToList(), user.Username)
                && EntityHasId(user.Id)
                && EntityHasId(user.GroupId)
                && !HasNumbersInString(user.Username);
        }

        /// <summary>
        /// Validates if the provided student is valid.
        /// </summary>
        /// <param name="student">The student to validate.</param>
        /// <returns>True if the student is valid; otherwise, false.</returns>
        public bool IsValidStudent(Student student)
        {
            if (student == null || string.IsNullOrEmpty(student.CompleteName))
            {
                throw new ArgumentNullException("The student cannot be empty!");
            }

            return !HasNumbersInString(student.CompleteName)
                && EntityHasId(student.Id);
        }

        /// <summary>
        /// Validates if the provided classroom is valid.
        /// </summary>
        /// <param name="classroom">The classroom to validate.</param>
        /// <returns>A task representing the asynchronous operation and indicating whether the classroom is valid or not.</returns>
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

        /// <summary>
        /// Checks if an entity has a valid ID.
        /// </summary>
        /// <param name="id">The ID of the entity.</param>
        /// <returns>True if the ID is valid; otherwise, throws an exception.</returns>
        public bool EntityHasId(int id)
        {
            if (id == 0 || id <= 0)
            {
                throw new EntityException("The attempt to create an object failed, due to a lack of Identification (Id)!");
            }
            return true;
        }

        /// <summary>
        /// Validates if the classroom name is in the correct format.
        /// </summary>
        /// <param name="entity">The classroom name to validate.</param>
        /// <returns>True if the classroom name is in the correct format; otherwise, false.</returns>
        public bool ClassroomNameIsInCorrectOrder(string entity)
        {
            if (entity == null || entity.Length > 2)
            {
                throw new ArgumentNullException("The classroom name cannot be null, and must be 2 characters long");
            }

            if (!char.IsNumber(entity[0]) || !char.IsLetter(entity[1]))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if the string contains any numbers.
        /// </summary>
        /// <param name="entity">The string to check.</param>
        /// <returns>True if the string contains numbers; otherwise, throws an exception.</returns>
        public bool HasNumbersInString(string entity)
        {
            foreach (char c in entity)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    throw new EntityException("You cannot have numbers in the field");
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if the provided entity is equal to any entity in the set.
        /// </summary>
        /// <typeparam name="T">The type of entity.</typeparam>
        /// <param name="entities">The set of entities.</param>
        /// <param name="entity">The entity to check.</param>
        /// <returns>True if the entity is equal to any entity in the set; otherwise, false.</returns>
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
            else if (entity is int)
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
