using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetInt32(0).ToString();
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Email hoặc mật khẩu không chính xác!";
            }
            conn.Close();
            return user;
        }
        public static Account getAccountByEmail(string email)
        {
            Account account = null;
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("proc_getAccountByEmail", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            account = new Account
                            {
                                id = reader.GetInt32(reader.GetOrdinal("id")), // Ensure id is read as int
                                accountName = reader.GetString(reader.GetOrdinal("accountName")),
                                gender = reader.GetString(reader.GetOrdinal("gender")),
                                birthday = reader.GetDateTime(reader.GetOrdinal("birthday")),
                                email = reader.GetString(reader.GetOrdinal("email")),
                                sPassword = reader.GetString(reader.GetOrdinal("sPassword")),
                                phoneNumber = reader.GetString(reader.GetOrdinal("phoneNumber"))
                            };
                        }
                    }
                }
            }
            return account;
        }

        public static List<GroupInfo> GetGroupInfoByAccountIdAndSchoolId(int accountId, int schoolId)
        {
            List<GroupInfo> groupInfoList = new List<GroupInfo>();

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("proc_getGroupInfoByAccountIdAndSchoolId", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@accountId", accountId);
                    command.Parameters.AddWithValue("@schoolId", schoolId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GroupInfo groupInfo = new GroupInfo
                            {
                                GroupId = reader.GetInt32(reader.GetOrdinal("GroupId")),
                                GroupName = reader.GetString(reader.GetOrdinal("GroupName")),
                                SubjectName = reader.GetString(reader.GetOrdinal("SubjectName")),
                                FacultyName = reader.GetString(reader.GetOrdinal("FacultyName")),
                                SchoolName = reader.GetString(reader.GetOrdinal("SchoolName"))
                            };
                            groupInfoList.Add(groupInfo);
                        }
                    }
                }
            }
            return groupInfoList;
        }
         public static List<School> GetAllSchools() 
        {
            List<School> schools = new List<School>();
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("proc_getSchools", conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        schools.Add(new School
                        {
                            Id = reader.GetInt32(0),
                            SchoolName = reader.GetString(1)
                        });
                    }
                }
            }
            return schools;
        }
        public static School GetSchoolById(int schoolId)
        {
            School school = null;
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("proc_getSchoolById", conn))
                {
                    command.CommandType = CommandType.StoredProcedure; // Set command type to stored procedure
                    command.Parameters.AddWithValue("@schoolId", schoolId); // Ensure this parameter is set

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            school = new School
                            {
                                Id = reader.GetInt32(0), // Ensure column indices match your SQL SELECT statement
                                SchoolName = reader.GetString(1)
                            };
                        }
                    }
                }
            }
            return school;
        }
        public static List<Faculty> GetFacultiesBySchoolId(int schoolId)
        {
            List<Faculty> faculties = new List<Faculty>();
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("proc_getFacultiesBySchoolId", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@schoolId", schoolId);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        faculties.Add(new Faculty
                        {
                            Id = reader.GetInt32(0),
                            FacultyName = reader.GetString(1)
                        });
                    }
                }
            }
            return faculties;
        }

        public static List<Subject> GetSubjectsByFacultyId(int facultyId)
        {
            List<Subject> subjects = new List<Subject>();
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("proc_getSubjectsByFacultyId", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@facultyId", facultyId);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        subjects.Add(new Subject
                        {
                            Id = reader.GetInt32(0),
                            SubjectName = reader.GetString(1)
                        });
                    }
                }
            }
            return subjects;
        }
        public static List<StudentDTO> GetStudentsByGroupId(int groupId)
        {
            List<StudentDTO> students = new List<StudentDTO>();

            using(SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand("proc_GetStudentsByGroupId", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@GroupId", groupId);

                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    StudentDTO student = new StudentDTO
                    {
                        Id = (int)reader["StudentId"],
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        STT = (int)reader["STT"],
                        GroupId = groupId
                    };
                    students.Add(student);
                }
            }

            return students;
        }


        /*** them xoa sua sinh vien trong StudentForm.cs ***/
        public void AddStudent(StudentDTO student, out int studentId)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                var command = new SqlCommand("proc_AddStudent", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                // Pass the necessary parameters including GroupId
                command.Parameters.AddWithValue("@Id", student.Id);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@STT", student.STT);
                command.Parameters.AddWithValue("@GroupId", student.GroupId); // Include GroupId
                command.Parameters.Add("@StudentId", SqlDbType.Int).Direction = ParameterDirection.Output;

                conn.Open();
                command.ExecuteNonQuery();
                studentId = (int)command.Parameters["@StudentId"].Value;
            }
        }

        public void UpdateStudent(StudentDTO student)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                var command = new SqlCommand("proc_UpdateStudent", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@StudentId", student.Id);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@STT", student.STT);

                conn.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(int studentId)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                var command = new SqlCommand("proc_DeleteStudent", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@StudentId", studentId);
                conn.Open();
                command.ExecuteNonQuery();
            }
        }

        public int GetNextStudentId()
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                string query = "SELECT ISNULL(MAX(id), 0) + 1 FROM STUDENT"; // Increment max ID by 1
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public int GetNextGroupId()
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                string query = "SELECT ISNULL(MAX(id), 0) + 1 FROM r_GROUP"; // Increment max ID by 1
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }
        public void AddStudentsToGroup(int groupId, List<int> studentIds, List<string> firstNames, List<string> lastNames)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                var command = new SqlCommand("proc_AddStudentsToGroup", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                // Prepare the comma-separated values for IDs, first names, and last names
                command.Parameters.AddWithValue("@GroupId", groupId);
                command.Parameters.AddWithValue("@StudentIds", string.Join(",", studentIds));
                command.Parameters.AddWithValue("@FirstNames", string.Join(",", firstNames));
                command.Parameters.AddWithValue("@LastNames", string.Join(",", lastNames));

                conn.Open();
                command.ExecuteNonQuery();
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

        public int InsertGroup(DTO.Group group)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                var command = new SqlCommand("proc_AddNewGroup", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                // Pass the necessary parameters including GroupId
                command.Parameters.AddWithValue("@groupName", group.GroupName);
                command.Parameters.AddWithValue("@numMember", group.NumMember);
                command.Parameters.AddWithValue("@numMaximumAbsent", group.NumMaximumAbsent);
                command.Parameters.AddWithValue("@accountId", group.AccountId);
                command.Parameters.AddWithValue("@subjectId", group.SubjectId); // Include GroupId
                //command.Parameters.Add("@StudentId", SqlDbType.Int).Direction = ParameterDirection.Output;

                SqlParameter outputGroupIdParam = new SqlParameter("@groupId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputGroupIdParam);

                conn.Open();
                command.ExecuteNonQuery();

                // Retrieve the new GroupId from the output parameter
                int newGroupId = (int)outputGroupIdParam.Value;

                return newGroupId; // Return the new GroupId
            }
        }


        public int InsertSchedule(ScheduleDTO schedule)
        {
            // To hold the ID of the inserted schedule
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                var command = new SqlCommand("proc_InsertSchedule", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };


                // Add parameters for the schedule
                command.Parameters.AddWithValue("@ShiftDay", schedule.ShiftDay);
                command.Parameters.AddWithValue("@StartTime", schedule.StartTime);
                command.Parameters.AddWithValue("@EndTime", schedule.EndTime);
                command.Parameters.AddWithValue("@GroupId", schedule.GroupId);
                command.Parameters.AddWithValue("@SubjectId", schedule.SubjectId);

                SqlParameter outputGroupIdParam = new SqlParameter("@scheduleId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputGroupIdParam);

                conn.Open();
                command.ExecuteNonQuery();

                // Retrieve the new GroupId from the output parameter
                int newSchedulId = (int)outputGroupIdParam.Value;

                return newSchedulId;
            }
        }
        
        public void InsertStudents(int groupId, DataTable excelData)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                int stt = 1;
                foreach (DataRow row in excelData.Rows)
                {
                    string firstName = row["FirstName"].ToString();
                    string lastName = row["LastName"].ToString();
                    int id = Convert.ToInt32(row["MSSV"].ToString());

                    string query = @"INSERT INTO STUDENT (id, firstName, lastName, stt)
                                 VALUES (@id, @firstName, @lastName, @stt);
                                 INSERT INTO GROUP_STUDENT (groupId, studentId)
                                 VALUES (@groupId, @id)"; // Assuming studentId is an auto-incremented field

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@stt", stt);
                        cmd.Parameters.AddWithValue("@groupId", groupId);
                        stt++;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
