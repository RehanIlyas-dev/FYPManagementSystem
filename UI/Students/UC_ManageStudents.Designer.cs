namespace FYPManagementSystem.UI.Students
{
    partial class UC_ManageStudents
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
            panel1 = new Panel();
            btnaddStudent = new Button();
            btnUpdateStudent = new Button();
            btndeleteStudent = new Button();
            btnclearform = new Button();
            dgvStudents = new DataGridView();
            databaseConnectionBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // btnaddStudent
            // 
            btnaddStudent.Dock = DockStyle.Top;
            btnaddStudent.BackColor = Color.FromArgb(0, 120, 215);
            btnaddStudent.FlatAppearance.BorderSize = 0;
            btnaddStudent.FlatStyle = FlatStyle.Flat;
            btnaddStudent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnaddStudent.ForeColor = Color.White;
            btnaddStudent.Location = new Point(0, 120);
            btnaddStudent.Name = "btnaddStudent";
            btnaddStudent.Size = new Size(160, 40);
            btnaddStudent.TabIndex = 8;
            btnaddStudent.Text = "Add Student";
            btnaddStudent.UseVisualStyleBackColor = false;
            btnaddStudent.Click += btnaddStudent_Click;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.Dock = DockStyle.Top;
            btnUpdateStudent.BackColor = Color.FromArgb(0, 120, 215);
            btnUpdateStudent.FlatAppearance.BorderSize = 0;
            btnUpdateStudent.FlatStyle = FlatStyle.Flat;
            btnUpdateStudent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdateStudent.ForeColor = Color.White;
            btnUpdateStudent.Location = new Point(0, 80);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(160, 40);
            btnUpdateStudent.TabIndex = 9;
            btnUpdateStudent.Text = "Update Student";
            btnUpdateStudent.UseVisualStyleBackColor = false;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            // 
            // btndeleteStudent
            // 
            btndeleteStudent.Dock = DockStyle.Top;
            btndeleteStudent.BackColor = Color.FromArgb(0, 120, 215);
            btndeleteStudent.FlatAppearance.BorderSize = 0;
            btndeleteStudent.FlatStyle = FlatStyle.Flat;
            btndeleteStudent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btndeleteStudent.ForeColor = Color.White;
            btndeleteStudent.Location = new Point(0, 40);
            btndeleteStudent.Name = "btndeleteStudent";
            btndeleteStudent.Size = new Size(160, 40);
            btndeleteStudent.TabIndex = 10;
            btndeleteStudent.Text = "Delete Student";
            btndeleteStudent.UseVisualStyleBackColor = false;
            btndeleteStudent.Click += btndeleteStudent_Click;
            // 
            // btnclearform
            // 
            btnclearform.Dock = DockStyle.Top;
            btnclearform.BackColor = Color.FromArgb(0, 120, 215);
            btnclearform.FlatAppearance.BorderSize = 0;
            btnclearform.FlatStyle = FlatStyle.Flat;
            btnclearform.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnclearform.ForeColor = Color.White;
            btnclearform.Location = new Point(0, 0);
            btnclearform.Name = "btnclearform";
            btnclearform.Size = new Size(160, 40);
            btnclearform.TabIndex = 13;
            btnclearform.Text = "Clear View";
            btnclearform.UseVisualStyleBackColor = false;
            btnclearform.Click += btnclearform_Click;
            // 
            // databaseConnectionBindingSource
            // 
            databaseConnectionBindingSource.DataSource = typeof(DL.DatabaseConnection);
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnaddStudent);
            panel1.Controls.Add(btnUpdateStudent);
            panel1.Controls.Add(btndeleteStudent);
            panel1.Controls.Add(btnclearform);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 487);
            panel1.TabIndex = 11;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvStudents.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.GridColor = Color.FromArgb(224, 224, 224);
            dgvStudents.Location = new Point(160, 0);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(1074, 594);
            dgvStudents.TabIndex = 1;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            dgvStudents.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            dgvStudents.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvStudents.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            // 
            // UC_ManageStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvStudents);
            Controls.Add(panel1);
            Name = "UC_ManageStudents";
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
