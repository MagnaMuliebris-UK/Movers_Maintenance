using Movers_Maintenance_Subsystem.AdditionalForms.Views;
using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;
using System.Globalization;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Adds
{
    public partial class AddVan : Form
    {
        public AddVan()
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
                Van newVan = new();
                newVan.Van_Make = txtbxVMake.Text;
                newVan.Is_In_Use = cbxIsFitToDrive.Checked;
                newVan.DriverID = Convert.ToInt32(txtbxDriverID.Text);
                DateTime parsed;
                if (DateTime.TryParseExact(txtbxMOTExpDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out parsed))
                {
                    //string reformatted = parsed.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                    //Using REFORMATED
                    DateTime v;
                    DateTime.TryParseExact("01-01-1960", "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out v);
                    if (parsed.CompareTo(v) < 0)
                    {
                        MessageBox.Show("Date is invalid - too early. Pick a date after 31-12-1959 (from the 1st of the 1st in 1960).", "Movers");
                        throw new Exception();
                    }
                    newVan.MOT_Expiry_Date = parsed;
                    if (FC.MultiValidationSTRING(newVan.Van_Make, 50) != 2)
                    {
                        stringIssue = true;
                        throw new FormatException();
                    }
                    DALVan.Add(newVan);
                    if (OverarchingSettings.ReportActionIsEnabled)
                    {
                        MessageBox.Show("Van successfully added.", "Movers");
                    }
                }
                else
                {
                    //eror message
                    MessageBox.Show("The value entered is not a date in the format \"dd-mm-yyyy\", please correct this value to this format.");
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
                MessageBox.Show("The value entered is too large to be stored and has been rejected. Please try a smaller value.");
            }
            catch (Exception)
            {
                //already handled.
            }
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            txtbxVMake.Text = "";
            txtbxDriverID.Text = "";
            txtbxMOTExpDate.Text = "";
            cbxIsFitToDrive.Checked = false;
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Van Make: The make of the van, this should be the company that made it, the model does not need to be included.\nDriver ID: An id of a staff member that has the position of 'Driver', which is purely numerical.\nMOT Expiration Date: The date where the van's MOT expires, in dd-mm-yyyy format.");
        }
    }
}