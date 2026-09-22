using Microsoft.Data.SqlClient;
using Movers_Maintenance_Subsystem.Models;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
namespace Movers_Maintenance_Subsystem.DALs
{
    public class DALCheckup
    {
        private static string _connectionString = string.Format(ConfigurationManager.ConnectionStrings["MaintenanceConnectionString"].ConnectionString, Program.ConnectionStringEstablish());
        public static int Add(Checkup checkup)
        {
            string SELECTION = "0";
            if (checkup.IsMoTCheckup)
            {
                SELECTION = "1";
            }
            bool MechError = false;
            try
            {
                if (isMechanic(checkup.MechanicID))
                using (SqlConnection Connection = new(_connectionString))
                {
                    Connection.Open();
                    SqlCommand insertCheckupCommand = new();
                    insertCheckupCommand.Connection = Connection;
                    //specifies this is a type of Stored Procedure
                    insertCheckupCommand.CommandType = CommandType.StoredProcedure;
                    //name of stored procedure we want to execute
                    insertCheckupCommand.CommandText = "AddCheckup";
                    //now add our parameters that are passed to the stored procedure
                    insertCheckupCommand.Parameters.Add(new SqlParameter("@Staff_ID", checkup.MechanicID));
                    insertCheckupCommand.Parameters.Add(new SqlParameter("@Is_MoT_Checkup", SELECTION));
                    insertCheckupCommand.Parameters.Add(new SqlParameter("@Van_ID", checkup.VanID));
                    insertCheckupCommand.Parameters.Add(new SqlParameter("@Van_Condition", checkup.Van_Condition));
                    insertCheckupCommand.Parameters.Add(new SqlParameter("@Checkup_Date", checkup.Checkup_Date));

                    int rowsAffected = insertCheckupCommand.ExecuteNonQuery();
                    //close sqlconnection
                    Connection.Close();
                    return rowsAffected;
                }
                else
                {
                    MechError = true;
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                if (MechError)
                {
                    MessageBox.Show("The staff id does not correspond to that of a mechanic's, try again.");
                }
                else
                {
                    MessageBox.Show("The staff or van id does not correspond with the staff or van id in the database. Please try again.");
                }
                return 0;
            }

        }
        public static bool isMechanic(int staffID)
        {
            foreach (Staff s in DALStaff.GetAll())
            {
                if (s.StaffID == staffID)
                {
                    if (s.Position == "Mechanic") return true;
                    else return false;
                }
            }
            return false;
        }
        public static List<Checkup> GetAll()
        {
            List<Checkup> list = new List<Checkup>();
            using (SqlConnection con = new(_connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Checkup_Results";
                SqlCommand SC = new SqlCommand(query, con);
                SqlDataReader SDR = SC.ExecuteReader();
                while (SDR.Read())
                {
                    Checkup c = new Checkup();
                    c.MechanicID = (int)SDR["Staff_ID"];
                    if ((bool)SDR["Is_MoT_Checkup"])
                    {
                        c.IsMoTCheckup = true;
                    }
                    else
                    {
                        c.IsMoTCheckup = false;
                    }
                    c.VanID = (int)SDR["Van_ID"];
                    c.Van_Condition = (string)SDR["Van_Condition"];
                    c.CheckupID = (int)SDR["Checkup_ID"];
                    c.Checkup_Date = (DateTime)SDR["Checkup_Date"];
                    list.Add(c);
                }
                con.Close();
                return list;
            }
        }
        public static int Remove(int id)
        {
            try
            {
                using (SqlConnection Connection = new(_connectionString))
                {
                    if(OverarchingSettings.CascadeDeleteIsEnabled)
                    {
                        DALActionCommenced.CheckupDelCheckInconsistencies(id);
                    }
                    Connection.Open();
                    SqlCommand deleteCommand = new();
                    deleteCommand.Connection = Connection;
                    //specifies this is a type of Stored Procedure
                    deleteCommand.CommandType = CommandType.StoredProcedure;
                    //name of stored procedure we want to execute
                    deleteCommand.CommandText = "DeleteCheckup";
                    //now add our parameters that are passed to the stored procedure
                    deleteCommand.Parameters.Add(new SqlParameter("@Checkup_ID", id));

                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    //close sqlconnection
                    Connection.Close();
                    return rowsAffected;
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("This field is depended upon by another field - please remove the other field first.");
            }
        }
        public static bool VaV(int id)
        {
            List<Checkup> list = GetAll();
            foreach (Checkup s in list)
            {
                if (s.CheckupID == id)
                {
                    return true;
                }
            }
            return false;
        }
        public static int Update(Checkup c)
        {
            string SELECTION = "0";
            if (c.IsMoTCheckup)
            {
                SELECTION = "1";
            }
            bool MechIssue = false;
            try
            {
                if (isMechanic(c.MechanicID))
                {
                    using (SqlConnection Connection = new(_connectionString))
                    {
                        Connection.Open();
                        SqlCommand UpdateCheckupCommand = new();
                        UpdateCheckupCommand.Connection = Connection;
                        UpdateCheckupCommand.CommandType = CommandType.StoredProcedure;
                        //name of stored procedure we want to execute
                        UpdateCheckupCommand.CommandText = "UpdateCheckup";
                        //now add our parameters that are passed to the stored procedure
                        UpdateCheckupCommand.Parameters.Add(new SqlParameter("@Checkup_ID", c.CheckupID));
                        UpdateCheckupCommand.Parameters.Add(new SqlParameter("@Staff_ID", c.MechanicID));
                        UpdateCheckupCommand.Parameters.Add(new SqlParameter("@Is_MoT_Checkup", SELECTION));
                        UpdateCheckupCommand.Parameters.Add(new SqlParameter("@Van_ID", c.VanID));
                        UpdateCheckupCommand.Parameters.Add(new SqlParameter("@Van_Condition", c.Van_Condition));
                        UpdateCheckupCommand.Parameters.Add(new SqlParameter("@Checkup_Date", c.Checkup_Date));
                        int rowsAffected = UpdateCheckupCommand.ExecuteNonQuery();
                        //close sqlconnection
                        Connection.Close();
                        return rowsAffected;
                    }

                }
                else
                {
                    MechIssue = true;
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                if (MechIssue)
                {
                    MessageBox.Show("The staff id does not correspond to that of a mechanic's, try again.");
                }
                else
                {
                    MessageBox.Show("The staff or van id does not correspond with the staff or van id in the database. Please try again.");
                }
                return 0;
            }
        }
    }
}
