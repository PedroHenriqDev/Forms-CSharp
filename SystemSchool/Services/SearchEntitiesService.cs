using Datas;
using Entities;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// Provides methods to search entities in the database.
    /// </summary>
    public class SearchEntitiesService
    {
        private readonly ConnectionDb _connectionDb;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchEntitiesService"/> class.
        /// </summary>
        /// <param name="connectionDb">The database connection.</param>
        public SearchEntitiesService(ConnectionDb connectionDb)
        {
            _connectionDb = connectionDb ?? throw new ArgumentNullException(nameof(connectionDb));
        }

        /// <summary>
        /// Finds an entity by its ID asynchronously.
        /// </summary>
        /// <typeparam name="T">The type of entity.</typeparam>
        /// <param name="id">The ID of the entity to find.</param>
        /// <returns>A task representing the asynchronous operation and containing the found entity.</returns>
        public async Task<T> FindEntityByIdAsync<T>(int id) where T : class, IEntity<T>
        {
            return await _connectionDb.ReturnEntityByIdAsync<T>(id);
        }

        /// <summary>
        /// Finds an entity by its name asynchronously.
        /// </summary>
        /// <typeparam name="T">The type of entity.</typeparam>
        /// <param name="name">The name of the entity to find.</param>
        /// <returns>A task representing the asynchronous operation and containing the found entity.</returns>
        public async Task<T> FindEntityByNameAsync<T>(string name) where T : class, IEntity<T>
        {
            return await _connectionDb.ReturnEntityByNameAsync<T>(name);
        }

        /// <summary>
        /// Finds entities by a reference entity ID asynchronously.
        /// </summary>
        /// <typeparam name="T">The type of entities to find.</typeparam>
        /// <typeparam name="TR">The type of reference entity.</typeparam>
        /// <param name="entity">The reference entity.</param>
        /// <returns>A task representing the asynchronous operation and containing the found entities.</returns>
        public async Task<IEnumerable<T>> FindEntitiesByReferenceIdAsync<T, TR>(TR entity)
            where T : class, IEntity<T>
            where TR : class, IEntity<TR>
        {
            return await _connectionDb.ReturnEntitiesByReferenceIdAsync<T, TR>(entity);
        }

        /// <summary>
        /// Finds all entities of a given type asynchronously.
        /// </summary>
        /// <typeparam name="T">The type of entities to find.</typeparam>
        /// <returns>A task representing the asynchronous operation and containing the found entities.</returns>
        public async Task<IEnumerable<T>> FindAllEntitiesAsync<T>() where T : class, IEntity<T>
        {
            return await _connectionDb.ReturnAllEntitiesAsync<T>();
        }

        /// <summary>
        /// Finds users matching a query asynchronously.
        /// </summary>
        /// <param name="query">The query string.</param>
        /// <returns>A task representing the asynchronous operation and containing the found users.</returns>
        public async Task<IEnumerable<User>> FindUsersByQueryAsync(string query)
        {
            IEnumerable<User> users = await _connectionDb.ReturnAllEntitiesAsync<User>();
            if (query == null)
            {
                return users;
            }

            return users.Where(c => c.Username.ToLower().Contains(query.ToLower())).ToList();
        }

        /// <summary>
        /// Finds students matching a query asynchronously.
        /// </summary>
        /// <param name="query">The query string.</param>
        /// <returns>A task representing the asynchronous operation and containing the found students.</returns>
        public async Task<IEnumerable<Student>> FindStudentByQueryAsync(string query)
        {
            IEnumerable<Student> students = await _connectionDb.ReturnAllEntitiesAsync<Student>();

            if (query == null)
            {
                return students;
            }

            return students.Where(s => s.CompleteName.ToLower().Contains(query.ToLower())).ToList();
        }

        /// <summary>
        /// Finds classrooms matching a query asynchronously.
        /// </summary>
        /// <param name="query">The query string.</param>
        /// <param name="classrooms">The list of classrooms to search in.</param>
        /// <returns>A task representing the asynchronous operation and containing the found classrooms.</returns>
        public async Task<IEnumerable<Classroom>> FindClassroomsByQueryAsync(string query, IEnumerable<Classroom> classrooms)
        {
            if (classrooms == null)
            {
                return classrooms;
            }

            return classrooms.Where(c => c.ClassroomName.ToLower().Contains(query.ToLower()) || c.Course.CourseName.ToLower().Contains(query.ToLower()));
        }

        /// <summary>
        /// Finds available letters for a school year asynchronously.
        /// </summary>
        /// <param name="schoolYear">The school year.</param>
        /// <returns>A task representing the asynchronous operation and containing the available letters.</returns>
        public async Task<IEnumerable<char>> FindLettersAvailableBySchoolYearAsync(string schoolYear)
        {
            IEnumerable<Classroom> classrooms = await _connectionDb.ReturnAllEntitiesAsync<Classroom>();

            IEnumerable<char> existingLetters = classrooms.Where(c => c.ClassroomName[0] == schoolYear[0]).Select(c => c.ClassroomName[1])
                .Where(letter => char.IsLetter(letter) && letter < 'E');

            return Enumerable.Range('A', 'D' - 'A' + 1)
                .Select(letter => (char)letter)
                .Except(existingLetters);
        }
    }
}
