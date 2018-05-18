using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_DichVu
    {
        public static DataTable GetDataTableDichVu()
        {
            string query = "SELECT * FROM DICHVU";
            return DatabaseHelper.GetData(query);
        }

        public static bool InsertDichVu(DTO_DichVu dichVu)
        {

            string query = "SET IDENTITY_INSERT DICHVU ON INSERT INTO DICHVU (MaDichVu,TenDichVu, DonGia) VALUES (" + dichVu.maDichVu + "," +"'" +dichVu.tenDichVu+"'" +"," + dichVu.donGia+ ") SET IDENTITY_INSERT DICHVU OFF";
            try
            {
                int state = DatabaseHelper.ExcuteSql(query);
                if (state > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static bool UpdateDichVu(DTO_DichVu dichVu)
        {
            string query = "Update DICHVU set DonGia = " + dichVu.donGia + " where MaDichVu = " + dichVu.maDichVu  ;
               
            try
            {
                int state = DatabaseHelper.ExcuteSql(query);
                if (state > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static bool DeleteDichVu(DTO_DichVu dichVu)
        {
            string query = "DELETE FROM DICHVU WHERE MaDichVu = "+dichVu.maDichVu;
            try
            {
                int state = DatabaseHelper.ExcuteSql(query);
                if (state > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static int LastIndex()
        {
            //string query = string.Format(@"SELECT TOP 1 MaDichVu FROM DICHVU ORDER BY MaDichVu DESC");
            string query = string.Format(@"SELECT IDENT_CURRENT('DICHVU')");
            return Int32.Parse(DatabaseHelper.GetData(query).Rows[0].ItemArray[0].ToString());
        }
    }
}




