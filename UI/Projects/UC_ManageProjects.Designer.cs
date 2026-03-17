namespace FYPManagementSystem.UI.Projects
{
    partial class UC_ManageProjects
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            leftpanel = new Panel();
            dgvProjects = new DataGridView();
            btnaddProject = new Button();
            btnUpdateProject = new Button();
            btnDeleteProject = new Button();
            leftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProjects).BeginInit();
            SuspendLayout();
            // 
            // leftpanel
            // 
            leftpanel.BackColor = Color.White;
            leftpanel.Controls.Add(btnaddProject);
            leftpanel.Controls.Add(btnUpdateProject);
            leftpanel.Controls.Add(btnDeleteProject);
            leftpanel.Dock = DockStyle.Left;
            leftpanel.Location = new Point(0, 0);
            leftpanel.Name = "leftpanel";
            leftpanel.Size = new Size(160, 594);
            leftpanel.TabIndex = 0;
            // 
            // dgvProjects
            // 
            dgvProjects.AllowUserToAddRows = false;
            dgvProjects.BackgroundColor = Color.White;
            dgvProjects.BorderStyle = BorderStyle.None;
            dgvProjects.EnableHeadersVisualStyles = false;
            dgvProjects.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvProjects.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvProjects.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjects.Dock = DockStyle.Fill;
            dgvProjects.GridColor = Color.FromArgb(224, 224, 224);
            dgvProjects.Location = new Point(160, 0);
            dgvProjects.Name = "dgvProjects";
            dgvProjects.ReadOnly = true;
            dgvProjects.RowHeadersVisible = false;
            dgvProjects.RowHeadersWidth = 51;
            dgvProjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProjects.Size = new Size(1074, 594);
            dgvProjects.TabIndex = 1;
            dgvProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProjects.CellContentClick += dgvProjects_CellContentClick_1;
            dgvProjects.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            dgvProjects.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvProjects.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            // 
            // btnaddProject
            // 
            btnaddProject.BackColor = Color.FromArgb(0, 120, 215);
            btnaddProject.Dock = DockStyle.Top;
            btnaddProject.FlatAppearance.BorderSize = 0;
            btnaddProject.FlatStyle = FlatStyle.Flat;
            btnaddProject.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnaddProject.ForeColor = Color.White;
            btnaddProject.Location = new Point(0, 80);
            btnaddProject.Name = "btnaddProject";
            btnaddProject.Size = new Size(160, 40);
            btnaddProject.TabIndex = 0;
            btnaddProject.Text = "Add Project";
            btnaddProject.UseVisualStyleBackColor = false;
            btnaddProject.Click += btnaddProject_Click;
            // 
            // btnUpdateProject
            // 
            btnUpdateProject.BackColor = Color.FromArgb(0, 120, 215);
            btnUpdateProject.Dock = DockStyle.Top;
            btnUpdateProject.FlatAppearance.BorderSize = 0;
            btnUpdateProject.FlatStyle = FlatStyle.Flat;
            btnUpdateProject.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdateProject.ForeColor = Color.White;
            btnUpdateProject.Location = new Point(0, 40);
            btnUpdateProject.Name = "btnUpdateProject";
            btnUpdateProject.Size = new Size(160, 40);
            btnUpdateProject.TabIndex = 1;
            btnUpdateProject.Text = "Update Project";
            btnUpdateProject.UseVisualStyleBackColor = false;
            btnUpdateProject.Click += btnUpdateProject_Click;
            // 
            // btnDeleteProject
            // 
            btnDeleteProject.BackColor = Color.FromArgb(0, 120, 215);
            btnDeleteProject.Dock = DockStyle.Top;
            btnDeleteProject.FlatAppearance.BorderSize = 0;
            btnDeleteProject.FlatStyle = FlatStyle.Flat;
            btnDeleteProject.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDeleteProject.ForeColor = Color.White;
            btnDeleteProject.Location = new Point(0, 0);
            btnDeleteProject.Name = "btnDeleteProject";
            btnDeleteProject.Size = new Size(160, 40);
            btnDeleteProject.TabIndex = 2;
            btnDeleteProject.Text = "Delete Project";
            btnDeleteProject.UseVisualStyleBackColor = false;
            btnDeleteProject.Click += btnDeleteProject_Click;
            // 
            // 
            // UC_ManageProjects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvProjects);
            Controls.Add(leftpanel);
            Name = "UC_ManageProjects";
            Size = new Size(1234, 594);
            Load += UC_ManageProjects_Load;
            leftpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProjects).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftpanel;
        private DataGridView dgvProjects;
        private Button btnaddProject;
        private Button btnUpdateProject;
        private Button btnDeleteProject;
    }
}
