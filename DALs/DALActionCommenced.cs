using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Movers_Maintenance_Subsystem.Models;

namespace Movers_Maintenance_Subsystem.DALs
{
    /// <summary>
    /// If an action in a DAL is suspected to interfere with a different database, it goes here. Goes hand in hand with CascadeDelete Setting.
    /// </summary>
    public class DALActionCommenced
    {
        public static void StaffDelCheckInconsistencies(int delStaffID)
        {
            List<Checkup> check = DALCheckup.GetAll();
            List<Van> van = DALVan.GetAll();
            List<StaffInSessions> SiS = DALStaffInSessions.GetAll();
            foreach(Van v in van)
            {
               if (v.DriverID == delStaffID)
               {
                    DALVan.Remove(v.VanID);
               }
            }
            foreach(Checkup c in check)
            {
                if(c.MechanicID == delStaffID)
                {
                    DALCheckup.Remove(c.CheckupID);
                }
            }
            foreach(StaffInSessions s in SiS)
            {
                if(s.StaffID==delStaffID||s.TrainerID==delStaffID)
                {
                    DALStaffInSessions.Remove(s.StaffID, s.SessionID);
                }
        }
        public static void VanDelCheckInconsistencies(int delVanID)
        {
            List<Checkup> check = DALCheckup.GetAll();
            foreach (Checkup c in check)
            {
                if(delVanID==c.VanID)
                {
                    DALCheckup.Remove(c.CheckupID);
                }
            }
        }
        public static void SessionDelCheckInconsistencies(int delSessionID)
        {
            List<StaffInSessions> SiS = DALStaffInSessions.GetAll();
            foreach (StaffInSessions s in SiS)
            {
                if (s.SessionID == delSessionID)
                {
                    DALStaffInSessions.Remove(s.StaffID, s.SessionID);
                }
            }
        }
        public static void CheckupDelCheckInconsistencies(int delCheckupID)
        {
            List<ItemsInCheckup> IiC = DALItemsInCheckup.GetAll();
            foreach (ItemsInCheckup iic in IiC)
            {
                if (iic.CheckupID == delCheckupID)
                {
                    DALItemsInCheckup.Remove(iic.CheckupID, iic.ItemID);
                }
            }
        }
        public static void ItemDelCheckInconsistencies(int delItemID)
        {
            List<ItemsInCheckup> IiC = DALItemsInCheckup.GetAll();
            foreach (ItemsInCheckup iic in IiC)
            {
                if (iic.ItemID == delItemID)
                {
                    DALItemsInCheckup.Remove(iic.CheckupID, iic.ItemID);
                }
            }
        }
    }
}
