using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Sanh
    {
        public DTO_Sanh() { }
        public DTO_Sanh(string tenSanh, int maLoaiSanh, int soLuongBanToiDa, string ghiChu)
        {
            this.tenSanh = tenSanh;
            this.maLoaiSanh = maLoaiSanh;
            this.soLuongBanToiDa = soLuongBanToiDa;
            this.ghiChu = ghiChu;
        }
        public int maSanh { get; set; }
        public string tenSanh { get; set; }
        public int maLoaiSanh { get; set; }
        public int soLuongBanToiDa { get; set; }
        public string ghiChu { get; set; }
    }
}
