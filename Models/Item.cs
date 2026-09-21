namespace Movers_Maintenance_Subsystem.Models
{
    /// <summary>
    /// dbo.Item object
    /// </summary>
    public class Item:Model
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int IdealQuantity { get; set; }
        public int CurrentQuantity { get; set; }
        public Item()
        {

        }
        public Item(string itemName, string itemDescription, int idealQuantity, int currentQuantity)
        {
            ItemName = itemName;
            ItemDescription = itemDescription;
            IdealQuantity = idealQuantity;
            CurrentQuantity = currentQuantity;
        }
    }
}
