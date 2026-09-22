using Microsoft.Data.SqlClient;
using Movers_Maintenance_Subsystem.Models;
using System.Configuration;
using System.Data;
using System.Linq.Expressions;

namespace Movers_Maintenance_Subsystem.DALs
{
    internal class DALStaff
    {
        private static string _connectionString = string.Format(ConfigurationManager.ConnectionStrings["MaintenanceConnectionString"].ConnectionString, Program.ConnectionStringEstablish());
        public static int Add(Staff staff)
        {
            string SELECTION = "0";
            if (staff.Trainer)
            {
                SELECTION = "1";
            }

            using (SqlConnection Connection = new(_connectionString))
            {
                Connection.Open();
                SqlCommand insertStaffCommand = new();
                insertStaffCommand.Connection = Connection;
                //specifies this is a type of Stored Procedure
                insertStaffCommand.CommandType = CommandType.StoredProcedure;
                //name of stored procedure we want to execute
                insertStaffCommand.CommandText = "AddStaff";
                //now add our parameters that are passed to the stored procedure
                insertStaffCommand.Parameters.Add(new SqlParameter("@Forename", staff.Forename));
                insertStaffCommand.Parameters.Add(new SqlParameter("@Surname", staff.Surname));
                insertStaffCommand.Parameters.Add(new SqlParameter("@Position", staff.Position));
                insertStaffCommand.Parameters.Add(new SqlParameter("@Is_Trainer", SELECTION));
                insertStaffCommand.Parameters.Add(new SqlParameter("@Working_Hours", staff.Working_Hours));
                insertStaffCommand.Parameters.Add(new SqlParameter("@Hourly_Salary", staff.Hourly_Salary));

                int rowsAffected = insertStaffCommand.ExecuteNonQuery();
                //close sqlconnection
                Connection.Close();
                return rowsAffected;
            }
        }
        public static int Remove(int StaffID)
        {
            try
            {
                using (SqlConnection Connection = new(_connectionString))
                {
                    if(OverarchingSettings.CascadeDeleteIsEnabled)
                    {
                        DALActionCommenced.StaffDelCheckInconsistencies(id);
                    }
                    Connection.Open();
                    SqlCommand removeStaffCommand = new();
                    removeStaffCommand.Connection = Connection;
                    //specifies this is a type of Stored Procedure
                    removeStaffCommand.CommandType = CommandType.StoredProcedure;
                    //name of stored procedure we want to execute
                    removeStaffCommand.CommandText = "DeleteStaff";
                    //now add our parameters that are passed to the stored procedure
                    removeStaffCommand.Parameters.Add(new SqlParameter("@Staff_ID", StaffID));
                    int rowsAffected = removeStaffCommand.ExecuteNonQuery();
                    //close sqlconnection
                    Connection.Close();
                    return rowsAffected;
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("This another field is reliant on this field and hence this field cannot be deleted");
                return -1;
            }
        }
        public static List<Staff> GetAll()
        {
            List<Staff> list = new List<Staff>();
            using (SqlConnection con = new(_connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Staff";
                SqlCommand SC = new SqlCommand(query, con);
                SqlDataReader SDR = SC.ExecuteReader();
                while (SDR.Read())
                {
                    Staff s = new Staff();
                    s.StaffID = (int)SDR["Staff_ID"];
                    if ((bool)SDR["Is_Trainer"])
                    {
                        s.Trainer = true;
                    }
                    else
                    {
                        s.Trainer = false;
                    }
                    s.Position = (string)SDR["Position"];
                    s.Working_Hours = (int)SDR["Working_Hours"];
                    s.Forename = (string)SDR["Forename"];
                    s.Hourly_Salary = Convert.ToDouble((decimal)SDR["Hourly_Salary"]);
                    s.Surname = (string)SDR["Surname"];
                    list.Add(s);
                }
                con.Close();
                return list;
            }
        }
        /// <summary>
        /// VaV means 'Validate and View'
        /// </summary>
        public static bool VaV(int id)
        {
            List<Staff> list = GetAll();
            foreach (Staff s in list)
            {
                if (s.StaffID == id)
                {
                    return true;
                }
            }
            return false;
        }
            public static int Update(Staff c)
            {
            string SELECTION = "0";
            if (c.Trainer)
            {
                SELECTION = "1";
            }
            using (SqlConnection Connection = new(_connectionString))
            {
                Connection.Open();
                SqlCommand UpdateStaffCommand = new();
                UpdateStaffCommand.Connection = Connection;
                UpdateStaffCommand.CommandType = CommandType.StoredProcedure;
                //name of stored procedure we want to execute
                UpdateStaffCommand.CommandText = "UpdateStaff";
                //now add our parameters that are passed to the stored procedure
                UpdateStaffCommand.Parameters.Add(new SqlParameter("@Staff_ID", c.StaffID));
                UpdateStaffCommand.Parameters.Add(new SqlParameter("@Forename", c.Forename));
                UpdateStaffCommand.Parameters.Add(new SqlParameter("@Surname", c.Surname));
                UpdateStaffCommand.Parameters.Add(new SqlParameter("@Position", c.Position));
                UpdateStaffCommand.Parameters.Add(new SqlParameter("@Is_Trainer", SELECTION));
                UpdateStaffCommand.Parameters.Add(new SqlParameter("@Working_Hours", c.Working_Hours));
                UpdateStaffCommand.Parameters.Add(new SqlParameter("@Hourly_Salary", c.Hourly_Salary));
                int rowsAffected = UpdateStaffCommand.ExecuteNonQuery();
                //close sqlconnection
                Connection.Close();
                return rowsAffected;
            }
        }
    }
}
