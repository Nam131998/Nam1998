using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class DAO_NhanDatTiecCuoi
    {
        public static DataTable GetSanh()
        {
            string sTruyVan = "Select MaSanh, TenSanh, DonGiaBanToiThieu,SoLuongBanToiDa from Sanh, LoaiSanh where Sanh.MaLoaiSanh = LoaiSanh.MaLoaiSanh";
            return DatabaseHelper.GetData(sTruyVan);
        }
        public static DataTable GetCa()
        {
            string sTruyVan = "Select * from Ca";
            return DatabaseHelper.GetData(sTruyVan);
        }
        public static bool CheckStateTiecCuoi(DTO_TiecCuoi tieccuoi)
        {
            string sTruyVan = string.Format(@"Select * from TiecCuoi where MaCa={0} and NgayDaiTiec={1}", tieccuoi.MaCa, tieccuoi.NgayDaiTiec);
            return DatabaseHelper.CheckIfExists(sTruyVan);
        }
        public static DataTable GetDate(DTO_TiecCuoi tieccuoi)
        {
            string sTruyVan = string.Format(@"Select * from TiecCuoi  where (DAY(NgayDaiTiec) = DAY('{0}')) and (MONTH(NgayDaiTiec) = MONTH('{0}')) and (YEAR(NgayDaiTiec) = YEAR('{0}')) and (MaCa='{1}') and (MaSanh='{2}')", tieccuoi.NgayDaiTiec, tieccuoi.MaCa, tieccuoi.MaSanh);
            return DatabaseHelper.GetData(sTruyVan);
        }
        public static DataTable GetLastID()
        {
            string struyvan = @"select MaTiecCuoi from TiecCuoi WHERE MaTiecCuoi = (SELECT MAX(MaTiecCuoi)  FROM TiecCuoi)";
            return DatabaseHelper.GetData(struyvan);
        }
        public static bool InsertTiecCuoi(DTO_TiecCuoi tieccuoi)
        {
            string sTruyVan = string.Format("Insert into TiecCuoi(TenChuRe,TenCoDau,DienThoai, NgayDatTiec,NgayDaiTiec,MaCa,MaSanh, TienCoc,GhiChu, MaNV, TinhTrangTiec) values (N'{0}',N'{1}',N'{2}','{3}','{4}',{5},{6},{7},N'{8}',{9},{10})",
                tieccuoi.TenChuRe, tieccuoi.TenCoDau, tieccuoi.DienThoai, tieccuoi.NgayDatTiec, tieccuoi.NgayDaiTiec, tieccuoi.MaCa, tieccuoi.MaSanh, tieccuoi.TienCoc, tieccuoi.GhiChu, tieccuoi.MaNV, tieccuoi.TinhTrangTiec);
            try
            {
                int state = DatabaseHelper.ExcuteSql(sTruyVan);
                if (state > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static bool InsertPhieuDatBan(DTO_PhieuDatBan phieudatban)
        {
            string sTruyVan = string.Format("Insert into PhieuDatBan(MaTiecCuoi, SoBan,SoBanDuTru,DonGiaBan,GhiChu) values({0},{1},{2},{3},N'{4}')",
                phieudatban.MaTiecCuoi, phieudatban.SoBan, phieudatban.SoBanDuTru, phieudatban.DonGiaBan, phieudatban.GhiChu);
            try
            {
                int state = DatabaseHelper.ExcuteSql(sTruyVan);
                if (state > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static DataTable GetLastIDPhieu()
        {
            string struyvan = @"select MaPhieuDatBan from PhieuDatBan WHERE MaPhieuDatBan = (SELECT MAX(MaPhieuDatBan)  FROM PhieuDatBan)";
            return DatabaseHelper.GetData(struyvan);
        }
        public static bool InsertChiTietDatBan(DTO_CT_PhieuDatBan ctphieudatban)
        {
            string sTruyVan = string.Format("Insert into CT_PHIEUDATBAN(MaPhieuDatBan, MaMonAn,DonGia, SoLuong, GhiChu) values({0},{1},{2},{3},N'{4}')",
                ctphieudatban.MaPhieuDatBan, ctphieudatban.MaMonAn, ctphieudatban.DonGia, ctphieudatban.SoLuong, ctphieudatban.GhiChu);
            try
            {
                int state = DatabaseHelper.ExcuteSql(sTruyVan);
                if (state > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static bool CheckDaLapTiecCuoi(DTO_TiecCuoi tieccuoi)
        {
            string sTruyVan = string.Format(@"select * from TIECCUOI where (DienThoai=N'{0}') and ((TenChuRe=N'{1}') or (TenCoDau=N'{2}')) and ((TinhTrangTiec = 1) or (TinhTrangTiec = 2))",
                tieccuoi.DienThoai, tieccuoi.TenChuRe, tieccuoi.TenCoDau, tieccuoi.TinhTrangTiec);
            try
            {
                DataTable res = DatabaseHelper.GetData(sTruyVan);
                if (res.Rows.Count > 0)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool InsertChiTietDatDichVu(DTO_CT_PhieuDatDichVu ctphieudatdichvu)
        {
            string sTruyVan = string.Format("Insert into CT_PHIEUDATDICHVU(MaTiecCuoi, MaDichVu, Soluong, DonGia) values({0},{1},{2},{3})",
                ctphieudatdichvu.MaTiecCuoi, ctphieudatdichvu.MaDichVu, ctphieudatdichvu.SoLuong, ctphieudatdichvu.DonGia);
            try
            {
                int state = DatabaseHelper.ExcuteSql(sTruyVan);
                if (state > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
    }
}
