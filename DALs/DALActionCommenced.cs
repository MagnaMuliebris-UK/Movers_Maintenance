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
    /// If an action in a DAL is suspected to interfere with another DAL, it goes here
    /// </summary>
    public class DALActionCommenced
    {
        public static void StaffDelCheckSiSInconsistencies()
        {
            bool Validated = false;
            List<Staff> staff = DALStaff.GetAll();
            List<StaffInSessions> SiS = DALStaffInSessions.GetAll();
            foreach (StaffInSessions s in SiS)
            {
                foreach (Staff stf in staff)
                {
                    if (s.StaffID == stf.StaffID)
                    {
                        Validated = true;
                    }

                }
                if (!Validated)
                {
                    DALStaffInSessions.Remove(s.StaffID, s.SessionID);
                }
                Validated = false;
            }
        }
        public static void SessionDelCheckSiSInconsistencies()
        {
            bool Validated = false;
            List<Session> sessions = DALSession.GetAll();
            List<StaffInSessions> SiS = DALStaffInSessions.GetAll();
            foreach (StaffInSessions s in SiS)
            {
                foreach (Session session in sessions)
                {
                    if (s.SessionID == session.SessionID)
                    {
                        Validated = true;
                    }

                }
                if (!Validated)
                {
                    DALStaffInSessions.Remove(s.StaffID, s.SessionID);
                }
                Validated = false;
            }
        }
        public static void CheckupDelCheckIiCInconsistencies()
        {
            bool Validated = false;
            List<Checkup> cUP = DALCheckup.GetAll();
            List<ItemsInCheckup> IiC = DALItemsInCheckup.GetAll();
            foreach (ItemsInCheckup iic in IiC)
            {
                foreach (Checkup c in cUP)
                {
                    if (iic.CheckupID == c.CheckupID)
                    {
                        Validated = true;
                    }

                }
                if (!Validated)
                {
                    DALItemsInCheckup.Remove(iic.CheckupID, iic.ItemID);
                }
                Validated = false;
            }
        }
        public static void ItemDelCheckIiCInconsistencies()
        {
            bool Validated = false;
            List<Item> itm = DALItem.GetAll();
            List<ItemsInCheckup> IiC = DALItemsInCheckup.GetAll();
            foreach (ItemsInCheckup iic in IiC)
            {
                foreach (Item i in itm)
                {
                    if (iic.ItemID == i.ItemID)
                    {
                        Validated = true;
                    }

                }
                if (!Validated)
                {
                    DALItemsInCheckup.Remove(iic.CheckupID, iic.ItemID);
                }
                Validated = false;
            }
        }
    }
}
