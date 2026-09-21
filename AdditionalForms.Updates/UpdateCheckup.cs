using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;
using System.Globalization;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Updates
{
    public partial class UpdateCheckup : Form
    {
        public UpdateCheckup()
        {
            InitializeComponent();
            if (!OverarchingSettings.HelpButtonsIsEnabled)
            {
                FC.Disable(btnHELP);
            }
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            updnCID.Value = 0;
            updnMID.Value = 0;
            updnVID.Value = 0;
            ckbxIsC_MOT.Checked = false;
            txtbxCDate.Text = "";
            txtbxVCondition.Text = "";
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Checkup ID: the id of the checkup you wish to update.\nMechanic ID: the id of a staff member who has the position of 'Mechanic', this is purely numerical.\nVan ID: the id of a van which is being put in for this checkup, which is purely numerical.\nVan Condition: the condition that the van is in after repair. Please be as concise as possible.\nDate of Checkup: the date when the checkup happened, in the format dd-mm-yyyy.", "Movers");
        }

        private void btnUpdRecord_Click(object sender, EventArgs e)
        {
            try
            {
                Checkup newCheckup = new();
                newCheckup.CheckupID = (int)updnCID.Value;
                newCheckup.MechanicID = (int)updnMID.Value;
                newCheckup.VanID = (int)updnVID.Value;
                newCheckup.IsMoTCheckup = ckbxIsC_MOT.Checked;
                newCheckup.Van_Condition = txtbxVCondition.Text;
                DateTime parsed;
                if (DateTime.TryParseExact(txtbxCDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out parsed))
                {
                    //string reformatted = parsed.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                    //Using REFORMATED
                    DateTime v;
                    DateTime.TryParseExact("01-01-1960", "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out v);
                    if (parsed.CompareTo(v) < 0)
                    {
                        MessageBox.Show("The date must be after 31-12-1959");
                    }
                        newCheckup.Checkup_Date = parsed;
                    DALCheckup.Add(newCheckup);
                    if (OverarchingSettings.ReportActionIsEnabled)
                    {
                        MessageBox.Show("Checkup successfully updated.", "Movers");
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
        }
    }
}
