using System.Data;
using FYPManagementSystem.Models;
using FYPManagementSystem.DAL;

namespace FYPManagementSystem.BLL
{
    public class AdvisorBL
    {
        private AdvisorDL dl = new AdvisorDL();

        public bool AddAdvisor(AdvisorModel adv)
        {
            return dl.AddAdvisor(adv);
        }

        public DataTable GetAdvisors()
        {
            return dl.GetAdvisors();
        }

        public bool UpdateAdvisor(AdvisorModel adv)
        {
            return dl.UpdateAdvisor(adv);
        }

        public bool DeleteAdvisor(int personId)
        {
            return dl.DeleteAdvisor(personId);
        }
    }
}