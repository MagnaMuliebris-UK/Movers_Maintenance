using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Adds
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
            if (!OverarchingSettings.HelpButtonsIsEnabled)
            {
                FC.Disable(btnHELP);
            }
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        { 
            bool stringIssue = false;
            try
            {
                Item newItem = new();
                newItem.ItemName = txtbxIName.Text;
                newItem.ItemDescription = txtbxDesc.Text;
                newItem.CurrentQuantity = Convert.ToInt32(txtbxCNum.Text);
                newItem.IdealQuantity = Convert.ToInt32(txtbxINum.Text);
                if(FC.MultiValidationSTRING(newItem.ItemName, 50)!=2)
                {
                    stringIssue = true;
                    throw new FormatException();
                }
                DALItem.Add(newItem);
                if (OverarchingSettings.ReportActionIsEnabled)
                {
                    MessageBox.Show("Item successfully added.", "Movers");
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
            catch (OverflowException)
            {
                MessageBox.Show("At least one value entered is too large to be stored and has been rejected. Please try a smaller value.");
            }
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            txtbxIName.Text = "";
            txtbxDesc.Text = "";
            txtbxCNum.Text = "";
            txtbxINum.Text = "";
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item name: name of the item.\nDescription: what the item is used for, preferably made as concise as possible.\nCurrent Quantity: the amount of items currently on hand.\nIdeal Quantity: the amount of items that should be on hand, in the event of a van's failure in some regard.");
        }
    }
}
