namespace FYPManagementSystem.UI.ProjectAdvisor
{
    partial class AddAdvisor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            cmbProjects = new ComboBox();
            cmbAdvisors = new ComboBox();
            cmbRoles = new ComboBox();
            btnAssign = new Button();
            dtpAssignmentDate = new DateTimePicker();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.Highlight;
            lblTitle.Font = new Font("Times New Roman", 36F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(234, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(396, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Assign Advisor";
            // 
            // cmbProjects
            // 
            cmbProjects.Anchor = AnchorStyles.Top;
            cmbProjects.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProjects.FormattingEnabled = true;
            cmbProjects.Location = new Point(260, 110);
            cmbProjects.Name = "cmbProjects";
            cmbProjects.Size = new Size(280, 28);
            cmbProjects.TabIndex = 1;
            // 
            // cmbAdvisors
            // 
            cmbAdvisors.Anchor = AnchorStyles.Top;
            cmbAdvisors.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAdvisors.FormattingEnabled = true;
            cmbAdvisors.Location = new Point(260, 160);
            cmbAdvisors.Name = "cmbAdvisors";
            cmbAdvisors.Size = new Size(280, 28);
            cmbAdvisors.TabIndex = 2;
            // 
            // cmbRoles
            // 
            cmbRoles.Anchor = AnchorStyles.Top;
            cmbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(260, 210);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(280, 28);
            cmbRoles.TabIndex = 3;
            // 
            // btnAssign
            // 
            btnAssign.BackColor = Color.FromArgb(0, 120, 215);
            btnAssign.FlatAppearance.BorderSize = 0;
            btnAssign.FlatStyle = FlatStyle.Flat;
            btnAssign.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(320, 320);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(160, 50);
            btnAssign.TabIndex = 5;
            btnAssign.Text = "Assign Advisor";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssign_Click;
            // 
            // dtpAssignmentDate
            // 
            dtpAssignmentDate.Anchor = AnchorStyles.Top;
            dtpAssignmentDate.Location = new Point(260, 260);
            dtpAssignmentDate.Name = "dtpAssignmentDate";
            dtpAssignmentDate.Size = new Size(280, 27);
            dtpAssignmentDate.TabIndex = 4;
            // 
            // AddAdvisor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAssign);
            Controls.Add(dtpAssignmentDate);
            Controls.Add(cmbRoles);
            Controls.Add(cmbAdvisors);
            Controls.Add(cmbProjects);
            Controls.Add(lblTitle);
            Name = "AddAdvisor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Add Advisor Assignment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.ComboBox cmbAdvisors;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.DateTimePicker dtpAssignmentDate;
        private System.Windows.Forms.Button btnAssign;

    }
}