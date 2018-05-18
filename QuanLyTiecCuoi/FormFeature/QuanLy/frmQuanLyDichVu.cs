using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using BUS;

namespace QuanLyTiecCuoiUI
{
    public partial class frmQuanLyDichVu : Form
    {
        public frmQuanLyDichVu()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = DAO_DichVu.GetDataTableDichVu();
            dtgdanhsachdichvu.DataSource = dt;


        }
        private void frmQuanLyDichVu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DAO_DichVu.GetDataTableDichVu();
            dtgdanhsachdichvu.DataSource = dt;
        }
    


        bool isLegalName(String name)
        {
            if (name.Contains("0")) return false;
            if (name.Contains("1")) return false;
            if (name.Contains("2")) return false;
            if (name.Contains("3")) return false;
            if (name.Contains("4")) return false;
            if (name.Contains("5")) return false;
            if (name.Contains("6")) return false;
            if (name.Contains("7")) return false;
            if (name.Contains("8")) return false;
            if (name.Contains("9")) return false;
            return true;
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            if (this.txtMaDichVu.TextLength == 0)
                MessageBox.Show("Tên Mã Dịch Vụ Không Được Bỏ Trống");
            else
            if (this.txtTenDichVu.TextLength == 0)
                MessageBox.Show("Tên Dịch Vụ Không Được Bỏ Trống");
            else
                if (isLegalName(txtTenDichVu.Text) == false)
                MessageBox.Show("Tên Dịch Vụ Không Được Có Số");
            else
                 if (this.txtDonGia.TextLength == 0)
                MessageBox.Show("Đơn Giá Không Được Bỏ Trống");
            else 
                try
            {
                DAO_DichVu.InsertDichVu(new DTO_DichVu(Convert.ToInt32(txtMaDichVu.Text), txtTenDichVu.Text, Convert.ToInt32(txtDonGia.Text)));
                frmQuanLyDichVu_Load(sender, e);
                MessageBox.Show("Đã Thêm Thông Tin Thành Công");

            }
            catch
            {
                MessageBox.Show(" Thông Tin Đã Tồn Tại ");
            }
        }
        private void btnhaplai_Click_1(object sender, EventArgs e)
        {
            this.txtMaDichVu.Clear();
            this.txtTenDichVu.Clear();
            this.txtDonGia.Clear();
        }
        private void btsua_Click_1(object sender, EventArgs e)
        {
            if (this.txtMaDichVu.TextLength == 0)
                MessageBox.Show("Tên Mã Dịch Vụ Không Được Bỏ Trống");
            else
            {
                DAO_DichVu.UpdateDichVu(new DTO_DichVu(Convert.ToInt32(txtMaDichVu.Text), Convert.ToDecimal(txtDonGia.Text)));
                frmQuanLyDichVu_Load(sender, e);
                MessageBox.Show("Đã Sửa Thông Tin Thành Công");
            }
        }
        private void btxoa_Click(object sender, EventArgs e)
        {
            if (this.txtMaDichVu.TextLength == 0)
                MessageBox.Show("Tên Mã Dịch Vụ Không Được Bỏ Trống");
            else
            {
                DAO_DichVu.DeleteDichVu(new DTO_DichVu(Convert.ToInt32(txtMaDichVu.Text)));
                frmQuanLyDichVu_Load(sender, e);
                MessageBox.Show("Đã Xoá Thông Tin Thành Công");
            }
        }
       
    }
}
