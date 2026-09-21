namespace Movers_Maintenance_Subsystem.Models
{
    /// <summary>
    /// dbo.Session Object
    /// </summary>
    public class Session:Model
    {
        public int SessionID { get; set; } //autoset
        public string SessionType { get; set; }
        public DateTime SessionDate { get; set; }
        public Session()
        {

        }
        public Session(string sessionType, DateTime sessionDate)
        {
            SessionType = sessionType;
            SessionDate = sessionDate;
        }
    }
}
