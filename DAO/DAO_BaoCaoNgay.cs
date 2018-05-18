using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_BaoCaoNgay
    {
        public static bool InsertBaoCaoNgay(DTO.DTO_BaoCaoNgay baoCaoNgay)
        {
            String sqlCommand = String.Format(@"Insert BAOCAONGAY(MaBCT, Ngay, SoLuongTiecCuoi, DoanhThu, TiLe) VALUES ({0}, {1}, {2}, {3}, {4})", baoCaoNgay.MaBCT, baoCaoNgay.Ngay, baoCaoNgay.SoLuongTiecCuoi, baoCaoNgay.DoanhThu, baoCaoNgay.TiLe);
            Console.WriteLine(sqlCommand);
            if (DatabaseHelper.ExcuteSql(sqlCommand) > 0)
                return true;
            return false;
        }

        public static bool UpdateBaoCaoNgay(DTO.DTO_BaoCaoNgay baoCaoNgay)
        {
            String sqlCommand = String.Format(@"Update BAOCAONGAY SET SoLuongTiecCuoi = {0}, DoanhThu = {1}, TiLe = {2} Where MaBCT = {3} AND Ngay = {4}", baoCaoNgay.SoLuongTiecCuoi, baoCaoNgay.DoanhThu, baoCaoNgay.TiLe, baoCaoNgay.MaBCT, baoCaoNgay.Ngay);
            Console.WriteLine(sqlCommand);
            if (DatabaseHelper.ExcuteSql(sqlCommand) > 0)
                return true;
            return false;
        }

        public static DTO.DTO_BaoCaoNgay GetBaoCaoNgay(int maBCT, int ngay)
        {
            String sqlCommand = String.Format(@"Select * from BAOCAONGAY Where MaBCT = {0} AND Ngay = {1}", maBCT, ngay);
            DataTable dataTable = DatabaseHelper.GetData(sqlCommand);
            DTO.DTO_BaoCaoNgay baoCaoNgay = null;
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                baoCaoNgay = new DTO.DTO_BaoCaoNgay();
                DataRow dataRow = dataTable.Rows[0];
                baoCaoNgay.MaBCT = maBCT;
                baoCaoNgay.Ngay = ngay;
                baoCaoNgay.SoLuongTiecCuoi = int.Parse(dataRow["SoLuongTiecCuoi"].ToString());
                baoCaoNgay.DoanhThu = decimal.Parse(dataRow["DoanhThu"].ToString());
                baoCaoNgay.TiLe = decimal.Parse(dataRow["TiLe"].ToString());
            }
            return baoCaoNgay;
        }

        public static bool IsExistBaoCaoNgay(int maBCT, int ngay)
        {
            String sqlCommand = String.Format(@"Select * from BAOCAONGAY Where MaBCT = {0} AND Ngay = {1}", maBCT, ngay);
            DataTable dataTable = DatabaseHelper.GetData(sqlCommand);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public static DataTable GetAllBaoCaoNgay(int maBCT)
        {
            String sqlCommmand = string.Format(@"Select Ngay, SoLuongTiecCuoi, DoanhThu, TiLe from BAOCAONGAY where MaBCT = {0}", maBCT);
            return DatabaseHelper.GetData(sqlCommmand);
        }
    }
}