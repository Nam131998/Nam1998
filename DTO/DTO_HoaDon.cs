using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        public int SoHoaDon { get; set; }
        public int MaTiecCuoi { get; set; }
        public String NgayThanhToan { get; set; }
        public decimal TongTienBan { get; set; }
        public decimal TongTienDichVu { get; set; }
        public decimal TongTienHoaDon { get; set; }
        public decimal TienDaThanhToan { get; set; }
        public decimal ConLai { get; set; }
    }
}