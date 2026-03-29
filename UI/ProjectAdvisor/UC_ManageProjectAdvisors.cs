using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FYPManagementSystem.BL;

namespace FYPManagementSystem.UI.ProjectAdvisor
{
    public partial class UC_ManageProjectAdvisors : UserControl
    {
        private ProjectAdvisorBL bl = new ProjectAdvisorBL();

        public UC_ManageProjectAdvisors()
        {
            InitializeComponent();
            LoadAssignments();
            SetupSidebarButtons();
        }

        private void SetupSidebarButtons()
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

        private void LoadAssignments()
        {
            try
            {
                DataTable dt = bl.GetAssignedAdvisors();
                dgvAssignments.DataSource = dt;

                if (dgvAssignments.Columns["ProjectId"] != null) dgvAssignments.Columns["ProjectId"].Visible = false;
                if (dgvAssignments.Columns["AdvisorId"] != null) dgvAssignments.Columns["AdvisorId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assignments: " + ex.Message);
            }
        }

        private void btnAssignAdvisor_Click(object sender, EventArgs e)
        {
            AddAdvisor form = new AddAdvisor();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadAssignments();
            }
        }

        private void btnRemoveAssignment_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Remove this assignment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    int pId = Convert.ToInt32(dgvAssignments.SelectedRows[0].Cells["ProjectId"].Value);
                    int aId = Convert.ToInt32(dgvAssignments.SelectedRows[0].Cells["AdvisorId"].Value);

                    if (bl.RemoveAssignment(pId, aId))
                    {
                        MessageBox.Show("Assignment removed successfully.");
                        LoadAssignments();
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove assignment.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an assignment to remove.");
            }
        }
    }
}
