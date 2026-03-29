using System;
using System.Data;
using System.Windows.Forms;
using FYPManagementSystem.BL;
using FYPManagementSystem.Models;

namespace FYPManagementSystem.UI.Evaluations
{
    public partial class AddGroupEvaluation : Form
    {
        private GroupEvaluationBL bl = new GroupEvaluationBL();

        public AddGroupEvaluation()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            cmbGroup.DataSource = bl.GetGroups();
            cmbGroup.DisplayMember = "Id";
            cmbGroup.ValueMember = "Id";

            cmbEvaluation.DataSource = bl.GetEvaluations();
            cmbEvaluation.DisplayMember = "Name";
            cmbEvaluation.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbGroup.SelectedValue == null || cmbEvaluation.SelectedValue == null || string.IsNullOrWhiteSpace(txtMarks.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            int marks = 0;
            if (!int.TryParse(txtMarks.Text, out marks))
            {
                MessageBox.Show("Please enter valid marks.");
                return;
            }

            GroupEvaluationModel ge = new GroupEvaluationModel();
            ge.GroupId = Convert.ToInt32(cmbGroup.SelectedValue);
            ge.EvaluationId = Convert.ToInt32(cmbEvaluation.SelectedValue);
            ge.ObtainedMarks = marks;
            ge.EvaluationDate = DateTime.Now;

            if (bl.AddGroupEvaluation(ge))
            {
                MessageBox.Show("Evaluation marked successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to mark evaluation. Ensure this group hasn't already been evaluated for this item.");
            }
        }
    }
}
