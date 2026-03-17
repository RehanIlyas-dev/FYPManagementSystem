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
            txtTitle = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.RichTextBox();
            lblTitle = new System.Windows.Forms.Label();
            btnUpdateProject = new System.Windows.Forms.Button();
            SuspendLayout();
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
            lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.ForeColor = System.Drawing.Color.RosyBrown;
            lblTitle.Location = new System.Drawing.Point(260, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(380, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Update Project";
            // 
            // btnUpdateProject
            // 
            btnUpdateProject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnUpdateProject.Location = new System.Drawing.Point(310, 310);
            btnUpdateProject.Name = "btnUpdateProject";
            btnUpdateProject.Size = new System.Drawing.Size(160, 50);
            btnUpdateProject.TabIndex = 3;
            btnUpdateProject.Text = "Update Project";
            btnUpdateProject.UseVisualStyleBackColor = true;
            btnUpdateProject.Click += btnUpdateProject_Click;
            // 
            // UpdateProject
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnUpdateProject);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Name = "UpdateProject";
            Text = "Update Project";
            Load += UpdateProject_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btnUpdateProject;
    }
}
