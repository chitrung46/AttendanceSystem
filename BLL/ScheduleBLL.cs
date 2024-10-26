using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class ScheduleBLL
    {
        private ScheduleAccess scheduleDAL = new ScheduleAccess();

        public int InsertScheduleDLA(ScheduleDTO schedule)
        {
            return scheduleDAL.InsertSchedule(schedule);
        }
    }
}
