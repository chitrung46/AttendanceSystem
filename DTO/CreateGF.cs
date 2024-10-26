using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CreateGF
    {
        public class School
        {
            public int Id { get; set; }
            public string SchoolName { get; set; }

            public School() { }
            public School(int id, string schoolName)
            {
                Id = id;
                SchoolName = schoolName;
            }
        }


        public class Faculty
        {
            public int Id { get; set; }
            public string FacultyName { get; set; }

            public Faculty() { }
            public Faculty(int id, string facultyName)
            {
                Id = id;
                FacultyName = facultyName;
            }
        }

        public class Subject
        {
            public int Id { get; set; }
            public string SubjectName { get; set; }
            public Subject() { }
            public Subject(int id, string subjectName) 
            { 
                Id = id;
                SubjectName = subjectName;
            }
        }
    }
}
