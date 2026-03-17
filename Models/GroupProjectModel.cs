using System;

namespace FYPManagementSystem.Models
{
    public class GroupProjectModel
    {
        public int ProjectId { get; set; }
        public int GroupId { get; set; }
        public DateTime AssignmentDate { get; set; }
    }
}