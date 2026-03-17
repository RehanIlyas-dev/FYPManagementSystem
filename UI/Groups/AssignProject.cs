using System;
using System.Data;
using System.Windows.Forms;
using FYPManagementSystem.BusinessLogic;
using FYPManagementSystem.Models;

namespace FYPManagementSystem.UI.Groups
{
    public partial class AssignProject : Form
    {
        public AssignProject()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                GroupProjectBL bl = new GroupProjectBL();
                
                cmbGroups.DataSource = bl.GetAvailableGroups();
                cmbGroups.DisplayMember = "Id";
                cmbGroups.ValueMember = "Id";

                cmbProjects.DataSource = bl.GetAvailableProjects();
                cmbProjects.DisplayMember = "Title";
                cmbProjects.ValueMember = "Id";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cmbGroups.SelectedValue == null || cmbProjects.SelectedValue == null)
            {
                MessageBox.Show("Please select both a group and a project.");
                return;
            }

            GroupProjectModel gp = new GroupProjectModel();
            gp.GroupId = Convert.ToInt32(cmbGroups.SelectedValue);
            gp.ProjectId = Convert.ToInt32(cmbProjects.SelectedValue);
            gp.AssignmentDate = DateTime.Now;

            GroupProjectBL bl = new GroupProjectBL();
            if (bl.AssignProject(gp))
            {
                MessageBox.Show("Project assigned successfully!");
                this.Close();
            }
            else { MessageBox.Show("Failed to assign project."); }
        }
    }
}
