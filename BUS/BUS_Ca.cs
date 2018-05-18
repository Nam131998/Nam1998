using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;

namespace BUS
{
    public class BUS_Ca
    {
        public static string GetCurrentIndexTable()
        {
            return null;
        }
        public static int CheckCountInCurrentTable()
        {
            return DAO_Ca.CheckCountInCurrentTable();
        }
        public static DataTable GetDataTable()
        {
            return DAO_Ca.GetDataTable();
        }
        public static bool InsertCa(DTO_Ca ca)
        {
            return DAO_Ca.InsertCa(ca);
        }
        public static bool UpdateCa(DTO_Ca ca)
        {
            return DAO_Ca.UpdateCa(ca);
        }
        public static bool DeleteCa(DTO_Ca ca)
        {
            return DAO_Ca.DeleteCa(ca);
        }
    }
}
