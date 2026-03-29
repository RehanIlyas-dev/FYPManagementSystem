using MySql.Data.MySqlClient;
using System;
using System.Data;
using FYPManagementSystem.Models;

namespace FYPManagementSystem.DL
{
    public class EvaluationDL
    {
        public bool AddEvaluation(EvaluationModel eval)
        {
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = "INSERT INTO evaluation (Name, TotalMarks, TotalWeightage) VALUES (@Name, @TotalMarks, @TotalWeightage)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", eval.Name);
                cmd.Parameters.AddWithValue("@TotalMarks", eval.TotalMarks);
                cmd.Parameters.AddWithValue("@TotalWeightage", eval.TotalWeightage);
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

        public DataTable GetEvaluations()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = "SELECT Id, Name, TotalMarks AS 'Total Marks', TotalWeightage AS 'Total Weightage' FROM evaluation";
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

        public bool UpdateEvaluation(EvaluationModel eval)
        {
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = "UPDATE evaluation SET Name=@Name, TotalMarks=@TotalMarks, TotalWeightage=@TotalWeightage WHERE Id=@Id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", eval.Id);
                cmd.Parameters.AddWithValue("@Name", eval.Name);
                cmd.Parameters.AddWithValue("@TotalMarks", eval.TotalMarks);
                cmd.Parameters.AddWithValue("@TotalWeightage", eval.TotalWeightage);
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

        public bool DeleteEvaluation(int id)
        {
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = "DELETE FROM evaluation WHERE Id=@Id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
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
