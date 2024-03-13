using Datas;
using Entities;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SearchEntitiesService
    {
        private readonly ConnectionDb _connectionDb;

        public SearchEntitiesService(ConnectionDb connectionDb)
        {
            _connectionDb = connectionDb;
        }

        public async Task<T> FindEntityByIdAsync<T>(int id) where T : class, IEntity<T> 
        {
            return await _connectionDb.ReturnEntityByIdAsync<T>(id);
        } 

        public async Task<T> FindEntityByNameAsync<T>(string name) where T : class, IEntity<T> 
        {
            return await _connectionDb.ReturnEntityByNameAsync<T>(name);
        }

        public async Task<Class> FindClassByIdAsync(int classId) 
        {
            return await _connectionDb.ReturnClassByIdAsync(classId);
        }

        public async Task<IEnumerable<User>> FindUsersByClassAsync(Class displayClass) 
        {
            return await _connectionDb.ReturnEntitiesByReferenceIdAsync<User, Class>(displayClass);
        }

        public async Task<IEnumerable<T>> FindEntitiesByReferenceIdAsync<T, TR>(TR entity) 
            where T : class, IEntity<T> 
            where TR : class, IEntity<TR> 
        {
            return await _connectionDb.ReturnEntitiesByReferenceIdAsync<T, TR>(entity);
        }

        public async Task<IEnumerable<T>> FindAllEntitiesAsync<T>() where T : class, IEntity<T>
        {
            return await _connectionDb.ReturnAllEntitiesAsync<T>();
        }

        public async Task<IEnumerable<Class>> FindAllClassesAsync()
        {
            return await _connectionDb.ReturnAllClassesAsync();
        }

        public async Task<IEnumerable<User>> FindUsersByQueryAsync(string query)
        {
            IEnumerable<User> users = await _connectionDb.ReturnAllEntitiesAsync<User>();
            if (query == null)
            {
                return users;
            }

            return users.Where(c => c.Username.ToLower().Contains(query.ToLower())).ToList();
        }

        public async Task<IEnumerable<Student>> FindStudentByQueryAsync(string query)
        {
            IEnumerable<Student> students = await _connectionDb.ReturnAllEntitiesAsync<Student>();

            if (query == null)
            {
                return students;
            }

            return students.Where(s => s.CompleteName.ToLower().Contains(query.ToLower())).ToList();
        }

        public async Task<IEnumerable<Classroom>> FindClassroomByQueryAsync(string query, IEnumerable<Classroom> classrooms)
        {
            if (classrooms == null)
            {
                return classrooms;
            }

            return classrooms.Where(c => c.ClassroomName.ToLower().Contains(query.ToLower()) || c.Course.CourseName.ToLower().Contains(query.ToLower()));
        }

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
