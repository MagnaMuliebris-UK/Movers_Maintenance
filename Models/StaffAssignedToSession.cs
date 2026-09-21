namespace Movers_Maintenance_Subsystem.Models
{
    /// <summary>
    /// dbo.Staff_Session Object
    /// </summary>
    public class StaffInSessions : Model
    {
        public int SessionID { get; set; }
        public int StaffID { get; set; }
        public int TrainerID { get; set; }
        public StaffInSessions()
        {

        }
        public StaffInSessions(int trainerId)
        {
            TrainerID = trainerId;
        }
    }
}
