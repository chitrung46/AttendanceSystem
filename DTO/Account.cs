using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public int id { get; set; } 
        public string accountName { get; set; }
        public string gender { get; set; }
        public DateTime birthday { get; set; }
        public string email { get; set; }
        public string sPassword { get; set; }
        public string phoneNumber { get; set; }

        public Account()
        {
        }

        public Account(int id, string accountName, string gender, DateTime birthday, string email, string sPassword, string phoneNumber)
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
    public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public int NumMember { get; set; }
        public int NumMaximumAbsent { get; set; }
        public int AccountId { get; set; }
        public int SubjectId { get; set; }

        public Group()
        {

        }

        // Constructor with parameters
        public Group(int id, string groupName, int numMember, int numMaximumAbsent, int accountId, int subjectId)
        {
            this.Id = id;
            this.GroupName = groupName;
            this.NumMember = numMember;
            this.NumMaximumAbsent = numMaximumAbsent;
            this.AccountId = accountId;
            this.SubjectId = subjectId;
        }
    }
}
