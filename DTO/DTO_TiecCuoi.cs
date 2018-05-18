using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TiecCuoi
    {
        public int MaTiecCuoi { get; set; }
        public string TenChuRe { get; set; }
        public string TenCoDau { get; set; }
        public string DienThoai { get; set; }
        public string NgayDatTiec { get; set; }
        public string NgayDaiTiec { get; set; }
        public int MaCa { get; set; }
        public int MaSanh { get; set; }
        public decimal TienCoc { get; set; }
        public string GhiChu { get; set; }
        public int MaNV { get; set; }
        public int TinhTrangTiec { get; set; }
    }
}