using Movers_Maintenance_Subsystem.AdditionalForms.Adds;
using Movers_Maintenance_Subsystem.AdditionalForms.Deletes;
using Movers_Maintenance_Subsystem.AdditionalForms.Views;
using Movers_Maintenance_Subsystem.AdditionalForms.Updates;
using Movers_Maintenance_Subsystem.AdditionalForms.Reports;
using NeaterOperations;

namespace Movers_Maintenance_Subsystem
{
    public partial class Main_Menu : Form
    {
        public static int pSize;
        public static int pSize2Small;
        public static int pSize2Large;
        //true means full size - false means only the button is visible.
        public bool CRUDSize = false;
        public bool ReportMenuOpenStatus = false;

        /// <summary>
        /// The Hub of the Program. Basically is the in and out
        /// </summary>
        public Main_Menu()
        {
            InitializeComponent();
            pSize = BaseScrollMenuPanel.Size.Width;
            pSize2Small = btnDataMenu.Size.Height;
            pSize2Large = pSize2Small * 5;
            pnlForDataManipulation.Size = new Size(pSize, pSize2Small);
            
        }

        private void btnManipulateData_Click(object sender, EventArgs e)
        {
            if (CRUDSize)
            {
                CRUDSize = false;
                pnlForDataManipulation.Size = new Size(pSize, pSize2Small);
            }
            else
            {
                CRUDSize = true;
                pnlForDataManipulation.Size = new Size(pSize, pSize2Large);
                ReportMenuOpenStatus = false;
            }
        }
        private void btnReportMenu_Click(object sender, EventArgs e)
        {
            if (ReportMenuOpenStatus)
            {
                ReportMenuOpenStatus = false;
                ReportMenu report_Menu = (ReportMenu)Application.OpenForms["ReportMenu"];
                if (report_Menu != null)
                {
                    pnlContainer.Controls.Remove(report_Menu);
                    FC.Remove(report_Menu);
                }
            }
            else
            {
                ReportMenuOpenStatus = true;

                CRUDSize = false;
                pnlForDataManipulation.Size = new Size(pSize, pSize2Small);
                ReportMenu report = new();
                FormMassClose(report, sender, e);
              
                FC.EstablishParent(this, report, pnlContainer);
                report.Show();
            }
        }
        public static bool AddMenuOpenStatus = false;
        private void btnAddDataMenu_Click(object sender, EventArgs e)
        {
            if (AddMenuOpenStatus)
            {
                AddMenuOpenStatus = false;
                //Possible "null" value is handled in such a way as to not cause errors
                AddMenuForm addMenuForm = (AddMenuForm)Application.OpenForms["AddMenuForm"];
                if (addMenuForm != null)
                {
                    pnlContainer.Controls.Remove(addMenuForm);
                    FC.Remove(addMenuForm);
                }
            }
            else
            {
                AddMenuOpenStatus = true;
                AddMenuForm add = new();
                FormMassClose(add, sender, e);
                FC.EstablishParent(this, add, pnlContainer);
                add.Show();
            }
        }
        public bool RemoveMenuOpenStatus = false;
        private void btnRemoveDataMenu_Click(object sender, EventArgs e)
        {
            if (RemoveMenuOpenStatus)
            {
                RemoveMenuOpenStatus = false;
                //Possible "null" value is handled in such a way as to not cause errors
                DeleteMenuForm removeMenuForm = (DeleteMenuForm)Application.OpenForms["DeleteMenuForm"];
                if (removeMenuForm != null)
                {
                    pnlContainer.Controls.Remove(removeMenuForm);
                    FC.Remove(removeMenuForm);
                }
            }
            else
            {
                RemoveMenuOpenStatus = true;
                DeleteMenuForm remove = new();
                FormMassClose(remove, sender, e);
                FC.EstablishParent(this, remove, pnlContainer);
                remove.Show();
            }
        }
        public bool ViewMenuOpenStatus = false;
        private void btnViewDataMenu_Click(object sender, EventArgs e)
        {
            if (ViewMenuOpenStatus)
            {
                ViewMenuOpenStatus = false;
                //Possible "null" value is handled in such a way as to not cause errors
                ViewMenuForm viewMenuForm = (ViewMenuForm)Application.OpenForms["ViewMenuForm"];
                if (viewMenuForm != null)
                {
                    pnlContainer.Controls.Remove(viewMenuForm);
                    FC.Remove(viewMenuForm);
                }
            }
            else
            {
                ViewMenuOpenStatus = true;
                ViewMenuForm view = new();
                FormMassClose(view, sender, e);
                FC.EstablishParent(this, view, pnlContainer);
                view.Show();
            }
        }
        public bool UpdateMenuOpenStatus = false;
        private void btnUpdateDataMenu_Click(object sender, EventArgs e)
        {
            if (UpdateMenuOpenStatus)
            {
                UpdateMenuOpenStatus = false;
                //Possible "null" value is handled in such a way as to not cause errors
                UpdateMenuForm updateMenuForm = (UpdateMenuForm)Application.OpenForms["UpdateMenuForm"];
                if (updateMenuForm != null)
                {
                    pnlContainer.Controls.Remove(updateMenuForm);
                    FC.Remove(updateMenuForm);
                }
            }
            else
            {
                UpdateMenuOpenStatus = true;
                UpdateMenuForm update = new();
                FormMassClose(update, sender, e);
                FC.EstablishParent(this, update, pnlContainer);
                update.Show();
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            if (FC.QueryAction("Are you sure you wish to leave the application?", "Movers"))
            {
                Environment.Exit(0);
            }
        }
        private bool SettingsOpenStatus = false;
        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (SettingsOpenStatus)
            {
                SettingsOpenStatus = false;
                //Possible "null" value is handled in such a way as to not cause errors
                SettingsForm settings = (SettingsForm)Application.OpenForms["SettingsForm"];
                if (settings != null)
                {
                    pnlContainer.Controls.Remove(settings);
                    FC.Remove(settings);
                }
            }
            else
            {
                SettingsOpenStatus = true;
                SettingsForm settings = new();
                FormMassClose(settings, sender, e);
                FC.EstablishParent(this, settings, pnlContainer);
                settings.Show();
            }
        }

        private void FormMassClose<FormType>(FormType form, object sender, EventArgs e) where FormType : Form
        {
            if (form is not AddMenuForm)
            {
                AddMenuOpenStatus = true;
                btnAddDataMenu_Click(sender, e);
            }
            if (form is not ViewMenuForm)
            {
                ViewMenuOpenStatus = true;
                btnViewDataMenu_Click(sender, e);
            }
            if (form is not UpdateMenuForm)
            {
                UpdateMenuOpenStatus = true;
                btnUpdateDataMenu_Click(sender, e);
            }
            if (form is not DeleteMenuForm)
            {
                RemoveMenuOpenStatus = true;
                btnRemoveDataMenu_Click(sender, e);
            }
            if (form is not ReportMenu)
            {
                ReportMenuOpenStatus = true;
                btnReportMenu_Click(sender, e);
            }
            if (form is not SettingsForm)
            {
                SettingsOpenStatus = true;
                btnSettings_Click(sender, e);
            }
        }
    }
}