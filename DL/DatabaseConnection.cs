using MySql.Data.MySqlClient;
using System;
using System.Configuration;

namespace FYPManagementSystem.DL
{
    public class DatabaseConnection
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["ProjectDbConnection"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static string TestConnection()
        {
            MySqlConnection connection = GetConnection();
            try
            {
                connection.Open();
                return "Database connection successful";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
