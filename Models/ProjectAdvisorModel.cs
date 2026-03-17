using System;

namespace FYPManagementSystem.Models
{
    public class ProjectAdvisorModel
    {
        public int ProjectId { get; set; }
        public int AdvisorId { get; set; }
        public int AdvisorRoleId { get; set; }
        public DateTime AssignmentDate { get; set; }
    }
}