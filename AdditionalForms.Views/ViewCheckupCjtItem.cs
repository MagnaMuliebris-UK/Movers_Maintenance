using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using System.ComponentModel;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Views
{
    public partial class ViewCheckupCjtItem : Form
    {
        public ViewCheckupCjtItem()
        {
            InitializeComponent();
            InitializeBindingList();
            RefreshDGV();
        }
        private BindingList<ItemsInCheckup> BL;
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }        

        private void InitializeBindingList()
        {
            BL = new BindingList<ItemsInCheckup>();
            dgvIiC.DataSource = BL;
        }

        private void RefreshDGV()
        {
            BL.Clear(); // Clear the BindingList, not DataGridView.Rows
            List<ItemsInCheckup> i = DALItemsInCheckup.GetAll();
            foreach (ItemsInCheckup iic in i)
            {
                BL.Add(iic); // Add items to the BindingList
            }
        }
    }
}
