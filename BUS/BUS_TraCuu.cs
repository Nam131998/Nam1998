using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TraCuu
    {
        public static DataTable GetData(DTO_TraCuu key)
        {
            return DAO_TraCuu.GetData(key);
        }
        #region TraCuu_TiecCuoi
        public static DataTable TraCuuTenChuRe(DTO_TraCuu key)
        {
            return DAO_TraCuu.TraCuuTenChuRe(key);
        }
        public static DataTable TraCuuTenCoDau(DTO_TraCuu key)
        {
            return DAO_TraCuu.TraCuuTenCoDau(key);
        }
        public static DataTable TraCuuSoDT(DTO_TraCuu key)
        {
            return DAO_TraCuu.TraCuuSoDT(key);
        }
        public static DataTable TraCuuNgay(DTO_TraCuu key)
        {
            return DAO_TraCuu.TraCuuNgay(key);
        }
        #endregion

        #region TraCuu_MonAn
        public static DataTable TraCuuMonAn(DTO_TraCuu key)
        {
            return DAO_TraCuu.TraCuuMonAn(key);
        }
        #endregion

        #region TraCuu_DichVu
        public static DataTable TraCuuDichVu(DTO_TraCuu key)
        {
            return DAO_TraCuu.TraCuuDichVu(key);
        }
        #endregion

    }
}