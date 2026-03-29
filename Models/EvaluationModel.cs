using System;

namespace FYPManagementSystem.Models
{
    public class EvaluationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
        public int TotalWeightage { get; set; }
    }
}