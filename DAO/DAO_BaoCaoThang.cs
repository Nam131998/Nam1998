using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_BaoCaoThang
    {
        public static bool InsertBaoCaoThang(DTO.DTO_BaoCaoThang baoCaoThang)
        {
            String sqlCommand = String.Format(@"INSERT INTO BAOCAOTHANG(Thang, Nam, TongSoLuongTiecCuoi, TongDoanhThu) VALUES ({0}, {1}, {2}, {3})", baoCaoThang.Thang, baoCaoThang.Nam, 0, 0);
            if (DatabaseHelper.ExcuteSql(sqlCommand) > 0)
                return true;
            return false;
        }

        public static bool UpdateBaoCaoThang(DTO.DTO_BaoCaoThang baoCaoThang)
        {
            String sqlCommand = String.Format(@"Update BAOCAOTHANG SET TongSoLuongTiecCuoi = {0}, TongDoanhThu = {1} WHERE MaBCT = {2}", baoCaoThang.TongSoLuongTiecCuoi, baoCaoThang.TongDoanhThu, baoCaoThang.MaBCT);
            if (DatabaseHelper.ExcuteSql(sqlCommand) > 0)
                return true;
            return false;
        }

        public static bool CheckExistBaoCaoThang(int thang, int nam)
        {
            String sqlCommand = String.Format(@"Select * from BAOCAOTHANG WHERE Thang = {0} AND Nam = {1}", thang, nam);
            DataTable dataTable = DatabaseHelper.GetData(sqlCommand);
            if (dataTable != null && dataTable.Rows.Count > 0)
                return true;
            return false;
        }

        public static int GetMaBCT(int thang, int nam)
        {
            String sqlCommand = String.Format(@"Select * from BAOCAOTHANG WHERE Thang = {0} AND Nam = {1}", thang, nam);
            DataTable dataTable = DatabaseHelper.GetData(sqlCommand);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return int.Parse(dataTable.Rows[0]["MaBCT"].ToString());
            }
            return -1;
        }

        public static decimal GetDoanhThuThang(int maBCT)
        {
            String sqlCommand = String.Format(@"Select SUM(DoanhThu) AS TongDoanhthu from BAOCAONGAY where MABCT = {0}", maBCT);

            Console.WriteLine(sqlCommand);
            DataTable dataTable = DatabaseHelper.GetData(sqlCommand);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return decimal.Parse(dataTable.Rows[0]["TongDoanhThu"].ToString());
            }
            return 0;
        }

        public static int GetTongSoTiecCuoi(int maBCT)
        {
            String sqlCommand = String.Format(@"Select Sum(SoLuongTiecCuoi) AS TongSoTiecCuoi from BAOCAONGAY where MaBCT = {0}", maBCT);
            DataTable dataTable = DatabaseHelper.GetData(sqlCommand);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return int.Parse(dataTable.Rows[0]["TongSoTiecCuoi"].ToString());
            }
            return 0;
        }
    }
}