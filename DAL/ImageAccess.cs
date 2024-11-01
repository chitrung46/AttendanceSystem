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
    public class ImageAccess
    {
        public void InsertImage(string imageURL)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_insertImage", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iamgeURL", imageURL);
                int result = cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public Image GetImageByURL(string imageURL)
        {
            Image image = new Image();
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                
                con.Open();
                using (SqlCommand cmd = new SqlCommand("proc_getFacultyList", con))
                {
                    
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        image = new Image
                        {
                            Id = (int)reader["id"],
                            ImageURL = (string)reader["imageURL"]
                        };
                    }
                }
                con.Close();
            return image;
            }
        }
    }
}
