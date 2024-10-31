using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class SubjectAccess
    {
        public DataTable GetAllSubjects()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_GetAllSubjects", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }

        public DataTable GetAllSubjectsWithDetails()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_GetAllSubjectsWithDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }





        public DataTable GetSubjectById(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_GetSubjectById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }

        public bool InsertSubject(Subject subject)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                int newId = GetMaxSubjectId() + 1;
                SqlCommand cmd = new SqlCommand("proc_InsertSubject", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", newId);
                cmd.Parameters.AddWithValue("@subjectName", subject.subjectName);
                cmd.Parameters.AddWithValue("@facultyId", subject.facultyId);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result > 0;
            }
        }

        public bool UpdateSubject(Subject subject)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_UpdateSubject", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", subject.id);
                cmd.Parameters.AddWithValue("@subjectName", subject.subjectName);
                cmd.Parameters.AddWithValue("@facultyId", subject.facultyId);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result > 0;
            }
        }

        public bool DeleteSubject(int id)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_DeleteSubject", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result > 0;
            }
        }

        public int GetMaxSubjectId()
        {
            int maxId = 0;
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_GetMaxSubjectId", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Lấy giá trị trả về từ ExecuteScalar
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    maxId = Convert.ToInt32(result); // Chuyển đổi an toàn sang int
                }

                con.Close();
            }
            return maxId;
        }


        public bool CheckIfSubjectExists(string subjectName, int facultyId)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand("proc_CheckIfSubjectExists", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số
                cmd.Parameters.AddWithValue("@subjectName", subjectName);
                cmd.Parameters.AddWithValue("@facultyId", facultyId);

                con.Open();

                // Thực hiện ExecuteScalar để trả về kết quả COUNT
                int result = (int)cmd.ExecuteScalar();

                con.Close();

                return result > 0; // Nếu số lượng lớn hơn 0, thì môn học đã tồn tại
            }
        }


        private object ExecuteScalar(string query, SqlParameter[] parameters)
        {
            object result = null;
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddRange(parameters);
                    con.Open();
                    result = cmd.ExecuteScalar();
                    con.Close();
                }
            }
            return result;
        }
    }
}
