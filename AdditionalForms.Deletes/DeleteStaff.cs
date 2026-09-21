using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Deletes
{
    public partial class DeleteStaff : Form
    {
        public DeleteStaff()
        {
            InitializeComponent();
            if (!OverarchingSettings.HelpButtonsIsEnabled)
            {
                FC.Disable(btnHELP);
            }
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Staff ID: This is a whole numerical value, which uniquely identifies each staff member.\nVerify Staff: This button is used to check what stored record the Staff ID corresponds to, it is highly recommended to use this before using the Remove Staff button.", "Movers");
        }

        private void btnVaV_Click(object sender, EventArgs e)
        {
            int StaffID = (int)updnSID.Value;
            if(DALStaff.VaV(StaffID))
            {
                List<Staff> Stf = DALStaff.GetAll();
                foreach(Staff s in Stf)
                {
                    if(s.StaffID == StaffID)
                    {
                        string add;
                        if(s.Trainer)
                        {
                            add = " - can train other staff.";
                        }
                        else
                        {
                            add = ".";
                        }
                        MessageBox.Show($"Staff ID: {s.StaffID}\nName: {s.Forename} {s.Surname}.\nPosition: {s.Position}{add}\nEarns £{s.Hourly_Salary} per hour - and works {s.Working_Hours} hours.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No staff member found with this id - please ensure this was the correct id - and try another id or option.");
            }
        }

        private void btnDelRecord_Click(object sender, EventArgs e)
        {
            bool ActionAcceptance = FC.QueryAction("Are you sure you would you like to remove this staff member?", "Movers");
            if (ActionAcceptance)
            {
                if (DALStaff.Remove((int)updnSID.Value) < 0)
                {
                    MessageBox.Show("No staff member removed. Does this ID correspond to a staff member?");
                }
                else
                {
                    if (!OverarchingSettings.ReportActionIsEnabled)
                    {
                        MessageBox.Show("Successfully removed staff member.");
                    }
                    
                }
            }
            else
            {
                //User is aware. Here as recognition and reminder to self.
            }
        }

        
    }
}
