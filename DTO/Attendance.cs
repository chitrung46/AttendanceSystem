using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Attendance
    {
        private int id;
        private DateTime attendanceTime;
        private string attendanceType;
        private string attendanceStatus;
        private string codeQR;
        private int studentId;
        private int imageId;
        private int sessionId;

        public Attendance(int id, DateTime attendanceTime, string attendanceType, string attendanceStatus, string codeQR, int studentId, int imageId, int sessionId)
        {
            this.id = id;
            this.attendanceTime = attendanceTime;
            this.attendanceType = attendanceType;
            this.attendanceStatus = attendanceStatus;
            this.codeQR = codeQR;
            this.studentId = studentId;
            this.imageId = imageId;
            this.sessionId = sessionId;
        }

        public int Id { get => id; set => id = value; }
        public DateTime AttendanceTime { get => attendanceTime; set => attendanceTime = value; }
        public string AttendanceType { get => attendanceType; set => attendanceType = value; }
        public string AttendanceStatus { get => attendanceStatus; set => attendanceStatus = value; }
        public string CodeQR { get => codeQR; set => codeQR = value; }
        public int StudentId { get => studentId; set => studentId = value; }
        public int ImageId { get => imageId; set => imageId = value; }
        public int SessionId { get => sessionId; set => sessionId = value; }
    }
}
