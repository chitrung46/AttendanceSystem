using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ScheduleAccess:DatabaseAccess
    {
        public int InsertScheduleDLA(ScheduleDTO schedule)
        {
            return InsertSchedule(schedule);
        }
    }
}
