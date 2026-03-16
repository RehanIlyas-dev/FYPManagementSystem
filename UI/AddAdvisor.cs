using System;
using System.Windows.Forms;
using FYPManagementSystem.Models;
using FYPManagementSystem.BLL;

namespace FYPManagementSystem.UI
{
    public partial class AddAdvisor : Form
    {
        public AddAdvisor()
        {
            InitializeComponent();
        }

        private void btnAddAdvisor_Click(object sender, EventArgs e)
        {
            try
            {
                int genderId = 1; // Male by default
                if (CBGender.Text == "Female") genderId = 2;
                else if (CBGender.Text == "Prefer not to say") genderId = 3;

                int designationId = 6; 
                if (CBDesignation.Text == "Professor") designationId = 6;
                else if (CBDesignation.Text == "Associate Professor") designationId = 7;
                else if (CBDesignation.Text == "Assistant Professor") designationId = 8;
                else if (CBDesignation.Text == "Lecturer") designationId = 9;
                else designationId = 10; 

                AdvisorModel adv = new AdvisorModel
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Contact = txtContact.Text,
                    Email = txtEmail.Text,
                    DateOfBirth = dtp01.Value,
                    GenderId = genderId,
                    DesignationId = designationId,
                    Salary = decimal.Parse(txtSalary.Text)
                };

                AdvisorBL bll = new AdvisorBL();
                if (bll.AddAdvisor(adv))
                {
                    MessageBox.Show("Advisor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add advisor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
