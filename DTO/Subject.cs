using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Subject
    {
        private int id;
        private string subjectName;
        private int facultyId;


        public Subject() { }

        public Subject(int id, string subjectName, int facultyId)
        {
            this.id = id;
            this.subjectName = subjectName;
            this.facultyId = facultyId;
        }

        public int Id { get => id; set => id = value; }
        public string SubjectName { get => subjectName; set => subjectName = value; }
        public int FacultyId { get => facultyId; set => facultyId = value; }
    }
}
