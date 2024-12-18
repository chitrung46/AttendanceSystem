﻿using System;
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

        public void InsertAttendance(string attendanceTime, string attendanceType, string attendanceStatus, string codeQR, int studentId, int imageId, int sessionId, string limitTime)
        {
            attendanceAccess.InsertAttendance(attendanceTime, attendanceType, attendanceStatus, codeQR, studentId, imageId, sessionId, limitTime);
        }

        public void UpdateAttendance(DateTime attendanceTime, string attendanceType, string attendanceStatus, string codeQR, int studentId, int imageId, int sessionId)
        {
            attendanceAccess.UpdateAttendance(attendanceTime, attendanceType, attendanceStatus, codeQR, studentId, imageId, sessionId);
        }
    }
}
