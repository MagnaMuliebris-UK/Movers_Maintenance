using NeaterOperations;
namespace Movers_Maintenance_Subsystem.AdditionalForms.Deletes
{
    public partial class DeleteMenuForm : Form
    {
        private bool StaffOpen = false;
        private bool VanOpen = false;
        private bool CheckupOpen = false;
        private bool ItemOpen = false;
        private bool SessionOpen = false;
        private bool SiSOpen = false;
        private bool IiCOpen = false;
        private bool ShowTheUI = true;
        private int height = 0;
        public DeleteMenuForm()
        {
            InitializeComponent();

            height = btnDelFrmStaff.Height;
        }

        private void btnThatHidesStuff_Click(object sender, EventArgs e)
        {
            List<Button> btns = new List<Button> { btnDelFrmStaff, btnDelFrmVan, btnDelFrmCheckup, btnDelFrmItem, btnDelFrmSession, btnDelFrmSiS, btnDelFrmIiC };
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
        private void btnDelFrmStaff_Click(object sender, EventArgs e)
        {
            if (StaffOpen)
            {
                StaffOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                DeleteStaff s = (DeleteStaff)Application.OpenForms["DeleteStaff"];
                if (s != null)
                {
                    pnlContainer.Controls.Remove(s);
                    FC.Remove(s);
                }
            }
            else
            {
                StaffOpen = true;
                DeleteStaff a = new DeleteStaff();
                FormMassClose(a, sender, e);
                FormOpen(a);
            }
        }
        private void btnDelFrmVan_Click(object sender, EventArgs e)
        {
            if (VanOpen)
            {
                VanOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                DeleteVan v = (DeleteVan)Application.OpenForms["DeleteVan"];
                if (v != null)
                {
                    pnlContainer.Controls.Remove(v);
                    FC.Remove(v);
                }
            }
            else
            {
                VanOpen = true;
                DeleteVan v = new DeleteVan();
                FormMassClose(v, sender, e);
                FormOpen(v);
            }
        }
        private void btnDelFrmCheckup_Click(object sender, EventArgs e)
        {
            if (CheckupOpen)
            {
                CheckupOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                DeleteCheckup c = (DeleteCheckup)Application.OpenForms["DeleteCheckup"];
                if (c != null)
                {
                    pnlContainer.Controls.Remove(c);
                    FC.Remove(c);
                }
            }
            else
            {
                CheckupOpen = true;
                DeleteCheckup c = new DeleteCheckup();
                FormMassClose(c, sender, e);
                FormOpen(c);
            }
        }
        private void btnDelFrmSession_Click(object sender, EventArgs e)
        {
            if (SessionOpen)
            {
                SessionOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                DeleteSession s = (DeleteSession)Application.OpenForms["DeleteSession"];
                if (s != null)
                {
                    pnlContainer.Controls.Remove(s);
                    FC.Remove(s);
                }
            }
            else
            {
                SessionOpen = true;
                DeleteSession s = new DeleteSession();
                FormMassClose(s, sender, e);
                FormOpen(s);
            }
        }
        private void btnDelFrmItem_Click(object sender, EventArgs e)
        {
            if (ItemOpen)
            {
                ItemOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                DeleteItem i = (DeleteItem)Application.OpenForms["DeleteItem"];
                if (i != null)
                {
                    pnlContainer.Controls.Remove(i);
                    FC.Remove(i);
                }
            }
            else
            {
                ItemOpen = true;
                DeleteItem i = new DeleteItem();
                FormMassClose(i, sender, e);
                FormOpen(i);
            }
        }
        private void btnDelFrmSiS_Click(object sender, EventArgs e)
        {
            if (SiSOpen)
            {
                SiSOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                DeleteSessionCjtStaff SiS = (DeleteSessionCjtStaff)Application.OpenForms["DeleteSessionCjtStaff"];
                if (SiS != null)
                {
                    pnlContainer.Controls.Remove(SiS);
                    FC.Remove(SiS);
                }
            }
            else
            {
                SiSOpen = true;
                DeleteSessionCjtStaff SiS = new DeleteSessionCjtStaff();
                FormMassClose(SiS, sender, e);
                FormOpen(SiS);
            }
        }
        private void btnDelFrmIiC_Click(object sender, EventArgs e)
        {
            if (IiCOpen)
            {
                IiCOpen = false;
                //Possible "null" value is handled in such a way as to not cause errors
                DeleteCheckupCjtItem IiC = (DeleteCheckupCjtItem)Application.OpenForms["DeleteCheckupCjtItem"];
                if (IiC != null)
                {
                    pnlContainer.Controls.Remove(IiC);
                    FC.Remove(IiC);
                }
            }
            else
            {
                IiCOpen = true;
                DeleteCheckupCjtItem IiC = new DeleteCheckupCjtItem();
                FormMassClose(IiC, sender, e);
                FormOpen(IiC);
            }
        }
        private void FormMassClose<FormType>(FormType form, object sender, EventArgs e) where FormType : Form
        {
            if (form is not DeleteStaff)
            {
                StaffOpen = true;
                btnDelFrmStaff_Click(sender, e);
            }
            if (form is not DeleteVan)
            {
                VanOpen = true;
                btnDelFrmVan_Click(sender, e);
            }
            if (form is not DeleteCheckup)
            {
                CheckupOpen = true;
                btnDelFrmCheckup_Click(sender, e);
            }
            if (form is not DeleteItem)
            {
                ItemOpen = true;
                btnDelFrmItem_Click(sender, e);
            }
            if (form is not DeleteSession)
            {
                SessionOpen = true;
                btnDelFrmSession_Click(sender, e);
            }
            if (form is not DeleteCheckupCjtItem)
            {
                IiCOpen = true;
                btnDelFrmIiC_Click(sender, e);
            }
            if (form is not DeleteSessionCjtStaff)
            {
                SiSOpen = true;
                btnDelFrmSiS_Click(sender, e);
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
