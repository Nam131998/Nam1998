using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BaoCaoNgay
    {
        public int MaBCT { get; set; }
        public int Ngay { get; set; }
        public int SoLuongTiecCuoi { get; set; }
        public decimal DoanhThu { get; set; }
        public decimal TiLe { get; set; }

        public DTO_BaoCaoNgay()
        {

        }
    }
}
