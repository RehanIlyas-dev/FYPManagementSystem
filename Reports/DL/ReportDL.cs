using MySql.Data.MySqlClient;
using System;
using System.Data;
using FYPManagementSystem.DL;

namespace FYPManagementSystem.Reports.DL
{
    public class ReportDL
    {
        public DataTable GetGroupMarksSummary()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = @"SELECT 
                                    g.Id AS 'Group ID',
                                    p.Title AS 'Project Title',
                                    COALESCE(SUM(ge.ObtainedMarks), 0) AS 'Total Marks Earned'
                                 FROM `group` g
                                 LEFT JOIN groupproject gp ON g.Id = gp.GroupId
                                 LEFT JOIN project p ON gp.ProjectId = p.Id
                                 LEFT JOIN groupevaluation ge ON g.Id = ge.GroupId
                                 GROUP BY g.Id, p.Title";

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

        public DataTable GetStudentsWithoutGroup()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = DatabaseConnection.GetConnection();
            try
            {
                con.Open();
                string query = @"SELECT s.RegistrationNo AS 'Registration No', p.FirstName, p.LastName 
                                 FROM student s 
                                 JOIN person p ON s.Id = p.Id 
                                 WHERE s.Id NOT IN (SELECT StudentId FROM groupstudent)";

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
