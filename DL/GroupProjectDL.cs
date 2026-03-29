using MySql.Data.MySqlClient;
using System;
using System.Data;
using FYPManagementSystem.Models;

namespace FYPManagementSystem.DL
{
    public class GroupProjectDL
    {
        public bool AssignProject(GroupProjectModel gp)
        {
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = "INSERT INTO groupproject (ProjectId, GroupId, AssignmentDate) VALUES (@pId, @gId, @date)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@pId", gp.ProjectId);
                cmd.Parameters.AddWithValue("@gId", gp.GroupId);
                cmd.Parameters.AddWithValue("@date", gp.AssignmentDate);
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

        public DataTable GetAssignedProjects()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = @"SELECT gp.GroupId AS 'Group ID', p.Title AS 'Project Title', gp.AssignmentDate AS 'Assigned On', gp.ProjectId
                                 FROM groupproject gp
                                 JOIN project p ON gp.ProjectId = p.Id";
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

        public DataTable GetAvailableGroups()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = @"SELECT Id FROM `group` WHERE Id NOT IN (SELECT GroupId FROM groupproject)";
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

        public DataTable GetAvailableProjects()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = @"SELECT Id, Title FROM project WHERE Id NOT IN (SELECT ProjectId FROM groupproject)";
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

        public bool RemoveAssignment(int groupId, int projectId)
        {
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = "DELETE FROM groupproject WHERE GroupId=@gId AND ProjectId=@pId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@gId", groupId);
                cmd.Parameters.AddWithValue("@pId", projectId);
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