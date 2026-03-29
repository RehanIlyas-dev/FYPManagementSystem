namespace FYPManagementSystem.UI.Evaluations
{
    partial class UC_ManageEvaluations
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
            btnAddEvaluation = new System.Windows.Forms.Button();
            btnUpdateEvaluation = new System.Windows.Forms.Button();
            btnDeleteEvaluation = new System.Windows.Forms.Button();
            dgvEvaluations = new System.Windows.Forms.DataGridView();
            leftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvaluations).BeginInit();
            SuspendLayout();
            // 
            // leftpanel
            // 
            leftpanel.BackColor = System.Drawing.Color.White;
            leftpanel.Controls.Add(btnAddEvaluation);
            leftpanel.Controls.Add(btnUpdateEvaluation);
            leftpanel.Controls.Add(btnDeleteEvaluation);
            leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            leftpanel.Location = new System.Drawing.Point(0, 0);
            leftpanel.Name = "leftpanel";
            leftpanel.Size = new System.Drawing.Size(160, 594);
            leftpanel.TabIndex = 0;
            // 
            // btnAddEvaluation
            // 
            btnAddEvaluation.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            btnAddEvaluation.Dock = System.Windows.Forms.DockStyle.Top;
            btnAddEvaluation.FlatAppearance.BorderSize = 0;
            btnAddEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddEvaluation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnAddEvaluation.ForeColor = System.Drawing.Color.White;
            btnAddEvaluation.Location = new System.Drawing.Point(0, 80);
            btnAddEvaluation.Name = "btnAddEvaluation";
            btnAddEvaluation.Size = new System.Drawing.Size(160, 40);
            btnAddEvaluation.TabIndex = 0;
            btnAddEvaluation.Text = "Add Evaluation";
            btnAddEvaluation.UseVisualStyleBackColor = false;
            btnAddEvaluation.Click += new System.EventHandler(btnAddEvaluation_Click);
            // 
            // btnUpdateEvaluation
            // 
            btnUpdateEvaluation.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            btnUpdateEvaluation.Dock = System.Windows.Forms.DockStyle.Top;
            btnUpdateEvaluation.FlatAppearance.BorderSize = 0;
            btnUpdateEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdateEvaluation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnUpdateEvaluation.ForeColor = System.Drawing.Color.White;
            btnUpdateEvaluation.Location = new System.Drawing.Point(0, 40);
            btnUpdateEvaluation.Name = "btnUpdateEvaluation";
            btnUpdateEvaluation.Size = new System.Drawing.Size(160, 40);
            btnUpdateEvaluation.TabIndex = 1;
            btnUpdateEvaluation.Text = "Update Evaluation";
            btnUpdateEvaluation.UseVisualStyleBackColor = false;
            btnUpdateEvaluation.Click += new System.EventHandler(btnUpdateEvaluation_Click);
            // 
            // btnDeleteEvaluation
            // 
            btnDeleteEvaluation.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            btnDeleteEvaluation.Dock = System.Windows.Forms.DockStyle.Top;
            btnDeleteEvaluation.FlatAppearance.BorderSize = 0;
            btnDeleteEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteEvaluation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnDeleteEvaluation.ForeColor = System.Drawing.Color.White;
            btnDeleteEvaluation.Location = new System.Drawing.Point(0, 0);
            btnDeleteEvaluation.Name = "btnDeleteEvaluation";
            btnDeleteEvaluation.Size = new System.Drawing.Size(160, 40);
            btnDeleteEvaluation.TabIndex = 2;
            btnDeleteEvaluation.Text = "Delete Evaluation";
            btnDeleteEvaluation.UseVisualStyleBackColor = false;
            btnDeleteEvaluation.Click += new System.EventHandler(btnDeleteEvaluation_Click);
            // 
            // dgvEvaluations
            // 
            dgvEvaluations.AllowUserToAddRows = false;
            dgvEvaluations.BackgroundColor = System.Drawing.Color.White;
            dgvEvaluations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvEvaluations.EnableHeadersVisualStyles = false;
            dgvEvaluations.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvEvaluations.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvEvaluations.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            dgvEvaluations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvaluations.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvEvaluations.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            dgvEvaluations.Location = new System.Drawing.Point(160, 0);
            dgvEvaluations.Name = "dgvEvaluations";
            dgvEvaluations.ReadOnly = true;
            dgvEvaluations.RowHeadersVisible = false;
            dgvEvaluations.RowHeadersWidth = 51;
            dgvEvaluations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvEvaluations.Size = new System.Drawing.Size(1074, 594);
            dgvEvaluations.TabIndex = 1;
            dgvEvaluations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvEvaluations.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dgvEvaluations.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dgvEvaluations.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            // 
            // UC_ManageEvaluations
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(dgvEvaluations);
            Controls.Add(leftpanel);
            Name = "UC_ManageEvaluations";
            Size = new System.Drawing.Size(1234, 594);
            leftpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEvaluations).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.DataGridView dgvEvaluations;
        private System.Windows.Forms.Button btnAddEvaluation;
        private System.Windows.Forms.Button btnUpdateEvaluation;
        private System.Windows.Forms.Button btnDeleteEvaluation;
    }
}
