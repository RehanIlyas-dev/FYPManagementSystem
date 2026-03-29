namespace FYPManagementSystem.UI.Evaluations
{
    partial class UC_MarkEvaluations
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
            leftpanel = new System.Windows.Forms.Panel();
            btnMarkEvaluation = new System.Windows.Forms.Button();
            btnUpdateMark = new System.Windows.Forms.Button();
            btnDeleteMark = new System.Windows.Forms.Button();
            dgvGroupEvaluations = new System.Windows.Forms.DataGridView();
            leftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGroupEvaluations).BeginInit();
            SuspendLayout();
            // 
            // leftpanel
            // 
            leftpanel.BackColor = System.Drawing.Color.White;
            leftpanel.Controls.Add(btnMarkEvaluation);
            leftpanel.Controls.Add(btnUpdateMark);
            leftpanel.Controls.Add(btnDeleteMark);
            leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            leftpanel.Location = new System.Drawing.Point(0, 0);
            leftpanel.Name = "leftpanel";
            leftpanel.Size = new System.Drawing.Size(160, 594);
            leftpanel.TabIndex = 0;
            // 
            // btnMarkEvaluation
            // 
            btnMarkEvaluation.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            btnMarkEvaluation.Dock = System.Windows.Forms.DockStyle.Top;
            btnMarkEvaluation.FlatAppearance.BorderSize = 0;
            btnMarkEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMarkEvaluation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnMarkEvaluation.ForeColor = System.Drawing.Color.White;
            btnMarkEvaluation.Location = new System.Drawing.Point(0, 80);
            btnMarkEvaluation.Name = "btnMarkEvaluation";
            btnMarkEvaluation.Size = new System.Drawing.Size(160, 40);
            btnMarkEvaluation.TabIndex = 0;
            btnMarkEvaluation.Text = "Mark Evaluation";
            btnMarkEvaluation.UseVisualStyleBackColor = false;
            btnMarkEvaluation.Click += new System.EventHandler(btnMarkEvaluation_Click);
            // 
            // btnUpdateMark
            // 
            btnUpdateMark.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            btnUpdateMark.Dock = System.Windows.Forms.DockStyle.Top;
            btnUpdateMark.FlatAppearance.BorderSize = 0;
            btnUpdateMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdateMark.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnUpdateMark.ForeColor = System.Drawing.Color.White;
            btnUpdateMark.Location = new System.Drawing.Point(0, 40);
            btnUpdateMark.Name = "btnUpdateMark";
            btnUpdateMark.Size = new System.Drawing.Size(160, 40);
            btnUpdateMark.TabIndex = 1;
            btnUpdateMark.Text = "Update Mark";
            btnUpdateMark.UseVisualStyleBackColor = false;
            btnUpdateMark.Click += new System.EventHandler(btnUpdateMark_Click);
            // 
            // btnDeleteMark
            // 
            btnDeleteMark.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            btnDeleteMark.Dock = System.Windows.Forms.DockStyle.Top;
            btnDeleteMark.FlatAppearance.BorderSize = 0;
            btnDeleteMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteMark.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnDeleteMark.ForeColor = System.Drawing.Color.White;
            btnDeleteMark.Location = new System.Drawing.Point(0, 0);
            btnDeleteMark.Name = "btnDeleteMark";
            btnDeleteMark.Size = new System.Drawing.Size(160, 40);
            btnDeleteMark.TabIndex = 2;
            btnDeleteMark.Text = "Delete Mark";
            btnDeleteMark.UseVisualStyleBackColor = false;
            btnDeleteMark.Click += new System.EventHandler(btnDeleteMark_Click);
            // 
            // dgvGroupEvaluations
            // 
            dgvGroupEvaluations.AllowUserToAddRows = false;
            dgvGroupEvaluations.BackgroundColor = System.Drawing.Color.White;
            dgvGroupEvaluations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvGroupEvaluations.EnableHeadersVisualStyles = false;
            dgvGroupEvaluations.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvGroupEvaluations.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvGroupEvaluations.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            dgvGroupEvaluations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGroupEvaluations.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvGroupEvaluations.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            dgvGroupEvaluations.Location = new System.Drawing.Point(160, 0);
            dgvGroupEvaluations.Name = "dgvGroupEvaluations";
            dgvGroupEvaluations.ReadOnly = true;
            dgvGroupEvaluations.RowHeadersVisible = false;
            dgvGroupEvaluations.RowHeadersWidth = 51;
            dgvGroupEvaluations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvGroupEvaluations.Size = new System.Drawing.Size(1074, 594);
            dgvGroupEvaluations.TabIndex = 1;
            dgvGroupEvaluations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvGroupEvaluations.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dgvGroupEvaluations.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dgvGroupEvaluations.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            // 
            // UC_MarkEvaluations
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(dgvGroupEvaluations);
            Controls.Add(leftpanel);
            Name = "UC_MarkEvaluations";
            Size = new System.Drawing.Size(1234, 594);
            leftpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGroupEvaluations).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.DataGridView dgvGroupEvaluations;
        private System.Windows.Forms.Button btnMarkEvaluation;
        private System.Windows.Forms.Button btnUpdateMark;
        private System.Windows.Forms.Button btnDeleteMark;
    }
}
