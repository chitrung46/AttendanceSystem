using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public string id { get; set; }
        public string accountName { get; set; }
        public string gender { get; set; }
        public DateTime birthday { get; set; }
        public string email { get; set; }
        public string sPassword { get; set; }
        public string phoneNumber { get; set; }

        public Account()
        {

        }

        public Account(string id, string accountName, string gender, DateTime birthday, string email, string sPassword, string phoneNumber)
        {
            this.id = id;
            this.accountName = accountName;
            this.gender = gender;
            this.birthday = birthday;
            this.email = email;
            this.sPassword = sPassword;
            this.phoneNumber = phoneNumber;
        }


    }

    public class School
    {
        public int id { get; set; }
        public string sschoolName { get; set; }

        public School() { }

        public School(int id, string sschoolName)
        {
            this.id = id;
            this.sschoolName = sschoolName;
        }
    }

    public class Faculty
    {
        public int id { get; set; }
        public string facultyName { get; set; }

        public int SchoolId { get; set; }

        public Faculty() { }

        public Faculty(int id, string facultyName, int schoolId)
        {
            this.id = id;
            this.facultyName = facultyName;
            this.SchoolId = schoolId;
        }
    }

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
