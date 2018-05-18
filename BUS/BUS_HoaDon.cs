using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HoaDon
    {
        public static bool InsertHoaDon(DTO.DTO_HoaDon hoaDon)
        {
            return DAO.DAO_HoaDon.InsertHoaDon(hoaDon);
        }

        public static bool UpdateHoaDon(DTO.DTO_HoaDon hoaDon)
        {
            return DAO.DAO_HoaDon.UpdateHoaDon(hoaDon);
        }

        public static List<DTO.DTO_HoaDon> GetAllHoaDon(int maTiecCuoi)
        {
            return DAO.DAO_HoaDon.GetAllHoaDon(maTiecCuoi);
        }
    }
}