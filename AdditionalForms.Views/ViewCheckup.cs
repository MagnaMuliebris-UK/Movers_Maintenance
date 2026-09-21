using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using System.ComponentModel;
namespace Movers_Maintenance_Subsystem.AdditionalForms.Views
{
    public partial class ViewCheckup : Form
    {
        public ViewCheckup()
        {
            InitializeComponent();
            InitializeBindingList();
            RefreshDGV();
        }
        private BindingList<Checkup> BL;
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void InitializeBindingList()
        {
            BL = new BindingList<Checkup>();
            dgvCheckup.DataSource = BL;
        }

        private void RefreshDGV()
        {
            BL.Clear(); // Clear the BindingList, not DataGridView.Rows
            List<Checkup> c = DALCheckup.GetAll();
            foreach (Checkup ckp in c)
            {
                BL.Add(ckp); // Add items to the BindingList
            }
        }
    }
}
