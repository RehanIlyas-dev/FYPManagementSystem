using System.Data;
using FYPManagementSystem.Models;
using FYPManagementSystem.DataLayer;

namespace FYPManagementSystem.BusinessLogic
{
    public class GroupProjectBL
    {
        private GroupProjectDL dl = new GroupProjectDL();

        public bool AssignProject(GroupProjectModel gp)
        {
            return dl.AssignProject(gp);
        }

        public DataTable GetAssignedProjects()
        {
            return dl.GetAssignedProjects();
        }

        public DataTable GetAvailableGroups()
        {
            return dl.GetAvailableGroups();
        }

        public DataTable GetAvailableProjects()
        {
            return dl.GetAvailableProjects();
        }

        public bool RemoveAssignment(int groupId, int projectId)
        {
            return dl.RemoveAssignment(groupId, projectId);
        }
    }
}