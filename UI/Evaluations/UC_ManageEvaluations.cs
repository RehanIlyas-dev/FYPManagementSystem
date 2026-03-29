using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FYPManagementSystem.BL;
using FYPManagementSystem.Models;

namespace FYPManagementSystem.UI.Evaluations
{
    public partial class UC_ManageEvaluations : UserControl
    {
        private EvaluationBL evalBl = new EvaluationBL();

        public UC_ManageEvaluations()
        {
            InitializeComponent();
            LoadEvaluations();
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

        private void LoadEvaluations()
        {
            DataTable dt = evalBl.GetEvaluations();
            dgvEvaluations.DataSource = dt;
            if (dgvEvaluations.Columns["Id"] != null)
                dgvEvaluations.Columns["Id"].Visible = false;
        }

        private void btnAddEvaluation_Click(object sender, EventArgs e)
        {
            AddEvaluation addForm = new AddEvaluation();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadEvaluations();
            }
        }

        private void btnUpdateEvaluation_Click(object sender, EventArgs e)
        {
            if (dgvEvaluations.SelectedRows.Count > 0)
            {
                EvaluationModel eval = new EvaluationModel();
                eval.Id = Convert.ToInt32(dgvEvaluations.SelectedRows[0].Cells["Id"].Value);
                eval.Name = dgvEvaluations.SelectedRows[0].Cells["Name"].Value.ToString();
                eval.TotalMarks = Convert.ToInt32(dgvEvaluations.SelectedRows[0].Cells["Total Marks"].Value);
                eval.TotalWeightage = Convert.ToInt32(dgvEvaluations.SelectedRows[0].Cells["Total Weightage"].Value);

                UpdateEvaluation updateForm = new UpdateEvaluation(eval);
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    LoadEvaluations();
                }
            }
            else
            {
                MessageBox.Show("Please select an evaluation to update.");
            }
        }

        private void btnDeleteEvaluation_Click(object sender, EventArgs e)
        {
            if (dgvEvaluations.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this evaluation?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvEvaluations.SelectedRows[0].Cells["Id"].Value);
                    if (evalBl.DeleteEvaluation(id))
                    {
                        MessageBox.Show("Evaluation deleted successfully!");
                        LoadEvaluations();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete evaluation.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an evaluation to delete.");
            }
        }
    }
}
