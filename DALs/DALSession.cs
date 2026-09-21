using Microsoft.Data.SqlClient;
using Movers_Maintenance_Subsystem.Models;
using System.Configuration;
using System.Data;
namespace Movers_Maintenance_Subsystem.DALs
{
    public class DALSession
    {
        private static string _connectionString = string.Format(ConfigurationManager.ConnectionStrings["MaintenanceConnectionString"].ConnectionString, Program.ConnectionStringEstablish());
        public static int Add(Session session)
        {

            using (SqlConnection Connection = new(_connectionString))
            {
                Connection.Open();
                SqlCommand insertSessionCommand = new();
                insertSessionCommand.Connection = Connection;
                //specifies this is a type of Stored Procedure
                insertSessionCommand.CommandType = CommandType.StoredProcedure;
                //name of stored procedure we want to execute
                insertSessionCommand.CommandText = "AddSession";
                //now add our parameters that are passed to the stored procedure
                insertSessionCommand.Parameters.Add(new SqlParameter("@Session_Type", session.SessionType));
                insertSessionCommand.Parameters.Add(new SqlParameter("@Session_Date", session.SessionDate));

                int rowsAffected = insertSessionCommand.ExecuteNonQuery();
                //close sqlconnection
                Connection.Close();
                return rowsAffected;
            }

        }
        public static List<Session> GetAll()
        {
            List<Session> list = new List<Session>();
            using (SqlConnection con = new(_connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Session";
                SqlCommand SC = new SqlCommand(query, con);
                SqlDataReader SDR = SC.ExecuteReader();
                while (SDR.Read())
                {
                    Session s = new Session();
                    s.SessionID = (int)SDR["Session_ID"];
                    s.SessionType = (string)SDR["Session_Type"];
                    s.SessionDate = (DateTime)SDR["Session_Date"];
                    list.Add(s);
                }
                con.Close();
                return list;
            }
        }
        public static int Remove(int SessionID)
        {
            try
            {
                using (SqlConnection Connection = new(_connectionString))
                {
                    Connection.Open();
                    SqlCommand deleteCommand = new();
                    deleteCommand.Connection = Connection;
                    //specifies this is a type of Stored Procedure
                    deleteCommand.CommandType = CommandType.StoredProcedure;
                    //name of stored procedure we want to execute
                    deleteCommand.CommandText = "DeleteSession";
                    //now add our parameters that are passed to the stored procedure
                    deleteCommand.Parameters.Add(new SqlParameter("@Session_ID", SessionID));

                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    //close sqlconnection
                    Connection.Close();
                    DALActionCommenced.SessionDelCheckSiSInconsistencies();
                    return rowsAffected;
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("This field is depended upon by another field, try deleting that field first.");
                return -1;
            }
        }
        public static bool VaV(int id)
        {
            List<Session> list = GetAll();
            foreach (Session s in list)
            {
                if (s.SessionID == id)
                {
                    return true;
                }
            }
            return false;
        }
        public static int Update(Session session)
        {
            using (SqlConnection Connection = new(_connectionString))
            {
                Connection.Open();

                SqlCommand UpdateCommand = new();
                UpdateCommand.Connection = Connection;
                //specifies this is a type of Stored Procedure
                UpdateCommand.CommandType = CommandType.StoredProcedure;
                //name of stored procedure we want to execute
                UpdateCommand.CommandText = "UpdateSession";
                //now add our parameters that are passed to the stored procedure
                UpdateCommand.Parameters.Add(new SqlParameter("@Session_ID", session.SessionID));
                UpdateCommand.Parameters.Add(new SqlParameter("@Session_Date", session.SessionDate));
                UpdateCommand.Parameters.Add(new SqlParameter("@Session_Type", session.SessionType));

                int rowsAffected = UpdateCommand.ExecuteNonQuery();
                //close sqlconnection
                Connection.Close();
                return rowsAffected;
            }
        }
    }
}