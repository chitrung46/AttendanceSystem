using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Text.RegularExpressions;

namespace BLL
{
    public class GroupBLL
    {
        GroupAccess groupAccess = new GroupAccess();

        public List<GroupInfo> GetGroupInfoByAccountIdAndSchoolIdDLA(int accountId, int schoolId) 
        {
            List<GroupInfo> groupInfos = groupAccess.GetGroupInfoByAccountIdAndSchoolIdDLA(accountId, schoolId);
            return groupInfos;
        }
        // Method to add a new group
        private GroupAccess groupDAL = new GroupAccess();

        public int InsertGroup(GroupDTO group)
        {
            return groupDAL.InsertGroup(group);
        }

        public void LinkStudentToGroup(int studentId, int groupId)
        {
            groupDAL.LinkStudentToGroup(studentId, groupId);
        }

        public DTO.Group GetGroupById(int groupId)
        {
            return groupAccess.GetGroupById(groupId);
        }





        /***

        // Method to retrieve groups by account ID
        public List<DTO.Group> GetGroupsByAccountId(string accountId)
        {
            if (string.IsNullOrEmpty(accountId))
            {
                throw new ArgumentException("Invalid account ID.");
            }

            return groupAccess.GetGroupsByAccountId(accountId);
        }***/
        public List<GroupInfo> GetAllGroupInformation()
        {
            return groupAccess.GetGroupInfoByAccountIdAndSchoolId();
        }
    }
}
