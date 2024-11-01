using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Session
    {
        private int id;
        private string sessionName;
        private DateTime sessionTime;
        private string code;
        private int groupId;

        public Session() { }

        public Session(int id, string sessionName, DateTime sessionTime, string code, int groupId)
        {
            this.id = id;
            this.sessionName = sessionName;
            this.sessionTime = sessionTime;
            this.code = code;
            this.groupId = groupId;
        }

        public int Id { get => id; set => id = value; }
        public string SessionName { get => sessionName; set => sessionName = value; }
        public DateTime SessionTime { get => sessionTime; set => sessionTime = value; }
        public int GroupId { get => groupId; set => groupId = value; }
        public string Code { get => code; set => code = value; }
    }
}
