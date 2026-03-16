using MySql.Data.MySqlClient;
using System;
using System.Data;
using FYPManagementSystem.Classes;

namespace FYPManagementSystem.DataLayer
{
    public class StudentDL
    {
        public bool AddStudent(StudentModel std)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                using (MySqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        string personQuery = @"INSERT INTO person (FirstName, LastName, Contact, Email, DateOfBirth, Gender) 
                                               VALUES (@FirstName, @LastName, @Contact, @Email, @DateOfBirth, @Gender);
                                               SELECT LAST_INSERT_ID();";

                        MySqlCommand cmdPerson = new MySqlCommand(personQuery, con, transaction);
                        cmdPerson.Parameters.AddWithValue("@FirstName", std.FirstName);
                        cmdPerson.Parameters.AddWithValue("@LastName", std.LastName);
                        cmdPerson.Parameters.AddWithValue("@Contact", std.Contact);
                        cmdPerson.Parameters.AddWithValue("@Email", std.Email);
                        cmdPerson.Parameters.AddWithValue("@DateOfBirth", std.DateOfBirth);
                        cmdPerson.Parameters.AddWithValue("@Gender", std.GenderId);

                        int newPersonId = Convert.ToInt32(cmdPerson.ExecuteScalar());

                        string studentQuery = "INSERT INTO student (Id, RegistrationNo) VALUES (@Id, @RegNo)";
                        MySqlCommand cmdStudent = new MySqlCommand(studentQuery, con, transaction);
                        cmdStudent.Parameters.AddWithValue("@Id", newPersonId);
                        cmdStudent.Parameters.AddWithValue("@RegNo", std.RegistrationNo);

                        cmdStudent.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public DataTable GetStudents()
        {
            DataTable dt = new DataTable();
        using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
            try
                {
                    con.Open();

                    string query = @"SELECT 
                                    p.Id,
                                    s.RegistrationNo AS 'Registration No', 
                                    p.FirstName AS 'First Name', 
                                    p.LastName AS 'Last Name', 
                                    p.Contact, 
                                    p.Email, 
                                    p.DateOfBirth AS 'DOB', 
                                    l.Value AS 'Gender'
                                 FROM student s
                                 INNER JOIN person p ON s.Id = p.Id
                                 LEFT JOIN lookup l ON p.Gender = l.Id";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception) { }
            }
            return dt;
        }

        public bool UpdateStudent(StudentModel std)
        {
        using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                using (MySqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        string queryPerson = "UPDATE person SET FirstName=@fname, LastName=@lname, Contact=@contact, Email=@email, DateOfBirth=@dob, Gender=@gender WHERE Id=@id";

                        MySqlCommand cmdPerson = new MySqlCommand(queryPerson, con, transaction);
                        cmdPerson.Parameters.AddWithValue("@id", std.PersonId);
                        cmdPerson.Parameters.AddWithValue("@fname", std.FirstName);
                        cmdPerson.Parameters.AddWithValue("@lname", std.LastName);
                        cmdPerson.Parameters.AddWithValue("@contact", std.Contact);
                        cmdPerson.Parameters.AddWithValue("@email", std.Email);
                        cmdPerson.Parameters.AddWithValue("@dob", std.DateOfBirth);
                        cmdPerson.Parameters.AddWithValue("@gender", std.GenderId);

                        cmdPerson.ExecuteNonQuery();

                        string queryStudent = "UPDATE student SET RegistrationNo=@regNo WHERE Id=@id";
                        MySqlCommand cmdStudent = new MySqlCommand(queryStudent, con, transaction);
                        cmdStudent.Parameters.AddWithValue("@id", std.PersonId);
                        cmdStudent.Parameters.AddWithValue("@regNo", std.RegistrationNo);

                        cmdStudent.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public bool DeleteStudent(int personId)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                using (MySqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        string queryStudent = "DELETE FROM student WHERE Id=@id";
                        MySqlCommand cmdStudent = new MySqlCommand(queryStudent, con, transaction);
                        cmdStudent.Parameters.AddWithValue("@id", personId);
                        cmdStudent.ExecuteNonQuery();

                        string queryPerson = "DELETE FROM person WHERE Id=@id";
                        MySqlCommand cmdPerson = new MySqlCommand(queryPerson, con, transaction);
                        cmdPerson.Parameters.AddWithValue("@id", personId);
                        cmdPerson.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
    }
}