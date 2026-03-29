using System.Data;
using FYPManagementSystem.Models;
using FYPManagementSystem.DL;

namespace FYPManagementSystem.BL
{
    public class GroupEvaluationBL
    {
        private GroupEvaluationDL dl = new GroupEvaluationDL();

        public bool AddGroupEvaluation(GroupEvaluationModel ge)
        {
            return dl.AddGroupEvaluation(ge);
        }

        public bool UpdateGroupEvaluation(GroupEvaluationModel ge)
        {
            return dl.UpdateGroupEvaluation(ge);
        }

        public bool DeleteGroupEvaluation(int groupId, int evaluationId)
        {
            return dl.DeleteGroupEvaluation(groupId, evaluationId);
        }

        public DataTable GetGroupEvaluations()
        {
            return dl.GetGroupEvaluations();
        }

        public DataTable GetGroups()
        {
            return dl.GetGroups();
        }

        public DataTable GetEvaluations()
        {
            return dl.GetEvaluations();
        }
    }
}