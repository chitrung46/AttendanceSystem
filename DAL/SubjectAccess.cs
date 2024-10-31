using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class SubjectAccess:DatabaseAccess
    {
        public List<Dictionary<string, object>> GetSubjectNameListWithSchoolNameAndFacultyName ()
        {
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("proc_getSubjectNameListWithSchoolNameAndFacultyName", con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Dictionary<string, object>
                        {
                            { "subjectId", reader["subjectId"]},
                            { "facultyId", reader["facultyid"]},
                            {"schoolId", reader["schoolId"]},
                            {"subjectName", reader["subjectName"]},         
                            {"facultyName", reader["facultyName"]},
                            {"schoolName", reader["schoolName"] }
                        });
                    }
                }
                con.Close();
            }
            return list;
        }

        public bool InsertSubject(string subjectName, int facultyId)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_insertSubject", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@subjectName", subjectName);
                cmd.Parameters.AddWithValue("@facultyId", facultyId);
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
                SqlCommand cmd = new SqlCommand("proc_updateSubject", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", subject.Id);
                cmd.Parameters.AddWithValue("@subjectName", subject.SubjectName);
                cmd.Parameters.AddWithValue("@facultyId", subject.FacultyId);
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
                SqlCommand cmd = new SqlCommand("proc_deleteSubject", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result > 0;
            }
        }

        public bool IsSubjectExist(string subjectName, int facultyId, int schoolId)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_isSubjectExist", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@subjectName", subjectName);
                cmd.Parameters.AddWithValue("@facultyId", facultyId);
                cmd.Parameters.AddWithValue("@schoolId", schoolId);
                int result = (int)cmd.ExecuteScalar();
                con.Close();
                return result > 0;
            }
        }
    }
}
