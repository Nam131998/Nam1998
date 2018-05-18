using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class DAO_LapBaoCaoThang
    {
        public static DataTable GetTableHoaDonTiecCuoiSortNgay()
        {
            return DatabaseHelper.GetData(@"SELECT * FROM HoaDonTiecCuoi ORDER BY Ngay");
        }

        public static DataTable GetTableOfYears()
        {
            string sqlCommand = "SELECT DATEPART(YEAR, Ngay) AS 'Nam' FROM HoaDonTiecCuoi GROUP BY DATEPART(YEAR, Ngay)";
            return DatabaseHelper.GetData(sqlCommand);
        }

        public static DataTable GetTableOfMonths(string year)
        {
            string sqlCommand = string.Format(
                "SELECT DATEPART(MONTH, Ngay) AS 'Thang' FROM HoaDonTiecCuoi WHERE DATEPART(YEAR, Ngay)={0} GROUP BY DATEPART(MONTH, Ngay)", year);
            return DatabaseHelper.GetData(sqlCommand);
        }

        public static DataTable GetBaoCaoThang(string month, string year)
        {
            string sqlCommand = string.Format(
                "SELECT DATEPART(DAY, Ngay) AS 'Ngay', COUNT(*) AS 'SoLuongTiecCuoi', SUM(CONLAI) AS 'DoanhThu', SUM(CONLAI)/COUNT(*) AS 'TiLe'"
                + " FROM HoaDonTiecCuoi "
                + " WHERE DATEPART(MONTH, Ngay)={0} AND DATEPART(YEAR, Ngay)={1}"
                + " GROUP BY DATEPART(DAY, Ngay)"
                , month, year);
            return DatabaseHelper.GetData(sqlCommand);
        }
    }
}