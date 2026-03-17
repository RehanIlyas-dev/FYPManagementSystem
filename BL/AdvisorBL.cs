using System.Data;
using FYPManagementSystem.Models;
using FYPManagementSystem.DataLayer;

namespace FYPManagementSystem.BusinessLogic
{
    public class AdvisorBL
    {
        private AdvisorDL advisorData = new AdvisorDL();

        public bool AddAdvisor(AdvisorModel adv)
        {
            return advisorData.AddAdvisor(adv);
        }

        public DataTable GetAdvisors()
        {
            return advisorData.GetAdvisors();
        }

        public bool UpdateAdvisor(AdvisorModel adv)
        {
            return advisorData.UpdateAdvisor(adv);
        }

        public bool DeleteAdvisor(int personId)
        {
            return advisorData.DeleteAdvisor(personId);
        }
    }
}
