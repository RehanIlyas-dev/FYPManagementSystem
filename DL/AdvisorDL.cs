using MySql.Data.MySqlClient;
using System;
using System.Data;
using FYPManagementSystem.Models;

namespace FYPManagementSystem.DataLayer
{
    public class AdvisorDL
    {
        public bool AddAdvisor(AdvisorModel adv)
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
                        cmdPerson.Parameters.AddWithValue("@FirstName", adv.FirstName);
                        cmdPerson.Parameters.AddWithValue("@LastName", adv.LastName);
                        cmdPerson.Parameters.AddWithValue("@Contact", adv.Contact);
                        cmdPerson.Parameters.AddWithValue("@Email", adv.Email);
                        cmdPerson.Parameters.AddWithValue("@DateOfBirth", adv.DateOfBirth);
                        cmdPerson.Parameters.AddWithValue("@Gender", adv.GenderId);

                        int newPersonId = Convert.ToInt32(cmdPerson.ExecuteScalar());

                        string advisorQuery = "INSERT INTO advisor (Id, Designation, Salary) VALUES (@Id, @Designation, @Salary)";
                        MySqlCommand cmdAdvisor = new MySqlCommand(advisorQuery, con, transaction);
                        cmdAdvisor.Parameters.AddWithValue("@Id", newPersonId);
                        cmdAdvisor.Parameters.AddWithValue("@Designation", adv.DesignationId);
                        cmdAdvisor.Parameters.AddWithValue("@Salary", adv.Salary);

                        cmdAdvisor.ExecuteNonQuery();

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

        public DataTable GetAdvisors()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = @"SELECT p.Id, p.FirstName, p.LastName, p.Contact, p.Email, 
                                            p.DateOfBirth AS 'DOB', l1.Value AS 'Gender', 
                                            l2.Value AS 'Designation', a.Salary
                                     FROM advisor a
                                     JOIN person p ON a.Id = p.Id
                                     JOIN lookup l1 ON p.Gender = l1.Id
                                     JOIN lookup l2 ON a.Designation = l2.Id";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception) { }
            }
            return dt;
        }

        public bool UpdateAdvisor(AdvisorModel adv)
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
                        cmdPerson.Parameters.AddWithValue("@id", adv.PersonId);
                        cmdPerson.Parameters.AddWithValue("@fname", adv.FirstName);
                        cmdPerson.Parameters.AddWithValue("@lname", adv.LastName);
                        cmdPerson.Parameters.AddWithValue("@contact", adv.Contact);
                        cmdPerson.Parameters.AddWithValue("@email", adv.Email);
                        cmdPerson.Parameters.AddWithValue("@dob", adv.DateOfBirth);
                        cmdPerson.Parameters.AddWithValue("@gender", adv.GenderId);

                        cmdPerson.ExecuteNonQuery();

                        string queryAdvisor = "UPDATE advisor SET Designation=@designation, Salary=@salary WHERE Id=@id";
                        MySqlCommand cmdAdvisor = new MySqlCommand(queryAdvisor, con, transaction);
                        cmdAdvisor.Parameters.AddWithValue("@id", adv.PersonId);
                        cmdAdvisor.Parameters.AddWithValue("@designation", adv.DesignationId);
                        cmdAdvisor.Parameters.AddWithValue("@salary", adv.Salary);

                        cmdAdvisor.ExecuteNonQuery();

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

        public bool DeleteAdvisor(int personId)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                using (MySqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        string queryAdvisor = "DELETE FROM advisor WHERE Id=@id";
                        MySqlCommand cmdAdvisor = new MySqlCommand(queryAdvisor, con, transaction);
                        cmdAdvisor.Parameters.AddWithValue("@id", personId);
                        cmdAdvisor.ExecuteNonQuery();

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
