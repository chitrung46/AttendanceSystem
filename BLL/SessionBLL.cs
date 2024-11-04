using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class SessionBLL
    {
        private SessionAccess sessionAccess = new SessionAccess();

        public string GetNewSessionName(int groupId)
        {
            return sessionAccess.GetNewSessionName(groupId);
        }

        public bool InsertSession (string sessionName, DateTime sessionTime, string code, int groupId)
        {
            return sessionAccess.InsertSession(sessionName, sessionTime, code, groupId);
        }

        public Session FindSession (string sessionName, DateTime sessionTime, string code, int groupId)
        {
            return sessionAccess.FindSession(sessionName, sessionTime, code, groupId);
        }
    }
}
