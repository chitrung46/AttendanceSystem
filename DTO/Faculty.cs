using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Faculty
    {
        private int id;
        private string facultyName;
        private int schoolId;

        public Faculty() { }

        public Faculty(int id, string facultyName, int schoolId)
        {
            this.id = id;
            this.facultyName = facultyName;
            this.schoolId = schoolId;
        }

        public int Id { get => id; set => id = value; }
        public string FacultyName { get => facultyName; set => facultyName = value; }
        public int SchoolId { get => schoolId; set => schoolId = value; }
    }
}
