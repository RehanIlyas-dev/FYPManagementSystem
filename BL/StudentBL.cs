using FYPManagementSystem.DAL;
using FYPManagementSystem.Models;
using System.Data;

namespace FYPManagementSystem.BLL
{
    public class StudentBL
    {
        private StudentDL dl = new StudentDL();

        public bool AddStudent(StudentModel std)
        {
            return dl.AddStudent(std);
        }

        public DataTable GetStudents()
        {
            return dl.GetStudents();
        }

        public bool UpdateStudent(StudentModel std)
        {
            return dl.UpdateStudent(std);
        }

        public bool DeleteStudent(int personId)
        {
            return dl.DeleteStudent(personId);
        }
    }
}