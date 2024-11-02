using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class GroupAccess : DatabaseAccess
    {
        public List<GroupInfo> GetGroupInfoByAccountIdAndSchoolIdDLA(int accountId, int schoolId)
        {
            return GetGroupInfoByAccountIdAndSchoolId(accountId, schoolId);
        }


        // Method to insert a new group into the database
        public int InsertGroup(GroupDTO group)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_InsertGroup", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@GroupName", group.GroupName);
                    cmd.Parameters.AddWithValue("@SchoolId", group.SchoolId);
                    cmd.Parameters.AddWithValue("@FacultyId", group.FacultyId);
                    cmd.Parameters.AddWithValue("@SubjectId", group.SubjectId);

                    SqlParameter outputParam = new SqlParameter("@GroupId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return (int)outputParam.Value;
                }
            }
        }

        public void LinkStudentToGroup(int studentId, int groupId)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_LinkStudentToGroup", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    cmd.Parameters.AddWithValue("@GroupId", groupId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }









        /***
        public string InsertGroup(Group group)
        {
            return InsertGroupD(group);
        }

        // Method to retrieve groups by account ID
        public List<Group> GetGroupsByAccountId(string accountId)
        {
            return GetGroupsByAccountIdDTO(accountId);
        }
        ***/
        public List<GroupInfo> GetGroupInfoByAccountIdAndSchoolId()
        {
            List<GroupInfo> groupList = new List<GroupInfo>();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            string query = @"
                SELECT 
                G.id AS GroupId,
                G.groupName AS GroupName,
                SJ.subjectName AS SubjectName,
                F.facultyName AS FacultyName,
                S.sschoolName AS SchoolName
            FROM 
                r_GROUP G
            INNER JOIN 
                r_SUBJECT SJ ON G.subjectId = SJ.id
            INNER JOIN 
                FACULTY F ON SJ.facultyId = F.id
            INNER JOIN 
                SCHOOL_FACULTY SF ON F.id = SF.facultyId
            INNER JOIN 
                SCHOOL S ON SF.schoolId = S.id
            WHERE 
                G.accountId = @accountId AND
		        S.id = @schoolId;";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int groupId = reader.GetInt32(reader.GetOrdinal("GroupId"));
                string groupName = reader["GroupName"].ToString();
                string schoolName = reader["SchoolName"].ToString();
                string facultyName = reader["FacultyName"].ToString();
                string subjectName = reader["SubjectName"].ToString();

                GroupInfo groupInfo = new GroupInfo(groupId, groupName, schoolName, facultyName, subjectName);
                groupList.Add(groupInfo);
            }

            conn.Close();
            return groupList;
        }

        public Group GetGroupById(int groupId)
        {
            Group group = new Group();
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("proc_getGroupById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@groupId", groupId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        group = new Group
                        {
                            Id = (int)reader["id"],
                            GroupName = (string)reader["groupName"],
                            NumMember = (int)reader["numMember"],
                            NumMaximumAbsent = (int)reader["numMaximumAbsent"],
                            AccountId = (int)reader["accountId"],
                            SubjectId = (int)reader["subjectId"]
                        };
                    }
                }
                con.Close();
            }
            return group;
        }
    }
}
