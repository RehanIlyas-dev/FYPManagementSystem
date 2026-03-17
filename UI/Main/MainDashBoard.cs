using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FYPManagementSystem.UI.Students;
using FYPManagementSystem.UI.Advisors;
using FYPManagementSystem.UI.Projects;
using FYPManagementSystem.UI.Groups;

namespace FYPManagementSystem.UI.Main
{
    public partial class MainDashBoard : Form
    {
        public MainDashBoard()
        {
            InitializeComponent();
        }

        private void MainDashBoard_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            SetupSidebarButtons();
        }

        private void SetupSidebarButtons()
        {
            foreach (Control ctrl in panelSideBar.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.MouseEnter += SidebarButton_MouseEnter;
                    btn.MouseLeave += SidebarButton_MouseLeave;
                }
            }
        }

        private void SidebarButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.RosyBrown;
        }

        private void SidebarButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelMainContent.Controls.Clear();
            UC_ManageGroupProjects uc = new UC_ManageGroupProjects();
            uc.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(uc);
        }

        private void ManageStudents_Click(object sender, EventArgs e)
        {

            this.panelMainContent.Controls.Clear();
            UC_ManageStudents studentScreen = new UC_ManageStudents();
            studentScreen.Dock = DockStyle.Fill;
            this.panelMainContent.Controls.Add(studentScreen);
            studentScreen.BringToFront();
        }

        private void panelMainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageAdvisors_Click(object sender, EventArgs e)
        {
            this.panelMainContent.Controls.Clear();
            UC_ManageAdvisors uc = new UC_ManageAdvisors();
            uc.Dock = DockStyle.Fill;
            this.panelMainContent.Controls.Add(uc);
            uc.BringToFront();
        }

        private void ManageProjects_Click(object sender, EventArgs e)
        {
            this.panelMainContent.Controls.Clear();
            UC_ManageProjects uc = new UC_ManageProjects();
            uc.Dock = DockStyle.Fill;
            this.panelMainContent.Controls.Add(uc);
            uc.BringToFront();
        }
        
        private void FormStudentGroups_Click(object sender, EventArgs e)
        {
            this.panelMainContent.Controls.Clear();
            UC_ManageGroups uc = new UC_ManageGroups();
            uc.Dock = DockStyle.Fill;
            this.panelMainContent.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
