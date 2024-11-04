using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SessionAccess:DatabaseAccess
    {
        public string GetNewSessionName(int groupId)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT dbo.func_getNewSessionName(@groupId)", con))
                {
                    command.Parameters.AddWithValue("@groupId", groupId);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {   
                        return result.ToString();
                    }
                    else
                    {
                        return "Không tìm tên mới được";
                    }
                }
            };
            
        }

        public bool InsertSession (string sessionName, DateTime sessionTime, string code, int groupId)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_insertSession", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sessionName", sessionName);
                cmd.Parameters.AddWithValue("@sessionTime", sessionTime);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@groupId", groupId);

                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result > 0;
            }
        }

        public Session FindSession (string sessionName, string sessionTime, string code, int groupId)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_findSession", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sessionName", sessionName);
                cmd.Parameters.AddWithValue("@sessionTime", sessionTime);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@groupId", groupId);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return (Session)result;
                }
                return null;
            }
        }
    }
}
