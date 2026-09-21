using Microsoft.Data.SqlClient;
using Movers_Maintenance_Subsystem.Models;
using System.Configuration;
using System.Data;

namespace Movers_Maintenance_Subsystem.DALs
{
    //SessionStaffDAL
    internal class DALStaffInSessions
    {
        private static string _connectionString = string.Format(ConfigurationManager.ConnectionStrings["MaintenanceConnectionString"].ConnectionString, Program.ConnectionStringEstablish());
        public static int Add(StaffInSessions sATS)
        {
            foreach(StaffInSessions s in GetAll())
            {
                if(s.StaffID == sATS.StaffID&&s.SessionID ==sATS.SessionID)
                {
                    MessageBox.Show("Record already exists.");
                    return 0;
                }
            }
            if (IsValidStaff(sATS) && IsValidSession(sATS) && IsTrainerSpecSession(sATS) && !IsStaffAndTrainerSame(sATS))
            {
                using (SqlConnection Connection = new(_connectionString))
                {
                    Connection.Open();
                    SqlCommand insertCommand = new();
                    insertCommand.Connection = Connection;
                    //specifies this is a type of Stored Procedure
                    insertCommand.CommandType = CommandType.StoredProcedure;
                    //name of stored procedure we want to execute
                    insertCommand.CommandText = "AddStaffCjtSession";
                    //now add our parameters that are passed to the stored procedure
                    insertCommand.Parameters.Add(new SqlParameter("@Staff_ID", sATS.StaffID));
                    insertCommand.Parameters.Add(new SqlParameter("@Session_ID", sATS.SessionID));
                    insertCommand.Parameters.Add(new SqlParameter("@Trainer_ID", sATS.TrainerID));

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    //close sqlconnection
                    Connection.Close();
                    return rowsAffected;
                }
            }
            else
            {
                if (!IsValidStaff(sATS))
                {
                    MessageBox.Show("The staff id that has been entered is invalid. Please enter a valid staff id.");
                }
                if (!IsValidSession(sATS))
                {
                    MessageBox.Show("The session id that has been entered is invalid. Please enter a valid session id.");
                }
                if (IsStaffAndTrainerSame(sATS))
                {
                    MessageBox.Show("Staff ID and Trainer ID must be distinct, please try again");
                }
                //runs out - Message already displayed. No further action required.
                return 0;
            }
        }
        public static int Remove(int StaffID, int SessionID)
        {
            foreach (StaffInSessions s in GetAll())
            {
                if (s.StaffID != StaffID && s.SessionID != SessionID)
                {
                    MessageBox.Show("Record does not exist.");
                    return 0;
                }
            }
            using (SqlConnection Connection = new(_connectionString))
            {
                Connection.Open();
                SqlCommand deleteCommand = new();
                deleteCommand.Connection = Connection;
                //specifies this is a type of Stored Procedure
                deleteCommand.CommandType = CommandType.StoredProcedure;
                //name of stored procedure we want to execute
                deleteCommand.CommandText = "DeleteStaffCjtSession";
                //now add our parameters that are passed to the stored procedure
                deleteCommand.Parameters.Add(new SqlParameter("@Staff_ID", StaffID));
                deleteCommand.Parameters.Add(new SqlParameter("@Session_ID", SessionID));

                int rowsAffected = deleteCommand.ExecuteNonQuery();
                //close sqlconnection
                Connection.Close();
                if (OverarchingSettings.ReportActionIsEnabled)
                {
                    MessageBox.Show("Staff member successfully removed.", "Movers");
                }
                return rowsAffected;
            }
        }
        public static int Update(StaffInSessions sATS)
        {
            if (IsValidStaff(sATS) && IsValidSession(sATS) && IsTrainerSpecSession(sATS) && !IsStaffAndTrainerSame(sATS))
            {
                using (SqlConnection Connection = new(_connectionString))
                {
                    Connection.Open();
                    SqlCommand UpdateCommand = new();
                    UpdateCommand.Connection = Connection;
                    UpdateCommand.CommandType = CommandType.StoredProcedure;
                    //name of stored procedure we want to execute
                    UpdateCommand.CommandText = "UpdateSessionCjtStaff";
                    //now add our parameters that are passed to the stored procedure
                    UpdateCommand.Parameters.Add(new SqlParameter("@Staff_ID", sATS.StaffID));
                    UpdateCommand.Parameters.Add(new SqlParameter("@Session_ID", sATS.SessionID));
                    UpdateCommand.Parameters.Add(new SqlParameter("@Trainer_ID", sATS.TrainerID));
                    int rowsAffected = UpdateCommand.ExecuteNonQuery();
                    //close sqlconnection
                    Connection.Close();
                    if (OverarchingSettings.ReportActionIsEnabled)
                    {
                        MessageBox.Show("Staff member in Session successfully updated.", "Movers");
                    }
                    return rowsAffected;
                }
            }
            else
            {
                if (!IsValidStaff(sATS))
                {
                    MessageBox.Show("The staff id that has been entered is invalid. Please enter a valid staff id.");
                }
                if (!IsValidSession(sATS))
                {
                    MessageBox.Show("The session id that has been entered is invalid. Please enter a valid session id.");
                }
                if (IsStaffAndTrainerSame(sATS))
                {
                    MessageBox.Show("Staff ID and Trainer ID must be distinct, please try again");
                }
                //runs out - Message already displayed. No further action required.
                return 0;
            }
        }
        public static bool VaV(int idStaff, int idSession)
        {
            List<StaffInSessions> list = GetAll();
            foreach (StaffInSessions s in list)
            {
                if (s.StaffID == idStaff&&s.SessionID == idSession)
                {
                    return true;
                }
            }
            return false;
        }
        public static List<StaffInSessions> GetAll()
        {
            List<StaffInSessions> list = new List<StaffInSessions>();
            using (SqlConnection con = new(_connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Session_Staff";
                SqlCommand SC = new SqlCommand(query, con);
                SqlDataReader SDR = SC.ExecuteReader();
                while (SDR.Read())
                {
                    StaffInSessions SaTS = new StaffInSessions();
                    SaTS.StaffID = (int)SDR["Staff_ID"];
                    SaTS.SessionID = (int)SDR["Session_ID"];
                    SaTS.TrainerID = (int)SDR["Trainer_ID"];
                    list.Add(SaTS);
                }
                con.Close();                
            }
            return list;
        }
        #region Validity Checks
        public static bool IsTrainerSpecSession(StaffInSessions sATS)
        {
            List<Staff> staff = DALStaff.GetAll();

            foreach (Staff s in staff)
            {
                if (s.StaffID == sATS.TrainerID)
                {
                    if (!s.Trainer)
                    {
                        MessageBox.Show("Session_ID: " + sATS.SessionID + " Staff_ID: " + s.StaffID + " Not qualified to Train Staff.");
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool IsTrainerSpecSession(int SuspectedTrainerID)
        {
            List<Staff> staff = DALStaff.GetAll();

            foreach (Staff s in staff)
            {
                if (s.StaffID == SuspectedTrainerID)
                {
                    if (!s.Trainer)
                    {
                        MessageBox.Show(" Staff_ID: " + s.StaffID + " Not qualified to Train Staff.");
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool IsValidSession(int SessionID)
        {
            List<Session> list = DALSession.GetAll();
            foreach (Session s in list)
            {
                if (s.SessionID == SessionID)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsValidSession(StaffInSessions SaTS)
        {
            List<Session> list = DALSession.GetAll();
            foreach (Session s in list)
            {
                if (s.SessionID == SaTS.SessionID)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsValidStaff(int StaffID)
        {
            List<Staff> list = DALStaff.GetAll();
            foreach (Staff s in list)
            {
                if (s.StaffID == StaffID)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsValidStaff(StaffInSessions SaTS)
        {
            List<Staff> list = DALStaff.GetAll();
            foreach (Staff s in list)
            {
                if (s.StaffID == SaTS.StaffID)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsStaffAndTrainerSame(StaffInSessions sis)
        {
            if(sis.StaffID == sis.TrainerID)
            {
                return true;
            }
            return false;
        }
        #endregion Validity Checks
    }
}
