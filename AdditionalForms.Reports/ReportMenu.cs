using Movers_Maintenance_Subsystem.AdditionalForms.Views;
using NeaterOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Reports
{
    public partial class ReportMenu : Form
    {
        #region Bools For Form Open + Close + Also to hide the hideousness of the UI bool too...
        private bool StaffOpen = false;
        private bool VanOpen = false;
        private bool CheckupOpen = false;
        private bool ShowTheUI = true;
        #endregion Bools For Form Open + Close + Also to hide the hideousness of the UI bool too...
        private int height = 0;
        public ReportMenu()
        {
            InitializeComponent();
            height = btnReportFrmStaff.Height;
        }

        private void btnThatHidesStuff_Click(object sender, EventArgs e)
        {
            List<Button> btns = new List<Button> { btnReportFrmStaff, btnReportFrmVan, btnReportFrmCheckup };
            if (ShowTheUI)
            {
                ShowTheUI = false;
                foreach (var b in btns)
                {
                    b.Height = 0;
                }
                btnThatHidesStuff.Text = "↓";
            }
            else
            {
                ShowTheUI = true;
                foreach (var b in btns)
                {
                    b.Height = height;
                }
                btnThatHidesStuff.Text = "↑";
            }
        }

        private void btnReportFrmStaff_Click(object sender, EventArgs e)
        {
            if (StaffOpen)
            {
                StaffOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                ReportStaff s = (ReportStaff)Application.OpenForms["ReportStaff"];
                if (s != null)
                {
                    pnlContainer.Controls.Remove(s);
                    FC.Remove(s);
                }
            }
            else
            {
                StaffOpen = true;
                ReportStaff s = new ReportStaff();
                FormMassClose(s, sender, e);
                FormOpen(s);
            }
        }

        private void btnReportFrmVan_Click(object sender, EventArgs e)
        {
            if (VanOpen)
            {
                VanOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                ReportVan v = (ReportVan)Application.OpenForms["ReportVan"];
                if (v != null)
                {
                    pnlContainer.Controls.Remove(v);
                    FC.Remove(v);
                }
            }
            else
            {
                VanOpen = true;
                ReportVan v = new ReportVan();
                FormMassClose(v, sender, e);
                FormOpen(v);
            }
        }

        private void btnReportFrmCheckup_Click(object sender, EventArgs e)
        {
            if (CheckupOpen)
            {
                CheckupOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                ReportCheckup c = (ReportCheckup)Application.OpenForms["ReportCheckup"];
                if (c != null)
                {
                    pnlContainer.Controls.Remove(c);
                    FC.Remove(c);
                }
            }
            else
            {
                CheckupOpen = true;
                ReportCheckup c = new ReportCheckup();
                FormMassClose(c, sender, e);
                FormOpen(c);
            }
        }

        private void FormMassClose<FormType>(FormType form, object sender, EventArgs e) where FormType : Form
        {
            if (form is not ReportStaff)
            {
                StaffOpen = true;
                btnReportFrmStaff_Click(sender, e);
            }
            if (form is not ReportVan)
            {
                VanOpen = true;
                btnReportFrmVan_Click(sender, e);
            }
            if (form is not ReportCheckup)
            {
                CheckupOpen = true;
                btnReportFrmCheckup_Click(sender, e);
            }
        }
        private void FormOpen<FormT>(FormT form) where FormT : Form
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(form);
            form.Show();
        }
    }
}
