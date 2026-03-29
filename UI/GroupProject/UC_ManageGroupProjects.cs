using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FYPManagementSystem.BL;

namespace FYPManagementSystem.UI.GroupProject
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

        private void UC_ManageGroupProjects_Load(object sender, EventArgs e)
        {
            LoadAssignments();
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
                DialogResult res = MessageBox.Show("Remove this assignment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        int gId = Convert.ToInt32(dgvAssignments.SelectedRows[0].Cells["Group ID"].Value);
                        int pId = Convert.ToInt32(dgvAssignments.SelectedRows[0].Cells["ProjectId"].Value);

                        GroupProjectBL bl = new GroupProjectBL();
                        if (bl.RemoveAssignment(gId, pId))
                        {
                            MessageBox.Show("Assignment removed successfully.");
                            LoadAssignments();
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove assignment.");
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
                }
            }
            else { MessageBox.Show("Select an assignment to remove."); }
        }

        private void LoadAssignments()
        {
            try
            {
                GroupProjectBL bl = new GroupProjectBL();
                dgvAssignments.DataSource = bl.GetAssignedProjects();
                if (dgvAssignments.Columns["ProjectId"] != null) dgvAssignments.Columns["ProjectId"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}
