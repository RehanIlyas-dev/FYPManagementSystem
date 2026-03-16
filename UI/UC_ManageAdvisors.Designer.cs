namespace FYPManagementSystem.Forms
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
            button1 = new Button();
            btnDeleteAdvisor = new Button();
            button2 = new Button();
            dgvAdvisors = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdvisors).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnDeleteAdvisor);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnAddAdvisor);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 574);
            panel1.TabIndex = 0;
            // 
            // btnAddAdvisor
            // 
            btnAddAdvisor.Dock = DockStyle.Top;
            btnAddAdvisor.Location = new Point(0, 0);
            btnAddAdvisor.Name = "btnAddAdvisor";
            btnAddAdvisor.Size = new Size(189, 29);
            btnAddAdvisor.TabIndex = 0;
            btnAddAdvisor.Text = "Add Advisor";
            btnAddAdvisor.UseVisualStyleBackColor = true;
            btnAddAdvisor.Click += btnAddAdvisor_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 29);
            button1.Name = "button1";
            button1.Size = new Size(189, 29);
            button1.TabIndex = 1;
            button1.Text = "Update Advisor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnUpdateAdvisor_Click;
            // 
            // btnDeleteAdvisor
            // 
            btnDeleteAdvisor.Dock = DockStyle.Top;
            btnDeleteAdvisor.Location = new Point(0, 58);
            btnDeleteAdvisor.Name = "btnDeleteAdvisor";
            btnDeleteAdvisor.Size = new Size(189, 29);
            btnDeleteAdvisor.TabIndex = 1;
            btnDeleteAdvisor.Text = "Delete Advisor";
            btnDeleteAdvisor.UseVisualStyleBackColor = true;
            btnDeleteAdvisor.Click += btnDeleteAdvisor_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 87);
            button2.Name = "button2";
            button2.Size = new Size(189, 29);
            button2.TabIndex = 1;
            button2.Text = "Clear Form";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnClearForm_Click;
            // 
            // dgvAdvisors
            // 
            dgvAdvisors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdvisors.Dock = DockStyle.Fill;
            dgvAdvisors.Location = new Point(189, 0);
            dgvAdvisors.Name = "dgvAdvisors";
            dgvAdvisors.ReadOnly = true;
            dgvAdvisors.RowHeadersWidth = 51;
            dgvAdvisors.Size = new Size(1056, 574);
            dgvAdvisors.TabIndex = 1;
            dgvAdvisors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        private Button button1;
        private Button btnAddAdvisor;
        private Button btnDeleteAdvisor;
        private Button button2;
        private DataGridView dgvAdvisors;
    }
}

