using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_TiepNhanSanh
    {
        public static DataTable GetLoaiSanhTable()
        {
            string sqlCommand = @"SELECT * FROM LoaiSanh";
            return DatabaseHelper.GetData(sqlCommand);
        }
        public static bool InsertSanh(DTO_Sanh sanh)
        {
            string sqlCommand = string.Format(@"INSERT INTO Sanh (TenSanh, MaLoaiSanh, SoLuongBanToiDa, GhiChu) VALUES (N'{0}', {1}, {2}, N'{3}')"
                , sanh.tenSanh, sanh.maLoaiSanh, sanh.soLuongBanToiDa, sanh.ghiChu);

            if (DatabaseHelper.ExcuteSql(sqlCommand) == 1)
                return true;
            return false;
        }

        public static bool TenSanhIsExistInSanh(string tenSanh)
        {
            string sqlCommand = @"SELECT TenSanh FROM Sanh WHERE TenSanh=N'" + tenSanh + "'";
            if (DatabaseHelper.GetData(sqlCommand).Rows.Count > 0)
                return true;
            return false;
        }
    }
}
