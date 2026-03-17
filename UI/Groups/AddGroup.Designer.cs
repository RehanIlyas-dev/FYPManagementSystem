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
            clbStudents = new CheckedListBox();
            btnCreateGroup = new Button();
            lblTitle = new Label();
            SuspendLayout();
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
            btnCreateGroup.Location = new Point(310, 310);
            btnCreateGroup.Name = "btnCreateGroup";
            btnCreateGroup.Size = new Size(160, 50);
            btnCreateGroup.TabIndex = 2;
            btnCreateGroup.Text = "Create Group";
            btnCreateGroup.UseVisualStyleBackColor = true;
            btnCreateGroup.Click += btnCreateGroup_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.RosyBrown;
            lblTitle.Location = new Point(260, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Group";
            // 
            // AddGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateGroup);
            Controls.Add(clbStudents);
            Controls.Add(lblTitle);
            Name = "AddGroup";
            Text = "Add Group";
            ResumeLayout(false);
            PerformLayout();
        }

        private CheckedListBox clbStudents;
        private Button btnCreateGroup;
        private Label lblTitle;
    }
}
