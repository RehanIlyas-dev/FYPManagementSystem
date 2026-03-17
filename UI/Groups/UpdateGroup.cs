using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FYPManagementSystem.BusinessLogic;
using FYPManagementSystem.Models;

namespace FYPManagementSystem.UI.Groups
{
    public partial class UpdateGroup : Form
    {
        private int _groupId;

        public UpdateGroup(int groupId)
        {
            InitializeComponent();
            _groupId = groupId;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                GroupsBL bl = new GroupsBL();
                
                // Load all possible students (unassigned + current members)
                DataTable allStudents = bl.GetAllStudentsForUpdate(_groupId);
                allStudents.Columns.Add("Display", typeof(string), "[Reg No] + ' - ' + [Name]");
                
                clbStudents.DataSource = allStudents;
                clbStudents.DisplayMember = "Display";
                clbStudents.ValueMember = "Id";

                // Pre-check current members
                DataTable currentMembers = bl.GetGroupStudents(_groupId);
                List<int> memberIds = new List<int>();
                foreach (DataRow row in currentMembers.Rows)
                {
                    memberIds.Add(Convert.ToInt32(row["StudentId"]));
                }

                for (int i = 0; i < clbStudents.Items.Count; i++)
                {
                    DataRowView rowView = (DataRowView)clbStudents.Items[i];
                    int id = Convert.ToInt32(rowView["Id"]);
                    if (memberIds.Contains(id))
                    {
                        clbStudents.SetItemChecked(i, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (clbStudents.CheckedItems.Count == 0)
            {
                MessageBox.Show("Group must have at least one student.");
                return;
            }

            GroupModel group = new GroupModel();
            group.Id = _groupId;
            
            foreach (DataRowView item in clbStudents.CheckedItems)
            {
                group.StudentIds.Add(Convert.ToInt32(item["Id"]));
            }

            GroupsBL bl = new GroupsBL();
            if (bl.UpdateGroupMembers(group))
            {
                MessageBox.Show("Group members updated successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update group.");
            }
        }
    }
}
