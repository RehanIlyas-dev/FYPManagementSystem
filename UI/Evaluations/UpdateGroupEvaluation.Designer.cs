namespace FYPManagementSystem.UI.Evaluations
{
    partial class UpdateGroupEvaluation
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
            lblTitle = new Label();
            lblGroup = new Label();
            lblEvaluation = new Label();
            txtMarks = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.Highlight;
            lblTitle.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(140, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(520, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Update Group Mark";
            // 
            // lblGroup
            // 
            lblGroup.Anchor = AnchorStyles.Top;
            lblGroup.AutoSize = true;
            lblGroup.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblGroup.Location = new Point(200, 120);
            lblGroup.Name = "lblGroup";
            lblGroup.Size = new Size(115, 28);
            lblGroup.TabIndex = 1;
            lblGroup.Text = "Group ID: -";
            // 
            // lblEvaluation
            // 
            lblEvaluation.Anchor = AnchorStyles.Top;
            lblEvaluation.AutoSize = true;
            lblEvaluation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEvaluation.Location = new Point(200, 160);
            lblEvaluation.Name = "lblEvaluation";
            lblEvaluation.Size = new Size(130, 28);
            lblEvaluation.TabIndex = 2;
            lblEvaluation.Text = "Evaluation: -";
            // 
            // txtMarks
            // 
            txtMarks.Anchor = AnchorStyles.Top;
            txtMarks.Location = new Point(200, 210);
            txtMarks.Name = "txtMarks";
            txtMarks.PlaceholderText = "Obtained Marks";
            txtMarks.Size = new Size(400, 27);
            txtMarks.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.BackColor = Color.FromArgb(0, 120, 215);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(320, 270);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 50);
            btnSave.TabIndex = 4;
            btnSave.Text = "Update Mark";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // UpdateGroupEvaluation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(lblGroup);
            Controls.Add(lblEvaluation);
            Controls.Add(txtMarks);
            Controls.Add(btnSave);
            Name = "UpdateGroupEvaluation";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Evaluation";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblGroup;
        private Label lblEvaluation;
        private TextBox txtMarks;
        private Button btnSave;
    }
}
