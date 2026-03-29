using MySql.Data.MySqlClient;
using System;
using System.Data;
using FYPManagementSystem.Models;

namespace FYPManagementSystem.DL
{
    public class ProjectAdvisorDL
    {
        public bool AssignAdvisor(ProjectAdvisorModel pa)
        {
            MySqlConnection con = DatabaseConnection.GetConnection();
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
            finally
            {
                con.Close();
            }
        }

        public DataTable GetProjects()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = "SELECT Id, Title FROM project";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception) { }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public DataTable GetAdvisors()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = "SELECT p.Id, CONCAT(p.FirstName, ' ', p.LastName) AS 'Name' FROM advisor a JOIN person p ON a.Id = p.Id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception) { }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public DataTable GetAdvisorRoles()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = "SELECT Id, Value FROM lookup WHERE Category = 'ADVISOR_ROLE'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception) { }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public DataTable GetAssignedAdvisors()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = @"SELECT p.Title AS 'Project Title', CONCAT(per.FirstName, ' ', per.LastName) AS 'Advisor Name', 
                                 l.Value AS 'Role', pa.AssignmentDate AS 'Assigned On', pa.ProjectId, pa.AdvisorId
                                 FROM projectadvisor pa
                                 JOIN project p ON pa.ProjectId = p.Id
                                 JOIN person per ON pa.AdvisorId = per.Id
                                 JOIN lookup l ON pa.AdvisorRole = l.Id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception) { }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public bool RemoveAssignment(int projectId, int advisorId)
        {
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = "DELETE FROM projectadvisor WHERE ProjectId=@pId AND AdvisorId=@aId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@pId", projectId);
                cmd.Parameters.AddWithValue("@aId", advisorId);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
