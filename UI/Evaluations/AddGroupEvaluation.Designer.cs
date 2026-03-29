namespace FYPManagementSystem.UI.Evaluations
{
    partial class AddGroupEvaluation
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
            cmbGroup = new ComboBox();
            cmbEvaluation = new ComboBox();
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
            lblTitle.Text = "Mark Group Evaluation";
            // 
            // cmbGroup
            // 
            cmbGroup.Anchor = AnchorStyles.Top;
            cmbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGroup.Location = new Point(200, 120);
            cmbGroup.Name = "cmbGroup";
            cmbGroup.Size = new Size(400, 28);
            cmbGroup.TabIndex = 1;
            // 
            // cmbEvaluation
            // 
            cmbEvaluation.Anchor = AnchorStyles.Top;
            cmbEvaluation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEvaluation.Location = new Point(200, 170);
            cmbEvaluation.Name = "cmbEvaluation";
            cmbEvaluation.Size = new Size(400, 28);
            cmbEvaluation.TabIndex = 2;
            // 
            // txtMarks
            // 
            txtMarks.Anchor = AnchorStyles.Top;
            txtMarks.Location = new Point(200, 220);
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
            btnSave.Location = new Point(320, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 50);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Mark";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AddGroupEvaluation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            Controls.Add(txtMarks);
            Controls.Add(cmbEvaluation);
            Controls.Add(cmbGroup);
            Name = "AddGroupEvaluation";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mark Evaluation";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private ComboBox cmbGroup;
        private ComboBox cmbEvaluation;
        private TextBox txtMarks;
        private Button btnSave;
    }
}
