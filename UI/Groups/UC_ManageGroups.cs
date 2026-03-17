using System;
using System.Data;
using System.Windows.Forms;
using FYPManagementSystem.BusinessLogic;

namespace FYPManagementSystem.UI.Groups
{
    public partial class UC_ManageGroups : UserControl
    {
        public UC_ManageGroups()
        {
            InitializeComponent();
            LoadGroups();
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

        private void LoadGroups()
        {
            try
            {
                GroupsBL bl = new GroupsBL();
                DataTable dt = bl.GetGroups();
                dgvGroups.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            AddGroup addForm = new AddGroup();
            addForm.ShowDialog();
            LoadGroups();
        }

        private void btnUpdateGroup_Click(object sender, EventArgs e)
        {
            if (dgvGroups.SelectedRows.Count > 0)
            {
                int groupId = Convert.ToInt32(dgvGroups.SelectedRows[0].Cells["Group Id"].Value);
                UpdateGroup updateForm = new UpdateGroup(groupId);
                updateForm.ShowDialog();
                LoadGroups();
            }
            else
            {
                MessageBox.Show("Please select a group to update.");
            }
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            if (dgvGroups.SelectedRows.Count > 0)
            {
                int groupId = Convert.ToInt32(dgvGroups.SelectedRows[0].Cells["Group Id"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this group?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    GroupsBL bl = new GroupsBL();
                    if (bl.DeleteGroup(groupId))
                    {
                        MessageBox.Show("Group deleted successfully!");
                        LoadGroups();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a group to delete.");
            }
        }
    }
}
