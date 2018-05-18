using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_BaoCaoThang
    {
        public static bool InsertBaoCaoThang(DTO.DTO_BaoCaoThang baoCaoThang)
        {
            return DAO.DAO_BaoCaoThang.InsertBaoCaoThang(baoCaoThang);
        }

        public static bool UpdateBaoCaoThang(DTO.DTO_BaoCaoThang baoCaoThang)
        {
            return DAO.DAO_BaoCaoThang.UpdateBaoCaoThang(baoCaoThang);
        }

        public static bool CheckExistBaoCaoThang(int thang, int nam)
        {
            return DAO.DAO_BaoCaoThang.CheckExistBaoCaoThang(thang, nam);

        }

        public static int GetMaBCT(int thang, int nam)
        {
            return DAO.DAO_BaoCaoThang.GetMaBCT(thang, nam);
        }

        public static decimal GetDoanhThuThang(int maBCT)
        {
            return DAO.DAO_BaoCaoThang.GetDoanhThuThang(maBCT);
        }

        public static int GetTongSoTiecCuoi(int maBCT)
        {
            return DAO.DAO_BaoCaoThang.GetTongSoTiecCuoi(maBCT);
        }
    }
}
