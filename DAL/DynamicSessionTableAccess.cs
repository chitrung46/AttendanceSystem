using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DynamicSessionTableAccess:DatabaseAccess
    {
        private DynamicSessionTable dst = new DynamicSessionTable();

        public DataTable GetSessionTableByGroupId (int groupId)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("proc_getSessionTableByGroupId", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@groupId", groupId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                con.Close();
            }
            return dt;
        }
    }
}
