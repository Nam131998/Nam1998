using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiSanh
    {
        public DTO_LoaiSanh() { }
        public DTO_LoaiSanh(string tenLoaiSanh, decimal donGiaBanToiThieu)
        {
            this.tenLoaiSanh = tenLoaiSanh;
            this.donGiaBanToiThieu = donGiaBanToiThieu;
        }
        public int maLoaiSanh;
        public string tenLoaiSanh { get; set; }
        public decimal donGiaBanToiThieu { get; set; }
    }
}
