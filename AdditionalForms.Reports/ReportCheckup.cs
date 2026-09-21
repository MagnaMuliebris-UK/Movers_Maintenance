using Movers_Maintenance_Subsystem.AdditionalForms.Views;
using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Reports
{
    public partial class ReportCheckup : Form
    {
        int iterator = 1;
        public ReportCheckup()
        {
            InitializeComponent();
            btnBeAeEBiAi.Text = "Before (Exclusive)";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            iterator++;
            if (iterator > 5)
            {
                iterator = 1;
            }
            switch (iterator)
            {
                case 1:
                    {
                        btnBeAeEBiAi.Text = "Before (Exclusive)";
                    }
                    break;
                case 2:
                    {
                        btnBeAeEBiAi.Text = "After (Exclusive)";
                    }
                    break;
                case 3:
                    {
                        btnBeAeEBiAi.Text = "Exact";
                    }
                    break;
                case 4:
                    {
                        btnBeAeEBiAi.Text = "Before (Inclusive)";
                    }
                    break;
                case 5:
                    {
                        btnBeAeEBiAi.Text = "After (Inclusive)";
                    }
                    break;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //try
            {
                DateTime parsed;
                if (DateTime.TryParseExact(txtbxCDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out parsed))
                {
                    //string reformatted = parsed.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                    //Using REFORMATED
                    DateTime v;
                    DateTime.TryParseExact("01-01-1960", "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out v);
                    if (parsed.CompareTo(v) < 0)
                    {
                        MessageBox.Show("Invalid date, the date must be after 31-12-1959");
                        throw new Exception();
                    }
                    Checkup cSort = new() { Checkup_Date = parsed };
                    ReportToPage.CallMe(DALCheckup.GetAll(), cSort, iterator);
                }
                else
                {
                    //error message
                    MessageBox.Show("The value entered is not a date in the format \"dd-mm-yyyy\", please correct this value to this format.", "Movers");
                }
            
            }
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the reporting system - this is not for reporting a checkup for any inaccuracies, this is to be taken to the maintenance to be dealt with.\nThe purpose of this reporting system is to obtain information on checkups of a similiar time period to gain an accurate view on what is occuring or how the checkups are being done - and whether or not any adjustments to protocol needs to be made.\nCheckup Date- the date of the checkup you wish to attain a report on. This should be entered in the format \"dd-mm-yyyy\", including the dashes.");
        }
    }
}
