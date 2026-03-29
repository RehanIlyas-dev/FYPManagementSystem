using System;
using System.Windows.Forms;
using FYPManagementSystem.BL;
using FYPManagementSystem.Models;

namespace FYPManagementSystem.UI.Evaluations
{
    public partial class UpdateGroupEvaluation : Form
    {
        private GroupEvaluationModel _ge;
        private GroupEvaluationBL bl = new GroupEvaluationBL();

        public UpdateGroupEvaluation(GroupEvaluationModel ge)
        {
            InitializeComponent();
            _ge = ge;
            LoadData();
        }

        private void LoadData()
        {
            lblGroup.Text = "Group ID: " + _ge.GroupId;
            lblEvaluation.Text = "Evaluation ID: " + _ge.EvaluationId;
            txtMarks.Text = _ge.ObtainedMarks.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarks.Text))
            {
                MessageBox.Show("Please enter marks.");
                return;
            }

            int marks = 0;
            if (!int.TryParse(txtMarks.Text, out marks))
            {
                MessageBox.Show("Please enter valid marks.");
                return;
            }

            _ge.ObtainedMarks = marks;
            _ge.EvaluationDate = DateTime.Now;

            if (bl.UpdateGroupEvaluation(_ge))
            {
                MessageBox.Show("Mark updated successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update mark.");
            }
        }
    }
}
