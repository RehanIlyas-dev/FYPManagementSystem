namespace FYPManagementSystem.UI.Groups
{
    partial class AddGroup
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
            pnlHeader = new Panel();
            clbStudents = new CheckedListBox();
            btnCreateGroup = new Button();
            lblTitle = new Label();
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
            pnlHeader.TabIndex = 3;
            // 
            // clbStudents
            // 
            clbStudents.Anchor = AnchorStyles.Top;
            clbStudents.FormattingEnabled = true;
            clbStudents.Location = new Point(260, 130);
            clbStudents.Name = "clbStudents";
            clbStudents.Size = new Size(280, 158);
            clbStudents.TabIndex = 1;
            // 
            // btnCreateGroup
            // 
            btnCreateGroup.Anchor = AnchorStyles.Top;
            btnCreateGroup.BackColor = Color.FromArgb(0, 120, 215);
            btnCreateGroup.FlatAppearance.BorderSize = 0;
            btnCreateGroup.FlatStyle = FlatStyle.Flat;
            btnCreateGroup.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCreateGroup.ForeColor = Color.White;
            btnCreateGroup.Location = new Point(320, 310);
            btnCreateGroup.Name = "btnCreateGroup";
            btnCreateGroup.Size = new Size(160, 50);
            btnCreateGroup.TabIndex = 2;
            btnCreateGroup.Text = "Create Group";
            btnCreateGroup.UseVisualStyleBackColor = false;
            btnCreateGroup.Click += btnCreateGroup_Click;

            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(252, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Group";
            // 
            // AddGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlHeader);
            Controls.Add(btnCreateGroup);
            Controls.Add(clbStudents);
            Name = "AddGroup";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Group";

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel pnlHeader;
        private CheckedListBox clbStudents;
        private Button btnCreateGroup;
        private Label lblTitle;
    }
}
