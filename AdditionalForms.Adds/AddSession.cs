using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;
using System.Globalization;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Adds
{
    public partial class AddSession : Form
    {
        public AddSession()
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
                Session newSession = new();
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
                    
                    if(FC.MultiValidationSTRING(newSession.SessionType, 50)!=2)
                    {
                        stringIssue = true;
                        throw new FormatException();
                    }
                    DALSession.Add(newSession);
                    if (OverarchingSettings.ReportActionIsEnabled)
                    {
                        MessageBox.Show("Session successfully added.", "Movers");
                    }
                }
                else
                {
                    //eror message
                    MessageBox.Show("The value entered is not a date in the format \"dd-mm-yyyy\", please correct this value to this format.");
                }
            }
            catch(FormatException)
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
            catch(Exception)
            {
                //already handled.
            }
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            txtbxSType.Text = "";
            txtbxSDate.Text = "";
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Session Type: the type of session that will take place.\nSession Date: the date when the session takes place, in the format dd-mm-yyyy.");
        }
    }
}
