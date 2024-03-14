using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Dapper;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using Entities.Interfaces;

namespace Datas
{
    public class ConnectionDb
    {
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

        public async Task<Class> ReturnClassByIdAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Classes WHERE Id = @id";
                return await connection.QueryFirstOrDefaultAsync<Class>(sqlQuery, new { id = id });
            }
        }

        public async Task<Class> ReturnClassByNameAsync(string nameClass) 
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Classes WHERE NameClass = @nameClass";
                return await connection.QueryFirstOrDefaultAsync<Class>(sqlQuery, new { nameClass = nameClass });
            }
        }

        public async Task<T> ReturnEntityByIdAsync<T>(int id) where T : class
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string tableName = typeof(T).Name + "s";
                string sqlQuery = $"SELECT * FROM {tableName} WHERE Id = @id";
                return await connection.QueryFirstOrDefaultAsync<T>(sqlQuery, new { id = id });
            }
        }

        public async Task<T> ReturnEntityByNameAsync<T>(string name) where T : class
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

        public async Task<IEnumerable<T>> ReturnAllEntitiesAsync<T> () where T : class
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string tableName = typeof(T).Name + "s";
                string sqlQuery = $"SELECT * FROM {tableName}";
                return await connection.QueryAsync<T>(sqlQuery);
            }
        }

        public async Task<IEnumerable<Class>> ReturnAllClassesAsync() 
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Classes";
                return await connection.QueryAsync<Class>(sqlQuery);
            }
        }

        public async Task<IEnumerable<T>> ReturnEntitiesByReferenceIdAsync<T, TR>(TR entity) 
            where T : class, IEntity<T> 
            where TR : class, IEntity<TR>
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
            {
                await connection.OpenAsync();
                string tableName = typeof(T).Name + "s";
                string where = typeof(TR).Name + "Id";
                string sqlQuery = $"SELECT * FROM {tableName} WHERE {where} = @referenceId";
                return await connection.QueryAsync<T>(sqlQuery, new { referenceId = entity.Id, });
            }
        }

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

        public async Task CreateClassroomInDbAsync(Classroom classroom) 
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
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

        public async Task CreateUserInDbAsync(User user) 
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
            {
                await connection.OpenAsync();
                string sqlQuery = @"INSERT INTO Users (Id, Username, PasswordHash, ClassId, DateCreation) 
                                    VALUES (@Id, @Username, @PasswordHash, @ClassId, @DateCreation)";

                await connection.ExecuteAsync(sqlQuery, new
                {
                    Id = user.Id,
                    Username = user.Username,
                    PasswordHash = user.PasswordHash,
                    ClassId = user.ClassId,
                    DateCreation = user.DateCreation
                });
            }
        }

        public async Task CreateStudentInDbAsync(Student student) 
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
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

        public async Task DeleteRecordInTableByIdAsync<T>(int id) where T : class 
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string tableName = typeof(T).Name + "s";
                string sqlQuery = $"DELETE FROM {tableName} WHERE Id = @id";
                await connection.ExecuteAsync(sqlQuery, new { id = id });
            }
        }

        public async Task DeleteRecordsInTableByIdAsync<T>(IEnumerable<int> recordIds) where T : class
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

        public async Task EditUserInDbAsync(User user) 
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
            {
                await connection.OpenAsync();
                string sqlQuery = @"UPDATE Users SET ClassId = @classId, Username = @username WHERE Id = @id";

                await connection.ExecuteAsync(sqlQuery, new 
                {
                    classId = user.ClassId, 
                    username = user.Username,
                    id = user.Id
                });
            }
        }

        public async Task EditPasswordInDbAsync(User user) 
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
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

        public async Task EditClassroomInDbAsync(Classroom classroom) 
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
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

