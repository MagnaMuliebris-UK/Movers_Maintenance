namespace Movers_Maintenance_Subsystem.AdditionalForms.Reports
{
    partial class ReportMenu
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
            pnlSelect = new Panel();
            btnThatHidesStuff = new Button();
            btnReportFrmCheckup = new Button();
            btnReportFrmVan = new Button();
            btnReportFrmStaff = new Button();
            pnlContainer = new Panel();
            pnlSelect.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSelect
            // 
            pnlSelect.BackColor = Color.FromArgb(64, 64, 64);
            pnlSelect.Controls.Add(btnThatHidesStuff);
            pnlSelect.Controls.Add(btnReportFrmCheckup);
            pnlSelect.Controls.Add(btnReportFrmVan);
            pnlSelect.Controls.Add(btnReportFrmStaff);
            pnlSelect.Dock = DockStyle.Left;
            pnlSelect.Location = new Point(0, 0);
            pnlSelect.Name = "pnlSelect";
            pnlSelect.Size = new Size(140, 550);
            pnlSelect.TabIndex = 7;
            // 
            // btnThatHidesStuff
            // 
            btnThatHidesStuff.BackColor = Color.Silver;
            btnThatHidesStuff.Dock = DockStyle.Top;
            btnThatHidesStuff.FlatAppearance.BorderColor = Color.FromArgb(172, 172, 172);
            btnThatHidesStuff.FlatStyle = FlatStyle.Flat;
            btnThatHidesStuff.Font = new Font("Segoe UI", 14F);
            btnThatHidesStuff.Location = new Point(0, 255);
            btnThatHidesStuff.Name = "btnThatHidesStuff";
            btnThatHidesStuff.Size = new Size(140, 35);
            btnThatHidesStuff.TabIndex = 9;
            btnThatHidesStuff.Text = "↑";
            btnThatHidesStuff.UseVisualStyleBackColor = false;
            btnThatHidesStuff.Click += btnThatHidesStuff_Click;
            // 
            // btnReportFrmCheckup
            // 
            btnReportFrmCheckup.BackColor = Color.FromArgb(210, 210, 210);
            btnReportFrmCheckup.Dock = DockStyle.Top;
            btnReportFrmCheckup.FlatAppearance.BorderColor = Color.FromArgb(190, 190, 190);
            btnReportFrmCheckup.FlatStyle = FlatStyle.Flat;
            btnReportFrmCheckup.Font = new Font("Segoe UI", 14F);
            btnReportFrmCheckup.Location = new Point(0, 170);
            btnReportFrmCheckup.Name = "btnReportFrmCheckup";
            btnReportFrmCheckup.Size = new Size(140, 85);
            btnReportFrmCheckup.TabIndex = 4;
            btnReportFrmCheckup.Text = "Reports for Checkups";
            btnReportFrmCheckup.UseVisualStyleBackColor = false;
            btnReportFrmCheckup.Click += btnReportFrmCheckup_Click;
            // 
            // btnReportFrmVan
            // 
            btnReportFrmVan.BackColor = Color.FromArgb(210, 210, 210);
            btnReportFrmVan.Dock = DockStyle.Top;
            btnReportFrmVan.FlatAppearance.BorderColor = Color.FromArgb(190, 190, 190);
            btnReportFrmVan.FlatStyle = FlatStyle.Flat;
            btnReportFrmVan.Font = new Font("Segoe UI", 14F);
            btnReportFrmVan.Location = new Point(0, 85);
            btnReportFrmVan.Name = "btnReportFrmVan";
            btnReportFrmVan.Size = new Size(140, 85);
            btnReportFrmVan.TabIndex = 3;
            btnReportFrmVan.Text = "Reports for Vans";
            btnReportFrmVan.UseVisualStyleBackColor = false;
            btnReportFrmVan.Click += btnReportFrmVan_Click;
            // 
            // btnReportFrmStaff
            // 
            btnReportFrmStaff.BackColor = Color.FromArgb(210, 210, 210);
            btnReportFrmStaff.Dock = DockStyle.Top;
            btnReportFrmStaff.FlatAppearance.BorderColor = Color.FromArgb(190, 190, 190);
            btnReportFrmStaff.FlatStyle = FlatStyle.Flat;
            btnReportFrmStaff.Font = new Font("Segoe UI", 14F);
            btnReportFrmStaff.Location = new Point(0, 0);
            btnReportFrmStaff.Name = "btnReportFrmStaff";
            btnReportFrmStaff.Size = new Size(140, 85);
            btnReportFrmStaff.TabIndex = 2;
            btnReportFrmStaff.Text = "Reports for Staff Members";
            btnReportFrmStaff.UseVisualStyleBackColor = false;
            btnReportFrmStaff.Click += btnReportFrmStaff_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(74, 74, 74);
            pnlContainer.Dock = DockStyle.Right;
            pnlContainer.Location = new Point(140, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(570, 550);
            pnlContainer.TabIndex = 8;
            // 
            // ReportMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 550);
            Controls.Add(pnlContainer);
            Controls.Add(pnlSelect);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportMenu";
            Text = "ReportMenu";
            pnlSelect.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSelect;
        private Button btnThatHidesStuff;
        private Button btnReportFrmCheckup;
        private Button btnReportFrmVan;
        private Button btnReportFrmStaff;
        private Panel pnlContainer;
    }
}