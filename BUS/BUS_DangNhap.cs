using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_DangNhap
    {
        public static bool KiemTraDangNhap(DTO_DangNhap dangnhap)
        {
            return DAO_DangNhap.KiemTraDangNhap(dangnhap);
        }
        public static DataTable GetPhanQuyen(DTO_DangNhap dangnhap)
        {
            return DAO_DangNhap.GetPhanQuyen(dangnhap);
        }
    }
}
