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
        private readonly string SqlQueryToLogin = ""

        public DataTable DLogin(EntityClass obj)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_logInto", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", obj.User);
                cmd.Parameters.AddWithValue("@keyPassword", obj.KeyPassword);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
