using System;
using System.Windows.Forms;
using FYPManagementSystem.BL;
using FYPManagementSystem.Models;

namespace FYPManagementSystem.UI.Evaluations
{
    public partial class UpdateEvaluation : Form
    {
        private EvaluationBL evalBl = new EvaluationBL();
        private EvaluationModel currentEval;

        public UpdateEvaluation(EvaluationModel eval)
        {
            InitializeComponent();
            currentEval = eval;
            PopulateData();
        }

        private void PopulateData()
        {
            txtName.Text = currentEval.Name;
            txtTotalMarks.Text = currentEval.TotalMarks.ToString();
            txtWeightage.Text = currentEval.TotalWeightage.ToString();
        }

        private void btnUpdateEvaluation_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtTotalMarks.Text) || string.IsNullOrEmpty(txtWeightage.Text))
                {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                int totalMarks = 0;
                int weightage = 0;

                if (!int.TryParse(txtTotalMarks.Text, out totalMarks) || totalMarks <= 0)
                {
                    MessageBox.Show("Please enter a valid positive number for Total Marks.");
                    return;
                }

                if (!int.TryParse(txtWeightage.Text, out weightage) || weightage <= 0)
                {
                    MessageBox.Show("Please enter a valid positive number for Weightage.");
                    return;
                }

                EvaluationModel eval = new EvaluationModel();
                eval.Id = currentEval.Id;
                eval.Name = txtName.Text;
                eval.TotalMarks = totalMarks;
                eval.TotalWeightage = weightage;

                if (evalBl.UpdateEvaluation(eval))
                {
                    MessageBox.Show("Evaluation updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update evaluation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
