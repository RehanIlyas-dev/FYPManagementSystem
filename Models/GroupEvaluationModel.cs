using System;

namespace FYPManagementSystem.Models
{
    public class GroupEvaluationModel
    {
        public int GroupId { get; set; }
        public int EvaluationId { get; set; }
        public int ObtainedMarks { get; set; }
        public DateTime EvaluationDate { get; set; }
    }
}