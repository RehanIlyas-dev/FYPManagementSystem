namespace FYPManagementSystem.UI.Advisors
{
    partial class UC_ManageAdvisors
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
            panel1 = new Panel();
            btnAddAdvisor = new Button();
            btnUpdateAdvisor = new Button();
            btnDeleteAdvisor = new Button();
            button2 = new Button();
            dgvAdvisors = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdvisors).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnAddAdvisor);
            panel1.Controls.Add(btnUpdateAdvisor);
            panel1.Controls.Add(btnDeleteAdvisor);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 594);
            panel1.TabIndex = 3;
            // 
            // btnAddAdvisor
            // 
            btnAddAdvisor.Dock = DockStyle.Top;
            btnAddAdvisor.BackColor = Color.FromArgb(0, 120, 215);
            btnAddAdvisor.FlatAppearance.BorderSize = 0;
            btnAddAdvisor.FlatStyle = FlatStyle.Flat;
            btnAddAdvisor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAddAdvisor.ForeColor = Color.White;
            btnAddAdvisor.Location = new Point(0, 120);
            btnAddAdvisor.Name = "btnAddAdvisor";
            btnAddAdvisor.Size = new Size(160, 40);
            btnAddAdvisor.TabIndex = 0;
            btnAddAdvisor.Text = "Add Advisor";
            btnAddAdvisor.UseVisualStyleBackColor = false;
            btnAddAdvisor.Click += btnAddAdvisor_Click;
            // 
            // btnUpdateAdvisor
            // 
            btnUpdateAdvisor.Dock = DockStyle.Top;
            btnUpdateAdvisor.BackColor = Color.FromArgb(0, 120, 215);
            btnUpdateAdvisor.FlatAppearance.BorderSize = 0;
            btnUpdateAdvisor.FlatStyle = FlatStyle.Flat;
            btnUpdateAdvisor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdateAdvisor.ForeColor = Color.White;
            btnUpdateAdvisor.Location = new Point(0, 80);
            btnUpdateAdvisor.Name = "btnUpdateAdvisor";
            btnUpdateAdvisor.Size = new Size(160, 40);
            btnUpdateAdvisor.TabIndex = 1;
            btnUpdateAdvisor.Text = "Update Advisor";
            btnUpdateAdvisor.UseVisualStyleBackColor = false;
            btnUpdateAdvisor.Click += btnUpdateAdvisor_Click;
            // 
            // btnDeleteAdvisor
            // 
            btnDeleteAdvisor.Dock = DockStyle.Top;
            btnDeleteAdvisor.BackColor = Color.FromArgb(0, 120, 215);
            btnDeleteAdvisor.FlatAppearance.BorderSize = 0;
            btnDeleteAdvisor.FlatStyle = FlatStyle.Flat;
            btnDeleteAdvisor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDeleteAdvisor.ForeColor = Color.White;
            btnDeleteAdvisor.Location = new Point(0, 40);
            btnDeleteAdvisor.Name = "btnDeleteAdvisor";
            btnDeleteAdvisor.Size = new Size(160, 40);
            btnDeleteAdvisor.TabIndex = 1;
            btnDeleteAdvisor.Text = "Delete Advisor";
            btnDeleteAdvisor.UseVisualStyleBackColor = false;
            btnDeleteAdvisor.Click += btnDeleteAdvisor_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.BackColor = Color.FromArgb(0, 120, 215);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(160, 40);
            button2.TabIndex = 1;
            button2.Text = "Clear View";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnClearForm_Click;
            // 
            // dgvAdvisors
            // 
            dgvAdvisors.AllowUserToAddRows = false;
            dgvAdvisors.BackgroundColor = Color.White;
            dgvAdvisors.BorderStyle = BorderStyle.None;
            dgvAdvisors.EnableHeadersVisualStyles = false;
            dgvAdvisors.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvAdvisors.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvAdvisors.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvAdvisors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdvisors.Dock = DockStyle.Fill;
            dgvAdvisors.GridColor = Color.FromArgb(224, 224, 224);
            dgvAdvisors.Location = new Point(160, 0);
            dgvAdvisors.Name = "dgvAdvisors";
            dgvAdvisors.ReadOnly = true;
            dgvAdvisors.RowHeadersVisible = false;
            dgvAdvisors.RowHeadersWidth = 51;
            dgvAdvisors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdvisors.Size = new Size(1074, 594);
            dgvAdvisors.TabIndex = 1;
            dgvAdvisors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdvisors.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            dgvAdvisors.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvAdvisors.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            // 
            // UC_ManageAdvisors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvAdvisors);
            Controls.Add(panel1);
            Name = "UC_ManageAdvisors";
            Size = new Size(1245, 574);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAdvisors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnUpdateAdvisor;
        private Button btnAddAdvisor;
        private Button btnDeleteAdvisor;
        private Button button2;
        private DataGridView dgvAdvisors;
    }
}

