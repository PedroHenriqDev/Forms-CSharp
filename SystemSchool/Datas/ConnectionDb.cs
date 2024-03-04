using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
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
                string SqlQuery = @"SELECT * FROM Users 
                                    WHERE Username = @username COLLATE SQL_Latin1_General_CP1_CS_AS 
                                    AND PasswordHash = HASHBYTES('SHA2_512', @passwordHash)";
                 return await connection.QueryFirstOrDefaultAsync<User>(SqlQuery, new { username = user.Username, passwordHash = user.PasswordHash });
            }
        }

        public async Task<Class> FindClassByUserAsync(int classId) 
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string SqlQuery = @"SELECT * FROM Classes WHERE ClassId = @classId";
                return await connection.QueryFirstOrDefaultAsync<Class>(SqlQuery, new { classId = classId });
            }
        }

        public async Task<Course> FindCourseByNameAsync(string courseName)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string SqlQuery = @"SELECT * FROM Courses WHERE CourseName = @courseName";
                return await connection.QueryFirstOrDefaultAsync<Course>(SqlQuery, new { courseName = courseName });
            }
        }

        public async Task<Classroom> FindClassroomByNameAsync(string classroomName)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string SqlQuery = @"SELECT * FROM Classrooms WHERE ClassroomName = @classroomName";
                return await connection.QueryFirstOrDefaultAsync<Classroom>(SqlQuery, new { classroomName = classroomName });
            }
        }

        public async Task<IEnumerable<Course>> ReturnAllCoursesAsync() 
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
            {
                await connection.OpenAsync();
                string SqlQuery = @"SELECT * FROM Courses";
                return await connection.QueryAsync<Course>(SqlQuery);
            }
        }

        public async Task<IEnumerable<Classroom>> ReturnAllClassromsAsync() 
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string SqlQuery = @"SELECT * FROM Classrooms";
                return await connection.QueryAsync<Classroom>(SqlQuery);
            }
        }

        public async Task<IEnumerable<Classroom>> ReturnClassroomsByCourseNameAsync(string courseName)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                Course course = await FindCourseByNameAsync(courseName);
                await connection.OpenAsync();
                string SqlQuery = @"SELECT * FROM Classrooms WHERE CourseId = @courseId";
                return await connection.QueryAsync<Classroom>(SqlQuery, new { courseId = course.CourseId });
            }
        }

        public async Task<IEnumerable<Classroom>> ReturnClassroomBySchoolYearAsync(char schoolYear) 
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
            {
                await connection.OpenAsync();
            }
        }
        public async Task<IEnumerable<Student>> ReturnAllStudentsAsync() 
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString)) 
            {
                await connection.OpenAsync();
                string SqlQuery = @"SELECT * FROM Students";
                return await connection.QueryAsync<Student>(SqlQuery);
            }
        }

        public async Task<IEnumerable<Student>> ReturnStudentsByClassroomIdAsync(int classroomId)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                string SqlQuery = @"SELECT * FROM Students WHERE ClassroomId = @classroomId";
                return await connection.QueryAsync<Student>(SqlQuery, new {classroomId = classroomId});
            }
        }

    }
}
