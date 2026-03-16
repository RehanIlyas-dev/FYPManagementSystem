using MySql.Data.MySqlClient;
using System;

namespace FYPManagementSystem.DataLayer
{
    public class DatabaseConnection
    {
        private static readonly string connectionString = "server=localhost;port=3306;database=projectadb26;user=root;password=1234;AllowPublicKeyRetrieval=True;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static string TestConnection()
        {
            try
            {
                using (MySqlConnection connection = GetConnection())
                {
                    connection.Open();
                    return "Database connection successful";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}