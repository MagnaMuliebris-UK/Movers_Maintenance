namespace Movers_Maintenance_Subsystem.AdditionalForms.Views
{
    partial class ViewSessionCjtStaff
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
            btnRefresh = new Button();
            dGVSiS = new DataGridView();
            sessionIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            staffIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            trainerIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            staffInSessionsBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dGVSiS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)staffInSessionsBindingSource).BeginInit();
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
            // dGVSiS
            // 
            dGVSiS.AutoGenerateColumns = false;
            dGVSiS.BackgroundColor = Color.FromArgb(74, 74, 74);
            dGVSiS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVSiS.Columns.AddRange(new DataGridViewColumn[] { sessionIDDataGridViewTextBoxColumn, staffIDDataGridViewTextBoxColumn, trainerIDDataGridViewTextBoxColumn });
            dGVSiS.DataSource = staffInSessionsBindingSource;
            dGVSiS.Location = new Point(0, 0);
            dGVSiS.Name = "dGVSiS";
            dGVSiS.Size = new Size(570, 460);
            dGVSiS.TabIndex = 13;
            // 
            // sessionIDDataGridViewTextBoxColumn
            // 
            sessionIDDataGridViewTextBoxColumn.DataPropertyName = "SessionID";
            sessionIDDataGridViewTextBoxColumn.HeaderText = "Session ID";
            sessionIDDataGridViewTextBoxColumn.Name = "sessionIDDataGridViewTextBoxColumn";
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            staffIDDataGridViewTextBoxColumn.HeaderText = "Staff ID";
            staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            // 
            // trainerIDDataGridViewTextBoxColumn
            // 
            trainerIDDataGridViewTextBoxColumn.DataPropertyName = "TrainerID";
            trainerIDDataGridViewTextBoxColumn.HeaderText = "Trainer ID";
            trainerIDDataGridViewTextBoxColumn.Name = "trainerIDDataGridViewTextBoxColumn";
            // 
            // staffInSessionsBindingSource
            // 
            staffInSessionsBindingSource.DataSource = typeof(Models.StaffInSessions);
            // 
            // ViewSessionCjtStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(dGVSiS);
            Controls.Add(btnRefresh);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewSessionCjtStaff";
            Text = "ViewSessionCjtStaff";
            ((System.ComponentModel.ISupportInitialize)dGVSiS).EndInit();
            ((System.ComponentModel.ISupportInitialize)staffInSessionsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private DataGridView dGVSiS;
        private DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trainerIDDataGridViewTextBoxColumn;
        private BindingSource staffInSessionsBindingSource;
    }
}