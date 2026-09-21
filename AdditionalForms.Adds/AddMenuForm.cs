using NeaterOperations;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Adds
{
    public partial class AddMenuForm : Form
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

        int height = 0;
        public AddMenuForm()
        {
            InitializeComponent();
            height = btnAddFrmStaff.Height;
        }

        private void btnAddFrmStaff_Click(object sender, EventArgs e)
        {
            if (StaffOpen)
            {
                StaffOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                AddStaff s = (AddStaff)Application.OpenForms["AddStaff"];
                if (s != null)
                {
                    pnlContainer.Controls.Remove(s);
                    FC.Remove(s);
                }
            }
            else
            {
                StaffOpen = true;
                AddStaff a = new AddStaff();
                FormMassClose(a, sender, e);
                FormOpen(a);
            }
        }
        private void btnAddFrmVan_Click(object sender, EventArgs e)
        {
            if (VanOpen)
            {
                VanOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                AddVan v = (AddVan)Application.OpenForms["AddVan"];
                if (v != null)
                {
                    pnlContainer.Controls.Remove(v);
                    FC.Remove(v);
                }
            }
            else
            {
                VanOpen = true;
                AddVan v = new AddVan();
                FormMassClose(v, sender, e);
                FormOpen(v);
            }
        }
        private void btnAddFrmCheckup_Click(object sender, EventArgs e)
        {
            if (CheckupOpen)
            {
                CheckupOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                AddCheckup c = (AddCheckup)Application.OpenForms["AddCheckup"];
                if (c != null)
                {
                    pnlContainer.Controls.Remove(c);
                    FC.Remove(c);
                }
            }
            else
            {
                CheckupOpen = true;
                AddCheckup c = new AddCheckup();
                FormMassClose(c, sender, e);
                FormOpen(c);
            }
        }
        private void btnAddFrmSession_Click(object sender, EventArgs e)
        {
            if (SessionOpen)
            {
                SessionOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                AddSession s = (AddSession)Application.OpenForms["AddSession"];
                if (s != null)
                {
                    pnlContainer.Controls.Remove(s);
                    FC.Remove(s);
                }
            }
            else
            {
                SessionOpen = true;
                AddSession s = new AddSession();
                FormMassClose(s, sender, e);
                FormOpen(s);
            }
        }
        private void btnAddFrmItem_Click(object sender, EventArgs e)
        {
            if (ItemOpen)
            {
                ItemOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                AddItem i = (AddItem)Application.OpenForms["AddItem"];
                if (i != null)
                {
                    pnlContainer.Controls.Remove(i);
                    FC.Remove(i);
                }
            }
            else
            {
                ItemOpen = true;
                AddItem i = new AddItem();
                FormMassClose(i, sender, e);
                FormOpen(i);
            }
        }
        private void btnAddFrmSiS_Click(object sender, EventArgs e)
        {
            if (SiSOpen)
            {
                SiSOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                AddSessionCjtStaff SiS = (AddSessionCjtStaff)Application.OpenForms["AddSessionCjtStaff"];
                if (SiS != null)
                {
                    pnlContainer.Controls.Remove(SiS);
                    FC.Remove(SiS);
                }
            }
            else
            {
                SiSOpen = true;
                AddSessionCjtStaff SiS = new AddSessionCjtStaff();
                FormMassClose(SiS, sender, e);
                FormOpen(SiS);
            }
        }
        private void btnAddFrmIiC_Click(object sender, EventArgs e)
        {
            if (IiCOpen)
            {
                IiCOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                AddCheckupCjtItem IiC = (AddCheckupCjtItem)Application.OpenForms["AddCheckupCjtItem"];
                if (IiC != null)
                {
                    pnlContainer.Controls.Remove(IiC);
                    FC.Remove(IiC);
                }
            }
            else
            {
                IiCOpen = true;
                AddCheckupCjtItem IiC = new AddCheckupCjtItem();
                FormMassClose(IiC, sender, e);
                FormOpen(IiC);
            }
        }
        private void btnThatHidesStuff_Click(object sender, EventArgs e)
        {
            List<Button> btns = new List<Button> { btnAddFrmStaff, btnAddFrmVan, btnAddFrmCheckup, btnAddFrmItem, btnAddFrmSession, btnAddFrmSiS, btnAddFrmIiC };
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
        private void FormMassClose<FormType>(FormType form, object sender, EventArgs e) where FormType : Form
        {
            if (form is not AddStaff)
            {
                StaffOpen = true;
                btnAddFrmStaff_Click(sender, e);
            }
            if (form is not AddVan)
            {
                VanOpen = true;
                btnAddFrmVan_Click(sender, e);
            }
            if (form is not AddCheckup)
            {
                CheckupOpen = true;
                btnAddFrmCheckup_Click(sender, e);
            }
            if (form is not AddItem)
            {
                ItemOpen = true;
                btnAddFrmItem_Click(sender, e);
            }
            if (form is not AddSession)
            {
                SessionOpen = true;
                btnAddFrmSession_Click(sender, e);
            }
            if (form is not AddCheckupCjtItem)
            {
                IiCOpen = true;
                btnAddFrmIiC_Click(sender, e);
            }
            if (form is not AddSessionCjtStaff)
            {
                SiSOpen = true;
                btnAddFrmSiS_Click(sender, e);
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
