namespace Movers_Maintenance_Subsystem.AdditionalForms.Views
{
    partial class ViewSession
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
            dgvSession = new DataGridView();
            sessionIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sessionTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sessionDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sessionBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvSession).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sessionBindingSource).BeginInit();
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
            // dgvSession
            // 
            dgvSession.AllowUserToAddRows = false;
            dgvSession.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvSession.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSession.AutoGenerateColumns = false;
            dgvSession.BackgroundColor = Color.FromArgb(74, 74, 74);
            dgvSession.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvSession.Columns.AddRange(new DataGridViewColumn[] { sessionIDDataGridViewTextBoxColumn, sessionTypeDataGridViewTextBoxColumn, sessionDateDataGridViewTextBoxColumn });
            dgvSession.DataSource = sessionBindingSource;
            dgvSession.GridColor = Color.Gainsboro;
            dgvSession.Location = new Point(0, 0);
            dgvSession.Margin = new Padding(0);
            dgvSession.Name = "dgvSession";
            dgvSession.ReadOnly = true;
            dgvSession.RowHeadersWidth = 30;
            dgvSession.Size = new Size(570, 460);
            dgvSession.TabIndex = 11;
            // 
            // sessionIDDataGridViewTextBoxColumn
            // 
            sessionIDDataGridViewTextBoxColumn.DataPropertyName = "SessionID";
            sessionIDDataGridViewTextBoxColumn.HeaderText = "Session ID";
            sessionIDDataGridViewTextBoxColumn.Name = "sessionIDDataGridViewTextBoxColumn";
            sessionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionTypeDataGridViewTextBoxColumn
            // 
            sessionTypeDataGridViewTextBoxColumn.DataPropertyName = "SessionType";
            sessionTypeDataGridViewTextBoxColumn.HeaderText = "Session Type";
            sessionTypeDataGridViewTextBoxColumn.Name = "sessionTypeDataGridViewTextBoxColumn";
            sessionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionDateDataGridViewTextBoxColumn
            // 
            sessionDateDataGridViewTextBoxColumn.DataPropertyName = "SessionDate";
            sessionDateDataGridViewTextBoxColumn.HeaderText = "Session Date";
            sessionDateDataGridViewTextBoxColumn.Name = "sessionDateDataGridViewTextBoxColumn";
            sessionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionBindingSource
            // 
            sessionBindingSource.DataSource = typeof(Models.Session);
            // 
            // ViewSession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(btnRefresh);
            Controls.Add(dgvSession);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewSession";
            Text = "ViewSession";
            ((System.ComponentModel.ISupportInitialize)dgvSession).EndInit();
            ((System.ComponentModel.ISupportInitialize)sessionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private DataGridView dgvSession;
        private BindingSource sessionBindingSource;
        private DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sessionTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sessionDateDataGridViewTextBoxColumn;
    }
}