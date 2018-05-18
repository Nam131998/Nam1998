using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BaoCaoThang
    {
        public int MaBCT { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int TongSoLuongTiecCuoi { get; set; }
        public decimal TongDoanhThu { get; set; }

        public DTO_BaoCaoThang()
        {

        }
    }
}
