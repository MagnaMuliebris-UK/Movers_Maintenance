using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Deletes
{
    public partial class DeleteSession : Form
    {
        public DeleteSession()
        {
            InitializeComponent();
            if (!OverarchingSettings.HelpButtonsIsEnabled)
            {
                FC.Disable(btnHELP);
            }
        }

        private void btnVaV_Click(object sender, EventArgs e)
        {
            int SessionID = (int)updnSID.Value;
            if (DALSession.VaV(SessionID))
            {
                List<Session> s = DALSession.GetAll();
                foreach (Session S in s)
                {
                    if (S.SessionID == SessionID)
                    {                        
                        MessageBox.Show($"Session ID: {S.SessionID}\nSession Type: {S.SessionType}\nSession Date: {S.SessionDate}");
                    }
                }
            }
            else
            {
                MessageBox.Show("No session found with this id - please ensure this was the correct id - and try another id or option.");
            }

        }

        private void btnDelRecord_Click(object sender, EventArgs e)
        {
            bool ActionAcceptance = FC.QueryAction("Are you sure you would you like to remove this session?", "Movers");
            if (ActionAcceptance)
            {
                if(DALSession.Remove((int)updnSID.Value)>0)
                {
                    if (!OverarchingSettings.ReportActionIsEnabled)
                    {
                        MessageBox.Show("Successfully removed session.");
                    }
                }
                else
                {
                    MessageBox.Show("No session removed. Does this ID correspond to a session?");
                }
            }
            else
            {
                //User is aware. Here as recognition and reminder to self.
            }
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Session ID: This is a whole numerical value, which uniquely identifies each session.\nVerify Session: This button is used to check what record the Session ID corresponds to, it is highly recommended to use this before using the Remove Session button.", "Movers");
        }
    }
}
