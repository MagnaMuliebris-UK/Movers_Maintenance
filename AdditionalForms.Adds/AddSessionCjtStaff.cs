using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Adds
{
    public partial class AddSessionCjtStaff : Form
    {
        public AddSessionCjtStaff()
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
                StaffInSessions newSCS = new StaffInSessions();
                newSCS.StaffID = Convert.ToInt32(txtbxStID.Text);
                newSCS.SessionID = Convert.ToInt32(txtbxSeID.Text);
                newSCS.TrainerID = Convert.ToInt32(txtbxTID.Text);
                DALStaffInSessions.Add(newSCS);
                if (OverarchingSettings.ReportActionIsEnabled)
                {
                    MessageBox.Show("Staff member in session successfully recorded.", "Movers");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("At least one value that has been entered is not a number. Please enter numerical values into the following fields: \"Staff_ID\"");
            }
            catch (OverflowException)
            {
                MessageBox.Show("At least one value entered is too large to be stored and has been rejected. Please try a smaller value.");
            }
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            txtbxStID.Text = "";
            txtbxSeID.Text = "";
            txtbxTID.Text = "";
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Staff ID: the id of the staff member who is assigned to this session.\nSession ID: the id of the session that the staff member is assigned to.\nTrainer ID:");
        }
    }
}
