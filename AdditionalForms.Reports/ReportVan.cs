using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Reports
{
    public partial class ReportVan : Form
    {
        public ReportVan()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            int check = (int)updnDriverID.Value;
            Van v = new Van();
            v.DriverID = check;
            bool c = DALVan.IsDriverSpecVan(v);
            if (c)
            {
                ReportToPage.CallMe(DALVan.GetAll(), v, 0);
            }
            else
            {
                MessageBox.Show("Not a valid driver id, please use an id that relates to a staff member with the position of \"Driver\".");
            }
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the reporting system - this is not for reporting a van that is potentially damaged, this is to be taken to the maintenance manager to be dealt with.\nThe purpose of this reporting system is to obtain information on vans with a similar driver to gain an accurate view on what and how the vans are doing, in conjunction with their drivers - and whether there happens to be redundancies in that area or not.\nDriver ID - the ID of the driver of the vans you wish to attain a report on.");
        }
    }
}
