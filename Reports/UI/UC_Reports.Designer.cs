namespace FYPManagementSystem.Reports.UI
{
    partial class UC_Reports
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
            lblTitle = new Label();
            lblGroupMarks = new Label();
            dgvGroupMarks = new DataGridView();
            lblStudentsWithoutGroup = new Label();
            dgvStudentsWithoutGroup = new DataGridView();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGroupMarks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudentsWithoutGroup).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(0, 120, 215);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(800, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "System Reports";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGroupMarks
            // 
            lblGroupMarks.AutoSize = true;
            lblGroupMarks.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblGroupMarks.Location = new Point(20, 80);
            lblGroupMarks.Name = "lblGroupMarks";
            lblGroupMarks.Size = new Size(211, 28);
            lblGroupMarks.TabIndex = 1;
            lblGroupMarks.Text = "Group Marks Summary";
            // 
            // dgvGroupMarks
            // 
            dgvGroupMarks.AllowUserToAddRows = false;
            dgvGroupMarks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvGroupMarks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGroupMarks.BackgroundColor = Color.White;
            dgvGroupMarks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGroupMarks.Location = new Point(20, 115);
            dgvGroupMarks.Name = "dgvGroupMarks";
            dgvGroupMarks.ReadOnly = true;
            dgvGroupMarks.RowHeadersWidth = 51;
            dgvGroupMarks.Size = new Size(760, 150);
            dgvGroupMarks.TabIndex = 2;
            // 
            // lblStudentsWithoutGroup
            // 
            lblStudentsWithoutGroup.AutoSize = true;
            lblStudentsWithoutGroup.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblStudentsWithoutGroup.Location = new Point(20, 280);
            lblStudentsWithoutGroup.Name = "lblStudentsWithoutGroup";
            lblStudentsWithoutGroup.Size = new Size(230, 28);
            lblStudentsWithoutGroup.TabIndex = 3;
            lblStudentsWithoutGroup.Text = "Students Without Groups";
            // 
            // dgvStudentsWithoutGroup
            // 
            dgvStudentsWithoutGroup.AllowUserToAddRows = false;
            dgvStudentsWithoutGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvStudentsWithoutGroup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudentsWithoutGroup.BackgroundColor = Color.White;
            dgvStudentsWithoutGroup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentsWithoutGroup.Location = new Point(20, 315);
            dgvStudentsWithoutGroup.Name = "dgvStudentsWithoutGroup";
            dgvStudentsWithoutGroup.ReadOnly = true;
            dgvStudentsWithoutGroup.RowHeadersWidth = 51;
            dgvStudentsWithoutGroup.Size = new Size(760, 150);
            dgvStudentsWithoutGroup.TabIndex = 4;
            // 
            // UC_Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvStudentsWithoutGroup);
            Controls.Add(lblStudentsWithoutGroup);
            Controls.Add(dgvGroupMarks);
            Controls.Add(lblGroupMarks);
            Controls.Add(pnlHeader);
            Name = "UC_Reports";
            Size = new Size(800, 500);
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGroupMarks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudentsWithoutGroup).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGroupMarks;
        private System.Windows.Forms.DataGridView dgvGroupMarks;
        private System.Windows.Forms.Label lblStudentsWithoutGroup;
        private System.Windows.Forms.DataGridView dgvStudentsWithoutGroup;
    }
}
