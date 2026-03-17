using System;
using System.Data;
using System.Windows.Forms;
using FYPManagementSystem.BusinessLogic;
using FYPManagementSystem.Models;

namespace FYPManagementSystem.UI.Students
{
    public partial class UC_ManageStudents : UserControl
    {
        public UC_ManageStudents()
        {
            InitializeComponent();
            LoadStudentData();
            SetupSidebarButtons();
        }

        private void SetupSidebarButtons()
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(0, 100, 180);
                    btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(0, 120, 215);
                }
            }
        }

        public void LoadStudentData()
        {
            try
            {
                StudentBL data = new StudentBL();
                DataTable dt = data.GetStudents();

                dgvStudents.DataSource = dt;

                if (dgvStudents.Columns["Id"] != null)
                {
                    dgvStudents.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnaddStudent_Click(object sender, EventArgs e)
        {
            AddStudent popupWindow = new AddStudent();
            popupWindow.ShowDialog();
            LoadStudentData();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                int personId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["Id"].Value);
                string regNo = dgvStudents.SelectedRows[0].Cells["Registration No"].Value.ToString();
                string firstName = dgvStudents.SelectedRows[0].Cells["First Name"].Value.ToString();
                string lastName = dgvStudents.SelectedRows[0].Cells["Last Name"].Value.ToString();
                string contact = dgvStudents.SelectedRows[0].Cells["Contact"].Value.ToString();
                string email = dgvStudents.SelectedRows[0].Cells["Email"].Value.ToString();
                DateTime dob = Convert.ToDateTime(dgvStudents.SelectedRows[0].Cells["DOB"].Value);
                string gender = dgvStudents.SelectedRows[0].Cells["Gender"].Value.ToString();

                UpdateStudent updateForm = new UpdateStudent(personId, regNo, firstName, lastName, contact, email, dob, gender);
                updateForm.ShowDialog();

                LoadStudentData();
            }
            else
            {
                MessageBox.Show("Please select an entire row from the left margin to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btndeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int personId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["Id"].Value);
                    
                    StudentBL data = new StudentBL();
                    bool isSuccess = data.DeleteStudent(personId);

                    if (isSuccess)
                    {
                        MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudentData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an entire row from the left margin to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnclearform_Click(object sender, EventArgs e)
        {
            dgvStudents.ClearSelection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
