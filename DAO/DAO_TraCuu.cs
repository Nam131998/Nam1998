using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_TraCuu
    {
        public static DataTable GetData(DTO_TraCuu traCuu)
        {
            string query = String.Format(@"SELECT TIECCUOI.TenChuRe AS 'Tên chú rể', TIECCUOI.TenCoDau AS 'Tên cô dâu', SANH.TenSanh AS 'Sảnh', TIECCUOI.NgayDaiTiec AS 'Ngày đãi tiệc', CA.TenCa AS 'Ca', PHIEUDATBAN.SoBan AS 'Số bàn' 
FROM (((TIECCUOI INNER JOIN SANH ON TIECCUOI.MaSanh = SANH.MaSanh)
 INNER JOIN Ca ON TIECCUOI.MaCa = CA.MaCa) INNER JOIN PHIEUDATBAN ON TIECCUOI.MaTiecCuoi = PHIEUDATBAN.MaTiecCuoi)");
            return DatabaseHelper.GetData(query);
        }
        #region TraCuu_TiecCuoi
        public static DataTable TraCuuTenChuRe(DTO_TraCuu traCuu)
        {
            string query = String.Format(@"SELECT TIECCUOI.TenChuRe AS 'Tên chú rể', TIECCUOI.TenCoDau AS 'Tên cô dâu', TIECCUOI.DienThoai AS 'Số ĐT', SANH.TenSanh AS 'Sảnh', TIECCUOI.NgayDaiTiec AS 'Ngày đãi tiệc', CA.TenCa AS 'Ca', PHIEUDATBAN.SoBan AS 'Số bàn' 
FROM (((TIECCUOI INNER JOIN SANH ON TIECCUOI.MaSanh = SANH.MaSanh) 
    INNER JOIN Ca ON TIECCUOI.MaCa = CA.MaCa) 
    INNER JOIN PHIEUDATBAN ON TIECCUOI.MaTiecCuoi = PHIEUDATBAN.MaTiecCuoi) 
WHERE dbo.BoDau(TIECCUOI.TenChuRe) LIKE N'%{0}%'", traCuu.key);
            return DatabaseHelper.GetData(query);
        }
        public static DataTable TraCuuTenCoDau(DTO_TraCuu traCuu)
        {
            string query = String.Format(@"SELECT TIECCUOI.TenChuRe AS 'Tên chú rể', TIECCUOI.TenCoDau AS 'Tên cô dâu', TIECCUOI.DienThoai AS 'Số ĐT', SANH.TenSanh AS 'Sảnh', TIECCUOI.NgayDaiTiec AS 'Ngày đãi tiệc', CA.TenCa AS 'Ca', PHIEUDATBAN.SoBan AS 'Số bàn' 
FROM (((TIECCUOI INNER JOIN SANH ON TIECCUOI.MaSanh = SANH.MaSanh) 
    INNER JOIN Ca ON TIECCUOI.MaCa = CA.MaCa) 
    INNER JOIN PHIEUDATBAN ON TIECCUOI.MaTiecCuoi = PHIEUDATBAN.MaTiecCuoi)  
WHERE dbo.BoDau(TIECCUOI.TenCoDau) LIKE N'%{0}%'", traCuu.key);
            return DatabaseHelper.GetData(query);
        }
        public static DataTable TraCuuSoDT(DTO_TraCuu traCuu)
        {
            string query = String.Format(@"SELECT TIECCUOI.TenChuRe AS 'Tên chú rể', TIECCUOI.TenCoDau AS 'Tên cô dâu', TIECCUOI.DienThoai AS 'Số ĐT', SANH.TenSanh AS 'Sảnh', TIECCUOI.NgayDaiTiec AS 'Ngày đãi tiệc', CA.TenCa AS 'Ca', PHIEUDATBAN.SoBan AS 'Số bàn' 
FROM (((TIECCUOI INNER JOIN SANH ON TIECCUOI.MaSanh = SANH.MaSanh) 
    INNER JOIN Ca ON TIECCUOI.MaCa = CA.MaCa) 
    INNER JOIN PHIEUDATBAN ON TIECCUOI.MaTiecCuoi = PHIEUDATBAN.MaTiecCuoi) 
WHERE DienThoai = '{0}'", traCuu.key);
            return DatabaseHelper.GetData(query);
        }
        public static DataTable TraCuuNgay(DTO_TraCuu traCuu)
        {
            string query = String.Format(@"SELECT TIECCUOI.TenChuRe AS 'Tên chú rể', TIECCUOI.TenCoDau AS 'Tên cô dâu', TIECCUOI.DienThoai AS 'Số ĐT', SANH.TenSanh AS 'Sảnh', TIECCUOI.NgayDaiTiec AS 'Ngày đãi tiệc', CA.TenCa AS 'Ca', PHIEUDATBAN.SoBan AS 'Số bàn' 
FROM (((TIECCUOI INNER JOIN SANH ON TIECCUOI.MaSanh = SANH.MaSanh) 
    INNER JOIN Ca ON TIECCUOI.MaCa = CA.MaCa) 
    INNER JOIN PHIEUDATBAN ON TIECCUOI.MaTiecCuoi = PHIEUDATBAN.MaTiecCuoi) 
WHERE TIECCUOI.NgayDaiTiec = '{0}'", traCuu.key);
            return DatabaseHelper.GetData(query);
        }
        #endregion

        #region TraCuu_MonAn
        public static DataTable TraCuuMonAn(DTO_TraCuu traCuu)
        {
            string query = String.Format(@"SELECT * FROM MONAN WHERE dbo.BoDau(TenMonAn) LIKE N'%{0}%'", traCuu.key);
            return DatabaseHelper.GetData(query);
        }
        #endregion

        #region TraCuu_DichVu
        public static DataTable TraCuuDichVu(DTO_TraCuu traCuu)
        {
            string query = String.Format(@"SELECT * FROM DICHVU WHERE dbo.BoDau(TenDichVu) LIKE N'%{0}%'", traCuu.key);
            return DatabaseHelper.GetData(query);
        }
        #endregion
    }
}