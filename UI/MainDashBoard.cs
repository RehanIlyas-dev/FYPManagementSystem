using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FYPManagementSystem.UI
{
    public partial class MainDashBoard : Form
    {
        public MainDashBoard()
        {
            InitializeComponent();
            this.Load += new EventHandler(MainDashBoard_Load);
        }

        private void MainDashBoard_Load(object? sender, EventArgs e)
        {
            using (Microsoft.Data.SqlClient.SqlConnection? conn = DAL.DatabaseConnection.GetConnection())
            {
                if (conn != null)
                {
                    try
                    {
                        conn.Open();
                        MessageBox.Show("Successfully connected to ProjectADb26! Phase 1 Complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
