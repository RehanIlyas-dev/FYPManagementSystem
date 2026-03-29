using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FYPManagementSystem.BL;

namespace FYPManagementSystem.UI.Projects
{
    public partial class UC_ManageProjects : UserControl
    {
        public UC_ManageProjects()
        {
            InitializeComponent();
            LoadProjects();
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

        private void UC_ManageProjects_Load(object sender, EventArgs e)
        {
            LoadProjects();
        }

        private void LoadProjects()
        {
            try
            {
                ProjectBL bll = new ProjectBL();
                DataTable dt = bll.GetProjects();
                dgvProjects.DataSource = dt;
                
                if (dgvProjects.Columns["Id"] != null)
                {
                    dgvProjects.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading projects: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateProject_Click(object sender, EventArgs e)
        {
            if (dgvProjects.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvProjects.SelectedRows[0].Cells["Id"].Value);
                string title = dgvProjects.SelectedRows[0].Cells["Title"].Value.ToString();
                string description = dgvProjects.SelectedRows[0].Cells["Description"].Value?.ToString() ?? string.Empty;
                UpdateProject updateForm = new UpdateProject(id, title, description);
                updateForm.ShowDialog();
                LoadProjects();
            }
            else
            {
                MessageBox.Show("Please select an entire row to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            if (dgvProjects.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this project?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvProjects.SelectedRows[0].Cells["Id"].Value);
                    ProjectBL bll = new ProjectBL();
                    if (bll.DeleteProject(id))
                    {
                        MessageBox.Show("Project deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProjects();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete project.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a project to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvProjects_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnaddProject_Click(object sender, EventArgs e)
        {
            Addproject addProjectForm = new Addproject();
            addProjectForm.ShowDialog();
            LoadProjects();
        }
    }
}
