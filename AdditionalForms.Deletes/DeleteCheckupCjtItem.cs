using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Deletes
{
    public partial class DeleteCheckupCjtItem : Form
    {
        public DeleteCheckupCjtItem()
        {
            InitializeComponent();
            if (!OverarchingSettings.HelpButtonsIsEnabled)
            {
                FC.Disable(btnHELP);
            }
        }

        private void btnVaV_Click(object sender, EventArgs e)
        {
            int ItemID = (int)updnIID.Value;
            int CheckupID = (int)updnCID.Value;
            
            if (DALItemsInCheckup.VaV(CheckupID, ItemID))
            {
                List<ItemsInCheckup> iic = DALItemsInCheckup.GetAll();
                foreach (ItemsInCheckup i in iic)
                {
                    if (i.ItemID == ItemID && i.CheckupID == CheckupID)
                    {
                        MessageBox.Show($"Item ID: {i.ItemID}\nCheckup ID: {i.CheckupID}\nQuantity Used: {i.QuantityUsed}");
                    }
                }
            }
            else
            {
                MessageBox.Show("No item in checkup found with those ids - please ensure this was the correct id - and try another id or option.");
            }
        }

        private void btnDelRecord_Click(object sender, EventArgs e)
        {
            bool ActionAcceptance = FC.QueryAction("Are you sure you would you like to remove this item from the checkup?", "Movers");
            if (ActionAcceptance)
            {
                DALItemsInCheckup.Remove((int)updnIID.Value, (int)updnCID.Value);            
                    
            }
            else
            {
                //User is aware. Here as recognition and reminder to self.
            }
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Checkup ID: This is a whole numerical value, which uniquely identifies each checkup.\nItem ID: This is a whole numerical value, which uniquely identifies each item.\nVerify Staff: This button is used to check what record the combination of Item ID and Checkup ID corresponds to, it is highly recommended to use this before using the Remove Item from Checkup button.", "Movers");
        }
    }
}
