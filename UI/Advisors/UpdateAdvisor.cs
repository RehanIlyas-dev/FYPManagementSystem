using System;
using System.Windows.Forms;
using FYPManagementSystem.Models;
using FYPManagementSystem.BusinessLogic;

namespace FYPManagementSystem.UI.Advisors
{
    public partial class UpdateAdvisor : Form
    {
        private int advisorId;
        private string firstName, lastName, contact, email, gender, designation;
        private DateTime dob;
        private decimal salary;

        public UpdateAdvisor(int id, string fname, string lname, string cont, string mail, DateTime birth, string gen, string desig, decimal sal)
        {
            InitializeComponent();
            advisorId = id;
            firstName = fname;
            lastName = lname;
            contact = cont;
            email = mail;
            dob = birth;
            gender = gen;
            designation = desig;
            salary = sal;
        }

        private void UpdateAdvisor_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            txtContact.Text = contact;
            txtEmail.Text = email;
            dtp01.Value = dob;
            CBGender.Text = gender;
            CBDesignation.Text = designation;
            txtSalary.Text = salary.ToString();
        }

        private void btnUpdateAdvisor_Click(object sender, EventArgs e)
        {
            try
            {
                int genderId = 1;
                if (CBGender.Text == "Female") genderId = 2;
                else if (CBGender.Text == "Prefer not to say") genderId = 3;

                int designationId = 6;
                if (CBDesignation.Text == "Professor") designationId = 6;
                else if (CBDesignation.Text == "Associate Professor") designationId = 7;
                else if (CBDesignation.Text == "Assistant Professor") designationId = 8;
                else if (CBDesignation.Text == "Lecturer") designationId = 9;
                else if (CBDesignation.Text == "Industry Professional") designationId = 10;

                AdvisorModel adv = new AdvisorModel
                {
                    PersonId = advisorId,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Contact = txtContact.Text,
                    Email = txtEmail.Text,
                    DateOfBirth = dtp01.Value,
                    GenderId = genderId,
                    DesignationId = designationId,
                    Salary = decimal.Parse(txtSalary.Text)
                };

                AdvisorBL data = new AdvisorBL();
                if (data.UpdateAdvisor(adv))
                {
                    MessageBox.Show("Advisor updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update advisor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
