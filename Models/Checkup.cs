namespace Movers_Maintenance_Subsystem.Models
{
    /// <summary>
    /// dbo.Checkup Object
    /// </summary>
    public class Checkup : Model
    {
        public int CheckupID { get; set; }
        public string Van_Condition { get; set; }
        public int VanID { get; set; }
        public bool IsMoTCheckup { get; set; }
        public int MechanicID { get; set; }
        public DateTime Checkup_Date { get; set; }
        public Checkup()
        {

        }
        public Checkup(string? van_Condition, int? vanID, bool? isMoTCheckup, int? staffID, DateTime? checkup_Date)
        {
            Van_Condition = van_Condition;
            VanID = (int)vanID;
            IsMoTCheckup = (bool)isMoTCheckup;
            MechanicID = (int)staffID;
            Checkup_Date = (DateTime)checkup_Date;
        }
    }
}
