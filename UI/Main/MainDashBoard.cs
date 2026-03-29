using System;
using System.Drawing;
using System.Windows.Forms;
using FYPManagementSystem.UI.Students;
using FYPManagementSystem.UI.Advisors;
using FYPManagementSystem.UI.Projects;
using FYPManagementSystem.UI.Groups;
using FYPManagementSystem.UI.ProjectAdvisor;
using FYPManagementSystem.UI.Evaluations;
using FYPManagementSystem.UI.GroupProject;
using FYPManagementSystem.Reports.UI;

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
            btn.BackColor = Color.FromArgb(0, 100, 180);
        }

        private void SidebarButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Transparent;
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

        private void AssignAdvisors_Click(object sender, EventArgs e)
        {
            this.panelMainContent.Controls.Clear();
            UC_ManageProjectAdvisors uc = new UC_ManageProjectAdvisors();
            uc.Dock = DockStyle.Fill;
            this.panelMainContent.Controls.Add(uc);
            uc.BringToFront();
        }

        private void ManageEvaluations_Click(object sender, EventArgs e)
        {
            this.panelMainContent.Controls.Clear();
            UC_ManageEvaluations uc = new UC_ManageEvaluations();
            uc.Dock = DockStyle.Fill;
            this.panelMainContent.Controls.Add(uc);
            uc.BringToFront();
        }

        private void MarkEvaluations_Click(object sender, EventArgs e)
        {
            this.panelMainContent.Controls.Clear();
            UC_MarkEvaluations uc = new UC_MarkEvaluations();
            uc.Dock = DockStyle.Fill;
            this.panelMainContent.Controls.Add(uc);
            uc.BringToFront();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            this.panelMainContent.Controls.Clear();
            UC_Reports uc = new UC_Reports();
            uc.Dock = DockStyle.Fill;
            this.panelMainContent.Controls.Add(uc);
            uc.BringToFront();
        }

        private void panelMainContent_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}
