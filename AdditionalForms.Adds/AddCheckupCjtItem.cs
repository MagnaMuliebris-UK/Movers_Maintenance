using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Adds
{
    public partial class AddCheckupCjtItem : Form
    {
        public AddCheckupCjtItem()
        {
            InitializeComponent();
            if (!OverarchingSettings.HelpButtonsIsEnabled)
            {
                FC.Disable(btnHELP);
            }
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                ItemsInCheckup newCCI = new ItemsInCheckup();
                newCCI.CheckupID = Convert.ToInt32(txtbxCID.Text);
                newCCI.ItemID = Convert.ToInt32(txtbxIID.Text);
                newCCI.QuantityUsed = Convert.ToInt32(txtbxNumUsed.Text);
                DALItemsInCheckup.Add(newCCI);
                
            }
            catch (FormatException)
            {
                MessageBox.Show("At least one value that has been entered is not a number. Please enter numerical values into the following fields: \"Checkup_ID\", \"ItemID\" and \"Quantity\"");
            }
            catch (OverflowException)
            {
                MessageBox.Show("At least one value entered is too large to be stored and has been rejected. Please try a smaller value.");
            }
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            txtbxCID.Text = "";
            txtbxIID.Text = "";
            txtbxNumUsed.Text = "";
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Checkup ID: the id that corresponds to a checkup, is purely numerical.\nItem ID: the id that corresponds to an item, is purely numerical.\nQuantity Used: the amount of a given item used for a given checkup.");
        }
    }
}
