using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GroupInfo
    {
        public int GroupId { get; set; } // Hidden column
        public string GroupName { get; set; }
        public string SchoolName { get; set; }
        public string FacultyName { get; set; }
        public string SubjectName { get; set; }

        public GroupInfo() { }
        public GroupInfo(int groupId, string groupName, string schoolName, string facultyName, string subjectName)
        {
            GroupId = groupId;
            GroupName = groupName;
            SchoolName = schoolName;
            FacultyName = facultyName;
            SubjectName = subjectName;
        }
    }
}
