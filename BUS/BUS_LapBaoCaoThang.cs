using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using System.Globalization;

namespace BUS
{
    public class BUS_LapBaoCaoThang
    {
        private static List<List<string>> mListMonths = new List<List<string>>();
        private static List<string> mListYears = new List<string>();
        private const String COLUMN_NAM = "Nam";
        private const String COLUMN_THANG = "Thang";

        public static void LoadLapBaoCaoThang()
        {
            DataTable dtYear = DAO_LapBaoCaoThang.GetTableOfYears();
            foreach (DataRow dr in dtYear.Rows)
            {
                mListYears.Add(dr[COLUMN_NAM].ToString());
            }

            foreach (string year in mListYears)
            {
                DataTable dtMonth = DAO_LapBaoCaoThang.GetTableOfMonths(year);
                List<string> listMonths = new List<string>();
                foreach (DataRow dr in dtMonth.Rows)
                {
                    listMonths.Add(dr[COLUMN_THANG].ToString());
                }
                mListMonths.Add(listMonths);
            }
        }

        public static List<string> GetListYears()
        {
            return mListYears;
        }

        public static List<List<string>> GetListOfListMonths()
        {
            return mListMonths;
        }

        public static DataTable GetBaoCaoThang(string month, string year)
        {
            return DAO_LapBaoCaoThang.GetBaoCaoThang(month, year);
        }
    }
}