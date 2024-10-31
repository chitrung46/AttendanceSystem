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

    public class FacultyBLL
    {
        private FacultyAccess facultyAccess = new FacultyAccess();

        public List<Dictionary<string, object>> GetFacultyNameListWithSchoolName()
        {
            return facultyAccess.GetFacultyNameListWithSchoolName();
        }

        public List<Faculty> GetFacultyList ()
        {
            return facultyAccess.GetFacultyList();
        }

        public List<Faculty> GetFacultyBySchoolName (string schoolName)
        {
            return facultyAccess.GetFacultyBySchoolName(schoolName);
        }
        public Faculty GetFacultyByName(string facultyName)
        {
            return facultyAccess.GetFacultyByName(facultyName);
        }

        public bool InsertFaculty(string facultyName, int schoolId)
        {
            if (string.IsNullOrEmpty(facultyName))
            {
                throw new ArgumentException("Thông tin khoa không hợp lệ.");
            }
            return facultyAccess.InsertFaculty(facultyName, schoolId);
        }

        public bool UpdateFaculty(Faculty faculty)
        {
            if (faculty == null || string.IsNullOrEmpty(faculty.FacultyName) || faculty.Id <= 0)
            {
                throw new ArgumentException("Thông tin khoa không hợp lệ.");
            }
            return facultyAccess.UpdateFaculty(faculty);
        }

        public bool DeleteFaculty(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID khoa không hợp lệ.");
            }
            return facultyAccess.DeleteFaculty(id);
        }

        public bool IsFacultyExist(string facultyName, int schoolId)
        {
            if (string.IsNullOrEmpty(facultyName) || schoolId <= 0)
            {
                throw new ArgumentException("Dữ liệu không hợp lệ.");
            }
            return facultyAccess.IsFacultyExist(facultyName, schoolId);
        }
    }
}
