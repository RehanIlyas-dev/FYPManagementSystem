using System;
using System.Drawing;
using System.Windows.Forms;

namespace FYPManagementSystem.UI.ProjectAdvisor
{
    partial class UC_ManageProjectAdvisors
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
            this.leftpanel = new System.Windows.Forms.Panel();
            this.btnAssignAdvisor = new System.Windows.Forms.Button();
            this.btnRemoveAssignment = new System.Windows.Forms.Button();
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            this.leftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.White;
            this.leftpanel.Controls.Add(this.btnAssignAdvisor);
            this.leftpanel.Controls.Add(this.btnRemoveAssignment);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(160, 594);
            this.leftpanel.TabIndex = 0;
            // 
            // btnAssignAdvisor
            // 
            this.btnAssignAdvisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAssignAdvisor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssignAdvisor.FlatAppearance.BorderSize = 0;
            this.btnAssignAdvisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignAdvisor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAssignAdvisor.ForeColor = System.Drawing.Color.White;
            this.btnAssignAdvisor.Location = new System.Drawing.Point(0, 40);
            this.btnAssignAdvisor.Name = "btnAssignAdvisor";
            this.btnAssignAdvisor.Size = new System.Drawing.Size(160, 40);
            this.btnAssignAdvisor.TabIndex = 0;
            this.btnAssignAdvisor.Text = "Assign Advisor";
            this.btnAssignAdvisor.UseVisualStyleBackColor = false;
            this.btnAssignAdvisor.Click += new System.EventHandler(this.btnAssignAdvisor_Click);
            // 
            // btnRemoveAssignment
            // 
            this.btnRemoveAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnRemoveAssignment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveAssignment.FlatAppearance.BorderSize = 0;
            this.btnRemoveAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAssignment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveAssignment.ForeColor = System.Drawing.Color.White;
            this.btnRemoveAssignment.Location = new System.Drawing.Point(0, 0);
            this.btnRemoveAssignment.Name = "btnRemoveAssignment";
            this.btnRemoveAssignment.Size = new System.Drawing.Size(160, 40);
            this.btnRemoveAssignment.TabIndex = 1;
            this.btnRemoveAssignment.Text = "Remove Assignment";
            this.btnRemoveAssignment.UseVisualStyleBackColor = false;
            this.btnRemoveAssignment.Click += new System.EventHandler(this.btnRemoveAssignment_Click);
            // 
            // dgvAssignments
            // 
            this.dgvAssignments.AllowUserToAddRows = false;
            this.dgvAssignments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssignments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssignments.Location = new System.Drawing.Point(160, 0);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.ReadOnly = true;
            this.dgvAssignments.RowHeadersVisible = false;
            this.dgvAssignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignments.Size = new System.Drawing.Size(1074, 594);
            this.dgvAssignments.TabIndex = 1;
            this.dgvAssignments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignments.EnableHeadersVisualStyles = false;
            this.dgvAssignments.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            this.dgvAssignments.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.dgvAssignments.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            this.dgvAssignments.GridColor = Color.FromArgb(224, 224, 224);
            this.dgvAssignments.DefaultCellStyle.SelectionBackColor = Color.White;
            this.dgvAssignments.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dgvAssignments.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            // 
            // UC_ManageProjectAdvisors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAssignments);
            this.Controls.Add(this.leftpanel);
            this.Name = "UC_ManageProjectAdvisors";
            this.Size = new System.Drawing.Size(1234, 594);
            this.leftpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.Button btnAssignAdvisor;
        private System.Windows.Forms.Button btnRemoveAssignment;
    }
}
