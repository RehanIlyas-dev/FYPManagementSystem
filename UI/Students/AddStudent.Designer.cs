namespace FYPManagementSystem.UI.Students
{
    partial class AddStudent
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
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtRegNo = new TextBox();
            dtp01 = new DateTimePicker();
            CBGender = new ComboBox();
            btnAddStudent = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(0, 120, 215);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 100);
            pnlHeader.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(235, 16);
            label1.Name = "label1";
            label1.Size = new Size(330, 68);
            label1.TabIndex = 5;
            label1.Text = "Add Student";
            label1.Click += label1_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top;
            txtFirstName.Location = new Point(200, 120);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "FirstName";
            txtFirstName.Size = new Size(400, 27);
            txtFirstName.TabIndex = 0;
            txtFirstName.TextChanged += textBox1_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top;
            txtLastName.Location = new Point(200, 160);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "LastName";
            txtLastName.Size = new Size(400, 27);
            txtLastName.TabIndex = 1;
            txtLastName.TextChanged += textBox2_TextChanged;
            // 
            // txtContact
            // 
            txtContact.Anchor = AnchorStyles.Top;
            txtContact.Location = new Point(200, 200);
            txtContact.Name = "txtContact";
            txtContact.PlaceholderText = "Contact";
            txtContact.Size = new Size(400, 27);
            txtContact.TabIndex = 2;
            txtContact.TextChanged += textBox3_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.Location = new Point(200, 240);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(400, 27);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += textBox4_TextChanged;
            // 
            // txtRegNo
            // 
            txtRegNo.Anchor = AnchorStyles.Top;
            txtRegNo.Location = new Point(200, 280);
            txtRegNo.Name = "txtRegNo";
            txtRegNo.PlaceholderText = "Registration No";
            txtRegNo.Size = new Size(400, 27);
            txtRegNo.TabIndex = 4;
            txtRegNo.TextChanged += textBox5_TextChanged;
            // 
            // dtp01
            // 
            dtp01.Anchor = AnchorStyles.Top;
            dtp01.Location = new Point(200, 320);
            dtp01.Name = "dtp01";
            dtp01.Size = new Size(400, 27);
            dtp01.TabIndex = 6;
            // 
            // CBGender
            // 
            CBGender.AccessibleName = "Gender";
            CBGender.Anchor = AnchorStyles.Top;
            CBGender.FormattingEnabled = true;
            CBGender.Items.AddRange(new object[] { "Male", "Female", "Prefer not to say" });
            CBGender.Location = new Point(200, 360);
            CBGender.Name = "CBGender";
            CBGender.Size = new Size(400, 28);
            CBGender.TabIndex = 7;
            CBGender.Text = "Gender";
            // 
            // btnAddStudent
            // 
            btnAddStudent.Anchor = AnchorStyles.Top;
            btnAddStudent.BackColor = Color.FromArgb(0, 120, 215);
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.Location = new Point(320, 410);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(160, 50);
            btnAddStudent.TabIndex = 8;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(pnlHeader);
            Controls.Add(btnAddStudent);
            Controls.Add(CBGender);
            Controls.Add(dtp01);
            Controls.Add(txtRegNo);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Student";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtRegNo;
        private Label label1;
        private DateTimePicker dtp01;
        private ComboBox CBGender;
        private Button btnAddStudent;
    }
}
