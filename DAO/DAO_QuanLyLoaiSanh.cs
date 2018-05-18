using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_QuanLyLoaiSanh
    {
        public static DataTable GetLoaiSanhTable()
        {
            string sqlCommand = @"SELECT * FROM LOAISANH";
            return DatabaseHelper.GetData(sqlCommand);
        }

        public static DataTable SearchLoaiSanhTable(string tenLoaiSanh)
        {
            string sqlCommand = string.Format(@"SELECT * FROM LOAISANH WHERE TenLoaiSanh LIKE N'%{0}%'",tenLoaiSanh);
            return DatabaseHelper.GetData(sqlCommand);

        }
        public static void InsertLoaiSanh(DTO_LoaiSanh loaiSanh)
        {
            string sqlCommand = string.Format(@"INSERT INTO LoaiSanh (TenLoaiSanh,DonGiaBanToiThieu) VALUES (N'{0}',{1})", loaiSanh.tenLoaiSanh, loaiSanh.donGiaBanToiThieu);
            DatabaseHelper.ExcuteSql(sqlCommand);
        }
        public static void UpdateLoaiSanh(DTO_LoaiSanh loaiSanh)
        {
            string sqlCommand = string.Format(@"UPDATE LoaiSanh SET TenLoaiSanh=N'{0}', DonGiaBanToiThieu={1} WHERE MaLoaiSanh={2}", loaiSanh.tenLoaiSanh, loaiSanh.donGiaBanToiThieu, loaiSanh.maLoaiSanh);
            DatabaseHelper.ExcuteSql(sqlCommand);
        }
        public static void DeleteLoaiSanh(DTO_LoaiSanh loaiSanh)
        {
            string sqlCommand = string.Format(@"DELETE FROM LoaiSanh WHERE MaLoaiSanh={0}", loaiSanh.maLoaiSanh);
            DatabaseHelper.ExcuteSql(sqlCommand);
        }
        public static int NumbersOfMaLoaiSanhInSanh(DTO_LoaiSanh loaiSanh)
        {
            string sqlCommand = string.Format(@"SELECT COUNT(*) FROM Sanh WHERE MaLoaiSanh='{0}'", loaiSanh.maLoaiSanh);
            return DatabaseHelper.CountRecord(sqlCommand);
        }
        public static int NumbersOfTenLoaiSanhInLoaiSanh(DTO_LoaiSanh loaiSanh)
        {
            string sqlCommand = string.Format(@"SELECT COUNT(*) FROM LoaiSanh WHERE TenLoaiSanh=N'{0}'", loaiSanh.tenLoaiSanh);
            return DatabaseHelper.CountRecord(sqlCommand);
        }
    }
}
