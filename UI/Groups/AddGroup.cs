using System;
using System.Data;
using System.Windows.Forms;
using FYPManagementSystem.BL;
using FYPManagementSystem.Models;

namespace FYPManagementSystem.UI.Groups
{
    public partial class AddGroup : Form
    {
        public AddGroup()
        {
            InitializeComponent();
            LoadUnassignedStudents();
        }

        private void LoadUnassignedStudents()
        {
            try
            {
                GroupsBL bl = new GroupsBL();
                DataTable dt = bl.GetUnassignedStudents();
                
                dt.Columns.Add("Display", typeof(string), "[Reg No] + ' - ' + [Name]");
                
                clbStudents.DataSource = dt;
                clbStudents.DisplayMember = "Display";
                clbStudents.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            if (clbStudents.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one student.");
                return;
            }

            GroupModel group = new GroupModel();
            group.CreatedOn = DateTime.Now;
            
            foreach (DataRowView item in clbStudents.CheckedItems)
            {
                group.StudentIds.Add(Convert.ToInt32(item["Id"]));
            }

            GroupsBL bl = new GroupsBL();
            if (bl.CreateGroup(group))
            {
                MessageBox.Show("Group created and students linked successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create group.");
            }
        }
    }
}
