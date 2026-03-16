namespace FYPManagementSystem.Forms
{
    partial class UpdateStudent
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtRegNo = new TextBox();
            label1 = new Label();
            dtp01 = new DateTimePicker();
            CBGender = new ComboBox();
            btnUpdateStudent = new Button();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top;
            txtFirstName.Location = new Point(12, 209);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "FirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top;
            txtLastName.Location = new Point(143, 209);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "LastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 1;
            // 
            // txtContact
            // 
            txtContact.Anchor = AnchorStyles.Top;
            txtContact.Location = new Point(274, 209);
            txtContact.Name = "txtContact";
            txtContact.PlaceholderText = "Contact";
            txtContact.Size = new Size(125, 27);
            txtContact.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.Location = new Point(405, 209);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtRegNo
            // 
            txtRegNo.Anchor = AnchorStyles.Top;
            txtRegNo.Location = new Point(536, 209);
            txtRegNo.Name = "txtRegNo";
            txtRegNo.PlaceholderText = "Registration No";
            txtRegNo.Size = new Size(125, 27);
            txtRegNo.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(410, 9);
            label1.Name = "label1";
            label1.Size = new Size(410, 68);
            label1.TabIndex = 5;
            label1.Text = "Update Student";
            // 
            // dtp01
            // 
            dtp01.Anchor = AnchorStyles.Top;
            dtp01.Location = new Point(667, 209);
            dtp01.Name = "dtp01";
            dtp01.Size = new Size(250, 27);
            dtp01.TabIndex = 6;
            // 
            // CBGender
            // 
            CBGender.Anchor = AnchorStyles.Top;
            CBGender.AccessibleName = "Gender";
            CBGender.FormattingEnabled = true;
            CBGender.Items.AddRange(new object[] { "Male", "Female", "Prefer not to say" });
            CBGender.Location = new Point(923, 209);
            CBGender.Name = "CBGender";
            CBGender.Size = new Size(151, 28);
            CBGender.TabIndex = 7;
            CBGender.Text = "Gender";
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.Anchor = AnchorStyles.Top;
            btnUpdateStudent.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdateStudent.Location = new Point(510, 298);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(151, 68);
            btnUpdateStudent.TabIndex = 8;
            btnUpdateStudent.Text = "Update Student";
            btnUpdateStudent.UseVisualStyleBackColor = true;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            // 
            // UpdateStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 450);
            Controls.Add(btnUpdateStudent);
            Controls.Add(CBGender);
            Controls.Add(dtp01);
            Controls.Add(label1);
            Controls.Add(txtRegNo);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "UpdateStudent";
            Text = "UpdateStudent";
            Load += UpdateStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtRegNo;
        private Label label1;
        private DateTimePicker dtp01;
        private ComboBox CBGender;
        private Button btnUpdateStudent;
    }
}
