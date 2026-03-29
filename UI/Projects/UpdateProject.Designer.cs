namespace FYPManagementSystem.UI.Projects
{
    partial class UpdateProject
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
            pnlHeader = new Panel();
            txtTitle = new TextBox();
            txtDescription = new RichTextBox();
            lblTitle = new Label();
            btnUpdateProject = new Button();
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
            pnlHeader.TabIndex = 4;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            txtTitle.Location = new System.Drawing.Point(260, 130);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Project Title";
            txtTitle.Size = new System.Drawing.Size(260, 27);
            txtTitle.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            txtDescription.Location = new System.Drawing.Point(260, 180);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(260, 100);
            txtDescription.TabIndex = 2;
            txtDescription.Text = "";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(210, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(380, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Update Project";
            // 
            // btnUpdateProject
            // 
            btnUpdateProject.Anchor = AnchorStyles.Top;
            btnUpdateProject.BackColor = Color.FromArgb(0, 120, 215);
            btnUpdateProject.FlatAppearance.BorderSize = 0;
            btnUpdateProject.FlatStyle = FlatStyle.Flat;
            btnUpdateProject.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdateProject.ForeColor = Color.White;
            btnUpdateProject.Location = new Point(320, 310);
            btnUpdateProject.Name = "btnUpdateProject";
            btnUpdateProject.Size = new Size(160, 50);
            btnUpdateProject.TabIndex = 3;
            btnUpdateProject.Text = "Update Project";
            btnUpdateProject.UseVisualStyleBackColor = false;
            btnUpdateProject.Click += btnUpdateProject_Click;

            // 
            // UpdateProject
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(pnlHeader);
            Controls.Add(btnUpdateProject);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Name = "UpdateProject";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Project";

            Load += UpdateProject_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private TextBox txtTitle;
        private RichTextBox txtDescription;
        private Button btnUpdateProject;
    }
}
