using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class AttendanceBLL
    {
        AttendanceAccess attendanceAccess = new AttendanceAccess();

        public void InsertAttendance(DateTime attendanceTime, string attendanceType, string attendanceStatus, string codeQR, int studentId, int imageId, int sessionId)
        {
            attendanceAccess.InsertAttendance(attendanceTime, attendanceType, attendanceStatus, codeQR, studentId, imageId, sessionId);
        }

        public void UpdateAttendance(DateTime attendanceTime, string attendanceType, string attendanceStatus, string codeQR, int studentId, int imageId, int sessionId)
        {
            attendanceAccess.UpdateAttendance(attendanceTime, attendanceType, attendanceStatus, codeQR, studentId, imageId, sessionId);
        }
    }
}
