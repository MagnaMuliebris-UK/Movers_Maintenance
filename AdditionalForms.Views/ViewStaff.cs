using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using System.ComponentModel;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Views
{
    public partial class ViewStaff : Form
    {
        public ViewStaff()
        {
            InitializeComponent();
            InitializeBindingList();
            RefreshDGV();
        }
        private BindingList<Staff> BL;
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void InitializeBindingList()
        {
            BL = new BindingList<Staff>();
            dgvStaff.DataSource = BL;
        }

        private void RefreshDGV()
        {
            BL.Clear(); // Clear the BindingList, not DataGridView.Rows
            List<Staff> s = DALStaff.GetAll();
            foreach (Staff staff in s)
            {
                BL.Add(staff); // Add items to the BindingList
            }
        }
    }
}
