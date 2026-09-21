using Microsoft.Data.SqlClient;
using Movers_Maintenance_Subsystem.Models;
using System.Configuration;
using System.Data;

namespace Movers_Maintenance_Subsystem.DALs
{
    //ItemsUsedDAL
    internal class DALItemsInCheckup
    {
        private static string _connectionString = string.Format(ConfigurationManager.ConnectionStrings["MaintenanceConnectionString"].ConnectionString, Program.ConnectionStringEstablish());
        public static int Add(ItemsInCheckup IuIC)
        {
            //BUT!
            foreach(ItemsInCheckup i in GetAll())
            {
                if(i.ItemID == IuIC.ItemID&&i.CheckupID == IuIC.CheckupID)
                {
                    MessageBox.Show("This record already exists.");
                    return 0;
                }
            }
            if (validCheckup(IuIC) && validItem(IuIC) && validQuantity(IuIC))
            {
                using (SqlConnection Connection = new(_connectionString))
                {
                    Connection.Open();
                    SqlCommand insertCommand = new();
                    insertCommand.Connection = Connection;
                    //specifies this is a type of Stored Procedure
                    insertCommand.CommandType = CommandType.StoredProcedure;
                    //name of stored procedure we want to execute
                    insertCommand.CommandText = "AddCheckupCjtItem";
                    //now add our parameters that are passed to the stored procedure

                    insertCommand.Parameters.Add(new SqlParameter("@Checkup_ID", IuIC.CheckupID));
                    insertCommand.Parameters.Add(new SqlParameter("@Item_ID", IuIC.ItemID));
                    insertCommand.Parameters.Add(new SqlParameter("@Quantity_Used", IuIC.QuantityUsed));

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    List<Item> I = DALItem.GetAll();
                    Item it = new();
                    foreach (Item i in I)
                    {
                        if (i.ItemID == IuIC.ItemID)
                        {
                            i.CurrentQuantity -= IuIC.QuantityUsed;
                            it = i;
                        }
                    }
                    DALItem.Update(it);
                    if (OverarchingSettings.ReportActionIsEnabled)
                    {
                        MessageBox.Show("Item in checkup successfully recorded.", "Movers");
                    }
                    //close sqlconnection
                    Connection.Close();
                    return rowsAffected;
                }
            }
            else
            {
                if (!validItem(IuIC))
                {
                    MessageBox.Show("The item id that has been entered is invalid. Please enter a valid item id.");
                }
                else if (!validQuantity(IuIC))
                {
                    MessageBox.Show("The quantity entered that is being taken is larger than the reported quantity of the item in stock.");
                }
                if (!validCheckup(IuIC))
                {
                    MessageBox.Show("The checkup id that has been entered is invalid. Please enter a valid checkup id.");
                }
                return 0;
            }
        }
        public static int Remove(int CheckupID, int ItemID)
        {
            foreach (ItemsInCheckup i in GetAll())
            {
                if (i.CheckupID != CheckupID && i.ItemID != ItemID)
                {
                    MessageBox.Show("Record does not exist.");
                    return 0;
                }
            }
            using (SqlConnection Connection = new(_connectionString))
            {
                Connection.Open();
                SqlCommand insertCommand = new();
                insertCommand.Connection = Connection;
                //specifies this is a type of Stored Procedure
                insertCommand.CommandType = CommandType.StoredProcedure;
                //name of stored procedure we want to execute
                insertCommand.CommandText = "DeleteCheckupCjtItem";
                //now add our parameters that are passed to the stored procedure
                insertCommand.Parameters.Add(new SqlParameter("@Checkup_ID", CheckupID));
                insertCommand.Parameters.Add(new SqlParameter("@Item_ID", ItemID));

                int rowsAffected = insertCommand.ExecuteNonQuery();
                //close sqlconnection
                Connection.Close();
                if (!OverarchingSettings.ReportActionIsEnabled)
                {
                    MessageBox.Show("Successfully removed item from checkup.");
                }
                return rowsAffected;
            }
        }
        public static bool VaV(int idCheckup, int idItem)
        {
            List<ItemsInCheckup> list = GetAll();
            foreach (ItemsInCheckup s in list)
            {
                if (s.CheckupID == idCheckup&&s.ItemID == idItem)
                {
                    return true;
                }
            }
            return false;
        }
        public static List<ItemsInCheckup> GetAll()
        {
            List<ItemsInCheckup> list = new List<ItemsInCheckup>();
            using (SqlConnection con = new(_connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Checkup_Item";
                SqlCommand SC = new SqlCommand(query, con);
                SqlDataReader SDR = SC.ExecuteReader();
                while (SDR.Read())
                {
                    ItemsInCheckup IC = new ItemsInCheckup();
                    IC.ItemID = (int)SDR["Item_ID"];
                    IC.CheckupID = (int)SDR["Checkup_ID"];
                    IC.QuantityUsed = (int)SDR["Quantity_Used"];
                    list.Add(IC);
                }
                con.Close();
                return list;
            }
        }
        public static int Update(ItemsInCheckup IiC)
        {
            if (validCheckup(IiC) && validItem(IiC) && validQuantity(IiC))
            {
                using (SqlConnection Connection = new(_connectionString))
                {
                    ItemsInCheckup ic = new();
                    bool trip = false;
                    List<ItemsInCheckup> IC = GetAll();
                    foreach (ItemsInCheckup iC in IC)
                    {
                        if (iC.ItemID == IiC.ItemID && iC.CheckupID == IiC.CheckupID)
                        {
                            trip = true;
                            ic = iC;
                        }
                    }

                    if (!trip)
                    {
                        MessageBox.Show("The values inserted for the ids don't match with any current records");
                        return 0;
                    }
                    Connection.Open();
                    SqlCommand updateCommand = new();
                    updateCommand.Connection = Connection;
                    //specifies this is a type of Stored Procedure
                    updateCommand.CommandType = CommandType.StoredProcedure;
                    //name of stored procedure we want to execute
                    updateCommand.CommandText = "UpdateCheckupCjtItem";
                    //now add our parameters that are passed to the stored procedure

                    updateCommand.Parameters.Add(new SqlParameter("@Checkup_ID", IiC.CheckupID));
                    updateCommand.Parameters.Add(new SqlParameter("@ItemID", IiC.ItemID));
                    updateCommand.Parameters.Add(new SqlParameter("@Quantity_Used", IiC.QuantityUsed));

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    List<Item> I = DALItem.GetAll();
                    Item it = new();
                    foreach (Item i in I)
                    {
                        if (i.ItemID == IiC.ItemID)
                        {
                            i.CurrentQuantity -= IiC.QuantityUsed;
                            it = i;
                        }
                    }
                    DALItem.Update(it);
                    if (OverarchingSettings.ReportActionIsEnabled)
                    {
                        MessageBox.Show("Items used in checkup successfully updated.", "Movers");
                    }
                    //close sqlconnection
                    Connection.Close();
                    return rowsAffected;
                }
            }
            else
            {
                if (!validItem(IiC))
                {
                    MessageBox.Show("The item id that has been entered is invalid. Please enter a valid item id.");
                }
                else if (!validQuantity(IiC))
                {
                    MessageBox.Show("The quantity entered that is being taken is larger than the reported quantity of the item in stock.");
                }
                if (!validCheckup(IiC))
                {
                    MessageBox.Show("The checkup id that has been entered is invalid. Please enter a valid checkup id.");
                }
                return 0;
            }
        }
        #region Validity Checks
        public static bool validItem(int ItemID)
        {
            List<Item> items = DALItem.GetAll();
            foreach (Item i in items)
            {
                if (i.ItemID == ItemID)
                {
                    return true;
                }
            }
            //fallen out of loop - no correct matches
            return false;
        }
        public static bool validItem(ItemsInCheckup IuIC)
        {
            List<Item> items = DALItem.GetAll();
            foreach (Item i in items)
            {
                if (i.ItemID == IuIC.ItemID)
                {
                    return true;
                }
            }
            //fallen out of loop - no correct matches
            return false;
        }
        public static bool validCheckup(int CheckupID)
        {
            List<Checkup> checkups = DALCheckup.GetAll();
            foreach (Checkup i in checkups)
            {
                if (i.CheckupID == CheckupID)
                {
                    return true;
                }
            }
            //fallen out of loop - no correct matches
            return false;
        }

        public static bool validCheckup(ItemsInCheckup IiC)
        {
            List<Checkup> checkups = DALCheckup.GetAll();
            foreach (Checkup i in checkups)
            {
                if (i.CheckupID == IiC.CheckupID)
                {
                    return true;
                }
            }
            //fallen out of loop - no correct matches
            return false;
        }
        public static bool validQuantity(ItemsInCheckup IiC)
        {
            List<Item> items = DALItem.GetAll();
            foreach (Item i in items)
            {
                if (i.ItemID == IiC.ItemID)
                {
                    if (i.CurrentQuantity < IiC.QuantityUsed)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            //MEANS ITEM AIN'T VALID
            return false;
        }
        #endregion Validity Checks
    }
}
