using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FYPManagementSystem.BLL;

namespace FYPManagementSystem.UI
{
    public partial class UC_ManageAdvisors : UserControl
    {
        public UC_ManageAdvisors()
        {
            InitializeComponent();
            LoadAdvisorData();
        }

        public void LoadAdvisorData()
        {
            try
            {
                AdvisorBL bll = new AdvisorBL();
                DataTable dt = bll.GetAdvisors();
                dgvAdvisors.DataSource = dt;

                if (dgvAdvisors.Columns["Id"] != null)
                {
                    dgvAdvisors.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddAdvisor_Click(object sender, EventArgs e)
        {
            AddAdvisor form = new AddAdvisor();
            form.FormClosed += (s, args) => LoadAdvisorData();
            form.ShowDialog();
        }

        private void btnUpdateAdvisor_Click(object sender, EventArgs e)
        {
            if (dgvAdvisors.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvAdvisors.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                string fname = row.Cells["FirstName"].Value.ToString();
                string lname = row.Cells["LastName"].Value.ToString();
                string contact = row.Cells["Contact"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();
                DateTime dob = Convert.ToDateTime(row.Cells["DOB"].Value);
                string gender = row.Cells["Gender"].Value.ToString();
                string designation = row.Cells["Designation"].Value.ToString();
                decimal salary = Convert.ToDecimal(row.Cells["Salary"].Value);

                UpdateAdvisor form = new UpdateAdvisor(id, fname, lname, contact, email, dob, gender, designation, salary);
                form.FormClosed += (s, args) => LoadAdvisorData();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an entire row to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteAdvisor_Click(object sender, EventArgs e)
        {
            if (dgvAdvisors.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this advisor?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int personId = Convert.ToInt32(dgvAdvisors.SelectedRows[0].Cells["Id"].Value);
                    AdvisorBL bll = new AdvisorBL();
                    if (bll.DeleteAdvisor(personId))
                    {
                        MessageBox.Show("Advisor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAdvisorData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete advisor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an entire row to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            dgvAdvisors.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
