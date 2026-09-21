using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Adds
{
    public partial class AddStaff : Form
    {
        public AddStaff()
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
            bool HTMFlag = false;
            try
            {
                Staff newStaff = new();
                newStaff.Forename = txtbxForename.Text;
                newStaff.Surname = txtbxSurname.Text;
                if (cbbxPosition.SelectedIndex != -1)
                {
                    string a = "";
                    switch(cbbxPosition.SelectedIndex)
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
                newStaff.Working_Hours = Convert.ToDouble(txtbxHWPW.Text);
                if (newStaff.Working_Hours > 48)
                {
                    OverflowException HoursTooMuch = new();
                    MessageBox.Show("The value entered is not in compliance with UK law for the average hours worked per week (48 hours per week on average for a 21 week period), please enter a lower value.");
                    HTMFlag = true;
                    throw HoursTooMuch;
                }
                newStaff.Hourly_Salary = Convert.ToDouble(txtbxHSalary.Text);
                if (newStaff.Hourly_Salary < 8.60)
                {
                    MessageBox.Show("The value entered is not in compliance with UK law for the minimum wage, please enter a higher value.");
                }
                
                if (FC.MultiValidationSTRING(newStaff.Forename, 50) != 2)
                {
                    stringIssue = true;
                    throw new FormatException();
                }
                if (FC.MultiValidationSTRING(newStaff.Surname, 50) != 2)
                {
                    stringIssue = true;
                    throw new FormatException();
                }
                DALStaff.Add(newStaff);
                if (OverarchingSettings.ReportActionIsEnabled)
                {
                    MessageBox.Show("Staff member successfully added.", "Movers");
                }

            }
            catch (FormatException ex)
            {
                if(stringIssue)
                {
                    MessageBox.Show("One or more of the entered values should not contain numbers or special characters - in addition to needing to be less than 50 characters long.");
                }
                else
                {
                    MessageBox.Show("At least one value that has been entered is not a number. Please enter numerical values into the following fields: \"Hours Worked Per Week\" and \"Hourly Salary\". Thank you.");
                }
            }
            catch (OverflowException ex)
            {
                if (!HTMFlag)
                {
                    MessageBox.Show("The value entered is too large to be stored and has been rejected. Please try a smaller value.");
                }
            }
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            txtbxForename.Text = "";
            txtbxSurname.Text = "";
            txtbxHWPW.Text = "";
            txtbxHSalary.Text = "";
            cbbxPosition.Text = "";
            cbbxPosition.SelectedIndex = -1;
            ckbxTrainer.Checked = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Forename: the forename of the staff member.\nSurname: the surname of the staff member.\nHours Worked Per Week: the number of hours that this staff member would typically work in a week - this is a whole number and as with UK law, cannot be over 48 hours.\nHourly Wage: the amount of money that would be allocated to this staff member after a typical hour of work. This cannot be below £8.60.\nPosition: simply select one of the options provided.");
        }
    }
}
