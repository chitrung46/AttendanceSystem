using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Faculty
    {
        public int id { get; set; }
        public string facultyName { get; set; }

        public int schoolId { get; set; }

        public Faculty() { }

        public Faculty(int id, string facultyName, int schoolId)
        {
            this.id = id;
            this.facultyName = facultyName;
            this.schoolId = schoolId;
        }
    }
}
