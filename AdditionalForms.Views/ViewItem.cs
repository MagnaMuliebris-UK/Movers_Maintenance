using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using System.ComponentModel;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Views
{
    public partial class ViewItem : Form
    {
        public ViewItem()
        {
            InitializeComponent();
            InitializeBindingList();
            RefreshDGV();
        }
        private BindingList<Item> BL;
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void InitializeBindingList()
        {
            BL = new BindingList<Item>();
            dgvItem.DataSource = BL;
        }

        private void RefreshDGV()
        {
            BL.Clear(); // Clear the BindingList, not DataGridView.Rows
            List<Item> i = DALItem.GetAll();
            foreach (Item iic in i)
            {
                BL.Add(iic); // Add items to the BindingList
            }
        }
    }
}
