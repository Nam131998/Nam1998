using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_MonAn
    {
        public static DataTable GetDataTableMonAn()
        {
            string query = @"SELECT * FROM MONAN";
            return DatabaseHelper.GetData(query);
        }

        public static bool InsertMonAn(DTO_MonAn monAn)
        {
            string query = String.Format(@"INSERT INTO MONAN (TenMonAn, DonGia, GhiChu, HinhAnh) VALUES (N'{0}', {1}, N'{2}', N'{3}')",
                monAn.TenMonAn, monAn.DonGia, monAn.GhiChu, monAn.HinhAnh);
            try
            {
                int state = DatabaseHelper.ExcuteSql(query);
                if (state > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }

        public static bool UpdateMonAn(DTO_MonAn monAn)
        {
            string query = String.Format(@"UPDATE MONAN SET TenMonAn=N'{0}', DonGia={1}, GhiChu=N'{2}', HinhAnh=N'{3}' WHERE MaMonAn={4}",
                monAn.TenMonAn, monAn.DonGia, monAn.GhiChu, monAn.HinhAnh, monAn.MaMonAn);
            try
            {
                int state = DatabaseHelper.ExcuteSql(query);
                if (state > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static bool DeleteMonAn(DTO_MonAn monAn)
        {
            string query = String.Format(@"DELETE FROM MonAn WHERE MaMonAn={0}", monAn.MaMonAn);
            try
            {
                int state = DatabaseHelper.ExcuteSql(query);
                if (state > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static int LastIndex()
        {
            //string query = string.Format(@"SELECT TOP 1 MaMonAn FROM MONAN ORDER BY MaMonAn DESC");
            string query = string.Format(@"SELECT IDENT_CURRENT('MONAN')");
            return Int32.Parse(DatabaseHelper.GetData(query).Rows[0].ItemArray[0].ToString());
        }
    }
}