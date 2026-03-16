using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FYPManagementSystem.Forms
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void ManageStudents_Click(object sender, EventArgs e)
        {

            this.panelMainContent.Controls.Clear();
            uc_manage_student studentScreen = new uc_manage_student();
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
    }
}