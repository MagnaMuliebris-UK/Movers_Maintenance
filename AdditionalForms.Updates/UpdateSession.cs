using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;
using System.Globalization;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Updates
{
    public partial class UpdateSession : Form
    {        
        public UpdateSession()
        {
            InitializeComponent();
            if (!OverarchingSettings.HelpButtonsIsEnabled)
            {
                FC.Disable(btnHELP);
            }
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            txtbxSDate.Text = null;
            txtbxSDate.Text = null;
            updnSID.Value = 0;
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Session ID: the id of the session you wish to update.\nSession Type: the type of session that will take place.\nSession Date: the date when the session takes place, in the format dd-mm-yyyy.");
        }

        private void btnUpdRecord_Click(object sender, EventArgs e)
        {
            bool stringIssue = false;
            try
            {
                Session newSession = new();
                newSession.SessionID = (int)updnSID.Value;
                newSession.SessionType = txtbxSType.Text;
                DateTime parsed;
                if (DateTime.TryParseExact(txtbxSDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out parsed))
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
                    newSession.SessionDate = parsed;
                    if (FC.MultiValidationSTRING(newSession.SessionType, 50) != 2)
                    {
                        stringIssue = true;
                        throw new FormatException();
                    }
                    DALSession.Add(newSession);
                    if (OverarchingSettings.ReportActionIsEnabled)
                    {
                        MessageBox.Show("Session successfully updated.", "Movers");
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
            catch (Exception)
            {
                //already handled.
            }
        }
    }
}