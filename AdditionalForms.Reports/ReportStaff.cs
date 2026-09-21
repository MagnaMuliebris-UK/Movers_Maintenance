using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movers_Maintenance_Subsystem.AdditionalForms.Views;
using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Reports
{
    public partial class ReportStaff : Form
    {
        public ReportStaff()
        {
            InitializeComponent();
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
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
                s.Position = a;
            }
            ReportToPage.CallMe(DALStaff.GetAll(), s, 0);
        }
        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the reporting system - this is not for reporting a staff member for any activities, this is to be taken to HR to be dealt with.\nThe purpose of this reporting system is to obtain information on staff of a similar position to gain an accurate view on what and how they are doing - and whether there happens to be redundancies in that area or not.\nPosition - the position of the staff members you wish to attain a report on.");
        }
    }
}
