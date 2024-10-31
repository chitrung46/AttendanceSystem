using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class FacultyAccess
    {
        public DataTable GetAllFaculties()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_getAllFaculties", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }

        public DataTable GetAllFacultiesWithSchoolName()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_GetAllFacultiesWithSchoolName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }

        public DataTable GetAllSchoolFaculties()
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand("proc_GetAllSchoolFaculties", con);
                cmd.CommandType = CommandType.StoredProcedure;  // Đặt CommandType là StoredProcedure

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool InsertFaculty(Faculty faculty)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_insertFaculty", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@facultyName", faculty.facultyName);
                cmd.Parameters.AddWithValue("@schoolId", faculty.schoolId);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result > 0;
            }
        }

        public bool UpdateFaculty(Faculty faculty)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_updateFaculty", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", faculty.id);
                cmd.Parameters.AddWithValue("@facultyName", faculty.facultyName);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result > 0;
            }
        }

        public bool DeleteFaculty(int id)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_deleteFaculty", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result > 0;
            }
        }

        public DataTable GetFacultiesBySchoolId(int schoolId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_GetFacultiesBySchoolId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@schoolId", schoolId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }

        public bool CheckIfFacultyExists(string facultyName, int schoolId)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand("proc_CheckIfFacultyExists", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số cho stored procedure
                cmd.Parameters.AddWithValue("@facultyName", facultyName);
                cmd.Parameters.AddWithValue("@schoolId", schoolId);

                con.Open();

                // ExecuteScalar trả về giá trị đầu tiên của hàng đầu tiên.
                int result = (int)cmd.ExecuteScalar();
                con.Close();

                return result > 0; // Nếu số lượng lớn hơn 0, thì đã tồn tại khoa này.
            }
        }
        public object ExecuteScalar(string query, SqlParameter[] parameters)
        {
            object result = null;

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddRange(parameters);
                    con.Open();
                    result = cmd.ExecuteScalar();  // ExecuteScalar sẽ trả về giá trị đầu tiên của hàng đầu tiên
                    con.Close();
                }
            }

            return result;
        }



    }
}
