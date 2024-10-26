using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using static DTO.CreateGF;
using System.Data;

namespace BLL
{
    public class CreateGFBLL
    {
        CreateGFAccess createGFAccess = new CreateGFAccess();
        public List<School> GetAllSchoolsDLA()
        {
            List<School> schools = createGFAccess.GetAllSchoolsDLA();
            return schools;
        }
        public School GetSchoolByIdDLA(int schoolId) 
        {
            School school = createGFAccess.GetSchoolByIdDLA(schoolId);
            return school;
        }
        public List<Faculty> GetFacultiesBySchoolIdDLA(int schoolId)
        {
            List<Faculty> faculties = createGFAccess.GetFacultiesBySchoolIdDLA(schoolId);
            return faculties;
        }
        public List<Subject> GetSubjectsByFacultyIdDLA(int facultyId)
        {
            List<Subject> subjects = createGFAccess.GetSubjectsByFacultyIdDLA(facultyId);
            return subjects;
        }
        /***
        public void AddStudentDAL(StudentDTO student, out int studentId)
        {
            createGFAccess.AddStudentDAL(student, out studentId);
        }

        public int InsertGroupDAL(DTO.Group group)
        {
            return createGFAccess.InsertGroupDAL(group);
        }

        public int GetNextStudentIdDAL()
        {
            // Assuming you have a method to get the highest STT from the database
            int maxSTT = createGFAccess.GetNextStudentIdDAL(); // Fetch the max STT from the database
            return maxSTT; // Return the next STT
        }
        public void InsertScheduleDAL(ScheduleDTO schedule)
        {
            createGFAccess.InsertScheduleDAL(schedule);
        }***/

        public int CreateNewGroup(DTO.Group group)
        {
            return createGFAccess.InsertGroupDAL(group); // Save the group and return the groupId
        }
        /***
        public void SaveGroupSchedule(int groupId, List<ScheduleDTO> schedules)
        {
            foreach (var schedule in schedules)
            {
                schedule.GroupId = groupId;
                createGFAccess.InsertScheduleDAL(groupId, schedule); // Save each schedule row
            }
        }***/

        public void SaveStudentsToGroup(int groupId, DataTable excelData)
        {
            createGFAccess.InsertStudentsDAL(groupId, excelData); // Save the students to the group
        }

        public int GetNextGroupIdDAL()
        {
            // Assuming you have a method to get the highest STT from the database
            int maxSTT = createGFAccess.GetNextGroupIdDAL(); // Fetch the max STT from the database
            return maxSTT; // Return the next STT
        }
    }
}
