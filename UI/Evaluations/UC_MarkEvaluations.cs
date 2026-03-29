using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FYPManagementSystem.BL;
using FYPManagementSystem.Models;

namespace FYPManagementSystem.UI.Evaluations
{
    public partial class UC_MarkEvaluations : UserControl
    {
        private GroupEvaluationBL bl = new GroupEvaluationBL();

        public UC_MarkEvaluations()
        {
            InitializeComponent();
            LoadGroupEvaluations();
            SetupHoverEffects();
        }

        private void SetupHoverEffects()
        {
            foreach (Control ctrl in leftpanel.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.MouseEnter += Button_MouseEnter;
                    btn.MouseLeave += Button_MouseLeave;
                }
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(0, 100, 180);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(0, 120, 215);
        }

        private void LoadGroupEvaluations()
        {
            DataTable dt = bl.GetGroupEvaluations();
            dgvGroupEvaluations.DataSource = dt;
            if (dgvGroupEvaluations.Columns["GroupId"] != null)
                dgvGroupEvaluations.Columns["GroupId"].HeaderText = "Group ID";
            if (dgvGroupEvaluations.Columns["EvaluationId"] != null)
                dgvGroupEvaluations.Columns["EvaluationId"].Visible = false;
        }

        private void btnMarkEvaluation_Click(object sender, EventArgs e)
        {
            AddGroupEvaluation addForm = new AddGroupEvaluation();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadGroupEvaluations();
            }
        }

        private void btnUpdateMark_Click(object sender, EventArgs e)
        {
            if (dgvGroupEvaluations.SelectedRows.Count > 0)
            {
                GroupEvaluationModel ge = new GroupEvaluationModel();
                ge.GroupId = Convert.ToInt32(dgvGroupEvaluations.SelectedRows[0].Cells["GroupId"].Value);
                ge.EvaluationId = Convert.ToInt32(dgvGroupEvaluations.SelectedRows[0].Cells["EvaluationId"].Value);
                ge.ObtainedMarks = Convert.ToInt32(dgvGroupEvaluations.SelectedRows[0].Cells["Obtained Marks"].Value);
                ge.EvaluationDate = Convert.ToDateTime(dgvGroupEvaluations.SelectedRows[0].Cells["Date"].Value);

                UpdateGroupEvaluation updateForm = new UpdateGroupEvaluation(ge);
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    LoadGroupEvaluations();
                }
            }
            else
            {
                MessageBox.Show("Please select a record to update.");
            }
        }

        private void btnDeleteMark_Click(object sender, EventArgs e)
        {
            if (dgvGroupEvaluations.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this mark?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int groupId = Convert.ToInt32(dgvGroupEvaluations.SelectedRows[0].Cells["GroupId"].Value);
                    int evaluationId = Convert.ToInt32(dgvGroupEvaluations.SelectedRows[0].Cells["EvaluationId"].Value);
                    
                    if (bl.DeleteGroupEvaluation(groupId, evaluationId))
                    {
                        MessageBox.Show("Mark deleted successfully!");
                        LoadGroupEvaluations();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete mark.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
        }
    }
}
