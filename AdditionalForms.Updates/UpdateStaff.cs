using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Updates
{
    public partial class UpdateStaff : Form
    {
        public UpdateStaff()
        {
            InitializeComponent();
            if (!OverarchingSettings.HelpButtonsIsEnabled)
            {
                FC.Disable(btnHELP);
            }
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Staff ID: the id of the staff member who's details you wish to update.\nForename: the forename of the staff member.\nSurname: the surname of the staff member.\nHours Worked Per Week: the number of hours that this staff member would typically work in a week - this is a whole number and as with UK law, cannot be over 48 hours.\nHourly Wage: the amount of money that would be allocated to this staff member after a typical hour of work. This cannot be below £8.60.\nPosition: simply select one of the options provided.");
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            updnSID.Value = 0;
            txtbxForename.Text = null;
            txtbxSurname.Text = null;
            UpDnHWPW.Value = 0;
            updnHSalary.Value = (decimal)8.60;
            cbbxPosition.SelectedIndex = -1;
            ckbxTrainer.Checked = false;
        }

        private void btnUpdRecord_Click(object sender, EventArgs e)
        {
            bool stringIssue = false;
            try
            {
                Staff newStaff = new();
                newStaff.StaffID = (int)updnSID.Value;
                newStaff.Forename = txtbxForename.Text;
                newStaff.Surname = txtbxSurname.Text;
                newStaff.Working_Hours = (int)UpDnHWPW.Value;
                newStaff.Hourly_Salary = (double)updnHSalary.Value;
                if (cbbxPosition.SelectedIndex != -1)
                {
                    string a = "";
                    switch (cbbxPosition.SelectedIndex)
                    {
                        case 0:
                            {
                                a = "Driver";
                            }
                            break;
                        case 1:
                            {
                                a = "Mechanic";
                            }
                            break;
                        case 2:
                            {
                                a = "Maintenance Manager";
                            }
                            break;
                        case 3:
                            {
                                a = "CEO";
                            }
                            break;
                        default:
                            {
                                MessageBox.Show("Unimplemented - critical error");
                            }
                            break;
                    }
                    newStaff.Position = a;
                }
                newStaff.Trainer = ckbxTrainer.Checked;
                if ((cbbxPosition.SelectedIndex != -1) && (newStaff.Forename != null) && (newStaff.Surname != null)) //UpDns resolve themselves anyways- mins and maxes
                {
                    if((FC.MultiValidationSTRING(newStaff.Forename, 50)!=2)|| (FC.MultiValidationSTRING(newStaff.Surname, 50) != 2))
                    {
                        stringIssue = true;
                        throw new FormatException();
                    }
                    DALStaff.Update(newStaff);
                    if (OverarchingSettings.ReportActionIsEnabled)
                    {
                        MessageBox.Show("Staff member successfully updated.", "Movers");
                    }
                }
                else if (cbbxPosition.SelectedIndex == -1)
                {
                    MessageBox.Show("No position selected, please select a position.", "Movers");
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
        }

       
    }
}
