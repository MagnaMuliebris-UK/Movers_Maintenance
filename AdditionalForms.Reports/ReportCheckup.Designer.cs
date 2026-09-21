namespace Movers_Maintenance_Subsystem.AdditionalForms.Reports
{
    partial class ReportCheckup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportCheckup));
            pnlRptCheckup = new Panel();
            txtbxCDate = new TextBox();
            lblCDate = new Label();
            lblHelpMessageShow = new Label();
            btnBeAeEBiAi = new Button();
            btnHELP = new Button();
            btnReport = new Button();
            pnlRptCheckup.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRptCheckup
            // 
            pnlRptCheckup.BackColor = Color.FromArgb(84, 84, 84);
            pnlRptCheckup.Controls.Add(txtbxCDate);
            pnlRptCheckup.Controls.Add(lblCDate);
            pnlRptCheckup.Controls.Add(lblHelpMessageShow);
            pnlRptCheckup.Controls.Add(btnBeAeEBiAi);
            pnlRptCheckup.Controls.Add(btnHELP);
            pnlRptCheckup.Controls.Add(btnReport);
            pnlRptCheckup.Location = new Point(30, 25);
            pnlRptCheckup.Name = "pnlRptCheckup";
            pnlRptCheckup.Size = new Size(510, 500);
            pnlRptCheckup.TabIndex = 66;
            // 
            // txtbxCDate
            // 
            txtbxCDate.Font = new Font("Segoe UI", 16F);
            txtbxCDate.Location = new Point(220, 120);
            txtbxCDate.Name = "txtbxCDate";
            txtbxCDate.PlaceholderText = "dd-mm-yyyy";
            txtbxCDate.Size = new Size(240, 36);
            txtbxCDate.TabIndex = 66;
            // 
            // lblCDate
            // 
            lblCDate.BackColor = Color.FromArgb(84, 84, 84);
            lblCDate.Font = new Font("Segoe UI", 16F);
            lblCDate.ForeColor = Color.White;
            lblCDate.Location = new Point(50, 120);
            lblCDate.Name = "lblCDate";
            lblCDate.Size = new Size(172, 38);
            lblCDate.TabIndex = 65;
            lblCDate.Text = "Checkup Date:";
            lblCDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHelpMessageShow
            // 
            lblHelpMessageShow.Font = new Font("Segoe UI", 12F);
            lblHelpMessageShow.ForeColor = Color.Gainsboro;
            lblHelpMessageShow.Location = new Point(0, 173);
            lblHelpMessageShow.Name = "lblHelpMessageShow";
            lblHelpMessageShow.Size = new Size(510, 153);
            lblHelpMessageShow.TabIndex = 64;
            lblHelpMessageShow.Text = resources.GetString("lblHelpMessageShow.Text");
            lblHelpMessageShow.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnBeAeEBiAi
            // 
            btnBeAeEBiAi.Font = new Font("Segoe UI", 14F);
            btnBeAeEBiAi.Location = new Point(175, 360);
            btnBeAeEBiAi.Name = "btnBeAeEBiAi";
            btnBeAeEBiAi.Size = new Size(200, 35);
            btnBeAeEBiAi.TabIndex = 63;
            btnBeAeEBiAi.Text = "Before (Exclusive)";
            btnBeAeEBiAi.UseVisualStyleBackColor = true;
            btnBeAeEBiAi.Click += btn_Click;
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
            // btnReport
            // 
            btnReport.Font = new Font("Segoe UI", 16F);
            btnReport.Location = new Point(125, 430);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(300, 50);
            btnReport.TabIndex = 11;
            btnReport.Text = "Obtain Report for Checkups";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // ReportCheckup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 74, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(pnlRptCheckup);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportCheckup";
            Text = "ReportCheckup";
            pnlRptCheckup.ResumeLayout(false);
            pnlRptCheckup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private Button button1;
        private Panel pnlRptCheckup;
        private Button btnBeAeEBiAi;
        private Button btnHELP;
        private Button btnReport;
        private Label lblHelpMessageShow;
        private TextBox txtbxCDate;
        private Label lblCDate;
    }
}