using MySql.Data.MySqlClient;
using System;
using System.Data;
using FYPManagementSystem.Models;

namespace FYPManagementSystem.DL
{
    public class GroupEvaluationDL
    {
        public bool AddGroupEvaluation(GroupEvaluationModel ge)
        {
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = "INSERT INTO groupevaluation (GroupId, EvaluationId, ObtainedMarks, EvaluationDate) VALUES (@GroupId, @EvaluationId, @ObtainedMarks, @EvaluationDate)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@GroupId", ge.GroupId);
                cmd.Parameters.AddWithValue("@EvaluationId", ge.EvaluationId);
                cmd.Parameters.AddWithValue("@ObtainedMarks", ge.ObtainedMarks);
                cmd.Parameters.AddWithValue("@EvaluationDate", ge.EvaluationDate);
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

        public bool UpdateGroupEvaluation(GroupEvaluationModel ge)
        {
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = "UPDATE groupevaluation SET ObtainedMarks = @ObtainedMarks, EvaluationDate = @EvaluationDate WHERE GroupId = @GroupId AND EvaluationId = @EvaluationId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@GroupId", ge.GroupId);
                cmd.Parameters.AddWithValue("@EvaluationId", ge.EvaluationId);
                cmd.Parameters.AddWithValue("@ObtainedMarks", ge.ObtainedMarks);
                cmd.Parameters.AddWithValue("@EvaluationDate", ge.EvaluationDate);
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

        public bool DeleteGroupEvaluation(int groupId, int evaluationId)
        {
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = "DELETE FROM groupevaluation WHERE GroupId = @GroupId AND EvaluationId = @EvaluationId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@GroupId", groupId);
                cmd.Parameters.AddWithValue("@EvaluationId", evaluationId);
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

        public DataTable GetGroupEvaluations()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = @"SELECT ge.GroupId, e.Name AS 'Evaluation Name', ge.ObtainedMarks AS 'Obtained Marks', ge.EvaluationDate AS 'Date', ge.EvaluationId
                                 FROM groupevaluation ge
                                 JOIN evaluation e ON ge.EvaluationId = e.Id";
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

        public DataTable GetGroups()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = "SELECT Id FROM `group`";
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

        public DataTable GetEvaluations()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = "SELECT Id, Name FROM evaluation";
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
    }
}