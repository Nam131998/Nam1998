using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DichVu
    {
        public int maDichVu;
        public string tenDichVu;
        public decimal donGia;
        public DTO_DichVu()
        {

        }
        public DTO_DichVu(int maDichVu, string tenDichVu, decimal donGia)
        {
            this.maDichVu = maDichVu;
            this.tenDichVu = tenDichVu;
            this.donGia = donGia;
        }
        public DTO_DichVu(int maDichVu, decimal donGia)
        {
            this.maDichVu = maDichVu;
            this.donGia = donGia;
        }
        public DTO_DichVu(int maDichVu)
        {
            this.maDichVu = maDichVu;
        }
    }
}