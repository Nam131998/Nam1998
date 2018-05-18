using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_DoiMatKhau
    {
        public static bool DoiMatKhau(DTO_NhanVien nhanvien)
        {
            string sTruyVan = string.Format(@"Update NHANVIEN set Password=N'{0}' where MaNV={1}", nhanvien.Password, nhanvien.MaNV);
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
