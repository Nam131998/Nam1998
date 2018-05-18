using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_BaoCaoNgay
    {
        public static DataTable GetAllBaoCaoNgay(int maBCT)
        {
            return DAO.DAO_BaoCaoNgay.GetAllBaoCaoNgay(maBCT);
        }

        public static bool InsertBaoCaoNgay(DTO.DTO_BaoCaoNgay baoCaoNgay)
        {
            return DAO.DAO_BaoCaoNgay.InsertBaoCaoNgay(baoCaoNgay);
        }

        public static bool UpdateBaoCaoNgay(DTO.DTO_BaoCaoNgay baoCaoNgay)
        {
            return DAO.DAO_BaoCaoNgay.UpdateBaoCaoNgay(baoCaoNgay);
        }

        public static DTO.DTO_BaoCaoNgay GetBaoCaoNgay(int maBCT, int ngay)
        {
            return DAO.DAO_BaoCaoNgay.GetBaoCaoNgay(maBCT, ngay);

        }

        public static bool IsExistBaoCaoNgay(int maBCT, int ngay)
        {
            return DAO.DAO_BaoCaoNgay.IsExistBaoCaoNgay(maBCT, ngay);
        }
    }
}
