using System.Data;
using FYPManagementSystem.Models;
using FYPManagementSystem.DL;

namespace FYPManagementSystem.BL
{
    public class EvaluationBL
    {
        private EvaluationDL evalData = new EvaluationDL();

        public bool AddEvaluation(EvaluationModel eval)
        {
            return evalData.AddEvaluation(eval);
        }

        public DataTable GetEvaluations()
        {
            return evalData.GetEvaluations();
        }

        public bool UpdateEvaluation(EvaluationModel eval)
        {
            return evalData.UpdateEvaluation(eval);
        }

        public bool DeleteEvaluation(int id)
        {
            return evalData.DeleteEvaluation(id);
        }
    }
}