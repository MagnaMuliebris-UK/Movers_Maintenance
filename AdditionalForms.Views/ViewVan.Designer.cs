namespace Movers_Maintenance_Subsystem.AdditionalForms.Views
{
    partial class ViewVan
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
            dgvVan = new DataGridView();
            vanIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vanMakeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mOTExpiryDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            driverIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isInUseDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            vanBindingSource = new BindingSource(components);
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvVan
            // 
            dgvVan.AllowUserToAddRows = false;
            dgvVan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvVan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVan.AutoGenerateColumns = false;
            dgvVan.BackgroundColor = Color.FromArgb(74, 74, 74);
            dgvVan.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvVan.Columns.AddRange(new DataGridViewColumn[] { vanIDDataGridViewTextBoxColumn, vanMakeDataGridViewTextBoxColumn, mOTExpiryDateDataGridViewTextBoxColumn, driverIDDataGridViewTextBoxColumn, isInUseDataGridViewCheckBoxColumn });
            dgvVan.DataSource = vanBindingSource;
            dgvVan.GridColor = Color.Gainsboro;
            dgvVan.Location = new Point(0, 0);
            dgvVan.Margin = new Padding(0);
            dgvVan.Name = "dgvVan";
            dgvVan.ReadOnly = true;
            dgvVan.RowHeadersWidth = 30;
            dgvVan.Size = new Size(570, 460);
            dgvVan.TabIndex = 8;
            // 
            // vanIDDataGridViewTextBoxColumn
            // 
            vanIDDataGridViewTextBoxColumn.DataPropertyName = "VanID";
            vanIDDataGridViewTextBoxColumn.HeaderText = "Van ID";
            vanIDDataGridViewTextBoxColumn.Name = "vanIDDataGridViewTextBoxColumn";
            vanIDDataGridViewTextBoxColumn.ReadOnly = true;
            vanIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // vanMakeDataGridViewTextBoxColumn
            // 
            vanMakeDataGridViewTextBoxColumn.DataPropertyName = "Van_Make";
            vanMakeDataGridViewTextBoxColumn.HeaderText = "Van Make";
            vanMakeDataGridViewTextBoxColumn.Name = "vanMakeDataGridViewTextBoxColumn";
            vanMakeDataGridViewTextBoxColumn.ReadOnly = true;
            vanMakeDataGridViewTextBoxColumn.Width = 70;
            // 
            // mOTExpiryDateDataGridViewTextBoxColumn
            // 
            mOTExpiryDateDataGridViewTextBoxColumn.DataPropertyName = "MOT_Expiry_Date";
            mOTExpiryDateDataGridViewTextBoxColumn.HeaderText = "MOT Expiration Date";
            mOTExpiryDateDataGridViewTextBoxColumn.Name = "mOTExpiryDateDataGridViewTextBoxColumn";
            mOTExpiryDateDataGridViewTextBoxColumn.ReadOnly = true;
            mOTExpiryDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // driverIDDataGridViewTextBoxColumn
            // 
            driverIDDataGridViewTextBoxColumn.DataPropertyName = "DriverID";
            driverIDDataGridViewTextBoxColumn.HeaderText = "Driver ID";
            driverIDDataGridViewTextBoxColumn.Name = "driverIDDataGridViewTextBoxColumn";
            driverIDDataGridViewTextBoxColumn.ReadOnly = true;
            driverIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // isInUseDataGridViewCheckBoxColumn
            // 
            isInUseDataGridViewCheckBoxColumn.DataPropertyName = "Is_In_Use";
            isInUseDataGridViewCheckBoxColumn.HeaderText = "In Use";
            isInUseDataGridViewCheckBoxColumn.Name = "isInUseDataGridViewCheckBoxColumn";
            isInUseDataGridViewCheckBoxColumn.ReadOnly = true;
            isInUseDataGridViewCheckBoxColumn.Width = 60;
            // 
            // vanBindingSource
            // 
            vanBindingSource.DataSource = typeof(Models.Van);
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 16F);
            btnRefresh.Location = new Point(186, 480);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(200, 50);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ViewVan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(dgvVan);
            Controls.Add(btnRefresh);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewVan";
            Text = "ViewVan";
            ((System.ComponentModel.ISupportInitialize)dgvVan).EndInit();
            ((System.ComponentModel.ISupportInitialize)vanBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVan;
        private DataGridViewTextBoxColumn vanIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vanMakeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mOTExpiryDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn driverIDDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isInUseDataGridViewCheckBoxColumn;
        private BindingSource vanBindingSource;
        private Button btnRefresh;
    }
}