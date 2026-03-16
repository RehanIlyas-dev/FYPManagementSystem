namespace FYPManagementSystem.UI
{
    partial class MainDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSideBar = new Panel();
            MarkSheetReport = new Button();
            ProjectRosterReport = new Button();
            button8 = new Button();
            MarkEvaluations = new Button();
            AssignAdvisors = new Button();
            AssignProjects = new Button();
            FormStudentGroups = new Button();
            ManageEvaluations = new Button();
            ManageProjects = new Button();
            ManageAdvisors = new Button();
            ManageStudents = new Button();
            MainHeader = new Panel();
            label1 = new Label();
            panelMainContent = new Panel();
            panelSideBar.SuspendLayout();
            MainHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideBar
            // 
            panelSideBar.AccessibleName = "PanelSideBar";
            panelSideBar.AllowDrop = true;
            panelSideBar.BackColor = Color.Gray;
            panelSideBar.BackgroundImageLayout = ImageLayout.None;
            panelSideBar.Controls.Add(MarkSheetReport);
            panelSideBar.Controls.Add(ProjectRosterReport);
            panelSideBar.Controls.Add(button8);
            panelSideBar.Controls.Add(MarkEvaluations);
            panelSideBar.Controls.Add(AssignAdvisors);
            panelSideBar.Controls.Add(AssignProjects);
            panelSideBar.Controls.Add(FormStudentGroups);
            panelSideBar.Controls.Add(ManageEvaluations);
            panelSideBar.Controls.Add(ManageProjects);
            panelSideBar.Controls.Add(ManageAdvisors);
            panelSideBar.Controls.Add(ManageStudents);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.ForeColor = SystemColors.Desktop;
            panelSideBar.Location = new Point(0, 0);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(159, 450);
            panelSideBar.TabIndex = 0;
            // 
            // MarkSheetReport
            // 
            MarkSheetReport.Dock = DockStyle.Top;
            MarkSheetReport.Location = new Point(0, 259);
            MarkSheetReport.Name = "MarkSheetReport";
            MarkSheetReport.Size = new Size(159, 28);
            MarkSheetReport.TabIndex = 10;
            MarkSheetReport.Text = "MarkSheetReport";
            MarkSheetReport.UseVisualStyleBackColor = true;
            // 
            // ProjectRosterReport
            // 
            ProjectRosterReport.Dock = DockStyle.Top;
            ProjectRosterReport.Location = new Point(0, 230);
            ProjectRosterReport.Name = "ProjectRosterReport";
            ProjectRosterReport.Size = new Size(159, 29);
            ProjectRosterReport.TabIndex = 9;
            ProjectRosterReport.Text = "ProjectRosterReport";
            ProjectRosterReport.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(482, -11);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 8;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // MarkEvaluations
            // 
            MarkEvaluations.Dock = DockStyle.Top;
            MarkEvaluations.Location = new Point(0, 201);
            MarkEvaluations.Name = "MarkEvaluations";
            MarkEvaluations.Size = new Size(159, 29);
            MarkEvaluations.TabIndex = 7;
            MarkEvaluations.Text = "MarkEvaluations";
            MarkEvaluations.UseVisualStyleBackColor = true;
            // 
            // AssignAdvisors
            // 
            AssignAdvisors.Dock = DockStyle.Top;
            AssignAdvisors.Location = new Point(0, 172);
            AssignAdvisors.Name = "AssignAdvisors";
            AssignAdvisors.Size = new Size(159, 29);
            AssignAdvisors.TabIndex = 6;
            AssignAdvisors.Text = "AssignAdvisors";
            AssignAdvisors.UseVisualStyleBackColor = true;
            // 
            // AssignProjects
            // 
            AssignProjects.Dock = DockStyle.Top;
            AssignProjects.Location = new Point(0, 143);
            AssignProjects.Name = "AssignProjects";
            AssignProjects.Size = new Size(159, 29);
            AssignProjects.TabIndex = 5;
            AssignProjects.Text = "AssignProjects";
            AssignProjects.UseVisualStyleBackColor = true;
            AssignProjects.Click += button5_Click;
            // 
            // FormStudentGroups
            // 
            FormStudentGroups.Dock = DockStyle.Top;
            FormStudentGroups.Location = new Point(0, 114);
            FormStudentGroups.Name = "FormStudentGroups";
            FormStudentGroups.Size = new Size(159, 29);
            FormStudentGroups.TabIndex = 4;
            FormStudentGroups.Text = "FormStudentGroups";
            FormStudentGroups.UseVisualStyleBackColor = true;
            // 
            // ManageEvaluations
            // 
            ManageEvaluations.Dock = DockStyle.Top;
            ManageEvaluations.Location = new Point(0, 85);
            ManageEvaluations.Name = "ManageEvaluations";
            ManageEvaluations.Size = new Size(159, 29);
            ManageEvaluations.TabIndex = 3;
            ManageEvaluations.Text = "ManageEvaluations";
            ManageEvaluations.UseVisualStyleBackColor = true;
            // 
            // ManageProjects
            // 
            ManageProjects.Dock = DockStyle.Top;
            ManageProjects.Location = new Point(0, 56);
            ManageProjects.Name = "ManageProjects";
            ManageProjects.Size = new Size(159, 29);
            ManageProjects.TabIndex = 2;
            ManageProjects.Text = "ManageProjects";
            ManageProjects.UseVisualStyleBackColor = true;
            // 
            // ManageAdvisors
            // 
            ManageAdvisors.Dock = DockStyle.Top;
            ManageAdvisors.Location = new Point(0, 27);
            ManageAdvisors.Name = "ManageAdvisors";
            ManageAdvisors.Size = new Size(159, 29);
            ManageAdvisors.TabIndex = 1;
            ManageAdvisors.Text = "ManageAdvisors";
            ManageAdvisors.UseVisualStyleBackColor = true;
            ManageAdvisors.Click += ManageAdvisors_Click;
            // 
            // ManageStudents
            // 
            ManageStudents.Dock = DockStyle.Top;
            ManageStudents.Location = new Point(0, 0);
            ManageStudents.Name = "ManageStudents";
            ManageStudents.Size = new Size(159, 27);
            ManageStudents.TabIndex = 0;
            ManageStudents.Text = "ManageStudents";
            ManageStudents.TextAlign = ContentAlignment.TopCenter;
            ManageStudents.UseVisualStyleBackColor = true;
            ManageStudents.Click += ManageStudents_Click;
            // 
            // MainHeader
            // 
            MainHeader.Controls.Add(label1);
            MainHeader.Dock = DockStyle.Top;
            MainHeader.ForeColor = Color.DarkCyan;
            MainHeader.ImeMode = ImeMode.Disable;
            MainHeader.Location = new Point(159, 0);
            MainHeader.Name = "MainHeader";
            MainHeader.Size = new Size(684, 56);
            MainHeader.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 30);
            label1.TabIndex = 0;
            label1.Text = "FYP Management System";
            label1.Click += label1_Click;
            // 
            // panelMainContent
            // 
            panelMainContent.Location = new Point(159, 56);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(684, 394);
            panelMainContent.TabIndex = 2;
            panelMainContent.Paint += panelMainContent_Paint;
            // 
            // MainDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 450);
            Controls.Add(panelMainContent);
            Controls.Add(MainHeader);
            Controls.Add(panelSideBar);
            Name = "MainDashBoard";
            Text = "MainDashBoard";
            Load += MainDashBoard_Load;
            panelSideBar.ResumeLayout(false);
            MainHeader.ResumeLayout(false);
            MainHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideBar;
        private Panel MainHeader;
        private Label label1;
        private Button ManageStudents;
        private Button ManageAdvisors;
        private Button FormStudentGroups;
        private Button ManageEvaluations;
        private Button ManageProjects;
        private Button AssignProjects;
        private Button MarkSheetReport;
        private Button ProjectRosterReport;
        private Button button8;
        private Button MarkEvaluations;
        private Button AssignAdvisors;
        private Panel panelMainContent;
    }
}