using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using FYPManagementSystem.BusinessLogic;
using FYPManagementSystem.Models;

namespace FYPManagementSystem.UI.Projects
{
    public partial class UpdateProject : Form
    {
        private int _projectId;
        private string _title;
        private string _description;

        public UpdateProject(int projectId, string title, string description)
        {
            InitializeComponent();
            _projectId = projectId;
            _title = title;
            _description = description;
        }

        private void UpdateProject_Load(object sender, EventArgs e)
        {
            txtTitle.Text = _title;
            txtDescription.Text = _description;
        }

        private void btnUpdateProject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Project Title is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProjectModel proj = new ProjectModel();
            proj.Id = _projectId;
            proj.Title = txtTitle.Text;
            proj.Description = txtDescription.Text;

            ProjectBL bll = new ProjectBL();
            if (bll.UpdateProject(proj))
            {
                MessageBox.Show("Project updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update project.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
