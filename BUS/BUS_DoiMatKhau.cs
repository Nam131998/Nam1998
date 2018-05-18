using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_DoiMatKhau
    {
        public static bool DoiMatKhau(DTO_NhanVien nhanvien)
        {
            return DAO_DoiMatKhau.DoiMatKhau(nhanvien);
        }
    }
}
