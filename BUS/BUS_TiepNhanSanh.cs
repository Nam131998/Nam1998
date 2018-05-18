
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
    public class BUS_TiepNhanSanh
    {
        private static List<string> mListTenLoaiSanh;
        private static List<string> mListDonGiaBanTT;
        private static List<string> mListMaLoaiSanh;
        public static bool mIsLoaiSanhDataEmpty;
        public static void Init()
        {
            GetListsInTableLoaiSanh();
        }
        private static void GetListsInTableLoaiSanh()
        {
            DataTable dt = DAO_TiepNhanSanh.GetLoaiSanhTable();
            if (dt.Rows.Count == 0)
            {
                mIsLoaiSanhDataEmpty = true;
                return;
            }
            mIsLoaiSanhDataEmpty = false;
            mListMaLoaiSanh = new List<string>();
            mListTenLoaiSanh = new List<string>();
            mListDonGiaBanTT = new List<string>();

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
            return DAO_TiepNhanSanh.InsertSanh(sanh);
        }

        public static bool TenSanhIsExistInSanh(string tenSanh)
        {
            return DAO_TiepNhanSanh.TenSanhIsExistInSanh(tenSanh);
        }
    }
}
