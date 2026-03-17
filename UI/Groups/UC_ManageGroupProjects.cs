using System;
using System.Data;
using System.Windows.Forms;
using FYPManagementSystem.BusinessLogic;

namespace FYPManagementSystem.UI.Groups
{
    public partial class UC_ManageGroupProjects : UserControl
    {
        public UC_ManageGroupProjects()
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
                    btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(0, 100, 180);
                    btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(0, 120, 215);
                }
            }
        }

        private void LoadAssignments()
        {
            try
            {
                GroupProjectBL bl = new GroupProjectBL();
                dgvAssignments.DataSource = bl.GetAssignedProjects();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnAssignProject_Click(object sender, EventArgs e)
        {
            AssignProject form = new AssignProject();
            form.ShowDialog();
            LoadAssignments();
        }

        private void btnRemoveAssignment_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Remove this assignment?", "Confirm", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    int gId = Convert.ToInt32(dgvAssignments.SelectedRows[0].Cells["Group ID"].Value);
                    MessageBox.Show("Assignment removal logic selected.");
                }
            }
            else { MessageBox.Show("Select an assignment to remove."); }
        }
    }
}
