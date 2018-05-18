using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;
namespace BUS
{
    public class BUS_NhanDatTiecCuoi
    {
        public static DataTable GetSanh()
        {
            return DAO_NhanDatTiecCuoi.GetSanh();
        }
        public static DataTable GetCa()
        {
            return DAO_NhanDatTiecCuoi.GetCa();
        }
        public static bool CheckStateTiecCuoi(DTO_TiecCuoi tieccuoi)
        {
            return DAO_NhanDatTiecCuoi.CheckStateTiecCuoi(tieccuoi);
        }
        public static DataTable GetDate(DTO_TiecCuoi tieccuoi)
        {
            return DAO_NhanDatTiecCuoi.GetDate(tieccuoi);
        }
        public static bool InsertTiecCuoi(DTO_TiecCuoi tieccuoi)
        {
            return DAO_NhanDatTiecCuoi.InsertTiecCuoi(tieccuoi);
        }
        public static DataTable GetLastID()
        {
            return DAO_NhanDatTiecCuoi.GetLastID();
        }
        public static bool InsertPhieuDatBan(DTO_PhieuDatBan phieudatban)
        {
            return DAO_NhanDatTiecCuoi.InsertPhieuDatBan(phieudatban);
        }
        public static DataTable GetLastIDPhieu()
        {
            return DAO_NhanDatTiecCuoi.GetLastIDPhieu();
        }
        public static bool InsertChiTietDatBan(DTO_CT_PhieuDatBan ctphieudatban)
        {
            return DAO_NhanDatTiecCuoi.InsertChiTietDatBan(ctphieudatban);
        }
        public static bool InsertChiTietDatDichVu(DTO_CT_PhieuDatDichVu ctphieudatdichvu)
        {
            return DAO_NhanDatTiecCuoi.InsertChiTietDatDichVu(ctphieudatdichvu);
        }
        public static bool CheckDaLapTiecCuoi(DTO_TiecCuoi tieccuoi)
        {
            return DAO_NhanDatTiecCuoi.CheckDaLapTiecCuoi(tieccuoi);
        }
    }
}
