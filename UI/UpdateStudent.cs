using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using FYPManagementSystem.BusinessLogic;
using FYPManagementSystem.Classes;

namespace FYPManagementSystem.Forms
{
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private int _personId;
        private string _regNo;
        private string _firstName;
        private string _lastName;
        private string _contact;
        private string _email;
        private DateTime _dob;
        private string _gender;

        public UpdateStudent(int personId, string regNo, string firstName, string lastName, string contact, string email, DateTime dob, string gender)
        {
            InitializeComponent();
            
            _personId = personId;
            _regNo = regNo;
            _firstName = firstName;
            _lastName = lastName;
            _contact = contact;
            _email = email;
            _dob = dob;
            _gender = gender;
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            txtRegNo.Text = _regNo;
            txtFirstName.Text = _firstName;
            txtLastName.Text = _lastName;
            txtContact.Text = _contact;
            txtEmail.Text = _email;
            dtp01.Value = _dob;

            if (_gender == "Male") CBGender.SelectedIndex = 0;
            else if (_gender == "Female") CBGender.SelectedIndex = 1;
            else CBGender.SelectedIndex = 2;
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int genderId = 1;
                if (CBGender.Text == "Female")
                {
                    genderId = 2;
                }

                StudentModel updatedStudent = new StudentModel
                {
                    PersonId = _personId,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Contact = txtContact.Text,
                    Email = txtEmail.Text,
                    DateOfBirth = dtp01.Value,
                    GenderId = genderId,
                    RegistrationNo = txtRegNo.Text
                };

                StudentBL data = new StudentBL();
                bool isSuccess = data.UpdateStudent(updatedStudent);

                if (isSuccess)
                {
                    MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
