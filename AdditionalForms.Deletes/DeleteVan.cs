using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Deletes
{
    public partial class DeleteVan : Form
    {
        public DeleteVan()
        {
            InitializeComponent();
            if (!OverarchingSettings.HelpButtonsIsEnabled)
            {
                FC.Disable(btnHELP);
            }
        }

        private void btnVaV_Click(object sender, EventArgs e)
        {
            int VanID = (int)updnVID.Value;
            if (DALVan.VaV(VanID))
            {
                List<Van> Van = DALVan.GetAll();
                foreach (Van v in Van)
                {
                    if (v.VanID == VanID)
                    {
                        string add;
                        if (v.Is_In_Use)
                        {
                            add = " - this van is currently in use.";
                        }
                        else
                        {
                            add = " - this van is not currently in use.";
                        }
                        MessageBox.Show($"Van ID: {v.VanID}{add}\nVan Make: {v.Van_Make}.\nDriver ID: {v.DriverID}\nVan's MOT Expiration Date {v.MOT_Expiry_Date}");
                    }
                }
            }
            else
            {
                MessageBox.Show("No van found with this id - please ensure this was the correct id - and try another id or option.");
            }
        }

        private void btnDelRecord_Click(object sender, EventArgs e)
        {

            bool ActionAcceptance = FC.QueryAction("Are you sure you would you like to remove this van?", "Movers");
            if (ActionAcceptance)
            {
                if (DALVan.Remove((int)updnVID.Value) < 0)
                {
                    MessageBox.Show("No van removed. Does this ID correspond to a van?");
                }
                else
                {                    
                    if (!OverarchingSettings.ReportActionIsEnabled)
                    {
                        MessageBox.Show("Successfully removed van.");
                    }
                }
            }
            else
            {
                //User is aware. Here as recognition and reminder to self.
            }
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Van ID: This is a whole numerical value, which uniquely identifies each Van.\nVerify Van: This button is used to check what stored record the Van ID corresponds to, it is highly recommended to use this before using the Remove Van button.", "Movers");
        }
    }
}
