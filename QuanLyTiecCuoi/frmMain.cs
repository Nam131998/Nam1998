using BUS;
using DTO;
using QuanLyTiecCuoi.DAO;
using QuanLyTiecCuoi.KetNoiCSDL;
using QuanLyTiecCuoiUI.FormFeature.QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoiUI
{

    public partial class frmMain : Form
    {

        ConnectDatabase condb = new ConnectDatabase();

        public frmMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //condb.connect();

            //ShowData(dgvTiec, "Select * from TIECCUOI");

            if (DAO.DatabaseHelper.OpenConnection())
            {
                MessageBox.Show("Ket noi thanh cong");
            }
            else MessageBox.Show("Khong thanh cong");

        }


        //Hien ket qua
        void ShowKetQua(string skq, bool kq)
        {
            lbKetQua.Text = skq;
            if (kq == true) lbKetQua.ForeColor = Color.Green;
            else lbKetQua.ForeColor = Color.Red;
        }




        private void btKhachHang_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang frmQLKH = new frmQuanLyKhachHang();
            frmQLKH.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien frmQLNV = new frmQuanLyNhanVien();
            frmQLNV.Show();
        }

        private void btCa_Click(object sender, EventArgs e)
        {
            frmCa frmca = new frmCa();
            frmca.Show();
        }

        private void btSanh_Click(object sender, EventArgs e)
        {
            frmQuanLySanh frmQLSanh = new frmQuanLySanh();
            frmQLSanh.Show();
        }

        private void btLoaiSanh_Click(object sender, EventArgs e)
        {
            frmQuanLyLoaiSanh frmQLLSanh = new frmQuanLyLoaiSanh();
            frmQLLSanh.Show();
        }

        private void btDichVu_Click(object sender, EventArgs e)
        {
            frmQuanLyDichVu frmQLDichVu = new frmQuanLyDichVu();
            frmQLDichVu.Show();
        }
    }
}