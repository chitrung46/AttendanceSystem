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
    public class SchoolBLL
    {
        private SchoolAccess schoolAccess = new SchoolAccess();

        public List<School> GetSchoolList()
        {
            return schoolAccess.GetSchoolList();
        }

        // Thêm mới trường học
        public bool InsertSchool(School school)
        {
            // Kiểm tra logic nghiệp vụ trước khi thêm
            if (string.IsNullOrWhiteSpace(school.SchoolName))
            {
                throw new ArgumentException("Tên trường không được để trống.");
            }
            return schoolAccess.InsertSchool(school);
        }

        // Cập nhật thông tin trường học
        public bool UpdateSchool(School school)
        {
            // Sửa lại tên thuộc tính Id (chữ "I" viết hoa)
            if (school.Id <= 0 || string.IsNullOrWhiteSpace(school.SchoolName))
            {
                throw new ArgumentException("Dữ liệu không hợp lệ.");
            }
            return schoolAccess.UpdateSchool(school);
        }

        // Xóa trường học
        public bool DeleteSchool(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID không hợp lệ.");
            }
            try
            {
                return schoolAccess.DeleteSchool(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting school: " + ex.Message);
            }
        }


        public bool IsSchoolNameExists(string schoolName, int? excludeId = null)
        {
            School school = schoolAccess.GetSchoolByName(schoolName);

            if (school == null)
                return false;

            if (excludeId == null)
                return true;

            if (excludeId == school.Id)
                return false;

            return false;


            //if (school != null && dt.Rows.Count > 0)
            //{
            //    // Nếu excludeId != null thì kiểm tra xem ID có khác với trường hiện tại không (để phục vụ cho việc sửa)
            //    if (excludeId != null)
            //    {
            //        int existingId = Convert.ToInt32(dt.Rows[0]["id"]);
            //        if (existingId == excludeId)
            //        {
            //            return false;  // Không tính là trùng nếu tên trùng với chính trường hiện tại đang sửa
            //        }
            //    }
            //    return true;  // Tên trường đã tồn tại
            //}
            //return false;  // Tên trường chưa tồn tại
        }

    }

}
