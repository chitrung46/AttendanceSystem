using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class SessionBLL
    {
        private SessionAccess sessionAccess = new SessionAccess();

        public string GetNewSessionName(int groupId)
        {
            return sessionAccess.GetNewSessionName(groupId);
        }
    }
}
