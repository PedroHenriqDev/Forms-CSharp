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

namespace Datas
{
    public class DatasClass
    {
        SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable DLogin(EntityClass obj) 
        {
            SqlCommand cmd = new SqlCommand("sp_logInto", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", obj.User);
            cmd.Parameters.AddWithValue("@keyPassword", obj.KeyPassword);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
