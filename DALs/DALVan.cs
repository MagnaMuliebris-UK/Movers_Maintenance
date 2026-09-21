using Microsoft.Data.SqlClient;
using Movers_Maintenance_Subsystem.Models;
using System.Configuration;
using System.Data;

namespace Movers_Maintenance_Subsystem.DALs
{
    public class DALVan
    {
        private static string _connectionString = string.Format(ConfigurationManager.ConnectionStrings["MaintenanceConnectionString"].ConnectionString, Program.ConnectionStringEstablish());
        public static int Add(Van van)
        {
            string SELECTION = "0";
            if (van.Is_In_Use)
            {
                SELECTION = "1";
            }

            if (IsDriverSpecVan(van))
            {
                using (SqlConnection Connection = new(_connectionString))
                {
                    Connection.Open();
                    SqlCommand insertVanCommand = new();
                    insertVanCommand.Connection = Connection;
                    //specifies this is a type of Stored Procedure
                    insertVanCommand.CommandType = CommandType.StoredProcedure;
                    //name of stored procedure we want to execute
                    insertVanCommand.CommandText = "AddVan";
                    //now add our parameters that are passed to the stored procedure
                    insertVanCommand.Parameters.Add(new SqlParameter("@Van_Make", van.Van_Make));
                    insertVanCommand.Parameters.Add(new SqlParameter("@Is_In_Use", SELECTION));
                    insertVanCommand.Parameters.Add(new SqlParameter("@Staff_ID", van.DriverID));
                    insertVanCommand.Parameters.Add(new SqlParameter("@MOT_Exp_Date", van.MOT_Expiry_Date));

                    int rowsAffected = insertVanCommand.ExecuteNonQuery();
                    //close sqlconnection
                    Connection.Close();
                    return rowsAffected;
                }
            }
            else
            {
                //runs out - Message already displayed. No further action required.
                return 0;
            }
        }
        public static bool IsDriverSpecVan(Van van)
        {
            List<Staff> staff = DALStaff.GetAll();

            foreach (Staff s in staff)
            {
                if (s.StaffID == van.DriverID)
                {
                    //Rename Positions later
                    if (s.Position != "Driver")
                    {
                        MessageBox.Show("Van_ID: " + van.VanID + " Staff_ID: " + s.StaffID + " Not a Driver");
                        return false;
                    }
                }
            }
            return true;
        }
        public static List<Van> GetAll()
        {
            List<Van> list = new List<Van>();
            using (SqlConnection con = new(_connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Van";
                SqlCommand SC = new SqlCommand(query, con);
                SqlDataReader SDR = SC.ExecuteReader();
                while (SDR.Read())
                {
                    Van v = new Van();
                    v.VanID = (int)SDR["Van_ID"];
                    v.MOT_Expiry_Date = (DateTime)SDR["MOT_Exp_Date"];
                    v.Van_Make = (string)SDR["Van_Make"];
                    v.Is_In_Use = (bool)SDR["Is_In_Use"];
                    v.DriverID = (int)SDR["Staff_ID"];
                    list.Add(v);
                }
                con.Close();
            }
            return list;
        }
        public static int Remove(int id)
        {
            try
            {
                using (SqlConnection Connection = new(_connectionString))
                {
                    Connection.Open();
                    SqlCommand removeVanCommand = new();
                    removeVanCommand.Connection = Connection;
                    //specifies this is a type of Stored Procedure
                    removeVanCommand.CommandType = CommandType.StoredProcedure;
                    //name of stored procedure we want to execute
                    removeVanCommand.CommandText = "DeleteVan";
                    //now add our parameters that are passed to the stored procedure
                    removeVanCommand.Parameters.Add(new SqlParameter("@Van_ID", id));
                    int rowsAffected = removeVanCommand.ExecuteNonQuery();
                    //close sqlconnection
                    Connection.Close();
                    return rowsAffected;
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Another field is dependant on this field.");
                return -1;
            }
        }
        public static bool VaV(int id)
        {
            List<Van> list = GetAll();
            foreach (Van s in list)
            {
                if (s.VanID == id)
                {
                    return true;
                }
            }
            return false;
        }
        public static int Update(Van v)
        {
            if (IsDriverSpecVan(v))
            {
                try
                {
                    using (SqlConnection Connection = new(_connectionString))
                    {
                        Connection.Open();

                        string SELECTION = "0";
                        if (v.Is_In_Use)
                        {
                            SELECTION = "1";
                        }
                        SqlCommand UpdateCommand = new();
                        UpdateCommand.Connection = Connection;
                        //specifies this is a type of Stored Procedure
                        UpdateCommand.CommandType = CommandType.StoredProcedure;
                        //name of stored procedure we want to execute
                        UpdateCommand.CommandText = "UpdateVan";
                        //now add our parameters that are passed to the stored procedure
                        UpdateCommand.Parameters.Add(new SqlParameter("@Van_ID", v.VanID));
                        UpdateCommand.Parameters.Add(new SqlParameter("@Driver_ID", v.DriverID));
                        UpdateCommand.Parameters.Add(new SqlParameter("@Is_In_Use", SELECTION));
                        UpdateCommand.Parameters.Add(new SqlParameter("@MOT_Exp_Date", v.MOT_Expiry_Date));
                        UpdateCommand.Parameters.Add(new SqlParameter("@Van_Make", v.Van_Make));

                        int rowsAffected = UpdateCommand.ExecuteNonQuery();
                        //close sqlconnection
                        Connection.Close();
                        return rowsAffected;
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("This another field is reliant on this field and hence this field cannot be deleted");
                    return -1;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
