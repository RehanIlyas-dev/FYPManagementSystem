using System.Data;
using FYPManagementSystem.Models;
using FYPManagementSystem.DL;

namespace FYPManagementSystem.BL
{
    public class ProjectBL
    {
        private ProjectDL dl = new ProjectDL();

        public bool AddProject(ProjectModel proj)
        {
            return dl.AddProject(proj);
        }

        public bool UpdateProject(ProjectModel proj)
        {
            return dl.UpdateProject(proj);
        }

        public bool DeleteProject(int id)
        {
            return dl.DeleteProject(id);
        }

        public DataTable GetProjects()
        {
            return dl.GetProjects();
        }
    }
}