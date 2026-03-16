using System.Runtime.InteropServices;

namespace FYPManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string status = DataLayer.DatabaseConnection.TestConnection();
            
            if (status == "Database connection successful")
            {
                MessageBox.Show(status, "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Connection Failed: " + status, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new Forms.MainDashBoard());
        }
    }
}
