using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_ThamSo
    {
        public const String COLUMN_TENQUYDINH = "TenQuyDinh";
        public const String COLUMN_GIATRI = "GiaTri";
        public static DataTable GetThamSo()
        {
            DataTable data = DatabaseHelper.GetData(@"select * from ThamSo");
            return data;
        }

        public static bool InsertThamSo(DTO_ThamSo thamSo)
        {
            String sql = String.Format("Insert into ThamSo(" + COLUMN_TENQUYDINH + "," + COLUMN_GIATRI + ") values (N'{0}',{1})",
              thamSo.TenQuyDinh, thamSo.GiaTri);
            if (DatabaseHelper.ExcuteSql(sql) == 1)
                return true;
            return false;
        }

        public static bool UpdateThamSo(DTO_ThamSo thamSo)
        {
            String sql = String.Format("update ThamSo set {0} = {1} where {2} = N'{3}'", COLUMN_GIATRI, thamSo.GiaTri, COLUMN_TENQUYDINH, thamSo.TenQuyDinh);
            if (DatabaseHelper.ExcuteSql(sql) == 1)
                return true;
            return false;
        }
    }
}
