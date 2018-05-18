using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_HoaDon
    {
        public static bool InsertHoaDon(DTO.DTO_HoaDon hoaDon)
        {
            String sqlCommand = String.Format(@"INSERT INTO HOADON (MaTiecCuoi, NgayThanhToan, TongTienBan, TongTienDichVu, TongTienHoaDon, TienDaThanhToan, ConLai)" +
                "VALUES ({0}, '{1}', {2}, {3}, {4}, {5}, {6})", hoaDon.MaTiecCuoi, hoaDon.NgayThanhToan, hoaDon.TongTienBan, hoaDon.TongTienDichVu, hoaDon.TongTienHoaDon, hoaDon.TienDaThanhToan, hoaDon.ConLai);

            if (DatabaseHelper.ExcuteSql(sqlCommand) == 1)
                return true;
            return false;
        }

        public static bool UpdateHoaDon(DTO.DTO_HoaDon hoaDon)
        {
            String sqlCommand = String.Format("UPDATE HOADON set MATIECCUOI = {0}, NgayThanhToan = '{1}', TongTienBan = {2}, TongTienDichVu = {3}, TongTienHoaDon = {4}, TienDaThanhToan = {5}, ConLai = {6} WHERE SoHoaDon = {6}", hoaDon.MaTiecCuoi, hoaDon.NgayThanhToan, hoaDon.TongTienBan, hoaDon.TongTienDichVu, hoaDon.TongTienHoaDon, hoaDon.ConLai, hoaDon.TienDaThanhToan, hoaDon.SoHoaDon);
            if (DatabaseHelper.ExcuteSql(sqlCommand) > 0)
                return true;
            return false;
        }

        public static List<DTO.DTO_HoaDon> GetAllHoaDon(int maTiecCuoi)
        {
            List<DTO.DTO_HoaDon> hoaDons = null;
            String sqlCommand = String.Format(@"Select * from HOADON where MaTiecCuoi = {0}", maTiecCuoi);
            DataTable dataTable = DatabaseHelper.GetData(sqlCommand);

            if (dataTable != null)
            {
                if (dataTable.Rows.Count > 0)
                {
                    hoaDons = new List<DTO.DTO_HoaDon>();
                    int size = dataTable.Rows.Count;
                    for (int i = 0; i < size; i++)
                    {
                        DTO.DTO_HoaDon hoaDon = new DTO.DTO_HoaDon();
                        DataRow dataRow = dataTable.Rows[i];
                        hoaDon.SoHoaDon = int.Parse(dataRow["SoHoaDon"].ToString());
                        hoaDon.MaTiecCuoi = int.Parse(dataRow["MaTiecCuoi"].ToString());
                        hoaDon.TongTienDichVu = decimal.Parse(dataRow["TongTienDichVu"].ToString());
                        hoaDon.TongTienBan = decimal.Parse(dataRow["TongTienBan"].ToString());
                        hoaDon.TongTienHoaDon = decimal.Parse(dataRow["TongTienHoaDon"].ToString());
                        hoaDon.TienDaThanhToan = decimal.Parse(dataRow["TienDaThanhToan"].ToString());
                        hoaDon.NgayThanhToan = DateTime.Parse(dataRow["NgayThanhToan"].ToString()).ToString("MM/dd/yyyy");
                        hoaDon.ConLai = decimal.Parse(dataRow["ConLai"].ToString());
                        hoaDons.Add(hoaDon);
                    }
                }
            }
            return hoaDons;
        }
    }
}