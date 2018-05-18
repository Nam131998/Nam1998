using QuanLyTiecCuoi.KetNoiCSDL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoi.DAO
{
    class QuanLyCa
    {
        static ConnectDatabase condb = new ConnectDatabase();

        public static void ThemCa(string MaCa, string TGBD, string TGKT)
        {
            //string.Format("INSERT INTO THANHVIEN(TV_NAME, TV_PHONE, TV_EMAIL) VALUES ('{0}', '{1}', '{2}')", tv.THANHVIEN_NAME, tv.THANHVIEN_PHONE, tv.THANHVIEN_EMAIL);


            string query = "insert into CA(MaCa,ThoiGianBatDau,ThoiGianKetThuc) values(@MaCa,@TGBD,@TGKT)";
            condb.connect();
            using (SqlCommand command = new SqlCommand(query, condb.conn))
            {
                command.Parameters.AddWithValue("@MaCa", "abc");
                command.Parameters.AddWithValue("@TGBD", "abc");
                command.Parameters.AddWithValue("@TGKT", "abc");


                condb.conn.Open();
                int result = command.ExecuteNonQuery();

                // Check Error
                if (result < 0)
                    Console.WriteLine("Error inserting data into Database!");
            }
           

        }

        public static void ShowData(DataGridView dgv, string sql)
        {
            DataView dv = new DataView(condb.getDataTable(sql));

            dgv.DataSource = dv;

            dgv.AutoResizeColumns();
        }
    }
}
