namespace Movers_Maintenance_Subsystem
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            if (OverarchingSettings.QueryActionIsEnabled)
            {
                lblQueryActionIsEnabled.Text = "Enabled";
                lblQueryActionIsEnabled.ForeColor = Color.FromArgb(77, 221, 77);
                ChoiceQA_EnaDisa = "disable";
            }
            else
            {
                lblQueryActionIsEnabled.Text = "Disabled";
                lblQueryActionIsEnabled.ForeColor = Color.FromArgb(255, 69, 61);
                ChoiceQA_EnaDisa = "enable";
            }
            if (OverarchingSettings.ReportActionIsEnabled)
            {
                lblReportActionIsEnabled.Text = "Enabled";
                lblReportActionIsEnabled.ForeColor = Color.FromArgb(77, 221, 77);
                ChoiceRA_EnaDisa = "disable";
            }
            else
            {
                lblReportActionIsEnabled.Text = "Disabled";
                lblReportActionIsEnabled.ForeColor = Color.FromArgb(255, 69, 61);
                ChoiceRA_EnaDisa = "enable";
            }
            if (OverarchingSettings.HelpButtonsIsEnabled)
            {
                lblIsHelpEnabled.Text = "Enabled";
                lblIsHelpEnabled.ForeColor = Color.FromArgb(77, 221, 77);
                ChoiceHB_EnaDisa = "disable";
            }
            else
            {
                lblIsHelpEnabled.Text = "Disabled";
                lblIsHelpEnabled.ForeColor = Color.FromArgb(255, 69, 61);
                ChoiceHB_EnaDisa = "enable";
            }
            if (OverarchingSettings.CascadeDeletionIsEnabled)
            {
                lblCascadeDeletionIsEnabled.Text = "Enabled";
                lblCascadeDeletionIsEnabled.ForeColor = Color.FromArgb(77, 221, 77);
                ChoiceCD_EnaDisa = "disable";
            }
            else
            {
                lblCascadeDeletionIsEnabled.Text = "Disabled";
                lblCascadeDeletionIsEnabled.ForeColor = Color.FromArgb(255, 69, 61);
                ChoiceCD_EnaDisa = "enable";
            }
        }
        string ChoiceQA_EnaDisa = ""; string ChoiceRA_EnaDisa = ""; string ChoiceHB_EnaDisa = ""; string ChoiceCD_EnaDisa = "";
        private void btnDisableQueryAction_Click(object sender, EventArgs e)
        {
            if (QuerySettingsAction("Are you sure you would like to " + ChoiceQA_EnaDisa /*Disable/Enable*/ + " this setting?", "Movers"))
            {
                if (OverarchingSettings.QueryActionIsEnabled)
                {
                    OverarchingSettings.QueryActionIsEnabled = false;
                    lblQueryActionIsEnabled.Text = "Disabled";
                    lblQueryActionIsEnabled.ForeColor = Color.FromArgb(255, 69, 61);
                    ChoiceQA_EnaDisa = "enable";
                }
                else
                {
                    OverarchingSettings.QueryActionIsEnabled = true;
                    lblQueryActionIsEnabled.Text = "Enabled";
                    lblQueryActionIsEnabled.ForeColor = Color.FromArgb(77, 221, 77);
                    ChoiceQA_EnaDisa = "disable";
                }
            }
        }

        private void btnCascadeDelete_Click(object sender, EventArgs e)
        {
            if (QuerySettingsAction("Are you sure you would like to " + ChoiceCD_EnaDisa /*Disable/Enable*/ + " this setting?", "Movers"))
            {
                if (OverarchingSettings.QueryActionIsEnabled)
                {
                    OverarchingSettings.CascadeDeletionIsEnabled  = false;
                    lblCascadeDeletionIsEnabled.Text = "Disabled";
                    lblCascadeDeletionIsEnabled.ForeColor = Color.FromArgb(255, 69, 61);
                    ChoiceCD_EnaDisa = "enable";
                }
                else
                {
                    OverarchingSettings.CascadeDeletionIsEnabled  = true;
                    lblCascadeDeletionIsEnabled.Text = "Enabled";
                    lblCascadeDeletionIsEnabled.ForeColor = Color.FromArgb(77, 221, 77);
                    ChoiceCD_EnaDisa = "disable";
                }
            }
        }

        private bool QuerySettingsAction(string Message, string Title)
        {
            DialogResult dialogResult = MessageBox.Show(Message, Title, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnDisableActionReports_Click(object sender, EventArgs e)
        {
            if (QuerySettingsAction("Are you sure you would like to " + ChoiceRA_EnaDisa /*Enable/Disable*/+ " this setting?", "Movers"))
            {
                if (OverarchingSettings.ReportActionIsEnabled)
                {
                    lblReportActionIsEnabled.Text = "Enabled";
                    lblReportActionIsEnabled.ForeColor = Color.FromArgb(77, 221, 77);
                    ChoiceRA_EnaDisa = "disable";
                }
                else
                {
                    lblReportActionIsEnabled.Text = "Disabled";
                    lblReportActionIsEnabled.ForeColor = Color.FromArgb(255, 69, 61);
                    ChoiceRA_EnaDisa = "enable";
                }
            }
        }

        private void btnDisableHelpBtns_Click(object sender, EventArgs e)
        {
            if (QuerySettingsAction("Are you sure you would like to " + ChoiceHB_EnaDisa /*Enable/Disable*/+ " this setting?", "Movers"))
            {
                if (OverarchingSettings.HelpButtonsIsEnabled)
                {
                    lblIsHelpEnabled.Text = "Enabled";
                    lblIsHelpEnabled.ForeColor = Color.FromArgb(77, 221, 77);
                    ChoiceHB_EnaDisa = "disable";
                }
                else
                {
                    lblIsHelpEnabled.Text = "Disabled";
                    lblIsHelpEnabled.ForeColor = Color.FromArgb(255, 69, 61);
                    ChoiceHB_EnaDisa = "enable";
                }
            }
        }
    }
}
