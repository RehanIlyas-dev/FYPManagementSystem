using MySql.Data.MySqlClient;
using System;
using System.Data;
using FYPManagementSystem.Models;

namespace FYPManagementSystem.DAL
{
    public class ProjectAdvisorDL
    {
        private string conString = "Server=localhost;Database=projectadb26;Uid=root;Pwd=1234;";

        public bool AssignAdvisor(ProjectAdvisorModel pa)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO projectadvisor (ProjectId, AdvisorId, AdvisorRole, AssignmentDate) VALUES (@pId, @aId, @role, @date)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@pId", pa.ProjectId);
                    cmd.Parameters.AddWithValue("@aId", pa.AdvisorId);
                    cmd.Parameters.AddWithValue("@role", pa.AdvisorRoleId);
                    cmd.Parameters.AddWithValue("@date", pa.AssignmentDate);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public DataTable GetProjects()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT Id, Title FROM project";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception) { }
            }
            return dt;
        }

        public DataTable GetAdvisors()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT p.Id, CONCAT(p.FirstName, ' ', p.LastName) AS 'Name' FROM advisor a JOIN person p ON a.Id = p.Id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception) { }
            }
            return dt;
        }

        public DataTable GetAdvisorRoles()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT Id, Value FROM lookup WHERE Category = 'ADVISOR_ROLE'";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception) { }
            }
            return dt;
        }
    }
}

