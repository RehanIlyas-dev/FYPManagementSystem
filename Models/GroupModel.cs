using System;
using System.Collections.Generic;

namespace FYPManagementSystem.Models
{
    public class GroupModel
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<int> StudentIds { get; set; } = new List<int>();
    }
}