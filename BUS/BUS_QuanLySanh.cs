using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_QuanLySanh
    {
        private static List<string> mListTenLoaiSanh;
        private static List<string> mListDonGiaBanTT;
        private static List<string> mListMaLoaiSanh;
        public static bool mIsLoaiSanhDataEmpty;
        public static void Init()
        {
            GetListsInTableLoaiSanh();
        }
        public static DataTable GetQLSanhTable()
        {
            return DAO_QuanLySanh.GetQLSanhTable();
        }
        public static void DeleteSanh(DTO_Sanh sanh)
        {
            DAO_QuanLySanh.DeleteSanh(sanh);
        }
        public static DataTable GetLoaiSanhTable()
        {
            return DAO_QuanLySanh.GetLoaiSanhTable();
        }
        private static void GetListsInTableLoaiSanh()
        {
            DataTable dt = GetLoaiSanhTable();
            if (dt.Rows.Count == 0)
            {
                mIsLoaiSanhDataEmpty = true;
                return;
            }
            mIsLoaiSanhDataEmpty = false;
            mListTenLoaiSanh = new List<string>();
            mListDonGiaBanTT = new List<string>();
            mListMaLoaiSanh = new List<string>();

            foreach (DataRow item in dt.Rows)
            {
                mListMaLoaiSanh.Add(item[0].ToString());
                mListTenLoaiSanh.Add(item[1].ToString());
                mListDonGiaBanTT.Add(item[2].ToString());
            }
        }
        public static List<string> GetListMaLoaiSanh()
        {
            return mListMaLoaiSanh;
        }
        public static List<string> GetListTenLoaiSanh()
        {
            return mListTenLoaiSanh;
        }
        public static List<string> GetListDonGiaBanTT()
        {
            return mListDonGiaBanTT;
        }

        public static bool InsertSanh(DTO_Sanh sanh)
        {
            return DAO_QuanLySanh.InsertSanh(sanh);
        }
        public static int UpdateSanh(DTO_Sanh sanh)
        {
            return DAO_QuanLySanh.UpdateSanh(sanh);
        }
    }
}
