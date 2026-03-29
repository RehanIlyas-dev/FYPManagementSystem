using System.Data;
using FYPManagementSystem.Models;
using FYPManagementSystem.DL;

namespace FYPManagementSystem.BL
{
    public class GroupsBL
    {
        private GroupsDL dl = new GroupsDL();

        public DataTable GetUnassignedStudents()
        {
            return dl.GetUnassignedStudents();
        }

        public bool CreateGroup(GroupModel group)
        {
            if (group.StudentIds.Count == 0)
            {
                return false;
            }
            return dl.CreateGroup(group);
        }

        public DataTable GetGroups()
        {
            return dl.GetGroups();
        }

        public bool DeleteGroup(int groupId)
        {
            return dl.DeleteGroup(groupId);
        }

        public DataTable GetGroupStudents(int groupId)
        {
            return dl.GetGroupStudents(groupId);
        }

        public bool UpdateGroupMembers(GroupModel group)
        {
            return dl.UpdateGroupMembers(group);
        }

        public DataTable GetAllStudentsForUpdate(int currentGroupId)
        {
            return dl.GetAllStudentsForUpdate(currentGroupId);
        }
    }
}