using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class DAO_DangNhap
    {
        public static DataTable GetPhanQuyen(DTO_DangNhap dangnhap)
        {
            string sTruyVan = string.Format(@"Select * from NHANVIEN,CHUCVU where (Username='{0}') and (Password='{1}') and (NhanVien.MaChucVu = Chucvu.MaChucVu)", dangnhap.Username, dangnhap.Password);
            DataTable state = DatabaseHelper.GetData(sTruyVan);
            return state;
        }
        public static bool KiemTraDangNhap(DTO_DangNhap dangnhap)
        {
            string sTruyVan = string.Format(@"Select * from NHANVIEN where (Username='{0}') and (Password='{1}')", dangnhap.Username, dangnhap.Password);
            try
            {
                DataTable state = DatabaseHelper.GetData(sTruyVan);
                if (state.Rows.Count > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
    }
}
