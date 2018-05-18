using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_Ca
    {
        public static string GetCurrentIndexTable()
        {
            return null;
        }
        public static int CheckCountInCurrentTable()
        {
            DataTable result = DatabaseHelper.GetData(@"Select * from Ca");
            return result.Rows.Count;
        }

        public static DataTable GetDataTable()
        {
            DataTable result = DatabaseHelper.GetData(@"Select * from Ca");
            return result;
        }

        public static bool InsertCa(DTO_Ca ca)
        {
            string sTruyVan = string.Format("Insert into Ca(TenCa) values (N'{0}')", ca.TenCa);
            try
            {
                int state = DatabaseHelper.ExcuteSql(sTruyVan);
                if (state > 0)
                    return true;
            }
            catch 
            {
                return false;
            }
            return false;
        }

        public static bool DeleteCa(DTO_Ca ca)
        {
            string sTruyVan = string.Format("Delete from Ca where MaCa = {0}", ca.MaCa);
            try
            {
                int state = DatabaseHelper.ExcuteSql(sTruyVan);
                if (state > 0)
                    return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public static bool UpdateCa(DTO_Ca ca)
        {
            string sTruyVan = string.Format("Update Ca set TenCa=N'{0}' where MaCa={1}", ca.TenCa, ca.MaCa);
            try
            {
                int state = DatabaseHelper.ExcuteSql(sTruyVan);
                if (state > 0)
                    return true;
            }
            catch 
            {

            }
            return false;
        }
    }
}
