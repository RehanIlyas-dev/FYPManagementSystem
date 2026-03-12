using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace FYPManagementSystem.DAL
{
    public class DatabaseConnection
    {
        public static SqlConnection? GetConnection()
        {
            try
            {
                string connString = "Server=MOZI; Database=projectadb26; Integrated Security=True; TrustServerCertificate=True;";
                return new SqlConnection(connString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
    }
}