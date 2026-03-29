using System;
using System.Data;
using System.Windows.Forms;
using FYPManagementSystem.BL;
using FYPManagementSystem.Models;

namespace FYPManagementSystem.UI.ProjectAdvisor
{
    public partial class AddAdvisor : Form
    {
        private ProjectAdvisorBL bl = new ProjectAdvisorBL();
        public AddAdvisor()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                cmbProjects.DataSource = bl.GetProjects();
                cmbProjects.DisplayMember = "Title";
                cmbProjects.ValueMember = "Id";

                cmbAdvisors.DataSource = bl.GetAdvisors();
                cmbAdvisors.DisplayMember = "Name";
                cmbAdvisors.ValueMember = "Id";

                cmbRoles.DataSource = bl.GetAdvisorRoles();
                cmbRoles.DisplayMember = "Value";
                cmbRoles.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cmbProjects.SelectedValue == null || cmbAdvisors.SelectedValue == null || cmbRoles.SelectedValue == null)
            {
                MessageBox.Show("Please select all fields.");
                return;
            }

            ProjectAdvisorModel pa = new ProjectAdvisorModel();
            pa.ProjectId = Convert.ToInt32(cmbProjects.SelectedValue);
            pa.AdvisorId = Convert.ToInt32(cmbAdvisors.SelectedValue);
            pa.AdvisorRoleId = Convert.ToInt32(cmbRoles.SelectedValue);
            pa.AssignmentDate = dtpAssignmentDate.Value;

            if (bl.AssignAdvisor(pa))
            {
                MessageBox.Show("Advisor assigned successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to assign advisor. Assignment might already exist.");
            }
        }
    }
}
