namespace FYPManagementSystem.UI.GroupProject
{
    partial class AssignProject
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
            pnlHeader = new Panel();
            cmbGroups = new ComboBox();
            cmbProjects = new ComboBox();
            btnAssign = new Button();
            lblGroup = new Label();
            lblProject = new Label();
            lblTitle = new Label();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(0, 120, 215);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 100);
            pnlHeader.TabIndex = 6;
            // 
            // cmbGroups
            // 
            cmbGroups.Anchor = AnchorStyles.Top;
            cmbGroups.FormattingEnabled = true;
            cmbGroups.Location = new Point(300, 140);
            cmbGroups.Name = "cmbGroups";
            cmbGroups.Size = new Size(250, 28);
            cmbGroups.TabIndex = 1;
            // 
            // cmbProjects
            // 
            cmbProjects.Anchor = AnchorStyles.Top;
            cmbProjects.FormattingEnabled = true;
            cmbProjects.Location = new Point(300, 200);
            cmbProjects.Name = "cmbProjects";
            cmbProjects.Size = new Size(250, 28);
            cmbProjects.TabIndex = 3;
            // 
            // btnAssign
            // 
            btnAssign.Anchor = AnchorStyles.Top;
            btnAssign.BackColor = Color.FromArgb(0, 120, 215);
            btnAssign.FlatAppearance.BorderSize = 0;
            btnAssign.FlatStyle = FlatStyle.Flat;
            btnAssign.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(320, 280);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(160, 50);
            btnAssign.TabIndex = 4;
            btnAssign.Text = "Assign Project";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssign_Click;

            // 
            // lblGroup
            // 
            lblGroup.Anchor = AnchorStyles.Top;
            lblGroup.AutoSize = true;
            lblGroup.Location = new Point(200, 143);
            lblGroup.Name = "lblGroup";
            lblGroup.Size = new Size(72, 20);
            lblGroup.TabIndex = 0;
            lblGroup.Text = "Group ID:";
            // 
            // lblProject
            // 
            lblProject.Anchor = AnchorStyles.Top;
            lblProject.AutoSize = true;
            lblProject.Location = new Point(200, 203);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(58, 20);
            lblProject.TabIndex = 2;
            lblProject.Text = "Project:";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 32F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(220, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 61);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Assign Project";
            // 
            // AssignProject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlHeader);
            Controls.Add(lblProject);
            Controls.Add(lblGroup);
            Controls.Add(btnAssign);
            Controls.Add(cmbProjects);
            Controls.Add(cmbGroups);
            Name = "AssignProject";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Assign Project";

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel pnlHeader;
        private ComboBox cmbGroups;
        private ComboBox cmbProjects;
        private Button btnAssign;
        private Label lblGroup;
        private Label lblProject;
        private Label lblTitle;
    }
}
