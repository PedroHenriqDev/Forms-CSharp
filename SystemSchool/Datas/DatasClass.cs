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

namespace Datas
{
    public class DatasClass 
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

        public async Task<Class> FindClassByUserAsync(User user) 
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                await connection.OpenAsync();
                int ClassId = user.ClassId;
                string SqlQuery = @"SELECT * FROM Classes WHERE ClassId = @ClassId";
                Class classDb = await connection.QueryFirstOrDefaultAsync<Class>(SqlQuery, new { ClassId = ClassId });
                return classDb;
            }
        }
    }
}
