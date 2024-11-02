using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DynamicSessionTableBLL
    {
        private DynamicSessionTableAccess dstAccess = new DynamicSessionTableAccess();

        public DataTable GetSessionTableByGroupId(int groupId)
        {
            return dstAccess.GetSessionTableByGroupId(groupId);
        }
    }
}
