using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentAccess:DatabaseAccess
    {
        public List<StudentDTO> GetStudentsByGroupIdDAL(int groupId)
        {
            List<StudentDTO> students= GetStudentsByGroupId(groupId);
            return students;
        }

        public void AddStudentDAL(StudentDTO student, out int studentId)
        {
            AddStudent(student, out studentId);
        }


        public void UpdateStudentDAL(StudentDTO student)
        {
            UpdateStudent(student);
        }

        public void DeleteStudentDAL(int studentId)
        {
            DeleteStudent(studentId);
        }

        public int GetNextStudentIdDAL()
        {
            return GetNextStudentId();
        }

        public void AddStudentsToGroupDAL(int groupId, List<int> studentIds, List<string> firstNames, List<string> lastNames)
        {
            AddStudentsToGroup(groupId, studentIds, firstNames, lastNames);
        }

        public void LinkStudentToGroupDAL(int studentId, int groupId)
        {
            LinkStudentToGroup(studentId, groupId);
        }
    }
}
