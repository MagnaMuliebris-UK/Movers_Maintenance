namespace Movers_Maintenance_Subsystem.AdditionalForms.Views
{
    partial class ViewCheckup
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
            dgvCheckup = new DataGridView();
            checkupIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vanConditionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vanIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isMoTCheckupDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            checkupDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkupBindingSource = new BindingSource(components);
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCheckup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkupBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvCheckup
            // 
            dgvCheckup.AllowUserToAddRows = false;
            dgvCheckup.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvCheckup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCheckup.AutoGenerateColumns = false;
            dgvCheckup.BackgroundColor = Color.FromArgb(74, 74, 74);
            dgvCheckup.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCheckup.Columns.AddRange(new DataGridViewColumn[] { checkupIDDataGridViewTextBoxColumn, vanConditionDataGridViewTextBoxColumn, vanIDDataGridViewTextBoxColumn, isMoTCheckupDataGridViewCheckBoxColumn, checkupDateDataGridViewTextBoxColumn });
            dgvCheckup.DataSource = checkupBindingSource;
            dgvCheckup.GridColor = Color.Gainsboro;
            dgvCheckup.Location = new Point(0, 0);
            dgvCheckup.Margin = new Padding(0);
            dgvCheckup.Name = "dgvCheckup";
            dgvCheckup.ReadOnly = true;
            dgvCheckup.RowHeadersWidth = 30;
            dgvCheckup.Size = new Size(570, 460);
            dgvCheckup.TabIndex = 9;
            // 
            // checkupIDDataGridViewTextBoxColumn
            // 
            checkupIDDataGridViewTextBoxColumn.DataPropertyName = "CheckupID";
            checkupIDDataGridViewTextBoxColumn.HeaderText = "Checkup ID";
            checkupIDDataGridViewTextBoxColumn.Name = "checkupIDDataGridViewTextBoxColumn";
            checkupIDDataGridViewTextBoxColumn.ReadOnly = true;
            checkupIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // vanConditionDataGridViewTextBoxColumn
            // 
            vanConditionDataGridViewTextBoxColumn.DataPropertyName = "Van_Condition";
            vanConditionDataGridViewTextBoxColumn.HeaderText = "Van Condition";
            vanConditionDataGridViewTextBoxColumn.Name = "vanConditionDataGridViewTextBoxColumn";
            vanConditionDataGridViewTextBoxColumn.ReadOnly = true;
            vanConditionDataGridViewTextBoxColumn.Width = 90;
            // 
            // vanIDDataGridViewTextBoxColumn
            // 
            vanIDDataGridViewTextBoxColumn.DataPropertyName = "VanID";
            vanIDDataGridViewTextBoxColumn.HeaderText = "Van ID";
            vanIDDataGridViewTextBoxColumn.Name = "vanIDDataGridViewTextBoxColumn";
            vanIDDataGridViewTextBoxColumn.ReadOnly = true;
            vanIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // isMoTCheckupDataGridViewCheckBoxColumn
            // 
            isMoTCheckupDataGridViewCheckBoxColumn.DataPropertyName = "IsMoTCheckup";
            isMoTCheckupDataGridViewCheckBoxColumn.HeaderText = "MoT Checkup";
            isMoTCheckupDataGridViewCheckBoxColumn.Name = "isMoTCheckupDataGridViewCheckBoxColumn";
            isMoTCheckupDataGridViewCheckBoxColumn.ReadOnly = true;
            isMoTCheckupDataGridViewCheckBoxColumn.Width = 90;
            // 
            // checkupDateDataGridViewTextBoxColumn
            // 
            checkupDateDataGridViewTextBoxColumn.DataPropertyName = "Checkup_Date";
            checkupDateDataGridViewTextBoxColumn.HeaderText = "Checkup Date";
            checkupDateDataGridViewTextBoxColumn.Name = "checkupDateDataGridViewTextBoxColumn";
            checkupDateDataGridViewTextBoxColumn.ReadOnly = true;
            checkupDateDataGridViewTextBoxColumn.Width = 90;
            // 
            // checkupBindingSource
            // 
            checkupBindingSource.DataSource = typeof(Models.Checkup);
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 16F);
            btnRefresh.Location = new Point(185, 480);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(200, 50);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ViewCheckup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(btnRefresh);
            Controls.Add(dgvCheckup);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewCheckup";
            Text = "ViewCheckup";
            ((System.ComponentModel.ISupportInitialize)dgvCheckup).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkupBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCheckup;
        private BindingSource checkupBindingSource;
        private DataGridViewTextBoxColumn checkupIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vanConditionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vanIDDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isMoTCheckupDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn driverIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkupDateDataGridViewTextBoxColumn;
        private Button btnRefresh;
    }
}