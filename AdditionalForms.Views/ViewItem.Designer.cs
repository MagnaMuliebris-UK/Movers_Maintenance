namespace Movers_Maintenance_Subsystem.AdditionalForms.Views
{
    partial class ViewItem
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
            dgvItem = new DataGridView();
            itemIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            currentQuantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idealQuantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
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
            // dgvItem
            // 
            dgvItem.AllowUserToAddRows = false;
            dgvItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvItem.AutoGenerateColumns = false;
            dgvItem.BackgroundColor = Color.FromArgb(74, 74, 74);
            dgvItem.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvItem.Columns.AddRange(new DataGridViewColumn[] { itemIDDataGridViewTextBoxColumn, itemNameDataGridViewTextBoxColumn, itemDescriptionDataGridViewTextBoxColumn, currentQuantityDataGridViewTextBoxColumn, idealQuantityDataGridViewTextBoxColumn });
            dgvItem.DataSource = itemBindingSource;
            dgvItem.GridColor = Color.Gainsboro;
            dgvItem.Location = new Point(0, 0);
            dgvItem.Margin = new Padding(0);
            dgvItem.Name = "dgvItem";
            dgvItem.ReadOnly = true;
            dgvItem.RowHeadersWidth = 30;
            dgvItem.Size = new Size(570, 460);
            dgvItem.TabIndex = 11;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            itemIDDataGridViewTextBoxColumn.HeaderText = "Item ID";
            itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            itemIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            itemNameDataGridViewTextBoxColumn.HeaderText = "Name";
            itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription";
            itemDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            itemDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentQuantityDataGridViewTextBoxColumn
            // 
            currentQuantityDataGridViewTextBoxColumn.DataPropertyName = "CurrentQuantity";
            currentQuantityDataGridViewTextBoxColumn.HeaderText = "Current Quantity";
            currentQuantityDataGridViewTextBoxColumn.Name = "currentQuantityDataGridViewTextBoxColumn";
            currentQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            currentQuantityDataGridViewTextBoxColumn.Width = 110;
            // 
            // idealQuantityDataGridViewTextBoxColumn
            // 
            idealQuantityDataGridViewTextBoxColumn.DataPropertyName = "IdealQuantity";
            idealQuantityDataGridViewTextBoxColumn.HeaderText = "Ideal Quantity";
            idealQuantityDataGridViewTextBoxColumn.Name = "idealQuantityDataGridViewTextBoxColumn";
            idealQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(Models.Item);
            // 
            // ViewItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(btnRefresh);
            Controls.Add(dgvItem);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewItem";
            Text = "ViewItem";
            ((System.ComponentModel.ISupportInitialize)dgvItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private DataGridView dgvItem;
        private BindingSource itemBindingSource;
        private DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idealQuantityDataGridViewTextBoxColumn;
    }
}