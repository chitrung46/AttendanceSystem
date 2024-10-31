using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using DTO;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string connectionString = @"Data Source=CHITRUNG-LAPTOP\TRUNG_SQL;Initial Catalog=ATTENDANCE_SYSTEM;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
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

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetInt32(0).ToString();
                }
                reader.Close();
            }
            else
            {
                return "Email hoặc mật khẩu không chính xác!";
            }
            conn.Close();
            return user;
        }




        //Faculty
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

            // Sử dụng stored procedure để lấy danh sách khoa và tên trường
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open(); // Mở kết nối

                // Khởi tạo SqlCommand và sử dụng stored procedure
                SqlCommand cmd = new SqlCommand("proc_GetAllFacultiesWithSchoolName", con);
                cmd.CommandType = CommandType.StoredProcedure; // Đặt loại command là StoredProcedure

                // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt); // Đổ dữ liệu vào DataTable

                con.Close(); // Đóng kết nối
            }

            return dt; // Trả về DataTable chứa dữ liệu
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
                cmd.Parameters.AddWithValue("@schoolId", faculty.schoolId);  // Thêm tham số @schoolId nếu cần
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
                cmd.Parameters.AddWithValue("@schoolId", schoolId);  // Tham số ID của trường
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            return dt;
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
            try
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
            catch (Exception ex)
            {
                throw new Exception("Error deleting faculty: " + ex.Message);
            }
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


        public DataTable GetAllSubject()
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
        public DataTable GetSubjectById(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_GetSubjectById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataAdapter da = new SqlDataAdapter(cmd);  // Gán cmd vào SqlDataAdapter
                da.Fill(dt);  // Nạp dữ liệu vào DataTable
                con.Close();
            }
            return dt;
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





        //Them mon moi
        public bool InsertSubject(Subject subject)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();

                // Lấy id lớn nhất hiện tại và cộng thêm 1 để tạo id mới
                int newId = GetMaxSubjectId() + 1;

                SqlCommand cmd = new SqlCommand("proc_InsertSubject", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", newId); // Thêm id mới vào
                cmd.Parameters.AddWithValue("@subjectName", subject.subjectName);
                cmd.Parameters.AddWithValue("@facultyId", subject.facultyId);

                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result > 0;
            }
        }


        // Cập nhật môn học
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

        // Xóa môn học
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





    }
}
