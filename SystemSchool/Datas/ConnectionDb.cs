using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Dapper;
using Entities.Interfaces;

namespace Datas
{
    /// <summary>
    /// Class responsible for managing the connection to the database and performing related operations.
    /// </summary>
    public class ConnectionDb
    {
        /// <summary>
        /// Verifies the credentials of a user in the database.
        /// </summary>
        /// <param name="user">The user whose credentials should be verified.</param>
        /// <returns>The user if the credentials are correct, otherwise null.</returns>
        public async Task<User> VerifyCredentialsAsync(User user)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Users 
                    WHERE Username = @username COLLATE SQL_Latin1_General_CP1_CS_AS 
                    AND PasswordHash = @passwordHash";
                return await connection.QueryFirstOrDefaultAsync<User>(sqlQuery, new { username = user.Username, passwordHash = user.PasswordHash });
            }
        }

        /// <summary>
        /// Returns an entity by its database ID.
        /// </summary>
        /// <typeparam name="T">The type of entity to return.</typeparam>
        /// <param name="id">The ID of the entity.</param>
        /// <returns>The entity corresponding to the specified ID.</returns>
        public async Task<T> ReturnEntityByIdAsync<T>(int id) where T : class, IEntity<T>
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string tableName = typeof(T).Name + "s";
                string sqlQuery = $"SELECT * FROM {tableName} WHERE Id = @id";
                return await connection.QueryFirstOrDefaultAsync<T>(sqlQuery, new { id = id });
            }
        }

        /// <summary>
        /// Returns an entity by its database name.
        /// </summary>
        /// <typeparam name="T">The type of entity to return.</typeparam>
        /// <param name="name">The name of the entity.</param>
        /// <returns>The entity corresponding to the specified name.</returns>
        public async Task<T> ReturnEntityByNameAsync<T>(string name) where T : class, IEntity<T>
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string tableName = typeof(T).Name + "s";
                string where = typeof(T).Name + "Name";
                string sqlQuery = $"SELECT * FROM {tableName} WHERE {where} = @name";
                return await connection.QueryFirstOrDefaultAsync<T>(sqlQuery, new { name = name });
            }
        }

        /// <summary>
        /// Returns all entities of a type from the database.
        /// </summary>
        /// <typeparam name="T">The type of entity to return.</typeparam>
        /// <returns>A collection of all entities of the specified type.</returns>
        public async Task<IEnumerable<T>> ReturnAllEntitiesAsync<T>() where T : class, IEntity<T>
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string tableName = typeof(T).Name + "s";
                string sqlQuery = $"SELECT * FROM {tableName}";
                return await connection.QueryAsync<T>(sqlQuery);
            }
        }

        /// <summary>
        /// Returns entities by reference ID from the database.
        /// </summary>
        /// <typeparam name="T">The type of entity to return.</typeparam>
        /// <typeparam name="TR">The type of reference entity.</typeparam>
        /// <param name="entity">The reference entity.</param>
        /// <returns>A collection of entities of the specified type referenced by the reference entity's ID.</returns>
        public async Task<IEnumerable<T>> ReturnEntitiesByReferenceIdAsync<T, TR>(TR entity)
            where T : class, IEntity<T>
            where TR : class, IEntity<TR>
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string tableName = typeof(T).Name + "s";
                string where = typeof(TR).Name + "Id";
                string sqlQuery = $"SELECT * FROM {tableName} WHERE {where} = @referenceId";
                return await connection.QueryAsync<T>(sqlQuery, new { referenceId = entity.Id, });
            }
        }
        /// <summary>
        /// Creates a new course in the database asynchronously.
        /// </summary>
        /// <param name="course">The course to create.</param>
        public async Task CreateCourseInDbAsync(Course course)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"INSERT INTO Courses (Id, CourseName, DateCreation) VALUES (@Id, @CourseName, @DateCreation)";

                await connection.ExecuteAsync(sqlQuery, new
                {
                    Id = course.Id,
                    CourseName = course.CourseName,
                    DateCreation = course.DateCreation
                });
            }
        }

        /// <summary>
        /// Creates a new classroom in the database asynchronously.
        /// </summary>
        /// <param name="classroom">The classroom to create.</param>
        public async Task CreateClassroomInDbAsync(Classroom classroom)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"INSERT INTO Classrooms (Id, ClassroomName, CourseId, DateCreation) 
                                    VALUES (@Id, @ClassroomName, @CourseId, @DateCreation)";

                await connection.ExecuteAsync(sqlQuery, new
                {
                    Id = classroom.Id,
                    ClassroomName = classroom.ClassroomName,
                    CourseId = classroom.CourseId,
                    DateCreation = classroom.DateCreation,
                });
            }
        }

        /// <summary>
        /// Creates a new user in the database asynchronously.
        /// </summary>
        /// <param name="user">The user to create.</param>
        public async Task CreateUserInDbAsync(User user)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"INSERT INTO Users (Id, Username, PasswordHash, GroupId, DateCreation) 
                                    VALUES (@Id, @Username, @PasswordHash, @ClassId, @DateCreation)";

                await connection.ExecuteAsync(sqlQuery, new
                {
                    Id = user.Id,
                    Username = user.Username,
                    PasswordHash = user.PasswordHash,
                    ClassId = user.GroupId,
                    DateCreation = user.DateCreation
                });
            }
        }

        /// <summary>
        /// Creates a new student in the database asynchronously.
        /// </summary>
        /// <param name="student">The student to create.</param>
        public async Task CreateStudentInDbAsync(Student student)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"INSERT INTO Students (Id, ClassroomId, CompleteName, DateCreation) 
                                    VALUES (@Id, @ClassroomId, @CompleteName, @DateCreation)";

                await connection.ExecuteAsync(sqlQuery, new
                {
                    Id = student.Id,
                    ClassroomId = student.ClassroomId,
                    CompleteName = student.CompleteName,
                    DateCreation = student.DateCreation
                });
            }
        }

        /// <summary>
        /// Deletes a record from a table by its ID asynchronously.
        /// </summary>
        /// <typeparam name="T">The type of entity.</typeparam>
        /// <param name="id">The ID of the record to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task DeleteRecordInTableByIdAsync<T>(int id) where T : class, IEntity<T>
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string tableName = typeof(T).Name + "s";
                string sqlQuery = $"DELETE FROM {tableName} WHERE Id = @id";
                await connection.ExecuteAsync(sqlQuery, new { id = id });
            }
        }

        /// <summary>
        /// Deletes multiple records from a table by their IDs asynchronously.
        /// </summary>
        /// <typeparam name="T">The type of entity.</typeparam>
        /// <param name="recordIds">The IDs of the records to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task DeleteRecordsInTableByIdAsync<T>(IEnumerable<int> recordIds) where T : class, IEntity<T>
        {
            if (recordIds.Any() && recordIds.Count() > 0)
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
                {
                    await connection.OpenAsync();
                    string idsToDelete = string.Join(",", recordIds);
                    string tableName = typeof(T).Name + "s";
                    string sqlQuery = $"DELETE FROM {tableName} WHERE Id IN ({idsToDelete})";
                    await connection.ExecuteAsync(sqlQuery);
                }
            }
        }

        /// <summary>
        /// Updates a student record in the database asynchronously.
        /// </summary>
        /// <param name="student">The student to update.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task EditStudentInDbAsync(Student student)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"UPDATE Students 
                                    SET CompleteName = @completeName, ClassroomId = @classroomId 
                                    WHERE Id = @id";

                await connection.ExecuteAsync(sqlQuery, new
                {
                    completeName = student.CompleteName,
                    classroomId = student.Classroom.Id,
                    id = student.Id,
                });
            }
        }

        /// <summary>
        /// Updates a user record in the database asynchronously.
        /// </summary>
        /// <param name="user">The user to update.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task EditUserInDbAsync(User user)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"UPDATE Users SET GroupId = @groupId, Username = @username WHERE Id = @id";

                await connection.ExecuteAsync(sqlQuery, new
                {
                    groupId = user.GroupId,
                    username = user.Username,
                    id = user.Id
                });
            }
        }

        /// <summary>
        /// Updates a password record in the database asynchronously.
        /// </summary>
        /// <param name="user">The user whose password is to be updated.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task EditPasswordInDbAsync(User user)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"UPDATE Users SET PasswordHash = @passwordHash WHERE Id = @id";

                await connection.ExecuteAsync(sqlQuery, new
                {
                    passwordHash = user.PasswordHash,
                    Id = user.Id
                });
            }
        }

        /// <summary>
        /// Updates a classroom record in the database asynchronously.
        /// </summary>
        /// <param name="classroom">The classroom to update.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task EditClassroomInDbAsync(Classroom classroom)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"UPDATE Classrooms 
                                    SET CourseId = @courseId
                                    WHERE Id = @id";

                await connection.ExecuteAsync(sqlQuery, new
                {
                    CourseId = classroom.CourseId,
                    Id = classroom.Id,
                });
            }
        }
    }
}

