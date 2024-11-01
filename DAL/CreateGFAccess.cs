using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using System.Data;
namespace DAL
{
    public class CreateGFAccess:DatabaseAccess
    {
        public List<School> GetAllSchoolsDLA()
        {
            List<School> schools = GetAllSchools();
            return schools;
        }
        public School GetSchoolByIdDLA(int schoolId)
        {
            School school = GetSchoolById(schoolId);
            return school;
        }
        public List<Faculty> GetFacultiesBySchoolIdDLA(int schoolId)
        {
            List<Faculty> faculties = GetFacultiesBySchoolId(schoolId);
            return faculties;
        }
        public List<Subject> GetSubjectsByFacultyIdDLA(int facultyId)
        {
            List<Subject> subjects = GetSubjectsByFacultyId(facultyId);
            return subjects;
        }
        /***
        public void InsertScheduleDAL(int groupId, ScheduleDTO schedule)
        {
            InsertSchedule(groupId, schedule);
        }***/

        public int InsertGroupDAL(DTO.Group group)
        {
           return InsertGroup(group);
        }

        public void InsertStudentsDAL(int groupId, DataTable excelData)
        {
            InsertStudents(groupId, excelData);
        }

        public int GetNextGroupIdDAL()
        {
            return GetNextGroupId();
        }


    }
}
