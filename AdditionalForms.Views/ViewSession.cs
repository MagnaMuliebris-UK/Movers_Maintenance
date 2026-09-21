using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using System.ComponentModel;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Views
{
    public partial class ViewSession : Form
    {
        public ViewSession()
        {
            InitializeComponent();
            InitializeBindingList();
            RefreshDGV();
        }
        private BindingList<Session> BL;
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void InitializeBindingList()
        {
            BL = new BindingList<Session>();
            dgvSession.DataSource = BL;
        }

        private void RefreshDGV()
        {
            BL.Clear(); // Clear the BindingList, not DataGridView.Rows
            List<Session> se = DALSession.GetAll();
            foreach (Session s in se)
            {
                BL.Add(s); // Add items to the BindingList
            }
        }
    }
}
