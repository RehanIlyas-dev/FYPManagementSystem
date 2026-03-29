using System.Data;
using FYPManagementSystem.Models;
using FYPManagementSystem.DL;

namespace FYPManagementSystem.BL
{
    public class ProjectAdvisorBL
    {
        private ProjectAdvisorDL dl = new ProjectAdvisorDL();

        public bool AssignAdvisor(ProjectAdvisorModel pa)
        {
            return dl.AssignAdvisor(pa);
        }

        public DataTable GetProjects()
        {
            return dl.GetProjects();
        }

        public DataTable GetAdvisors()
        {
            return dl.GetAdvisors();
        }

        public DataTable GetAdvisorRoles()
        {
            return dl.GetAdvisorRoles();
        }

        public DataTable GetAssignedAdvisors()
        {
            return dl.GetAssignedAdvisors();
        }

        public bool RemoveAssignment(int projectId, int advisorId)
        {
            return dl.RemoveAssignment(projectId, advisorId);
        }
    }
}
