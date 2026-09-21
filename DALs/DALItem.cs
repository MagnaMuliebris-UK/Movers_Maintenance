using Microsoft.Data.SqlClient;
using Movers_Maintenance_Subsystem.Models;
using System.Configuration;
using System.Data;
namespace Movers_Maintenance_Subsystem.DALs
{
    public class DALItem
    {
        private static string _connectionString = string.Format(ConfigurationManager.ConnectionStrings["MaintenanceConnectionString"].ConnectionString, Program.ConnectionStringEstablish());
        public static int Add(Item item)
        {
            using (SqlConnection Connection = new(_connectionString))
            {
                Connection.Open();
                SqlCommand insertItemCommand = new();
                insertItemCommand.Connection = Connection;
                //specifies this is a type of Stored Procedure
                insertItemCommand.CommandType = CommandType.StoredProcedure;
                //name of stored procedure we want to execute
                insertItemCommand.CommandText = "AddItem";
                //now add our parameters that are passed to the stored procedure
                insertItemCommand.Parameters.Add(new SqlParameter("@Item_Name", item.ItemName));
                insertItemCommand.Parameters.Add(new SqlParameter("@Description", item.ItemDescription));
                insertItemCommand.Parameters.Add(new SqlParameter("@Current_Quantity", item.CurrentQuantity));
                insertItemCommand.Parameters.Add(new SqlParameter("@Ideal_Quantity", item.IdealQuantity));

                int rowsAffected = insertItemCommand.ExecuteNonQuery();
                //close sqlconnection
                Connection.Close();
                DALActionCommenced.ItemDelCheckIiCInconsistencies();
                return rowsAffected;
            }

        }
        public static List<Item> GetAll()
        {
            List<Item> list = new List<Item>();
            using (SqlConnection con = new(_connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Item";
                SqlCommand SC = new SqlCommand(query, con);
                SqlDataReader SDR = SC.ExecuteReader();
                while (SDR.Read())
                {
                    Item i = new Item();
                    i.ItemName = (string)SDR["Item_Name"];
                    i.ItemDescription = (string)SDR["Description"];
                    i.IdealQuantity = (int)SDR["Ideal_Quantity"];
                    i.CurrentQuantity = (int)SDR["Current_Quantity"];
                    i.ItemID = (int)SDR["Item_ID"];
                    list.Add(i);
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
                    Connection.Open();
                    SqlCommand deleteCommand = new();
                    deleteCommand.Connection = Connection;
                    //specifies this is a type of Stored Procedure
                    deleteCommand.CommandType = CommandType.StoredProcedure;
                    //name of stored procedure we want to execute
                    deleteCommand.CommandText = "DeleteItem";
                    //now add our parameters that are passed to the stored procedure
                    deleteCommand.Parameters.Add(new SqlParameter("@Item_ID", id));

                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    //close sqlconnection
                    Connection.Close();
                    return rowsAffected;
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("This field depends on another field. Please delete that field first.");
            }
        }
        public static bool VaV(int id)
        {
            List<Item> list = GetAll();
            foreach (Item s in list)
            {
                if (s.ItemID == id)
                {
                    return true;
                }
            }
            return false;
        }
        public static int Update(Item item)
        {
            using (SqlConnection Connection = new(_connectionString))
            {
                Connection.Open();

                SqlCommand UpdateCommand = new();
                UpdateCommand.Connection = Connection;
                //specifies this is a type of Stored Procedure
                UpdateCommand.CommandType = CommandType.StoredProcedure;
                //name of stored procedure we want to execute
                UpdateCommand.CommandText = "UpdateItem";
                //now add our parameters that are passed to the stored procedure
                UpdateCommand.Parameters.Add(new SqlParameter("@Item_ID", item.ItemID));
                UpdateCommand.Parameters.Add(new SqlParameter("@Item_Name", item.ItemName));
                UpdateCommand.Parameters.Add(new SqlParameter("@Description", item.ItemDescription));
                UpdateCommand.Parameters.Add(new SqlParameter("@Current_Quantity", item.CurrentQuantity));
                UpdateCommand.Parameters.Add(new SqlParameter("@Ideal_Quantity", item.IdealQuantity));

                int rowsAffected = UpdateCommand.ExecuteNonQuery();
                //close sqlconnection
                Connection.Close();
                return rowsAffected;
            }
        }
    }
}