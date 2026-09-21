namespace Movers_Maintenance_Subsystem.AdditionalForms.Reports
{
    partial class ReportStaff
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
            btnReport = new Button();
            cbbxPosition = new ComboBox();
            lblPosition = new Label();
            RptStaff = new Panel();
            btnHELP = new Button();
            RptStaff.SuspendLayout();
            SuspendLayout();
            // 
            // btnReport
            // 
            btnReport.Font = new Font("Segoe UI", 16F);
            btnReport.Location = new Point(175, 380);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(200, 100);
            btnReport.TabIndex = 11;
            btnReport.Text = "Obtain Report for Staff Members";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // cbbxPosition
            // 
            cbbxPosition.FlatStyle = FlatStyle.Flat;
            cbbxPosition.Font = new Font("Segoe UI", 16F);
            cbbxPosition.FormattingEnabled = true;
            cbbxPosition.Items.AddRange(new object[] { "Driver", "Mechanic", "Maintenance Manager", "CEO" });
            cbbxPosition.Location = new Point(190, 190);
            cbbxPosition.Name = "cbbxPosition";
            cbbxPosition.Size = new Size(240, 38);
            cbbxPosition.TabIndex = 48;
            // 
            // lblPosition
            // 
            lblPosition.BackColor = Color.FromArgb(84, 84, 84);
            lblPosition.Font = new Font("Segoe UI", 16F);
            lblPosition.ForeColor = Color.White;
            lblPosition.Location = new Point(70, 190);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(120, 38);
            lblPosition.TabIndex = 47;
            lblPosition.Text = "Position:";
            lblPosition.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RptStaff
            // 
            RptStaff.BackColor = Color.FromArgb(84, 84, 84);
            RptStaff.Controls.Add(btnHELP);
            RptStaff.Controls.Add(btnReport);
            RptStaff.Controls.Add(cbbxPosition);
            RptStaff.Controls.Add(lblPosition);
            RptStaff.Location = new Point(30, 20);
            RptStaff.Name = "RptStaff";
            RptStaff.Size = new Size(510, 500);
            RptStaff.TabIndex = 65;
            // 
            // btnHELP
            // 
            btnHELP.Font = new Font("Segoe UI", 16F);
            btnHELP.Location = new Point(390, 20);
            btnHELP.Name = "btnHELP";
            btnHELP.Size = new Size(100, 50);
            btnHELP.TabIndex = 62;
            btnHELP.Text = "Help";
            btnHELP.UseVisualStyleBackColor = true;
            btnHELP.Click += btnHELP_Click;
            // 
            // ReportStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 74, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(RptStaff);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportStaff";
            Text = "ReportStaff";
            RptStaff.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnReport;
        private ComboBox cbbxPosition;
        private Label lblPosition;
        private Panel RptStaff;
        private Button btnHELP;
    }
}