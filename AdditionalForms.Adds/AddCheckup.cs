using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;
using System.Globalization;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Adds
{
    public partial class AddCheckup : Form
    {
        public AddCheckup()
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
                Checkup newCheckup = new();
                newCheckup.MechanicID = Convert.ToInt32(txtbxMechanicID.Text);
                newCheckup.VanID = Convert.ToInt32(txtbxVanID.Text);
                newCheckup.IsMoTCheckup = ckbxMOTCertified.Checked;
                newCheckup.Van_Condition = txtbxVanCondition.Text;
                DateTime parsed;
                if (DateTime.TryParseExact(txtbxCDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out parsed))
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
                    newCheckup.Checkup_Date = parsed;
                    DALCheckup.Add(newCheckup);
                    if (OverarchingSettings.ReportActionIsEnabled)
                    {
                        MessageBox.Show("Checkup successfully added.", "Movers");
                    }
                }
                else
                {
                    //eror message
                    MessageBox.Show("The value entered is not a date in the format \"dd-mm-yyyy\", please correct this value to this format.", "Movers");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("The value that has been entered is not a number. Please enter numerical values into the following fields: \"Staff_ID\" and \"Van_ID\"", "Movers");
            }
            catch (OverflowException)
            {
                MessageBox.Show("The value entered is too large to be stored and has been rejected. Please try a smaller value.", "Movers");
            }
            catch (Exception)
            {
                //already handled
            }
        }

            private void btnWipe_Click(object sender, EventArgs e)
        {
            txtbxMechanicID.Text = "";
            txtbxVanID.Text = "";
            txtbxVanCondition.Text = "";
            txtbxCDate.Text = "";
            ckbxMOTCertified.Checked = false;
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mechanic ID: the id of a staff member who has the position of 'Mechanic', this is purely numerical.\nVan ID: the id of a van which is being put in for this checkup, which is purely numerical.\nVan Condition: the condition that the van is in after repair. Please be as concise as possible.\nDate of Checkup: the date when the checkup happened, in the format dd-mm-yyyy.", "Movers");
        }
    }
}
