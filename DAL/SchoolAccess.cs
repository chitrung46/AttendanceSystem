using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class SchoolAccess
    {
        public DataTable GetAllSchools()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_GetAllSchools", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }

        public bool InsertSchool(School school)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_InsertSchool", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sschoolName", school.sschoolName);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result > 0;
            }
        }

        public bool UpdateSchool(School school)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_UpdateSchool", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", school.id);
                cmd.Parameters.AddWithValue("@sschoolName", school.sschoolName);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result > 0;
            }
        }

        public bool DeleteSchool(int id)
        {
            try
            {
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("proc_DeleteSchool", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    con.Close();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting school: " + ex.Message);
            }
        }

        public DataTable GetSchoolByName(string schoolName)
        {
            string procName = "proc_GetSchoolByName";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@schoolName", schoolName)
            };

            return ExecuteQuery(procName, parameters, isStoredProc: true);
        }

        private DataTable ExecuteQuery(string queryOrProcName, SqlParameter[] parameters = null, bool isStoredProc = false)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = SqlConnectionData.Connect())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(queryOrProcName, con))
                    {
                        cmd.CommandType = isStoredProc ? CommandType.StoredProcedure : CommandType.Text;
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing query: " + ex.Message);
            }
            return dt;
        }
    }
}
