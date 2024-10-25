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
        //private DatabaseAccess subjectAccess = new DatabaseAccess();  // Đối tượng truy cập cơ sở dữ liệu
        private SubjectAccess subjectAccess = new SubjectAccess();
        private FacultyAccess FacultyAccess = new FacultyAccess();

        // Lấy danh sách tất cả các khoa
        public DataTable GetAllsubject()
        {
            return FacultyAccess.GetAllFaculties();
        }

        public DataTable GetAllFacultiesWithSchoolName()
        {
            try
            {
                return FacultyAccess.GetAllFacultiesWithSchoolName();  // Gọi phương thức DAL
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách khoa: " + ex.Message);
            }
        }

        public DataTable GetAllSubjectsWithDetails()
        {
            try
            {
                // Gọi DAL để lấy dữ liệu
                return subjectAccess.GetAllSubjectsWithDetails();
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching subjects with details: " + ex.Message);
            }
        }

        // Thêm môn học mới
        public bool InsertSubject(Subject subject)
        {
            if (subject == null || string.IsNullOrEmpty(subject.subjectName))
            {
                throw new ArgumentException("Thông tin môn học không hợp lệ.");
            }

            // Kiểm tra xem đã tồn tại môn học với cùng tên, trong cùng khoa và trường chưa
            if (subjectAccess.CheckIfSubjectExists(subject.subjectName, subject.facultyId))
            {
                throw new Exception("Môn học này đã tồn tại trong cùng trường và khoa.");
            }

            return subjectAccess.InsertSubject(subject);  // Gọi phương thức InsertSubject() từ DAL
        }

        public bool CheckIfSubjectExists(string subjectName, int facultyId)
        {
            try
            {
                return subjectAccess.CheckIfSubjectExists(subjectName, facultyId);  // Gọi phương thức DAL
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra môn học: " + ex.Message);
            }
        }


        // Cập nhật thông tin môn học
        public bool UpdateSubject(Subject subject)  // Giữ tên function là UpdateFaculty nhưng nội dung là xử lý cập nhật môn học
        {
            if (subject == null || string.IsNullOrEmpty(subject.subjectName) || subject.id <= 0)
            {
                throw new ArgumentException("Thông tin môn học không hợp lệ.");
            }
            return subjectAccess.UpdateSubject(subject);  // Gọi phương thức UpdateSubject() từ DAL
        }

        // Xóa môn học
        public bool DeleteSubject(int id)  // Giữ tên function là DeleteFaculty nhưng nội dung là xóa môn học
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID môn học không hợp lệ.");
            }
            return subjectAccess.DeleteSubject(id);  // Gọi phương thức DeleteSubject() từ DAL
        }


    }

}
