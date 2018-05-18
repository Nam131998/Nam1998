using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThamSo
    {
        public String TenQuyDinh { get; set; }
        public float GiaTri { get; set; }
        public DTO_ThamSo()
        {

        }

        public DTO_ThamSo(String tenQuyDinh, float giaTri)
        {
            this.TenQuyDinh = tenQuyDinh;
            this.GiaTri = giaTri;
        }
    }


}
