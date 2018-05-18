using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuDatBan
    {
        public int MaPhieuDatBan { get; set; }
        public int MaTiecCuoi { get; set; }
        public int SoBan { get; set; }
        public int SoBanDuTru { get; set; }
        public decimal DonGiaBan { get; set; }
        public string GhiChu { get; set; }
    }
}
