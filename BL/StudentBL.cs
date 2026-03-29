using System.Data;
using FYPManagementSystem.Models;
using FYPManagementSystem.DL;

namespace FYPManagementSystem.BL
{
    public class StudentBL
    {
        private StudentDL studentData = new StudentDL();

        public bool AddStudent(StudentModel std)
        {
            return studentData.AddStudent(std);
        }

        public DataTable GetStudents()
        {
            return studentData.GetStudents();
        }

        public bool UpdateStudent(StudentModel std)
        {
            return studentData.UpdateStudent(std);
        }

        public bool DeleteStudent(int personId)
        {
            return studentData.DeleteStudent(personId);
        }
    }
}
