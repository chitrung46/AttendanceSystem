using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class SchoolAccess:DatabaseAccess
    {
        public List<School> GetSchoolList()
        {
            List<School> list = new List<School>();
            string query = "proc_getSchoolList";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new School
                        {
                            Id = (int)reader["id"],
                            SchoolName = reader["schoolName"].ToString()
                        });
                    }
                }
                con.Close();
            }
            return list;
        }

        public bool InsertSchool(School school)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_insertSchool", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@schoolName", school.SchoolName);
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
                SqlCommand cmd = new SqlCommand("proc_updateSchool", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", school.Id);
                cmd.Parameters.AddWithValue("@schoolName", school.SchoolName);
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
                    SqlCommand cmd = new SqlCommand("proc_deleteSchool", con);
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

        public School GetSchoolByName(string schoolName)
        {
            string query = "proc_getSchoolByName";

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@schoolName", schoolName);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        School school = new School
                        {
                            Id = (int)reader["id"],
                            SchoolName = reader["schoolName"].ToString()
                        };
                        con.Close();
                        return school;
                    }
                } 
                con.Close();
                return null;
            }    
        }
    }
}
