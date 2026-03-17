using MySql.Data.MySqlClient;
using System;
using System.Data;
using FYPManagementSystem.Models;
using System.Collections.Generic;

namespace FYPManagementSystem.DataLayer
{
    public class ProjectDL
    {

        public bool AddProject(ProjectModel proj)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO project (Title, Description) VALUES (@Title, @Description)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Title", proj.Title);
                    cmd.Parameters.AddWithValue("@Description", proj.Description);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool UpdateProject(ProjectModel proj)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "UPDATE project SET Title = @Title, Description = @Description WHERE Id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Title", proj.Title);
                    cmd.Parameters.AddWithValue("@Description", proj.Description);
                    cmd.Parameters.AddWithValue("@Id", proj.Id);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool DeleteProject(int id)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM project WHERE Id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);

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
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT Id, Title, Description FROM project";
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