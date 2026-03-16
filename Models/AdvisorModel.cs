using System;

namespace FYPManagementSystem.Classes
{
    public class AdvisorModel
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GenderId { get; set; }
        public int DesignationId { get; set; }
        public decimal Salary { get; set; }
    }
}
