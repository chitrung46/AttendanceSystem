using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Subject
    {
        public int id { get; set; }
        public string subjectName { get; set; }
        public int facultyId { get; set; }


        public Subject() { }

        public Subject(int id, string subjectName, int facultyId)
        {
            this.id = id;
            this.subjectName = subjectName;
            this.facultyId = facultyId;
        }
    }
}
