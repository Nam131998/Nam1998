using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_LapHoaDonThanhToan
    {
        public static DataTable GetAllTiecCuoi(string ngayDaiTiec)
        {
            string sqlCommand = String.Format(@"Select * from TIECCUOI where NgayDaiTiec = '{0}'", ngayDaiTiec);
            return DatabaseHelper.GetData(sqlCommand);
        }

        public static DataTable GetAllTiecCuoi()
        {
            String sqlCommand = @"select * from TiecCuoi";
            return DatabaseHelper.GetData(sqlCommand);
        }

        public static DTO.DTO_TiecCuoi GetTiecCuoi(String tenChuRe, String tenCoDau, string ngayDaiTiec)
        {
            DTO_TiecCuoi tiecCuoi = null;
            String sqlCommand = String.Format("Select * from TIECCUOI where TenChuRe = N'{0}' AND TenCoDau = N'{1}' AND NgayDaiTiec = '{2}'", tenChuRe, tenCoDau, ngayDaiTiec);
            DataTable dataTable = DatabaseHelper.GetData(sqlCommand);
            if (dataTable != null)
            {
                if (dataTable.Rows.Count > 0)
                {
                    tiecCuoi = new DTO_TiecCuoi();
                    DataRow dataRow = dataTable.Rows[0];
                    tiecCuoi.MaTiecCuoi = int.Parse(dataRow["MaTiecCuoi"].ToString());
                    tiecCuoi.TenChuRe = dataRow["TenChuRe"].ToString();
                    tiecCuoi.TenCoDau = dataRow["TenCoDau"].ToString();
                    tiecCuoi.DienThoai = dataRow["DienThoai"].ToString();
                    tiecCuoi.NgayDatTiec = dataRow["NgayDatTiec"].ToString();
                    tiecCuoi.NgayDaiTiec = dataRow["NgayDaiTiec"].ToString();
                    tiecCuoi.MaCa = int.Parse(dataRow["MaCa"].ToString());
                    tiecCuoi.MaSanh = int.Parse(dataRow["MaSanh"].ToString());
                    tiecCuoi.TienCoc = decimal.Parse(dataRow["TienCoc"].ToString());
                    tiecCuoi.GhiChu = dataRow["GhiChu"].ToString();
                    tiecCuoi.MaNV = int.Parse(dataRow["MaNV"].ToString());
                }
            }
            return tiecCuoi;
        }

        public static bool UpdateSoTienConLai(DTO.DTO_HoaDon hoaDon)
        {
            String sqlCommand = String.Format(@"UPDATE HoaDon SET ConLai = {0} WHERE SoHoaDon = {1}", hoaDon.ConLai, hoaDon.SoHoaDon);
            if (DatabaseHelper.ExcuteSql(sqlCommand) > 0)
                return true;
            return false;
        }

        public static DataTable GetChiTietDichVu(int maTiecCuoi)
        {
            String sqlCommand = @"Select DV.TenDichVu, CT.SoLuong, CT.DonGia AS DonGia, (CT.DonGia * CT.SoLuong) AS ThanhTien from DICHVU AS DV INNER JOIN CT_PHIEUDATDICHVU CT ON DV.MaDichVu = CT.MaDichVu WHERE CT.MaTiecCuoi = " + maTiecCuoi + "";
            return DatabaseHelper.GetData(sqlCommand);
        }

        public static DTO.DTO_PhieuDatBan GetPhieuDatBan(int maTiecCuoi)
        {
            DTO.DTO_PhieuDatBan phieuDatBan = null;
            String sqlCommand = String.Format(@"SELECT * FROM PHIEUDATBAN WHERE MaTiecCuoi = {0}", maTiecCuoi);
            DataTable dataTable = DatabaseHelper.GetData(sqlCommand);
            if (dataTable != null)
            {
                if (dataTable.Rows.Count > 0)
                {
                    DataRow dataRow = dataTable.Rows[0];
                    phieuDatBan = new DTO_PhieuDatBan();
                    phieuDatBan.MaTiecCuoi = maTiecCuoi;
                    phieuDatBan.MaPhieuDatBan = int.Parse(dataRow["MaPhieuDatBan"].ToString());
                    phieuDatBan.SoBan = int.Parse(dataRow["SoBan"].ToString());
                    phieuDatBan.SoBanDuTru = int.Parse(dataRow["SoBanDuTru"].ToString());
                    phieuDatBan.GhiChu = dataRow["GhiChu"].ToString();
                    phieuDatBan.DonGiaBan = decimal.Parse(dataRow["DonGiaBan"].ToString());
                }
            }
            return phieuDatBan;
        }

        public static decimal GetTongTienDichVu(int maTiecCuoi)
        {
            decimal tongTien = 0;
            String sqlCommand = @"Select SUM(CT.DonGia * CT.SoLuong) AS TongTien from CT_PHIEUDATDICHVU AS CT where CT.MaTiecCuoi = " + maTiecCuoi + "";
            DataTable dataTable = DatabaseHelper.GetData(sqlCommand);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                tongTien = decimal.Parse(dataTable.Rows[0]["TongTien"].ToString());
            }
            return tongTien;
        }

        public static DataTable GetChiTietDatBan(int maPhieuDatBan)
        {
            String sqlCommand = String.Format(@"SELECT MA.TenMonAn AS TenMonAn, CT.DonGia AS DonGia  FROM CT_PHIEUDATBAN AS CT INNER JOIN MONAN AS MA ON CT.MaMonAn = MA.MaMonAn WHERE CT.MaPhieuDatBan = {0}", maPhieuDatBan);
            return DatabaseHelper.GetData(sqlCommand);
        }

        public static DataTable GetTableTenChuReAndTenCoDau()
        {
            string sqlCommand = @"SELECT MaKH, TenChuRe, TenCoDau FROM KhachHang";
            return DatabaseHelper.GetData(sqlCommand);
        }

        public static DataTable GetNgayDatTiec(string tenChuRe)
        {
            string sqlCommand = string.Format(
                "SELECT DATEPART(DAY, Ngay) 'Ngay', DATEPART(MONTH, Ngay) 'Thang', DATEPART(YEAR, Ngay) 'Nam' FROM HoaDonTiecCuoi WHERE MaKH = ("
                + " SELECT MaKH FROM KhachHang WHERE TenChuRe=N'{0}')"
                , tenChuRe
            );
            return DatabaseHelper.GetData(sqlCommand);
        }

        public static DataTable GetTableHDTCCustom(string MaKH, string ngayDatTiec)
        {
            string sqlCommand = string.Format(
                "SELECT MaSanh,SoLuongBan,MaHD,TienCoc FROM HoaDonTiecCuoi WHERE MaKH={0} AND CAST(Ngay AS DATE)='{1}'"
                , MaKH, ngayDatTiec
            );
            return DatabaseHelper.GetData(sqlCommand);
        }

        public static string GetDonGiaBanTT(string maSanh)
        {
            DataTable dt = DatabaseHelper.GetData(@"SELECT DonGiaBanToiThieu FROM LoaiSanh WHERE MaLoaiSanh=(SELECT MaLoaiSanh FROM Sanh WHERE MaSanh='" + maSanh + "')");
            return dt.Rows[0]["DonGiaBanToiThieu"].ToString();
        }

        public static bool UpdateTiecCuoi(DTO_TiecCuoi tiecCuoiInfo)
        {
            String sqlCommand = String.Format(@"UPDATE TIECCUOI SET TinhTrangTiec = {0} WHERE MaTiecCuoi = {1}", tiecCuoiInfo.TinhTrangTiec, tiecCuoiInfo.MaTiecCuoi);
            if (DatabaseHelper.ExcuteSql(sqlCommand) > 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsLapHoaDonThanhToan(int maTiecCuoi)
        {
            List<DTO.DTO_HoaDon> hoaDons = DAO_HoaDon.GetAllHoaDon(maTiecCuoi);
            if (hoaDons != null && hoaDons.Count > 0)
                return true;
            return false;
        }
    }
}