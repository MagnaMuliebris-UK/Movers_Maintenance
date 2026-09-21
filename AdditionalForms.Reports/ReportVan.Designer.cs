namespace Movers_Maintenance_Subsystem.AdditionalForms.Reports
{
    partial class ReportVan
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
            RptVan = new Panel();
            updnDriverID = new NumericUpDown();
            btnHELP = new Button();
            btnReport = new Button();
            lblDriverID = new Label();
            RptVan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updnDriverID).BeginInit();
            SuspendLayout();
            // 
            // RptVan
            // 
            RptVan.BackColor = Color.FromArgb(84, 84, 84);
            RptVan.Controls.Add(updnDriverID);
            RptVan.Controls.Add(btnHELP);
            RptVan.Controls.Add(btnReport);
            RptVan.Controls.Add(lblDriverID);
            RptVan.Location = new Point(30, 25);
            RptVan.Name = "RptVan";
            RptVan.Size = new Size(510, 500);
            RptVan.TabIndex = 66;
            // 
            // updnDriverID
            // 
            updnDriverID.Font = new Font("Segoe UI", 16F);
            updnDriverID.Location = new Point(190, 191);
            updnDriverID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updnDriverID.Name = "updnDriverID";
            updnDriverID.Size = new Size(240, 36);
            updnDriverID.TabIndex = 64;
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
            btnReport.Location = new Point(115, 430);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(300, 50);
            btnReport.TabIndex = 11;
            btnReport.Text = "Obtain Report for Vans";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // lblDriverID
            // 
            lblDriverID.BackColor = Color.FromArgb(84, 84, 84);
            lblDriverID.Font = new Font("Segoe UI", 16F);
            lblDriverID.ForeColor = Color.White;
            lblDriverID.Location = new Point(70, 190);
            lblDriverID.Name = "lblDriverID";
            lblDriverID.Size = new Size(120, 38);
            lblDriverID.TabIndex = 47;
            lblDriverID.Text = "Driver ID:";
            lblDriverID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ReportVan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 74, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(RptVan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportVan";
            Text = "ReportVan";
            RptVan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)updnDriverID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel RptVan;
        private Button btnHELP;
        private Button btnReport;
        private Label lblDriverID;
        private NumericUpDown updnDriverID;
    }
}