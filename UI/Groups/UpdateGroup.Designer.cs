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
            pnlHeader = new Panel();
            clbStudents = new CheckedListBox();
            btnUpdate = new Button();
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
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top;
            btnUpdate.BackColor = Color.FromArgb(0, 120, 215);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(320, 310);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(160, 50);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update Group";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;

            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(222, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Update Group";
            // 
            // UpdateGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlHeader);
            Controls.Add(btnUpdate);
            Controls.Add(clbStudents);
            Name = "UpdateGroup";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Group";

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel pnlHeader;
        private CheckedListBox clbStudents;
        private Button btnUpdate;
        private Label lblTitle;
    }
}
