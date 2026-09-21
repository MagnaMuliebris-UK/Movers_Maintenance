using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Deletes
{
    public partial class DeleteItem : Form
    {
        public DeleteItem()
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
            if (DALItem.VaV(ItemID))
            { 
                List<Item> i = DALItem.GetAll();
                foreach (Item I in i)
                {
                    if (I.ItemID == ItemID)
                    {
                        MessageBox.Show($"Item ID: {I.ItemID}\nItem Name: {I.ItemName}\nDescription: {I.ItemDescription}\nCurrent Quantity: {I.CurrentQuantity}\nIdeal Quantity: {I.IdealQuantity}");
                    }
                }
            }
            else
            {
                MessageBox.Show("No item found with this id - please ensure this was the correct id - and try another id or option.");
            }
        }

        private void btnDelRecord_Click(object sender, EventArgs e)
        {
            bool ActionAcceptance = FC.QueryAction("Are you sure you would you like to remove this item?", "Movers");
            if (ActionAcceptance)
            {
                if(DALItem.Remove((int)updnIID.Value)>0)
                {
                    if (!OverarchingSettings.ReportActionIsEnabled)
                    {
                        MessageBox.Show("Successfully removed item.");
                    }
                }
                else
                {
                    MessageBox.Show("No item removed. Does this ID correspond to a item?");
                }
            }
            else
            {
                //User is aware. Here as recognition and reminder to self.
            }
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item ID: This is a whole numerical value, which uniquely identifies each item.\nVerify Item: This button is used to check what record the Item ID corresponds to, it is highly recommended to use this before using the Remove Item button.", "Movers");
        }
    }
}
