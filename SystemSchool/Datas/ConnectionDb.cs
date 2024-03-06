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

        public async Task<Class> ReturnClassByIdAsync(int classId)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Classes WHERE ClassId = @classId";
                Class classDb = await connection.QueryFirstOrDefaultAsync<Class>(sqlQuery, new { classId = classId });
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

        public async Task<Classroom> ReturnClassroomByIdAsync(int classroomId) 
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FRIM Classrooms WHERE ClassroomId = @classroomId";
                return await connection.QueryFirstOrDefaultAsync(sqlQuery, new { classroomId = classroomId });
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

        public async Task<IEnumerable<Classroom>> ReturnClassroomsByCourseIdAsync(int courseId)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Classrooms WHERE CourseId = @courseId";
                return await connection.QueryAsync<Classroom>(sqlQuery, new { courseId = courseId });
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

        public async Task<IEnumerable<Student>> ReturnStudentsByClassroomIdAsync(int classroomId)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Students WHERE ClassroomId = @classroomId";
                return await connection.QueryAsync<Student>(sqlQuery, new { classroomId = classroomId });
            }
        }

        public async Task<Student> ReturnStudentByIdAsync(int studentId) 
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
            {
                await connection.OpenAsync();
                string sqlQuery = @"SELECT * FROM Students WHERE StudentId = @studentId";
                return await connection.QueryFirstOrDefaultAsync<Student>(sqlQuery, new { studentId= studentId });
            }
        }

        public async Task CreateCourseInDbAsync(Course course)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"INSERT INTO Courses (CourseId, CourseName) VALUES (@CourseId, @CourseName)";

                await connection.ExecuteAsync(sqlQuery, new 
                {
                    CourseId = course.CourseId,
                    CourseName = course.CourseName 
                });
            }
        }

        public async Task CreateClassroomInDbAsync(Classroom classroom) 
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"INSERT INTO Classrooms (ClassroomId, ClassroomName, CourseId) 
                                    VALUES (@ClassroomId, @ClassroomName, @CourseId)";

                await connection.ExecuteAsync(sqlQuery, new
                {
                    ClassroomId = classroom.ClassroomId,
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
                string sqlQuery = @"INSERT INTO Students (StudentId, ClassroomId, CompleteName) 
                                    VALUES (@StudentId, @ClassroomId, @CompleteName)";

                await connection.ExecuteAsync(sqlQuery, new 
                {
                    StudentId = student.StudentId,
                    ClassroomId = student.ClassroomId,
                    CompleteName = student.CompleteName
                });
            }
        }

        public async Task DeleteStudentByIdAsync(int studentId) 
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string sqlQuery = @"DELETE FROM Students WHERE StudentId = @studentId";
                await connection.ExecuteAsync(sqlQuery, new {studentId = studentId});
            }
        }
    }
}

