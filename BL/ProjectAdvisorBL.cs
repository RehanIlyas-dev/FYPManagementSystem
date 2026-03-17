using System.Data;
using FYPManagementSystem.Models;
using FYPManagementSystem.DAL;

namespace FYPManagementSystem.BLL
{
    public class ProjectAdvisorBLL
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
    }
}

