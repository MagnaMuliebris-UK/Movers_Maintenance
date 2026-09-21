using NeaterOperations;
namespace Movers_Maintenance_Subsystem.AdditionalForms.Updates
{
    public partial class UpdateMenuForm : Form
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
        public UpdateMenuForm()
        {
            InitializeComponent();
            height = btnUpdFrmCheckup.Height;
        }

        private void btnThatHidesStuff_Click(object sender, EventArgs e)
        {
            List<Button> btns = new List<Button> { btnUpdFrmStaff, btnUpdFrmVan, btnUpdFrmCheckup, btnUpdFrmItem, btnUpdFrmSession, btnUpdFrmSiS, btnUpdFrmIiC };
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

        private void btnUpdFrmStaff_Click(object sender, EventArgs e)
        {
            if (StaffOpen)
            {
                StaffOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                UpdateStaff s = (UpdateStaff)Application.OpenForms["UpdateStaff"];
                if (s != null)
                {
                    pnlContainer.Controls.Remove(s);
                    FC.Remove(s);
                }
            }
            else
            {
                StaffOpen = true;
                UpdateStaff s = new UpdateStaff();
                FormMassClose(s, sender, e);
                FormOpen(s);
            }
        }

        private void btnUpdFrmVan_Click(object sender, EventArgs e)

        {
            if (VanOpen)
            {
                VanOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                UpdateVan v = (UpdateVan)Application.OpenForms["UpdateVan"];
                if (v != null)
                {
                    pnlContainer.Controls.Remove(v);
                    FC.Remove(v);
                }
            }
            else
            {
                VanOpen = true;
                UpdateVan v = new UpdateVan();
                FormMassClose(v, sender, e);
                FormOpen(v);
            }
        }

        private void btnUpdFrmCheckup_Click(object sender, EventArgs e)
        {
            if (CheckupOpen)
            {
                CheckupOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                UpdateCheckup c = (UpdateCheckup)Application.OpenForms["UpdateCheckup"];
                if (c != null)
                {
                    pnlContainer.Controls.Remove(c);
                    FC.Remove(c);
                }
            }
            else
            {
                CheckupOpen = true;
                UpdateCheckup c = new UpdateCheckup();
                FormMassClose(c, sender, e);
                FormOpen(c);
            }
        }
        private void btnUpdFrmSession_Click(object sender, EventArgs e)
        {
            if (SessionOpen)
            {
                SessionOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                UpdateSession s = (UpdateSession)Application.OpenForms["UpdateSession"];
                if (s != null)
                {
                    pnlContainer.Controls.Remove(s);
                    FC.Remove(s);
                }
            }
            else
            {
                SessionOpen = true;
                UpdateSession s = new UpdateSession();
                FormMassClose(s, sender, e);
                FormOpen(s);
            }
        }
        private void btnUpdFrmItem_Click(object sender, EventArgs e)
        {
            if (ItemOpen)
            {
                ItemOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                UpdateItem i = (UpdateItem)Application.OpenForms["UpdateItem"];
                if (i != null)
                {
                    pnlContainer.Controls.Remove(i);
                    FC.Remove(i);
                }
            }
            else
            {
                ItemOpen = true;
                UpdateItem i = new UpdateItem();
                FormMassClose(i, sender, e);
                FormOpen(i);
            }
        }
        private void btnUpdFrmSiS_Click(object sender, EventArgs e)
        {
            if (SiSOpen)
            {
                SiSOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                UpdateSessionCjtStaff SiS = (UpdateSessionCjtStaff)Application.OpenForms["UpdateSessionCjtStaff"];
                if (SiS != null)
                {
                    pnlContainer.Controls.Remove(SiS);
                    FC.Remove(SiS);
                }
            }
            else
            {
                SiSOpen = true;
                UpdateSessionCjtStaff SiS = new UpdateSessionCjtStaff();
                FormMassClose(SiS, sender, e);
                FormOpen(SiS);
            }
        }
        private void btnUpdFrmIiC_Click(object sender, EventArgs e)
        {
            if (IiCOpen)
            {
                IiCOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                UpdateCheckupCjtItem IiC = (UpdateCheckupCjtItem)Application.OpenForms["UpdateCheckupCjtItem"];
                if (IiC != null)
                {
                    pnlContainer.Controls.Remove(IiC);
                    FC.Remove(IiC);
                }
            }
            else
            {
                IiCOpen = true;
                UpdateCheckupCjtItem IiC = new UpdateCheckupCjtItem();
                FormMassClose(IiC, sender, e);
                FormOpen(IiC);
            }
        }

        

        private void FormMassClose<FormType>(FormType form, object sender, EventArgs e) where FormType : Form
        {
            if (form is not UpdateStaff)
            {
                StaffOpen = true;
                btnUpdFrmStaff_Click(sender, e);
            }
            if (form is not UpdateVan)
            {
                VanOpen = true;
                btnUpdFrmVan_Click(sender, e);
            }
            if (form is not UpdateCheckup)
            {
                CheckupOpen = true;
                btnUpdFrmCheckup_Click(sender, e);
            }
            if (form is not UpdateItem)
            {
                ItemOpen = true;
                btnUpdFrmItem_Click(sender, e);
            }
            if (form is not UpdateSession)
            {
                SessionOpen = true;
                btnUpdFrmSession_Click(sender, e);
            }
            if (form is not UpdateCheckupCjtItem)
            {
                IiCOpen = true;
                btnUpdFrmIiC_Click(sender, e);
            }
            if (form is not UpdateSessionCjtStaff)
            {
                SiSOpen = true;
                btnUpdFrmSiS_Click(sender, e);
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
