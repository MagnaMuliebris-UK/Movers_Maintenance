namespace Movers_Maintenance_Subsystem
{
    partial class SettingsForm
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
            btnDisableQueryAction = new Button();
            lblQueryActionIsEnabled = new Label();
            lblSettingsTitle = new Label();
            lblReportActionIsEnabled = new Label();
            btnDisableActionReports = new Button();
            lblIsHelpEnabled = new Label();
            btnDisableHelpBtns = new Button();
            SuspendLayout();
            // 
            // btnDisableQueryAction
            // 
            btnDisableQueryAction.BackColor = Color.Gainsboro;
            btnDisableQueryAction.FlatAppearance.BorderColor = Color.Silver;
            btnDisableQueryAction.FlatStyle = FlatStyle.Flat;
            btnDisableQueryAction.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDisableQueryAction.Location = new Point(205, 120);
            btnDisableQueryAction.Name = "btnDisableQueryAction";
            btnDisableQueryAction.Size = new Size(300, 50);
            btnDisableQueryAction.TabIndex = 0;
            btnDisableQueryAction.Text = "Query Most Actions";
            btnDisableQueryAction.UseVisualStyleBackColor = false;
            btnDisableQueryAction.Click += btnDisableQueryAction_Click;
            // 
            // lblQueryActionIsEnabled
            // 
            lblQueryActionIsEnabled.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblQueryActionIsEnabled.Location = new Point(205, 180);
            lblQueryActionIsEnabled.Name = "lblQueryActionIsEnabled";
            lblQueryActionIsEnabled.Size = new Size(300, 30);
            lblQueryActionIsEnabled.TabIndex = 1;
            lblQueryActionIsEnabled.Text = "Enabled";
            lblQueryActionIsEnabled.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSettingsTitle
            // 
            lblSettingsTitle.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblSettingsTitle.ForeColor = Color.Gainsboro;
            lblSettingsTitle.Location = new Point(0, 0);
            lblSettingsTitle.Name = "lblSettingsTitle";
            lblSettingsTitle.Size = new Size(710, 70);
            lblSettingsTitle.TabIndex = 2;
            lblSettingsTitle.Text = "Settings";
            lblSettingsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReportActionIsEnabled
            // 
            lblReportActionIsEnabled.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblReportActionIsEnabled.Location = new Point(205, 460);
            lblReportActionIsEnabled.Name = "lblReportActionIsEnabled";
            lblReportActionIsEnabled.Size = new Size(300, 30);
            lblReportActionIsEnabled.TabIndex = 4;
            lblReportActionIsEnabled.Text = "Enabled";
            lblReportActionIsEnabled.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDisableActionReports
            // 
            btnDisableActionReports.BackColor = Color.Gainsboro;
            btnDisableActionReports.FlatAppearance.BorderColor = Color.Silver;
            btnDisableActionReports.FlatStyle = FlatStyle.Flat;
            btnDisableActionReports.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDisableActionReports.Location = new Point(205, 400);
            btnDisableActionReports.Name = "btnDisableActionReports";
            btnDisableActionReports.Size = new Size(300, 50);
            btnDisableActionReports.TabIndex = 3;
            btnDisableActionReports.Text = "Report Successful Actions";
            btnDisableActionReports.UseVisualStyleBackColor = false;
            btnDisableActionReports.Click += btnDisableActionReports_Click;
            // 
            // lblIsHelpEnabled
            // 
            lblIsHelpEnabled.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblIsHelpEnabled.Location = new Point(205, 320);
            lblIsHelpEnabled.Name = "lblIsHelpEnabled";
            lblIsHelpEnabled.Size = new Size(300, 30);
            lblIsHelpEnabled.TabIndex = 6;
            lblIsHelpEnabled.Text = "Enabled";
            lblIsHelpEnabled.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDisableHelpBtns
            // 
            btnDisableHelpBtns.BackColor = Color.Gainsboro;
            btnDisableHelpBtns.FlatAppearance.BorderColor = Color.Silver;
            btnDisableHelpBtns.FlatStyle = FlatStyle.Flat;
            btnDisableHelpBtns.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDisableHelpBtns.Location = new Point(205, 260);
            btnDisableHelpBtns.Name = "btnDisableHelpBtns";
            btnDisableHelpBtns.Size = new Size(300, 50);
            btnDisableHelpBtns.TabIndex = 5;
            btnDisableHelpBtns.Text = "Show Help Buttons";
            btnDisableHelpBtns.UseVisualStyleBackColor = false;
            btnDisableHelpBtns.Click += btnDisableHelpBtns_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(710, 550);
            ControlBox = false;
            Controls.Add(lblIsHelpEnabled);
            Controls.Add(btnDisableHelpBtns);
            Controls.Add(lblReportActionIsEnabled);
            Controls.Add(btnDisableActionReports);
            Controls.Add(lblSettingsTitle);
            Controls.Add(lblQueryActionIsEnabled);
            Controls.Add(btnDisableQueryAction);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            Text = "Report_Staff";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDisableQueryAction;
        private Label lblQueryActionIsEnabled;
        private Label lblSettingsTitle;
        private Label lblReportActionIsEnabled;
        private Button btnDisableActionReports;
        private Label lblIsHelpEnabled;
        private Button btnDisableHelpBtns;
    }
}