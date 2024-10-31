using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class FacultyAccess:DatabaseAccess
    {
        public List<Dictionary<string, object>> GetFacultyNameListWithSchoolName()
        {
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("proc_getFacultyNameOrderBySchoolName", con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Dictionary<string, object>
                        {
                            { "id", reader["id"]},
                            {"schoolId", reader["schoolId"]},
                            {"facultyName", reader["facultyName"]},
                            {"schoolName", reader["schoolName"] }
                        });
                    }    
                }
                con.Close();
            }
            return list;
        }

        public List<Faculty> GetFacultyList ()
        {
            List<Faculty> list = new List<Faculty>();
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("proc_getFacultyList", con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Faculty
                        {
                            Id = (int)reader["id"],
                            FacultyName = (string)reader["facultyName"],
                            SchoolId = (int)reader["schoolId"]
                        });
                    }
                }
                con.Close();
            }
            return list;
        }

        public List<Faculty> GetFacultyBySchoolName(string schoolName)
        {
            List<Faculty> list = new List<Faculty>();
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("proc_getFacultyBySchoolName", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@schoolName", schoolName);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Faculty
                        {
                            Id = (int)reader["id"],
                            FacultyName = (string)reader["facultyName"],
                            SchoolId = (int)reader["schoolId"]
                        });
                    }
                }
                con.Close();
            }
            return list;
        }



        public Faculty GetFacultyByName(string facultyName)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("proc_getFacultyByName", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@facultyName", facultyName);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Faculty faculty = new Faculty
                        {
                            Id = (int)reader["id"],
                            FacultyName = (string)reader["facultyName"],
                            SchoolId = (int)reader["schoolId"] 
                        };
                        con.Close();
                        return faculty;
                    }
                }
                con.Close();
                return null;
            }
        }

        public bool InsertFaculty(string facultyName, int schoolId)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_insertFaculty", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@facultyName", facultyName);
                cmd.Parameters.AddWithValue("@schoolId", schoolId);
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
                cmd.Parameters.AddWithValue("@id", faculty.Id);
                cmd.Parameters.AddWithValue("@facultyName", faculty.FacultyName);
                cmd.Parameters.AddWithValue("@schoolId", faculty.SchoolId);
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

        public bool IsFacultyExist(string facultyName, int schoolId) {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_isFacultyExist", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@facultyName", facultyName);
                cmd.Parameters.AddWithValue("@schoolId", schoolId);
                int result = (int)cmd.ExecuteScalar();
                con.Close();
                return result > 0;
            }
        }
    }
}
