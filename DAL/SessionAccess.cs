using System;
using System.Collections;
using System.Collections.Generic;
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
                using (SqlCommand command = new SqlCommand("func_getNewSessionName", con))
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
    }
}
