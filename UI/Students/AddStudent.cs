using FYPManagementSystem.BusinessLogic;
using FYPManagementSystem.Models;
using System;
using System.Windows.Forms;

namespace FYPManagementSystem.UI.Students
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int genderId = 1;
                if (CBGender.Text == "Female")
                {
                    genderId = 2;
                }

                StudentModel newStudent = new StudentModel
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Contact = txtContact.Text,
                    Email = txtEmail.Text,
                    DateOfBirth = dtp01.Value,
                    GenderId = genderId,
                    RegistrationNo = txtRegNo.Text
                };

                StudentBL data = new StudentBL();
                bool isSuccess = data.AddStudent(newStudent);

                if (isSuccess)
                {
                    MessageBox.Show("Student saved to the database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
