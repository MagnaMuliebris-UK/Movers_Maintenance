using NeaterOperations;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Views
{
    public partial class ViewMenuForm : Form
    {
        #region Bools For Form Open + Close + Also to hide the hideousness of the UI bool too...
        private bool StaffOpen = false;
        private bool VanOpen = false;
        private bool CheckupOpen = false;
        private bool ItemOpen = false;
        private bool SessionOpen = false;
        private bool SiSOpen = false;
        private bool IiCOpen = false;
        private bool ShowTheUI = true;
        #endregion Bools For Form Open + Close + Also to hide the hideousness of the UI bool too...
        private int height = 0;
        public ViewMenuForm()
        {
            InitializeComponent();
            height = btnViewFrmCheckup.Height;
        }

        private void btnThatHidesStuff_Click(object sender, EventArgs e)
        {
            List<Button> btns = new List<Button> { btnViewFrmStaff, btnViewFrmVan, btnViewFrmCheckup, btnViewFrmItem, btnViewFrmSession, btnViewFrmSiS, btnViewFrmIiC };
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

        private void btnViewFrmStaff_Click(object sender, EventArgs e)
        {
            if (StaffOpen)
            {
                StaffOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                ViewStaff s = (ViewStaff)Application.OpenForms["ViewStaff"];
                if (s != null)
                {
                    pnlContainer.Controls.Remove(s);
                    FC.Remove(s);
                }
            }
            else
            {
                StaffOpen = true;
                ViewStaff s = new ViewStaff();
                FormMassClose(s, sender, e);
                FormOpen(s);
            }
        }

        private void btnViewFrmVan_Click(object sender, EventArgs e)

        {
            if (VanOpen)
            {
                VanOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                ViewVan v = (ViewVan)Application.OpenForms["ViewVan"];
                if (v != null)
                {
                    pnlContainer.Controls.Remove(v);
                    FC.Remove(v);
                }
            }
            else
            {
                VanOpen = true;
                ViewVan v = new ViewVan();
                FormMassClose(v, sender, e);
                FormOpen(v);
            }
        }

        private void btnViewFrmCheckup_Click(object sender, EventArgs e)
        {
            if (CheckupOpen)
            {
                CheckupOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                ViewCheckup c = (ViewCheckup)Application.OpenForms["ViewCheckup"];
                if (c != null)
                {
                    pnlContainer.Controls.Remove(c);
                    FC.Remove(c);
                }
            }
            else
            {
                CheckupOpen = true;
                ViewCheckup c = new ViewCheckup();
                FormMassClose(c, sender, e);
                FormOpen(c);
            }
        }
        private void btnViewFrmSession_Click(object sender, EventArgs e)
        {
            if (SessionOpen)
            {
                SessionOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                ViewSession s = (ViewSession)Application.OpenForms["ViewSession"];
                if (s != null)
                {
                    pnlContainer.Controls.Remove(s);
                    FC.Remove(s);
                }
            }
            else
            {
                SessionOpen = true;
                ViewSession s = new ViewSession();
                FormMassClose(s, sender, e);
                FormOpen(s);
            }
        }
        private void btnViewFrmItem_Click(object sender, EventArgs e)
        {
            if (ItemOpen)
            {
                ItemOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                ViewItem i = (ViewItem)Application.OpenForms["ViewItem"];
                if (i != null)
                {
                    pnlContainer.Controls.Remove(i);
                    FC.Remove(i);
                }
            }
            else
            {
                ItemOpen = true;
                ViewItem i = new ViewItem();
                FormMassClose(i, sender, e);
                FormOpen(i);
            }
        }
        private void btnViewFrmSiS_Click(object sender, EventArgs e)
        {
            if (SiSOpen)
            {
                SiSOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                ViewSessionCjtStaff SiS = (ViewSessionCjtStaff)Application.OpenForms["ViewSessionCjtStaff"];
                if (SiS != null)
                {
                    pnlContainer.Controls.Remove(SiS);
                    FC.Remove(SiS);
                }
            }
            else
            {
                SiSOpen = true;
                ViewSessionCjtStaff SiS = new ViewSessionCjtStaff();
                FormMassClose(SiS, sender, e);
                FormOpen(SiS);
            }
        }
        private void btnViewFrmIiC_Click(object sender, EventArgs e)
        {
            if (IiCOpen)
            {
                IiCOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                ViewCheckupCjtItem IiC = (ViewCheckupCjtItem)Application.OpenForms["ViewCheckupCjtItem"];
                if (IiC != null)
                {
                    pnlContainer.Controls.Remove(IiC);
                    FC.Remove(IiC);
                }
            }
            else
            {
                IiCOpen = true;
                ViewCheckupCjtItem IiC = new ViewCheckupCjtItem();
                FormMassClose(IiC, sender, e);
                FormOpen(IiC);
            }
        }

        private void FormMassClose<FormType>(FormType form, object sender, EventArgs e) where FormType : Form
        {
            if (form is not ViewStaff)
            {
                StaffOpen = true;
                btnViewFrmStaff_Click(sender, e);
            }
            if (form is not ViewVan)
            {
                VanOpen = true;
                btnViewFrmVan_Click(sender, e);
            }
            if (form is not ViewCheckup)
            {
                CheckupOpen = true;
                btnViewFrmCheckup_Click(sender, e);
            }
            if (form is not ViewItem)
            {
                ItemOpen = true;
                btnViewFrmItem_Click(sender, e);
            }
            if (form is not ViewSession)
            {
                SessionOpen = true;
                btnViewFrmSession_Click(sender, e);
            }
            if (form is not ViewCheckupCjtItem)
            {
                IiCOpen = true;
                btnViewFrmIiC_Click(sender, e);
            }
            if (form is not ViewSessionCjtStaff)
            {
                SiSOpen = true;
                btnViewFrmSiS_Click(sender, e);
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
