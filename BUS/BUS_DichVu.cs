using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DichVu
    {
        public static DataTable GetDataTableDichVu()
        {
            return DAO_DichVu.GetDataTableDichVu();
        }
        public static bool InsertDichVu(DTO_DichVu dichVu)
        {
            return DAO_DichVu.InsertDichVu(dichVu);
        }
        public static bool UpdateDichVu(DTO_DichVu dichVu)
        {
            return DAO_DichVu.UpdateDichVu(dichVu);
        }
        public static bool DeleteDichVu(DTO_DichVu dichVu)
        {
            return DAO_DichVu.DeleteDichVu(dichVu);
        }
        public static int LastIndex()
        {
            return DAO_DichVu.LastIndex();
        }
    }
}