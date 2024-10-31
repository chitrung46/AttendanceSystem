using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;
namespace BLL
{
    public class StudentBLL
    {
        private StudentAccess studentBLL = new StudentAccess();

        public void AddStudentDAL(StudentDTO newStudent, out int studentId)
        {
            studentBLL.AddStudentDAL(newStudent, out studentId);
        }
        public void LinkStudentToGroupDAL(int studentId, int groupId)
        {
            studentBLL.LinkStudentToGroupDAL(studentId, groupId);
        }
        public void AddStudentsToGroupDAL(int groupId, List<int> studentIds, List<string> firstNames, List<string> lastNames)
        {
            studentBLL.AddStudentsToGroupDAL(groupId, studentIds, firstNames, lastNames);
        }
        public void DeleteStudentDAL(int studentId)
        {
            studentBLL.DeleteStudentDAL(studentId);
        }

        public List<StudentDTO> GetStudentsByGroupIdDAL(int groupId)
        {
            return studentBLL.GetStudentsByGroupIdDAL(groupId);
        }

        public void UpdateStudentDAL(StudentDTO student)
        {
            studentBLL.UpdateStudentDAL(student);
            
        }

        public int GetNextStudentIdDAL()
        {
            // Assuming you have a method to get the highest STT from the database
            int maxSTT = studentBLL.GetNextStudentIdDAL(); // Fetch the max STT from the database
            return maxSTT; // Return the next STT
        }


    }
}
