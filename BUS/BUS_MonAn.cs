using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_MonAn
    {
        public static DataTable GetDataTableMonAn()
        {
            return DAO_MonAn.GetDataTableMonAn();
        }
        public static bool InsertMonAn(DTO_MonAn monAn)
        {
            return DAO_MonAn.InsertMonAn(monAn);
        }
        public static bool UpdateMonAn(DTO_MonAn monAn)
        {
            return DAO_MonAn.UpdateMonAn(monAn);
        }
        public static bool DeleteMonAn(DTO_MonAn monAn)
        {
            return DAO_MonAn.DeleteMonAn(monAn);
        }
        public static int LastIndex()
        {
            return DAO_MonAn.LastIndex();
        }
    }
}