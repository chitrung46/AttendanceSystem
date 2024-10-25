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
        //private DatabaseAccess facultyAccess = new DatabaseAccess();  // Đối tượng truy cập cơ sở dữ liệu
        private FacultyAccess facultyAccess = new FacultyAccess();

        // Lấy danh sách tất cả các khoa
        public DataTable GetAllFaculty()
        {
            return facultyAccess.GetAllFaculties();
        }

        public DataTable GetAllFacultiesWithSchoolName()
        {
            try
            {
                return facultyAccess.GetAllFacultiesWithSchoolName();  // Gọi phương thức DAL
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách khoa: " + ex.Message);
            }
        }
        public bool IsFacultyExist(string facultyName, int schoolId)
        {
            return facultyAccess.CheckIfFacultyExists(facultyName, schoolId);
        }


        public DataTable GetFacultiesBySchoolId(int schoolId)
        {
            // Giả sử bạn đã có phương thức trong lớp DAL để lấy danh sách khoa theo ID trường
            return facultyAccess.GetFacultiesBySchoolId(schoolId);
        }


        // Thêm khoa mới
        public bool InsertFaculty(Faculty faculty)
        {
            if (faculty == null || string.IsNullOrEmpty(faculty.facultyName))
            {
                throw new ArgumentException("Thông tin khoa không hợp lệ.");
            }
            return facultyAccess.InsertFaculty(faculty);
        }

        // Cập nhật thông tin khoa
        public bool UpdateFaculty(Faculty faculty)
        {
            if (faculty == null || string.IsNullOrEmpty(faculty.facultyName) || faculty.id <= 0)
            {
                throw new ArgumentException("Thông tin khoa không hợp lệ.");
            }
            return facultyAccess.UpdateFaculty(faculty);
        }

        // Xóa khoa
        public bool DeleteFaculty(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID khoa không hợp lệ.");
            }
            return facultyAccess.DeleteFaculty(id);
        }


        public DataTable GetAllSchoolFaculties()
        {
            return facultyAccess.GetAllSchoolFaculties();  // Phương thức này sẽ gọi DAL để lấy tất cả các trường và khoa
        }



    }

}
