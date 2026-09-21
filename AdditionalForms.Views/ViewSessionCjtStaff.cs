using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using System.ComponentModel;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Views
{ 
    public partial class ViewSessionCjtStaff : Form
    {
        private BindingList<StaffInSessions> BL;

        public ViewSessionCjtStaff()
        {
            InitializeComponent();
            InitializeBindingList();
            RefreshDGV();
        }

        private void InitializeBindingList()
        {
            BL = new BindingList<StaffInSessions>();
            dGVSiS.DataSource = BL;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void RefreshDGV()
        {
            BL.Clear(); // Clear the BindingList, not DataGridView.Rows
            List<StaffInSessions> list = DALStaffInSessions.GetAll();
            foreach (StaffInSessions SiS in list)
            {
                BL.Add(SiS); // Add items to the BindingList
            }
        }
    }
}
