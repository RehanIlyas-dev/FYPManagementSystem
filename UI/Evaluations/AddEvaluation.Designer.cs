namespace FYPManagementSystem.UI.Evaluations
{
    partial class AddEvaluation
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
            txtName = new TextBox();
            txtTotalMarks = new TextBox();
            txtWeightage = new TextBox();
            btnAddEvaluation = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.Highlight;
            lblTitle.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(207, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(407, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Evaluation";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top;
            txtName.Location = new Point(200, 120);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Evaluation Name";
            txtName.Size = new Size(400, 27);
            txtName.TabIndex = 1;
            // 
            // txtTotalMarks
            // 
            txtTotalMarks.Anchor = AnchorStyles.Top;
            txtTotalMarks.Location = new Point(200, 170);
            txtTotalMarks.Name = "txtTotalMarks";
            txtTotalMarks.PlaceholderText = "Total Marks";
            txtTotalMarks.Size = new Size(400, 27);
            txtTotalMarks.TabIndex = 2;
            // 
            // txtWeightage
            // 
            txtWeightage.Anchor = AnchorStyles.Top;
            txtWeightage.Location = new Point(200, 220);
            txtWeightage.Name = "txtWeightage";
            txtWeightage.PlaceholderText = "Total Weightage";
            txtWeightage.Size = new Size(400, 27);
            txtWeightage.TabIndex = 3;
            // 
            // btnAddEvaluation
            // 
            btnAddEvaluation.Anchor = AnchorStyles.Top;
            btnAddEvaluation.BackColor = Color.FromArgb(0, 120, 215);
            btnAddEvaluation.FlatAppearance.BorderSize = 0;
            btnAddEvaluation.FlatStyle = FlatStyle.Flat;
            btnAddEvaluation.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAddEvaluation.ForeColor = Color.White;
            btnAddEvaluation.Location = new Point(320, 280);
            btnAddEvaluation.Name = "btnAddEvaluation";
            btnAddEvaluation.Size = new Size(160, 50);
            btnAddEvaluation.TabIndex = 4;
            btnAddEvaluation.Text = "Add Evaluation";
            btnAddEvaluation.UseVisualStyleBackColor = false;
            btnAddEvaluation.Click += btnAddEvaluation_Click;
            // 
            // AddEvaluation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(btnAddEvaluation);
            Controls.Add(txtWeightage);
            Controls.Add(txtTotalMarks);
            Controls.Add(txtName);
            Name = "AddEvaluation";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Evaluation";
            ResumeLayout(false);
            PerformLayout();
        }


        private Label lblTitle;
        private TextBox txtName;
        private TextBox txtTotalMarks;
        private TextBox txtWeightage;
        private Button btnAddEvaluation;

    }
}
