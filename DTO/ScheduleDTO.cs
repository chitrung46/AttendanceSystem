using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ScheduleDTO
    {
        public int Id { get; set; }
        public string ShiftDay { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int GroupId { get; set; }
        public int SubjectId { get; set; }
        public ScheduleDTO() { }
        public ScheduleDTO(int id, string shiftDay, TimeSpan startTime, TimeSpan endTime, int groupId, int subjectId)
        {
            Id = id;
            ShiftDay = shiftDay;
            StartTime = startTime;
            EndTime = endTime;
            GroupId = groupId;
            SubjectId = subjectId;
        }
    }
}
