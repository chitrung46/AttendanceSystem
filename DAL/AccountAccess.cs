using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class AccountAccess:DatabaseAccess
    {
        public string checkLogin(Account acc)
        {
            string info = checkLoginDTO(acc);
            return info;
        }

        public Account getAccountByEmailDLA(string email) 
        {
            Account acc = getAccountByEmail(email);
            return acc;
        }
    }
}
