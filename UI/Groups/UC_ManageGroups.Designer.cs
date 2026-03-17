namespace FYPManagementSystem.UI.Groups
{
    partial class UC_ManageGroups
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
            btnAddGroup = new Button();
            btnUpdateGroup = new Button();
            btnDeleteGroup = new Button();
            dgvGroups = new DataGridView();
            leftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGroups).BeginInit();
            SuspendLayout();
            // 
            // leftpanel
            // 
            leftpanel.BackColor = Color.White;
            leftpanel.Controls.Add(btnAddGroup);
            leftpanel.Controls.Add(btnUpdateGroup);
            leftpanel.Controls.Add(btnDeleteGroup);
            leftpanel.Dock = DockStyle.Left;
            leftpanel.Location = new Point(0, 0);
            leftpanel.Name = "leftpanel";
            leftpanel.Size = new Size(160, 594);
            leftpanel.TabIndex = 0;
            // 
            // btnAddGroup
            // 
            btnAddGroup.BackColor = Color.FromArgb(0, 120, 215);
            btnAddGroup.Dock = DockStyle.Top;
            btnAddGroup.FlatAppearance.BorderSize = 0;
            btnAddGroup.FlatStyle = FlatStyle.Flat;
            btnAddGroup.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAddGroup.ForeColor = Color.White;
            btnAddGroup.Location = new Point(0, 80);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(160, 40);
            btnAddGroup.TabIndex = 0;
            btnAddGroup.Text = "Add Group";
            btnAddGroup.UseVisualStyleBackColor = false;
            btnAddGroup.Click += btnAddGroup_Click;
            // 
            // btnUpdateGroup
            // 
            btnUpdateGroup.BackColor = Color.FromArgb(0, 120, 215);
            btnUpdateGroup.Dock = DockStyle.Top;
            btnUpdateGroup.FlatAppearance.BorderSize = 0;
            btnUpdateGroup.FlatStyle = FlatStyle.Flat;
            btnUpdateGroup.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdateGroup.ForeColor = Color.White;
            btnUpdateGroup.Location = new Point(0, 40);
            btnUpdateGroup.Name = "btnUpdateGroup";
            btnUpdateGroup.Size = new Size(160, 40);
            btnUpdateGroup.TabIndex = 1;
            btnUpdateGroup.Text = "Update Group";
            btnUpdateGroup.UseVisualStyleBackColor = false;
            btnUpdateGroup.Click += btnUpdateGroup_Click;
            // 
            // btnDeleteGroup
            // 
            btnDeleteGroup.BackColor = Color.FromArgb(0, 120, 215);
            btnDeleteGroup.Dock = DockStyle.Top;
            btnDeleteGroup.FlatAppearance.BorderSize = 0;
            btnDeleteGroup.FlatStyle = FlatStyle.Flat;
            btnDeleteGroup.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDeleteGroup.ForeColor = Color.White;
            btnDeleteGroup.Location = new Point(0, 0);
            btnDeleteGroup.Name = "btnDeleteGroup";
            btnDeleteGroup.Size = new Size(160, 40);
            btnDeleteGroup.TabIndex = 2;
            btnDeleteGroup.Text = "Delete Group";
            btnDeleteGroup.UseVisualStyleBackColor = false;
            btnDeleteGroup.Click += btnDeleteGroup_Click;
            // 
            // dgvGroups
            // 
            dgvGroups.AllowUserToAddRows = false;
            dgvGroups.BackgroundColor = Color.White;
            dgvGroups.BorderStyle = BorderStyle.None;
            dgvGroups.EnableHeadersVisualStyles = false;
            dgvGroups.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvGroups.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvGroups.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGroups.Dock = DockStyle.Fill;
            dgvGroups.GridColor = Color.FromArgb(224, 224, 224);
            dgvGroups.Location = new Point(160, 0);
            dgvGroups.Name = "dgvGroups";
            dgvGroups.ReadOnly = true;
            dgvGroups.RowHeadersVisible = false;
            dgvGroups.RowHeadersWidth = 51;
            dgvGroups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGroups.Size = new Size(1074, 594);
            dgvGroups.TabIndex = 1;
            dgvGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGroups.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            dgvGroups.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvGroups.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            // 
            // UC_ManageGroups
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvGroups);
            Controls.Add(leftpanel);
            Name = "UC_ManageGroups";
            Size = new Size(1234, 594);
            leftpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGroups).EndInit();
            ResumeLayout(false);
        }

        private Panel leftpanel;
        private DataGridView dgvGroups;
        private Button btnAddGroup;
        private Button btnUpdateGroup;
        private Button btnDeleteGroup;
    }
}
