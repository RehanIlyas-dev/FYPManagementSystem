namespace FYPManagementSystem.UI.Projects
{
    partial class Addproject
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
            txtTitle = new TextBox();
            txtDescription = new RichTextBox();
            lblTitle = new Label();
            btnAddProject = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top;
            txtTitle.Location = new Point(260, 130);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Project Title";
            txtTitle.Size = new Size(260, 27);
            txtTitle.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top;
            txtDescription.Location = new Point(260, 180);
            txtDescription.Name = "txtDescription";
            txtDescription.RightToLeft = RightToLeft.No;
            txtDescription.Size = new Size(260, 100);
            txtDescription.TabIndex = 2;
            txtDescription.Text = "";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.RosyBrown;
            lblTitle.Location = new Point(260, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(317, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Project";
            // 
            // btnAddProject
            // 
            btnAddProject.Anchor = AnchorStyles.Top;
            btnAddProject.Location = new Point(310, 310);
            btnAddProject.Name = "btnAddProject";
            btnAddProject.Size = new Size(160, 50);
            btnAddProject.TabIndex = 3;
            btnAddProject.Text = "Add Project";
            btnAddProject.UseVisualStyleBackColor = true;
            btnAddProject.Click += btnAddProject_Click;
            // 
            // Addproject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddProject);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Name = "Addproject";
            Text = "Addproject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btnAddProject;
    }
}