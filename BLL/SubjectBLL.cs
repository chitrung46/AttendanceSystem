using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{

    public class subjectBLL
    {
        private SubjectAccess subjectAccess = new SubjectAccess();

        public List<Dictionary<string, object>> GetSubjectNameListWithSchoolNameAndFacultyName ()
        {
            return subjectAccess.GetSubjectNameListWithSchoolNameAndFacultyName();
        }
        public bool InsertSubject(string subjectName, int facultyId)
        {
            if (string.IsNullOrEmpty(subjectName))
            {
                throw new ArgumentException("Thông tin môn học không hợp lệ.");
            }
            return subjectAccess.InsertSubject(subjectName, facultyId);  
        }

        public bool IsSubjectExist(string subjectName, int facultyId, int schoolId)
        {
            if (string.IsNullOrEmpty(subjectName) || facultyId <= 0 || schoolId <= 0)
            {
                throw new ArgumentException("Dữ liệu không hợp lệ.");
            }
            return subjectAccess.IsSubjectExist(subjectName, facultyId, schoolId);
        }


        public bool UpdateSubject(Subject subject)  
        {
            if (subject == null || string.IsNullOrEmpty(subject.SubjectName) || subject.Id <= 0)
            {
                throw new ArgumentException("Thông tin môn học không hợp lệ.");
            }
            return subjectAccess.UpdateSubject(subject);
        }

        public bool DeleteSubject(int id)  
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID môn học không hợp lệ.");
            }
            return subjectAccess.DeleteSubject(id); 
        }


    }

}
