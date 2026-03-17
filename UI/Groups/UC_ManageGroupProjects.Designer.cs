namespace FYPManagementSystem.UI.Groups
{
    partial class UC_ManageGroupProjects
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            leftpanel = new Panel();
            btnAssignProject = new Button();
            btnRemoveAssignment = new Button();
            dgvAssignments = new DataGridView();
            leftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).BeginInit();
            SuspendLayout();
            // 
            // leftpanel
            // 
            leftpanel.BackColor = Color.White;
            leftpanel.Controls.Add(btnAssignProject);
            leftpanel.Controls.Add(btnRemoveAssignment);
            leftpanel.Dock = DockStyle.Left;
            leftpanel.Location = new Point(0, 0);
            leftpanel.Name = "leftpanel";
            leftpanel.Size = new Size(160, 600);
            leftpanel.TabIndex = 0;
            // 
            // btnAssignProject
            // 
            btnAssignProject.BackColor = Color.FromArgb(0, 120, 215);
            btnAssignProject.Dock = DockStyle.Top;
            btnAssignProject.FlatAppearance.BorderSize = 0;
            btnAssignProject.FlatStyle = FlatStyle.Flat;
            btnAssignProject.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAssignProject.ForeColor = Color.White;
            btnAssignProject.Location = new Point(0, 45);
            btnAssignProject.Name = "btnAssignProject";
            btnAssignProject.Size = new Size(160, 40);
            btnAssignProject.TabIndex = 0;
            btnAssignProject.Text = "Assign Project";
            btnAssignProject.UseVisualStyleBackColor = false;
            btnAssignProject.Click += btnAssignProject_Click;
            // 
            // btnRemoveAssignment
            // 
            btnRemoveAssignment.BackColor = Color.FromArgb(0, 120, 215);
            btnRemoveAssignment.Dock = DockStyle.Top;
            btnRemoveAssignment.FlatAppearance.BorderSize = 0;
            btnRemoveAssignment.FlatStyle = FlatStyle.Flat;
            btnRemoveAssignment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRemoveAssignment.ForeColor = Color.White;
            btnRemoveAssignment.Location = new Point(0, 0);
            btnRemoveAssignment.Name = "btnRemoveAssignment";
            btnRemoveAssignment.Size = new Size(160, 40);
            btnRemoveAssignment.TabIndex = 1;
            btnRemoveAssignment.Text = "Remove Project";
            btnRemoveAssignment.UseVisualStyleBackColor = false;
            btnRemoveAssignment.Click += btnRemoveAssignment_Click;
            // 
            // dgvAssignments
            // 
            dgvAssignments.AllowUserToAddRows = false;
            dgvAssignments.BackgroundColor = Color.White;
            dgvAssignments.BorderStyle = BorderStyle.None;
            dgvAssignments.EnableHeadersVisualStyles = false;
            dgvAssignments.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvAssignments.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvAssignments.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssignments.Dock = DockStyle.Fill;
            dgvAssignments.GridColor = Color.FromArgb(224, 224, 224);
            dgvAssignments.Location = new Point(160, 0);
            dgvAssignments.Name = "dgvAssignments";
            dgvAssignments.ReadOnly = true;
            dgvAssignments.RowHeadersVisible = false;
            dgvAssignments.RowHeadersWidth = 51;
            dgvAssignments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssignments.Size = new Size(990, 600);
            dgvAssignments.TabIndex = 1;
            dgvAssignments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssignments.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            dgvAssignments.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvAssignments.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            // 
            // UC_ManageGroupProjects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvAssignments);
            Controls.Add(leftpanel);
            Name = "UC_ManageGroupProjects";
            Size = new Size(1150, 600);
            leftpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).EndInit();
            ResumeLayout(false);
        }

        private Panel leftpanel;
        private Button btnAssignProject;
        private Button btnRemoveAssignment;
        private DataGridView dgvAssignments;
    }
}
