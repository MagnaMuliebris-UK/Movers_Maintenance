using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using System.ComponentModel;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Views
{
    public partial class ViewVan : Form
    {
        public ViewVan()
        {
            InitializeComponent();
            InitializeBindingList();
            RefreshDGV();
        }
        private BindingList<Van> BL;
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void InitializeBindingList()
        {
            BL = new BindingList<Van>();
            dgvVan.DataSource = BL;
        }

        private void RefreshDGV()
        {
            BL.Clear(); // Clear the BindingList, not DataGridView.Rows
            List<Van> list = DALVan.GetAll();
            foreach (Van v in list)
            {
                BL.Add(v); // Add items to the BindingList
            }
        }
    }
}
