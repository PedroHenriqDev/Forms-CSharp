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

        public async Task<Class> ReturnClassByIdAsync(int Id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Classes WHERE ClassId = @classId";
                Class classDb = await connection.QueryFirstOrDefaultAsync<Class>(sqlQuery, new { Id = Id });
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

        public async Task<IEnumerable<Course>> ReturnAllCoursesAsync()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Courses";
                return await connection.QueryAsync<Course>(sqlQuery);
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

        public async Task<Classroom> ReturnClassroomByIdAsync(int Id) 
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Classrooms WHERE Id = @Id";
                return await connection.QueryFirstOrDefaultAsync<Classroom>(sqlQuery, new { Id = Id });
            }
        }

        public async Task<IEnumerable<Classroom>> ReturnAllClassromsAsync()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Classrooms";
                return await connection.QueryAsync<Classroom>(sqlQuery);
            }
        }

        public async Task<IEnumerable<Classroom>> ReturnClassroomsByCourseIdAsync(int Id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Classrooms WHERE Id = @Id";
                return await connection.QueryAsync<Classroom>(sqlQuery, new { Id = Id });
            }
        }

        public async Task<IEnumerable<Student>> ReturnAllStudentsAsync()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Students";
                return await connection.QueryAsync<Student>(sqlQuery);
            }
        }

        public async Task<IEnumerable<Student>> ReturnStudentsByClassroomIdAsync(int Id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Students WHERE Id = @Id";
                return await connection.QueryAsync<Student>(sqlQuery, new { Id = Id });
            }
        }

        public async Task<Student> ReturnStudentByIdAsync(int Id) 
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Students WHERE Id = @Id";
                return await connection.QueryFirstOrDefaultAsync<Student>(sqlQuery, new { Id = Id });
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

        public async Task DeleteStudentByIdAsync(int Id) 
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"DELETE FROM Students WHERE Id = @Id";
                await connection.ExecuteAsync(sqlQuery, new {Id = Id});
            }
        }

        public async Task DeleteCourseByIdAsync(int Id) 
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
            {
                await connection.OpenAsync();
                string sqlQuery = @"DELETE FROM Courses WHERE Id = @Id";
                await connection.ExecuteAsync(sqlQuery, new { Id = Id });
            }
        }

        public async Task DeleteRecordsInTableAsync(IEnumerable<int> recordIds, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
            {
                await connection.OpenAsync();
                string idsToDelete = string.Join(",", recordIds);
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
                                    WHERE Id = @Id";
                await connection.ExecuteAsync(sqlQuery, new
                {
                    completeName = student.CompleteName,
                    classroomId = student.ClassroomId,
                    Id = student.Id,
                });
            }
        }
    }
}

