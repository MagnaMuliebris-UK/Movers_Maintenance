namespace Movers_Maintenance_Subsystem.AdditionalForms.Views
{
    partial class ViewCheckupCjtItem
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
            dgvIiC = new DataGridView();
            itemIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkupIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            QuantityUsed = new DataGridViewTextBoxColumn();
            itemsInCheckupBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvIiC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemsInCheckupBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 16F);
            btnRefresh.Location = new Point(185, 480);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(200, 50);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvIiC
            // 
            dgvIiC.AllowUserToAddRows = false;
            dgvIiC.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvIiC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvIiC.AutoGenerateColumns = false;
            dgvIiC.BackgroundColor = Color.FromArgb(74, 74, 74);
            dgvIiC.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvIiC.Columns.AddRange(new DataGridViewColumn[] { itemIDDataGridViewTextBoxColumn, checkupIDDataGridViewTextBoxColumn, QuantityUsed });
            dgvIiC.DataSource = itemsInCheckupBindingSource;
            dgvIiC.GridColor = Color.Gainsboro;
            dgvIiC.Location = new Point(0, 0);
            dgvIiC.Margin = new Padding(0);
            dgvIiC.Name = "dgvIiC";
            dgvIiC.ReadOnly = true;
            dgvIiC.RowHeadersWidth = 30;
            dgvIiC.Size = new Size(570, 460);
            dgvIiC.TabIndex = 11;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkupIDDataGridViewTextBoxColumn
            // 
            checkupIDDataGridViewTextBoxColumn.DataPropertyName = "CheckupID";
            checkupIDDataGridViewTextBoxColumn.HeaderText = "CheckupID";
            checkupIDDataGridViewTextBoxColumn.Name = "checkupIDDataGridViewTextBoxColumn";
            checkupIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // QuantityUsed
            // 
            QuantityUsed.DataPropertyName = "QuantityUsed";
            QuantityUsed.HeaderText = "Quantity Used";
            QuantityUsed.Name = "QuantityUsed";
            QuantityUsed.ReadOnly = true;
            // 
            // itemsInCheckupBindingSource
            // 
            itemsInCheckupBindingSource.DataSource = typeof(Models.ItemsInCheckup);
            // 
            // ViewCheckupCjtItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(btnRefresh);
            Controls.Add(dgvIiC);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewCheckupCjtItem";
            Text = "ViewCheckupCjtItem";
            ((System.ComponentModel.ISupportInitialize)dgvIiC).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemsInCheckupBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private DataGridView dgvIiC;
        private DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkupIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private BindingSource itemsInCheckupBindingSource;
        private DataGridViewTextBoxColumn QuantityUsed;
    }
}