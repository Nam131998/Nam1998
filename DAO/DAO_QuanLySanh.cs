using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_QuanLySanh
    {
        public static DataTable GetQLSanhTable()
        {
            string sqlCommand = @"SELECT MaSanh, TenSanh, LoaiSanh.TenLoaiSanh, SoLuongBanToiDa, DonGiaBanToiThieu, GhiChu FROM LoaiSanh, Sanh WHERE LoaiSanh.MaLoaiSanh = Sanh.MaLoaiSanh";
            return DatabaseHelper.GetData(sqlCommand);
        }
        public static void DeleteSanh(DTO_Sanh sanh)
        {
            string sqlCommand = string.Format(@"DELETE FROM Sanh WHERE MaSanh={0}", sanh.maSanh);
            DatabaseHelper.ExcuteSql(sqlCommand);
        }
        public static DataTable GetLoaiSanhTable()
        {
            string sqlCommand = @"SELECT * FROM LoaiSanh";
            return DatabaseHelper.GetData(sqlCommand);
        }

        public static DataTable SearchSanhTableTheoTen(string tenSanh)
        {
            string sqlCommand = string.Format(@"SELECT * FROM SANH WHERE TenSanh LIKE N'%{0}%'", tenSanh);
            return DatabaseHelper.GetData(sqlCommand);

        }

        public static bool InsertSanh(DTO_Sanh sanh)
        {
            //string sqlCommand = @"SELECT * FROM LoaiSanh";
            string sqlCommand = string.Format(@"INSERT INTO Sanh (TenSanh, MaLoaiSanh, SoLuongBanToiDa, GhiChu) VALUES (N'{0}', {1}, {2}, N'{3}')", sanh.tenSanh, sanh.maLoaiSanh, sanh.soLuongBanToiDa, sanh.ghiChu);

            if (DatabaseHelper.ExcuteSql(sqlCommand) == 1)
                return true;
            return false;
            //return DatabaseHelper.ExecuteNonQuery(sqlCommand);
        }
        public static int UpdateSanh(DTO_Sanh sanh)
        {
            string sqlCommand = String.Format(@"UPDATE Sanh SET TenSanh=N'{0}', MaLoaiSanh={1}, SoLuongBanToiDa={2}, GhiChu=N'{3}' WHERE MaSanh={4}",
                sanh.tenSanh, sanh.maLoaiSanh, sanh.soLuongBanToiDa, sanh.ghiChu, sanh.maSanh);
            return DatabaseHelper.ExcuteSql(sqlCommand);
        }
    }
}
