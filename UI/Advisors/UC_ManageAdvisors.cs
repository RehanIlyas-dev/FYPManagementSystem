using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FYPManagementSystem.BL;

namespace FYPManagementSystem.UI.Advisors
{
    public partial class UC_ManageAdvisors : UserControl
    {
        public UC_ManageAdvisors()
        {
            InitializeComponent();
            LoadAdvisors();
            SetupSidebarButtons();
        }

        private void SetupSidebarButtons()
        {
            foreach (Control ctrl in panel1.Controls)
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

        private void LoadAdvisors()
        {
            try
            {
                AdvisorBL bl = new AdvisorBL();
                DataTable dt = bl.GetAdvisors();
                dgvAdvisors.DataSource = dt;

                if (dgvAdvisors.Columns["Id"] != null)
                {
                    dgvAdvisors.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading advisors: " + ex.Message);
            }
        }

        private void btnAddAdvisor_Click(object sender, EventArgs e)
        {
            AddAdvisor addForm = new AddAdvisor();
            addForm.ShowDialog();
            LoadAdvisors();
        }

        private void btnUpdateAdvisor_Click(object sender, EventArgs e)
        {
            if (dgvAdvisors.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvAdvisors.SelectedRows[0];
                int personId = Convert.ToInt32(row.Cells["Id"].Value);
                string fname = row.Cells["FirstName"].Value.ToString();
                string lname = row.Cells["LastName"].Value.ToString();
                string contact = row.Cells["Contact"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();
                DateTime dob = Convert.ToDateTime(row.Cells["DOB"].Value);
                string gender = row.Cells["Gender"].Value.ToString();
                string designation = row.Cells["Designation"].Value.ToString();
                decimal salary = Convert.ToDecimal(row.Cells["Salary"].Value);

                UpdateAdvisor updateForm = new UpdateAdvisor(personId, fname, lname, contact, email, dob, gender, designation, salary);
                updateForm.ShowDialog();
                LoadAdvisors();
            }
            else
            {
                MessageBox.Show("Please select an advisor to update.");
            }
        }

        private void btnDeleteAdvisor_Click(object sender, EventArgs e)
        {
            if (dgvAdvisors.SelectedRows.Count > 0)
            {
                int personId = Convert.ToInt32(dgvAdvisors.SelectedRows[0].Cells["Id"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this advisor?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (result == DialogResult.Yes)
                {
                    AdvisorBL bl = new AdvisorBL();
                    if (bl.DeleteAdvisor(personId))
                    {
                        MessageBox.Show("Advisor deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAdvisors();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete advisor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an advisor to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            LoadAdvisors();
        }
    }
}
