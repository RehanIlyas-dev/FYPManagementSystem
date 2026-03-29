namespace FYPManagementSystem.UI.Main
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
            Reports = new Button();
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
            panelSideBar.BackColor = Color.FromArgb(44, 62, 80);
            panelSideBar.BackgroundImageLayout = ImageLayout.None;
            panelSideBar.Controls.Add(Reports);
            panelSideBar.Controls.Add(MarkEvaluations);
            panelSideBar.Controls.Add(AssignAdvisors);
            panelSideBar.Controls.Add(AssignProjects);
            panelSideBar.Controls.Add(FormStudentGroups);
            panelSideBar.Controls.Add(ManageEvaluations);
            panelSideBar.Controls.Add(ManageProjects);
            panelSideBar.Controls.Add(ManageAdvisors);
            panelSideBar.Controls.Add(ManageStudents);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.ForeColor = Color.White;
            panelSideBar.Location = new Point(0, 0);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(200, 450);
            panelSideBar.TabIndex = 0;
            // 
            // Reports
            // 
            Reports.Dock = DockStyle.Top;
            Reports.FlatAppearance.BorderSize = 0;
            Reports.FlatStyle = FlatStyle.Flat;
            Reports.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            Reports.Location = new Point(0, 320);
            Reports.Name = "Reports";
            Reports.Padding = new Padding(15, 0, 0, 0);
            Reports.Size = new Size(200, 40);
            Reports.TabIndex = 10;
            Reports.Text = "Standard Reports";
            Reports.TextAlign = ContentAlignment.MiddleLeft;
            Reports.UseVisualStyleBackColor = true;
            Reports.Click += Reports_Click;
            // 
            // MarkEvaluations
            // 
            MarkEvaluations.Dock = DockStyle.Top;
            MarkEvaluations.FlatAppearance.BorderSize = 0;
            MarkEvaluations.FlatStyle = FlatStyle.Flat;
            MarkEvaluations.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            MarkEvaluations.Location = new Point(0, 280);
            MarkEvaluations.Name = "MarkEvaluations";
            MarkEvaluations.Padding = new Padding(15, 0, 0, 0);
            MarkEvaluations.Size = new Size(200, 40);
            MarkEvaluations.TabIndex = 7;
            MarkEvaluations.Text = "Mark Evaluation";
            MarkEvaluations.TextAlign = ContentAlignment.MiddleLeft;
            MarkEvaluations.UseVisualStyleBackColor = true;
            MarkEvaluations.Click += MarkEvaluations_Click;
            // 
            // AssignAdvisors
            // 
            AssignAdvisors.Dock = DockStyle.Top;
            AssignAdvisors.FlatAppearance.BorderSize = 0;
            AssignAdvisors.FlatStyle = FlatStyle.Flat;
            AssignAdvisors.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            AssignAdvisors.Location = new Point(0, 240);
            AssignAdvisors.Name = "AssignAdvisors";
            AssignAdvisors.Padding = new Padding(15, 0, 0, 0);
            AssignAdvisors.Size = new Size(200, 40);
            AssignAdvisors.TabIndex = 6;
            AssignAdvisors.Text = "Assign Advisors";
            AssignAdvisors.TextAlign = ContentAlignment.MiddleLeft;
            AssignAdvisors.UseVisualStyleBackColor = true;
            AssignAdvisors.Click += AssignAdvisors_Click;

            // 
            // AssignProjects
            // 
            AssignProjects.Dock = DockStyle.Top;
            AssignProjects.FlatAppearance.BorderSize = 0;
            AssignProjects.FlatStyle = FlatStyle.Flat;
            AssignProjects.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            AssignProjects.Location = new Point(0, 200);
            AssignProjects.Name = "AssignProjects";
            AssignProjects.Padding = new Padding(15, 0, 0, 0);
            AssignProjects.Size = new Size(200, 40);
            AssignProjects.TabIndex = 5;
            AssignProjects.Text = "Assign Projects";
            AssignProjects.TextAlign = ContentAlignment.MiddleLeft;
            AssignProjects.UseVisualStyleBackColor = true;
            AssignProjects.Click += button5_Click;
            // 
            // FormStudentGroups
            // 
            FormStudentGroups.Dock = DockStyle.Top;
            FormStudentGroups.FlatAppearance.BorderSize = 0;
            FormStudentGroups.FlatStyle = FlatStyle.Flat;
            FormStudentGroups.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            FormStudentGroups.Location = new Point(0, 160);
            FormStudentGroups.Name = "FormStudentGroups";
            FormStudentGroups.Padding = new Padding(15, 0, 0, 0);
            FormStudentGroups.Size = new Size(200, 40);
            FormStudentGroups.TabIndex = 4;
            FormStudentGroups.Text = "Manage Groups";
            FormStudentGroups.TextAlign = ContentAlignment.MiddleLeft;
            FormStudentGroups.UseVisualStyleBackColor = true;
            FormStudentGroups.Click += FormStudentGroups_Click;
            // 
            // ManageEvaluations
            // 
            ManageEvaluations.Dock = DockStyle.Top;
            ManageEvaluations.FlatAppearance.BorderSize = 0;
            ManageEvaluations.FlatStyle = FlatStyle.Flat;
            ManageEvaluations.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            ManageEvaluations.Location = new Point(0, 120);
            ManageEvaluations.Name = "ManageEvaluations";
            ManageEvaluations.Padding = new Padding(15, 0, 0, 0);
            ManageEvaluations.Size = new Size(200, 40);
            ManageEvaluations.TabIndex = 3;
            ManageEvaluations.Text = "Evaluations";
            ManageEvaluations.TextAlign = ContentAlignment.MiddleLeft;
            ManageEvaluations.UseVisualStyleBackColor = true;
            ManageEvaluations.Click += ManageEvaluations_Click;
            // 
            // ManageProjects
            // 
            ManageProjects.Dock = DockStyle.Top;
            ManageProjects.FlatAppearance.BorderSize = 0;
            ManageProjects.FlatStyle = FlatStyle.Flat;
            ManageProjects.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            ManageProjects.Location = new Point(0, 80);
            ManageProjects.Name = "ManageProjects";
            ManageProjects.Padding = new Padding(15, 0, 0, 0);
            ManageProjects.Size = new Size(200, 40);
            ManageProjects.TabIndex = 2;
            ManageProjects.Text = "Projects";
            ManageProjects.TextAlign = ContentAlignment.MiddleLeft;
            ManageProjects.UseVisualStyleBackColor = true;
            ManageProjects.Click += ManageProjects_Click;
            // 
            // ManageAdvisors
            // 
            ManageAdvisors.Dock = DockStyle.Top;
            ManageAdvisors.FlatAppearance.BorderSize = 0;
            ManageAdvisors.FlatStyle = FlatStyle.Flat;
            ManageAdvisors.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            ManageAdvisors.Location = new Point(0, 40);
            ManageAdvisors.Name = "ManageAdvisors";
            ManageAdvisors.Padding = new Padding(15, 0, 0, 0);
            ManageAdvisors.Size = new Size(200, 40);
            ManageAdvisors.TabIndex = 1;
            ManageAdvisors.Text = "Advisors";
            ManageAdvisors.TextAlign = ContentAlignment.MiddleLeft;
            ManageAdvisors.UseVisualStyleBackColor = true;
            ManageAdvisors.Click += ManageAdvisors_Click;
            // 
            // ManageStudents
            // 
            ManageStudents.Dock = DockStyle.Top;
            ManageStudents.FlatAppearance.BorderSize = 0;
            ManageStudents.FlatStyle = FlatStyle.Flat;
            ManageStudents.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            ManageStudents.Location = new Point(0, 0);
            ManageStudents.Name = "ManageStudents";
            ManageStudents.Padding = new Padding(15, 0, 0, 0);
            ManageStudents.Size = new Size(200, 40);
            ManageStudents.TabIndex = 0;
            ManageStudents.Text = "Students";
            ManageStudents.TextAlign = ContentAlignment.MiddleLeft;
            ManageStudents.UseVisualStyleBackColor = true;
            ManageStudents.Click += ManageStudents_Click;
            // 
            // MainHeader
            // 
            MainHeader.BackColor = Color.White;
            MainHeader.Controls.Add(label1);
            MainHeader.Dock = DockStyle.Top;
            MainHeader.ForeColor = Color.FromArgb(44, 62, 80);
            MainHeader.ImeMode = ImeMode.Disable;
            MainHeader.Location = new Point(200, 0);
            MainHeader.Name = "MainHeader";
            MainHeader.Size = new Size(643, 60);
            MainHeader.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(643, 60);
            label1.TabIndex = 0;
            label1.Text = "FYP Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.FromArgb(245, 247, 250);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(200, 60);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(643, 390);
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
            Text = "FYP Portal";
            Load += MainDashBoard_Load;
            panelSideBar.ResumeLayout(false);
            MainHeader.ResumeLayout(false);
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
        private Button MarkEvaluations;
        private Button AssignAdvisors;
        private Button Reports;
        private Panel panelMainContent;
    }
}
