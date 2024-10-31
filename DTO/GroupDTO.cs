using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GroupDTO
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public int SchoolId { get; set; }
        public int FacultyId { get; set; }
        public int SubjectId { get; set; }
        public GroupDTO(int id, string groupName, int schoolId, int facultyId, int subjectId)
        {
            Id = id;
            GroupName = groupName;
            SchoolId = schoolId;
            FacultyId = facultyId;
            SubjectId = subjectId;
        }
        public GroupDTO() { }
    }
}
