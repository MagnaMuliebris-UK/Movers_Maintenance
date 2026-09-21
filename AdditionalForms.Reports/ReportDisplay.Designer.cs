namespace Movers_Maintenance_Subsystem.AdditionalForms.Reports
{
    partial class ReportDisplay
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
            pctbxHoldReport = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctbxHoldReport).BeginInit();
            SuspendLayout();
            // 
            // pctbxHoldReport
            // 
            pctbxHoldReport.BackColor = Color.FromArgb(84, 84, 84);
            pctbxHoldReport.Dock = DockStyle.Fill;
            pctbxHoldReport.Location = new Point(0, 0);
            pctbxHoldReport.Margin = new Padding(0);
            pctbxHoldReport.Name = "pctbxHoldReport";
            pctbxHoldReport.Size = new Size(500, 470);
            pctbxHoldReport.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbxHoldReport.TabIndex = 0;
            pctbxHoldReport.TabStop = false;
            // 
            // ReportDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 74, 84);
            ClientSize = new Size(500, 470);
            Controls.Add(pctbxHoldReport);
            Name = "ReportDisplay";
            Text = "Movers - Printed Report";
            ((System.ComponentModel.ISupportInitialize)pctbxHoldReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctbxHoldReport;
    }
}