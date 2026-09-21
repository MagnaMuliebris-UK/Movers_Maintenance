using Movers_Maintenance_Subsystem.DALs;
using Movers_Maintenance_Subsystem.Models;
using NeaterOperations;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Updates
{
    public partial class UpdateCheckupCjtItem : Form
    {
        public UpdateCheckupCjtItem()
        {
            InitializeComponent();
            if (!OverarchingSettings.HelpButtonsIsEnabled)
            {
                FC.Disable(btnHELP);
            }
        }

        private void btnUpdRecord_Click(object sender, EventArgs e)
        {
            ItemsInCheckup newIiC = new();
            newIiC.CheckupID = (int)updnCID.Value;
            newIiC.ItemID = (int)updnIID.Value;
            newIiC.QuantityUsed = (int)updnNumUsed.Value;
            DALItemsInCheckup.Update(newIiC);
        }
        private void btnWipe_Click(object sender, EventArgs e)
        {
            updnCID.Value = 0;
            updnIID.Value = 0;
            updnNumUsed.Value = 0;
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Checkup ID: the id of the checkup where the items are bein used.\nItem ID: the id of the items being used in the checkup.\nQuantity Used: the quantity of the given item, used in the given checkup.", "Movers");
        }
    }
}
