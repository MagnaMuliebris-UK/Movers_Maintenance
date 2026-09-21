namespace Movers_Maintenance_Subsystem.Models
{
    /// <summary>
    /// dbo.Van Object
    /// </summary>
    public class Van:Model
    {
        public int VanID { get; set; }
        public string Van_Make { get; set; }
        public DateTime MOT_Expiry_Date { get; set; }
        public int DriverID { get; set; }
        public bool Is_In_Use { get; set; }
        public Van()
        {

        }

        public Van(string? vanMake, DateTime? motExpDate, int? staffID, bool? inUse)
        {
            Van_Make = vanMake;
            MOT_Expiry_Date = (DateTime)motExpDate;
            DriverID = (int)staffID;
            Is_In_Use = (bool)inUse;
        }
    }
}
