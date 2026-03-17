namespace FYPManagementSystem.UI.Groups
{
    partial class UpdateGroup
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
            btnUpdate = new Button();
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
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top;
            btnUpdate.Location = new Point(310, 310);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(160, 50);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update Group";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.RosyBrown;
            lblTitle.Location = new Point(230, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Update Group";
            // 
            // UpdateGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(clbStudents);
            Controls.Add(lblTitle);
            Name = "UpdateGroup";
            Text = "Update Group";
            ResumeLayout(false);
            PerformLayout();
        }

        private CheckedListBox clbStudents;
        private Button btnUpdate;
        private Label lblTitle;
    }
}
