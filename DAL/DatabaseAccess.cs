using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=CHITRUNG-LAPTOP\TRUNG_SQL;Initial Catalog=ATTENDANCE_SYSTEM;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
    
    public class DatabaseAccess
    {
        public static string checkLoginDTO(Account acc)
        {
            string user = null;
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_login", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@email", acc.email);
            command.Parameters.AddWithValue("@pass", acc.sPassword);

            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetInt32(0).ToString();
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Email hoặc mật khẩu không chính xác!";
            }

            return user;
        }
    }
}
