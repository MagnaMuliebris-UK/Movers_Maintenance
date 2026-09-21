using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;
using System.Globalization;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Updates
{
    public partial class UpdateVan : Form
    {
        public UpdateVan()
        {
            InitializeComponent();
            if (!OverarchingSettings.HelpButtonsIsEnabled)
            {
                FC.Disable(btnHELP);
            }
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Van ID: The id of the van you wish to update.\nVan Make: The make of the van, this should be the company that made it, the model does not need to be included.\nDriver ID: An id of a staff member that has the position of 'Driver', which is purely numerical.\nMOT Expiration Date: The date where the van's MOT expires, in dd-mm-yyyy format.");
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            updnVID.Value = 0;
            txtbxVMake.Text = null;
            updnDriverID.Value = 0;
            txtbxMOTExpDate.Text = null;
            ckbxIsDrivable.Checked = false;
        }        

        private void btnUpdRecord_Click(object sender, EventArgs e)
        {
            bool stringIssue = false;
            try
            {
                Van newVan = new();
                newVan.VanID = (int)updnVID.Value;
                newVan.Van_Make = txtbxVMake.Text;
                newVan.Is_In_Use = ckbxIsDrivable.Checked;
                newVan.DriverID = (int)updnDriverID.Value;
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
                        MessageBox.Show("Van successfully updated.", "Movers");
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
    }
}
