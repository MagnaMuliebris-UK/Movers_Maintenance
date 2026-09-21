using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Updates
{
    public partial class UpdateSessionCjtStaff : Form
    {
        public UpdateSessionCjtStaff()
        {
            InitializeComponent();
            if (!OverarchingSettings.HelpButtonsIsEnabled)
            {
                FC.Disable(btnHELP);
            }
        }

        private void btnUpdRecord_Click(object sender, EventArgs e)
        {
            StaffInSessions newSiS = new StaffInSessions();
            newSiS.StaffID = (int)updnStID.Value;
            newSiS.SessionID = (int)updnSeID.Value;
            newSiS.TrainerID = (int)updnTID.Value;
            DALStaffInSessions.Update(newSiS);

        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            updnStID.Value = 0;
            updnSeID.Value = 0;
            updnTID.Value = 0;
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Staff ID: the id of the staff member being assigned to a session.\nSession ID: the id of a session the staff member is being assigned to.\nTrainer ID: the id of the staff member who is training the rest of the staff members - must be distinct from the entered staff id.", "Movers");
        }
    }
}
