using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using DAO;
namespace BUS
{
    public class BUS_QuanLyNhanVien
    {
        public static DataTable LoadChucVu()
        {
            return DAO_QuanLyNhanVien.LoadChucVu();
        }
        public static DataTable LoadDanhSachNhanVien()
        {
            return DAO_QuanLyNhanVien.LoadDanhSachNhanVien();
        }
        public static DataTable GetDataTable()
        {
            return DAO_QuanLyNhanVien.GetDataTable();
        }
        public static bool CheckUserNameNotExists(DTO_NhanVien nhanvien)
        {
            return DAO_QuanLyNhanVien.CheckUserNameNotExists(nhanvien);
        }
        public static bool InsertNhanVien(DTO_NhanVien nhanvien)
        {
            return DAO_QuanLyNhanVien.InsertNhanVien(nhanvien);
        }
        public static bool CheckRowEffectLargerThanOnce(string anhdaidien)
        {
            return DAO_QuanLyNhanVien.CheckRowEffectLargerThanOnce(anhdaidien);
        }
        public static bool CheckNhanVienKhongLapHopDong(string manhanvien)
        {
            return DAO_QuanLyNhanVien.CheckNhanVienKhongLapHopDong(manhanvien);
        }
        public static bool DeleteNhanVien(DTO_NhanVien nhanvien)
        {
            return DAO_QuanLyNhanVien.DeleteNhanVien(nhanvien);
        }
        public static bool UpdateNhanVien(DTO_NhanVien nhanvien)
        {
            return DAO_QuanLyNhanVien.UpdateNhanVien(nhanvien);
        }
    }
}
