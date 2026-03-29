using System;
using System.Data;
using System.Windows.Forms;
using FYPManagementSystem.Reports.BL;

namespace FYPManagementSystem.Reports.UI
{
    public partial class UC_Reports : UserControl
    {
        private ReportBL reportBL = new ReportBL();

        public UC_Reports()
        {
            InitializeComponent();
            LoadReports();
        }

        public void LoadReports()
        {
            try
            {
                dgvGroupMarks.DataSource = reportBL.GetGroupMarksSummary();
                dgvStudentsWithoutGroup.DataSource = reportBL.GetStudentsWithoutGroup();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message);
            }
        }
    }
}
