using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class AccountBLL
    {
        AccountAccess accAccess = new AccountAccess();
        public string checkLogin(Account acc)
        {
            if (acc.email == "")
            {
                return "required_email";
            }    

            if (acc.sPassword == "")
            {
                return "required_password";
            }

            string info = accAccess.checkLogin(acc);
            return info;
                
        }
        public Account getAccountByEmailDLA(string email) 
        {
            Account acc = accAccess.getAccountByEmailDLA(email);
            return acc;
        }
    }
}
