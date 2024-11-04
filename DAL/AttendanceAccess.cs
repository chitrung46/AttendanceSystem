using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class AttendanceAccess
    {
        public void InsertAttendance(DateTime attendanceTime, string attendanceType, string attendanceStatus, string codeQR, int studentId, int imageId, int sessionId, string limitTime)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_insertAttendance", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@attendanceTime", attendanceTime);
                cmd.Parameters.AddWithValue("@attendanceType", attendanceType);
                cmd.Parameters.AddWithValue("@attendanceStatus", attendanceStatus);
                cmd.Parameters.AddWithValue("@codeQR", codeQR);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@imageId", imageId);
                cmd.Parameters.AddWithValue("@sessionId", sessionId);
                cmd.Parameters.AddWithValue("@limit", limitTime);
                int result = cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void UpdateAttendance (DateTime attendanceTime, string attendanceType, string attendanceStatus, string codeQR, int studentId, int imageId, int sessionId)
        {
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_updateAttendance", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@attendanceTime", attendanceTime);
                cmd.Parameters.AddWithValue("@attendanceType", attendanceType);
                cmd.Parameters.AddWithValue("@attendanceStatus", attendanceStatus);
                cmd.Parameters.AddWithValue("@codeQR", codeQR);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@imageId", imageId);
                cmd.Parameters.AddWithValue("@sessionId", sessionId);
                int result = cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
