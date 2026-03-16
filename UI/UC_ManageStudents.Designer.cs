namespace FYPManagementSystem
{
    partial class uc_manage_student
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnaddStudent = new Button();
            btnUpdateStudent = new Button();
            btndeleteStudent = new Button();
            btnclearform = new Button();
            databaseConnectionBindingSource = new BindingSource(components);
            panel1 = new Panel();
            dgvStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // btnaddStudent
            // 
            btnaddStudent.Dock = DockStyle.Top;
            btnaddStudent.Location = new Point(0, 33);
            btnaddStudent.Name = "btnaddStudent";
            btnaddStudent.Size = new Size(150, 38);
            btnaddStudent.TabIndex = 7;
            btnaddStudent.Text = "AddStudent";
            btnaddStudent.UseVisualStyleBackColor = true;
            btnaddStudent.Click += btnaddStudent_Click;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.Dock = DockStyle.Top;
            btnUpdateStudent.Location = new Point(0, 106);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(150, 37);
            btnUpdateStudent.TabIndex = 8;
            btnUpdateStudent.Text = "UpdateStudent";
            btnUpdateStudent.UseVisualStyleBackColor = true;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            // 
            // btndeleteStudent
            // 
            btndeleteStudent.Dock = DockStyle.Top;
            btndeleteStudent.Location = new Point(0, 71);
            btndeleteStudent.Name = "btndeleteStudent";
            btndeleteStudent.Size = new Size(150, 35);
            btndeleteStudent.TabIndex = 9;
            btndeleteStudent.Text = "DeleteStudent";
            btndeleteStudent.UseVisualStyleBackColor = true;
            btndeleteStudent.Click += btndeleteStudent_Click;
            // 
            // btnclearform
            // 
            btnclearform.Dock = DockStyle.Top;
            btnclearform.Location = new Point(0, 0);
            btnclearform.Name = "btnclearform";
            btnclearform.Size = new Size(150, 33);
            btnclearform.TabIndex = 10;
            btnclearform.Text = "ClearForm";
            btnclearform.UseVisualStyleBackColor = true;
            btnclearform.Click += btnclearform_Click;
            // 
            // databaseConnectionBindingSource
            // 
            databaseConnectionBindingSource.DataSource = typeof(DAL.DatabaseConnection);
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnUpdateStudent);
            panel1.Controls.Add(btndeleteStudent);
            panel1.Controls.Add(btnaddStudent);
            panel1.Controls.Add(btnclearform);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 487);
            panel1.TabIndex = 11;
            // 
            // dgvStudents
            // 
            dgvStudents.BackgroundColor = SystemColors.Control;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.GridColor = SystemColors.HighlightText;
            dgvStudents.Location = new Point(150, 0);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(1152, 487);
            dgvStudents.TabIndex = 12;
            dgvStudents.CellContentClick += dataGridView1_CellContentClick;
            // 
            // uc_manage_student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvStudents);
            Controls.Add(panel1);
            Name = "uc_manage_student";
            Size = new Size(1302, 487);
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnaddStudent;
        private Button btnUpdateStudent;
        private Button btndeleteStudent;
        private Button btnclearform;
        private BindingSource databaseConnectionBindingSource;
        private Panel panel1;
        private DataGridView dgvStudents;
    }
}
