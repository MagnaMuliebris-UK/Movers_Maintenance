using Movers_Maintenance_Subsystem.DALs;

namespace Movers_Maintenance_Subsystem.Models
{
    /// <summary>
    /// dbo.Staff Object
    /// </summary>
    public class Staff:Model
    {
        public int StaffID { get; set; } //Is auto in tables
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public bool Trainer { get; set; }
        public double Working_Hours { get; set; }
        public double Hourly_Salary { get; set; }
        public Staff(string fname, string sname, string pos, bool isTrainer, double WHours, double HSal)
        {
            Forename = fname;
            Surname = sname;
            Position = pos;
            Trainer = isTrainer;
            Working_Hours = WHours;
            Hourly_Salary = HSal;
        }

        public Staff()
        {

        }
    }
}
