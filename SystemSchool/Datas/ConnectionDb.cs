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
                                    AND PasswordHash = HASHBYTES('SHA2_512', @passwordHash)";
                return await connection.QueryFirstOrDefaultAsync<User>(sqlQuery, new { username = user.Username, passwordHash = user.PasswordHash });
            }
        }

        public async Task<Class> ReturnClassByIdAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Classes WHERE Id = @id";
                Class classDb = await connection.QueryFirstOrDefaultAsync<Class>(sqlQuery, new { id = id });
                return classDb;
            }
        }

        public async Task<Course> ReturnCourseByNameAsync(string courseName)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Courses WHERE CourseName = @courseName";
                return await connection.QueryFirstOrDefaultAsync<Course>(sqlQuery, new { courseName = courseName });
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

        public async Task<Classroom> ReturnClassroomByNameAsync(string classroomName)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Classrooms WHERE ClassroomName = @classroomName";
                return await connection.QueryFirstOrDefaultAsync<Classroom>(sqlQuery, new { classroomName = classroomName });
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

        public async Task<IEnumerable<Classroom>> ReturnClassroomsByCourseIdAsync(int courseId)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Classrooms WHERE CourseId = @courseId";
                return await connection.QueryAsync<Classroom>(sqlQuery, new { courseId = courseId });
            }
        }


        public async Task<IEnumerable<Student>> ReturnStudentsByClassroomIdAsync(int classroomId)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Students WHERE ClassroomId = @classroomId";
                return await connection.QueryAsync<Student>(sqlQuery, new { classroomId = classroomId });
            }
        }

        public async Task CreateCourseInDbAsync(Course course)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"INSERT INTO Courses (Id, CourseName) VALUES (@Id, @CourseName)";

                await connection.ExecuteAsync(sqlQuery, new 
                {
                    Id = course.Id,
                    CourseName = course.CourseName  
                });
            }
        }

        public async Task CreateClassroomInDbAsync(Classroom classroom) 
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"INSERT INTO Classrooms (Id, ClassroomName, CourseId) 
                                    VALUES (@Id, @ClassroomName, @CourseId)";

                await connection.ExecuteAsync(sqlQuery, new
                {
                    Id = classroom.Id,
                    ClassroomName = classroom.ClassroomName,
                    CourseId = classroom.CourseId
                });
            }
        }

        public async Task CreateStudentInDbAsync(Student student) 
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
            {
                await connection.OpenAsync();
                string sqlQuery = @"INSERT INTO Students (Id, ClassroomId, CompleteName) 
                                    VALUES (@Id, @ClassroomId, @CompleteName)";

                await connection.ExecuteAsync(sqlQuery, new 
                {
                    Id = student.Id,
                    ClassroomId = student.ClassroomId,
                    CompleteName = student.CompleteName
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
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
            {
                await connection.OpenAsync();
                string idsToDelete = string.Join(",", recordIds);
                string tableName = typeof(T).Name + "s";
                string sqlQuery = $"DELETE FROM {tableName} WHERE Id IN ({idsToDelete})";
                await connection.ExecuteAsync(sqlQuery);
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
    }
}

