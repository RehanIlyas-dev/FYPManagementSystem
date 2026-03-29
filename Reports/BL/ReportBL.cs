using System.Data;
using FYPManagementSystem.Reports.DL;

namespace FYPManagementSystem.Reports.BL
{
    public class ReportBL
    {
        private ReportDL dl = new ReportDL();

        public DataTable GetGroupMarksSummary()
        {
            return dl.GetGroupMarksSummary();
        }

        public DataTable GetStudentsWithoutGroup()
        {
            return dl.GetStudentsWithoutGroup();
        }
    }
}
