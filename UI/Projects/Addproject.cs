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
    public partial class Addproject : Form
    {
        public Addproject()
        {
            InitializeComponent();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Project Title is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProjectModel proj = new ProjectModel();
            proj.Title = txtTitle.Text;
            proj.Description = txtDescription.Text;

            ProjectBL bll = new ProjectBL();
            if (bll.AddProject(proj))
            {
                MessageBox.Show("Project added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTitle.Clear();
                txtDescription.Clear();
            }
            else
            {
                MessageBox.Show("Failed to add project.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
