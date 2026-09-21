namespace Movers_Maintenance_Subsystem.Models
{
    /// <summary>
    /// dbo.Checkup_Item Object
    /// </summary>
    public class ItemsInCheckup:Model
    {
        public int ItemID { get; set; }
        public int CheckupID { get; set; }
        public int QuantityUsed { get; set; }
        public ItemsInCheckup()
        {

        }
        public ItemsInCheckup(int Quantity)
        {
            QuantityUsed = Quantity;
        }

    }
}
