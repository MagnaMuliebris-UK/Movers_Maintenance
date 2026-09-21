using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Deletes
{
    public partial class DeleteSessionCjtStaff : Form
    {
        public DeleteSessionCjtStaff()
        {
            InitializeComponent();
            if (!OverarchingSettings.HelpButtonsIsEnabled)
            {
                FC.Disable(btnHELP);
            }
        }

        private void btnVaV_Click(object sender, EventArgs e)
        {
            int StaffID = (int)updnStID.Value;
            int SessionID = (int)updnSeID.Value;
            
            if (DALStaffInSessions.VaV(StaffID, SessionID))
            {
                List<StaffInSessions> s = DALStaffInSessions.GetAll();
                foreach (StaffInSessions S in s)
                {
                    if (S.StaffID == StaffID && S.SessionID == SessionID)
                    {
                        MessageBox.Show($"Staff ID: {S.StaffID}\nSession ID: {S.SessionID}\nTrainer ID: {S.TrainerID}");
                    }
                }
            }
            else
            {
                MessageBox.Show("No staff in session found with those ids - please ensure this was the correct id - and try another id or option.");
            }
        }        

        private void btnDelRecord_Click(object sender, EventArgs e)
        {
            bool ActionAcceptance = FC.QueryAction("Are you sure you would you like to remove this staff from this session?", "Movers");
            if (ActionAcceptance)
            {
                DALStaffInSessions.Remove((int)updnStID.Value, (int)updnSeID.Value);                 
                
            }

            else
            {
                //User is aware. Here as recognition and reminder to self.
            }
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Staff ID: This is a whole numerical value, which uniquely identifies each staff member.\nSession ID: This is a whole numerical value, which uniquely identifies each session.\nVerify Staff in Session: This button is used to check what record the combination of the Staff ID and the Session ID corresponds to, it is highly recommended to use this before using the Remove Staff from Session button.", "Movers");
        }
    }
}
