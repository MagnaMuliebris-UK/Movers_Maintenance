using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Deletes
{
    public partial class DeleteCheckup : Form
    {
        public DeleteCheckup()
        {
            InitializeComponent();
            if (!OverarchingSettings.HelpButtonsIsEnabled)
            {
                FC.Disable(btnHELP);
            }
        }

        private void btnVaV_Click(object sender, EventArgs e)
        {
            int Checkup = (int)updnCID.Value;
            
            if (DALCheckup.VaV(Checkup))
            {
                List<Checkup> c = DALCheckup.GetAll();
                foreach (Checkup C in c)
                {
                    if (C.CheckupID == Checkup)
                    {                        
                        string add;
                        if (C.IsMoTCheckup)
                        {
                            add = " - is also an MOT checkup.";
                        }
                        else
                        {
                            add = ".";
                        }
                        MessageBox.Show($"Checkup ID: {C.CheckupID}\nVan ID: {C.VanID}, in the condition: {C.Van_Condition}\nMechanic ID: {C.MechanicID}\nCheckup Date: {C.CheckupID}{add}");
                    }
                }
            }
            else
            {
                MessageBox.Show("No checkup found with this id - please ensure this was the correct id - and try another id or option.");
            }
        }

        private void btnDelRecord_Click(object sender, EventArgs e)
        {
            bool ActionAcceptance = FC.QueryAction("Are you sure you would you like to remove this checkup?", "Movers");
            if (ActionAcceptance)
            {
                if(DALCheckup.Remove((int)updnCID.Value)>0)
                {
                    if (!OverarchingSettings.ReportActionIsEnabled)
                    {
                        MessageBox.Show("Successfully removed checkup.");
                    }
                }
                else
                {
                    MessageBox.Show("No checkup removed. Does this ID correspond to a checkup?");
                }
            }
            else
            {
                //User is aware. Here as recognition and reminder to self.
            }
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Checkup ID: This is a whole numerical value, which uniquely identifies each checkup.\nVerify Checkup: This button is used to check what stored record the Checkup ID corresponds to, it is highly recommended to use this before using the Remove Checkup button.", "Movers");
        }
    }
}
