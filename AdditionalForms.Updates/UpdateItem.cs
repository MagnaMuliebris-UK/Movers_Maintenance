using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Updates
{
    public partial class UpdateItem : Form
    {
        public UpdateItem()
        {
            InitializeComponent();
            if (!OverarchingSettings.HelpButtonsIsEnabled)
            {
                FC.Disable(btnHELP);
            }
        }

        private void btnUpdRecord_Click(object sender, EventArgs e)
        {
            bool stringIssue = false;
            try
            {
                Item newItem = new();
                newItem.ItemID = (int)updnIID.Value;
                newItem.ItemName = txtbxIName.Text;
                newItem.ItemDescription = txtbxDesc.Text;
                newItem.CurrentQuantity = (int)updnCNum.Value;
                newItem.IdealQuantity = (int)updnINum.Value;
                if (FC.MultiValidationSTRING(newItem.ItemName, 50) != 2)
                {
                    stringIssue = true;
                    throw new FormatException();
                }
                DALItem.Add(newItem);
                if (OverarchingSettings.ReportActionIsEnabled)
                {
                    MessageBox.Show("Item successfully updated.", "Movers");
                }
            }
            catch (FormatException)
            {
                if (stringIssue)
                {
                    MessageBox.Show("One or more of the entered values should not contain numbers or special characters - in addition to needing to be less than 50 characters long.");
                }
                else
                {
                    MessageBox.Show("At least one value that has been entered is not a number. Please enter numerical values into the following fields: \"Hours Worked Per Week\" and \"Hourly Salary\". Thank you.");
                }
            }
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item name: name of the item.\nDescription: what the item is used for, preferably made as concise as possible.\nCurrent Quantity: the amount of items currently on hand.\nIdeal Quantity: the amount of items that should be on hand, in the event of a van's failure in some regard.");
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            txtbxIName.Text = "";
            txtbxDesc.Text = "";
            updnCNum.Value = 0;
            updnINum.Value = 0;
        }

    }
}
