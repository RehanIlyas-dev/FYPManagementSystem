using System;

namespace FYPManagementSystem.Models
{
    public class StudentModel
    {
        public int PersonId { get; set; }
        public string RegistrationNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GenderId { get; set; }
    }
}