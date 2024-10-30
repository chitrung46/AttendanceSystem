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
}
