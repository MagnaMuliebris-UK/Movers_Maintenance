namespace Movers_Maintenance_Subsystem.AdditionalForms.Views
{
    partial class ViewStaff
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnRefresh = new Button();
            dgvStaff = new DataGridView();
            staffIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            forenameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            positionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            trainerDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            workingHoursDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Hourly_Salary = new DataGridViewTextBoxColumn();
            staffBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)staffBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 16F);
            btnRefresh.Location = new Point(185, 480);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(200, 50);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvStaff
            // 
            dgvStaff.AllowUserToAddRows = false;
            dgvStaff.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvStaff.AutoGenerateColumns = false;
            dgvStaff.BackgroundColor = Color.FromArgb(74, 74, 74);
            dgvStaff.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvStaff.Columns.AddRange(new DataGridViewColumn[] { staffIDDataGridViewTextBoxColumn, forenameDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn, positionDataGridViewTextBoxColumn, trainerDataGridViewCheckBoxColumn, workingHoursDataGridViewTextBoxColumn, Hourly_Salary });
            dgvStaff.DataSource = staffBindingSource;
            dgvStaff.GridColor = Color.Gainsboro;
            dgvStaff.Location = new Point(0, 0);
            dgvStaff.Margin = new Padding(0);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.ReadOnly = true;
            dgvStaff.RowHeadersWidth = 30;
            dgvStaff.Size = new Size(570, 460);
            dgvStaff.TabIndex = 6;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            staffIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // forenameDataGridViewTextBoxColumn
            // 
            forenameDataGridViewTextBoxColumn.DataPropertyName = "Forename";
            forenameDataGridViewTextBoxColumn.HeaderText = "Forename";
            forenameDataGridViewTextBoxColumn.Name = "forenameDataGridViewTextBoxColumn";
            forenameDataGridViewTextBoxColumn.ReadOnly = true;
            forenameDataGridViewTextBoxColumn.Width = 70;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            surnameDataGridViewTextBoxColumn.ReadOnly = true;
            surnameDataGridViewTextBoxColumn.Width = 70;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            positionDataGridViewTextBoxColumn.HeaderText = "Position";
            positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            positionDataGridViewTextBoxColumn.ReadOnly = true;
            positionDataGridViewTextBoxColumn.Width = 80;
            // 
            // trainerDataGridViewCheckBoxColumn
            // 
            trainerDataGridViewCheckBoxColumn.DataPropertyName = "Trainer";
            trainerDataGridViewCheckBoxColumn.HeaderText = "Trainer";
            trainerDataGridViewCheckBoxColumn.Name = "trainerDataGridViewCheckBoxColumn";
            trainerDataGridViewCheckBoxColumn.ReadOnly = true;
            trainerDataGridViewCheckBoxColumn.Width = 60;
            // 
            // workingHoursDataGridViewTextBoxColumn
            // 
            workingHoursDataGridViewTextBoxColumn.DataPropertyName = "Working_Hours";
            workingHoursDataGridViewTextBoxColumn.HeaderText = "Work Hours";
            workingHoursDataGridViewTextBoxColumn.Name = "workingHoursDataGridViewTextBoxColumn";
            workingHoursDataGridViewTextBoxColumn.ReadOnly = true;
            workingHoursDataGridViewTextBoxColumn.Width = 80;
            // 
            // Hourly_Salary
            // 
            Hourly_Salary.DataPropertyName = "Hourly_Salary";
            Hourly_Salary.HeaderText = "Hourly Wage";
            Hourly_Salary.Name = "Hourly_Salary";
            Hourly_Salary.ReadOnly = true;
            Hourly_Salary.Width = 90;
            // 
            // staffBindingSource
            // 
            staffBindingSource.DataSource = typeof(Models.Staff);
            // 
            // ViewStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(dgvStaff);
            Controls.Add(btnRefresh);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewStaff";
            Text = "ViewStaff";
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ((System.ComponentModel.ISupportInitialize)staffBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private DataGridView dgvStaff;
        private DataGridViewTextBoxColumn hourlySalaryDataGridViewTextBoxColumn;
        private BindingSource staffBindingSource;
        private DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn forenameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn trainerDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn workingHoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Hourly_Salary;
    }
}