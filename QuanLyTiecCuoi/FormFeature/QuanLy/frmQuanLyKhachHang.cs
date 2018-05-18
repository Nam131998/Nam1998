
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyTiecCuoiUI
{
    public partial class frmQuanLyKhachHang : Form
    {
        
        private string IDTable = "KH";
        
        private DataTable ResultTable;



        //Convert Number to string for index

        private string ConvertNumber(int state)
        {
            if (state <= 9) return '0' + state.ToString();
            else
                return state.ToString();
        }

        //Get next index in table
        private string GetNextID(DataTable result)
        {
            try
            {
                return IDTable + (ConvertNumber(Int32.Parse(result.Rows[ResultTable.Rows.Count - 1].ItemArray[0].ToString().Substring(2)) + 1));
            }
            catch 
            {
                return IDTable + "01";
            }
        }
        //public frmQuanLyKhachHang(string TableID)
        //{
        //    InitializeComponent();
        //    IDTable = TableID;
        //    ResultTable = BUS_KhachHang.GetDataTable();
        //}


        //Khoi tao
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
            
            LoadDataGridView();

            lblThongTinMaKhachHang.Text = GetNextID(ResultTable);
        }
        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {

            LoadDataGridView();
            btnThem.Focus();

        }

        //Load DatagridView
        private void LoadDataGridView()
        {
            ResultTable = BUS_KhachHang.GetDataTable();
            dgvDanhSachKhachHang.DataSource = ResultTable;
            dgvDanhSachKhachHang.Columns[0].HeaderText = "Mã KH";
            dgvDanhSachKhachHang.Columns[1].HeaderText = "Tên chú rể";
            dgvDanhSachKhachHang.Columns[2].HeaderText = "Tên cô dâu";
            dgvDanhSachKhachHang.Columns[3].HeaderText = "Điện thoại";
            dgvDanhSachKhachHang.Columns[4].HeaderText = "Địa chỉ";


            //dgvDanhSachKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachKhachHang.ReadOnly = true;
            //dgvDanhSachKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachKhachHang.MultiSelect = false;
        }

        //Update datagridview
        private void UpDateDataGridView()
        {
            ResultTable = BUS_KhachHang.GetDataTable();
            dgvDanhSachKhachHang.DataSource = ResultTable;
        }

        void ClearDuLieuNhap()
        {
            txtTenChuRe.Text = "";
            txtTenCoDau.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
        }

        void ShowKetQua(string skq, bool kq)
        {

            lbKetQua.Text = skq;
            if (kq) lbKetQua.ForeColor = Color.Green;
            else lbKetQua.ForeColor = Color.Red;
        }

 
        #region Them, Sua, Xoa

        private void llbThemMoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnThem.Visible = true;
            btnCapNhat.Visible = false;
            btnXoa.Visible = false;

            //Load ma khach hang
            lblThongTinMaKhachHang.Text = GetNextID(ResultTable);

            ClearDuLieuNhap();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
             
        
            //Them

            if (txtTenChuRe.Text == "" || txtTenCoDau.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "")
            {
                ShowKetQua("Không thể thực hiện, vui lòng kiểm tra thông tin nhập.", false);
                return;
            }
            DTO_KhachHang khachhang = new DTO_KhachHang(lblThongTinMaKhachHang.Text, txtTenChuRe.Text, txtTenCoDau.Text, txtDienThoai.Text, txtDiaChi.Text);

            if (BUS_KhachHang.InsertKhachHang(khachhang))
            {
                 UpDateDataGridView();
                 dgvDanhSachKhachHang.ClearSelection();
                 ShowKetQua("Thêm thành công khách hàng '" + khachhang.MaKH + "' !!", true);
            }
                else
                ShowKetQua("Thêm thất bại, vui lòng kiểm tra lại.", false);
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {


            //Cap nhat
            if (txtTenChuRe.Text == "" || txtTenCoDau.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "")
            {
                ShowKetQua("Cập nhật thất bại, thông tin còn trống.", false);
                return;
            }
            DTO_KhachHang khachhang = new DTO_KhachHang(lblThongTinMaKhachHang.Text, txtTenChuRe.Text, txtTenCoDau.Text, txtDienThoai.Text, txtDiaChi.Text);

            if (BUS_KhachHang.UpdateKhachHang(khachhang))
            {
                UpDateDataGridView(); 
                ShowKetQua("Cập nhật thành công khách hàng '" +khachhang.MaKH+ "' !!",true);
            }
            else
                ShowKetQua("Cập nhật thất bại, vui lòng kiểm tra lại.", false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            

            DTO_KhachHang khachhang =  new DTO_KhachHang(lblThongTinMaKhachHang.Text, txtTenChuRe.Text, txtTenCoDau.Text, txtDienThoai.Text, txtDiaChi.Text);
            
            DialogResult resultDialog = MessageBox.Show("Bạn có muốn xóa dữ liệu khách hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.Yes)
            {
                if (BUS_KhachHang.DeleteKhachHang(khachhang))
                {
                    UpDateDataGridView();
                    ShowKetQua("Xóa thành công khách hàng '" +khachhang.MaKH+ "' !!",true);
                }
                else
                    ShowKetQua("Xóa khách hàng '" + khachhang.MaKH + "' thất bại, vui lòng thử lại.", false);
            }

        }
        //Chon hang tren data 
        private void ShowDataCell(int row)
        {
            btnThem.Visible = false;
            btnCapNhat.Visible = true;
            btnXoa.Visible = true;
            lblThongTinMaKhachHang.Text = dgvDanhSachKhachHang[0, row].Value.ToString();
            txtTenChuRe.Text = dgvDanhSachKhachHang[1, row].Value.ToString();
            txtTenCoDau.Text = dgvDanhSachKhachHang[2, row].Value.ToString();
            txtDienThoai.Text = dgvDanhSachKhachHang[3, row].Value.ToString();
            txtDiaChi.Text = dgvDanhSachKhachHang[4, row].Value.ToString();
        }
        private void dgvDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowS = e.RowIndex;
            if (rowS >= 0)
            {
                ShowDataCell(rowS);
            }
        }

        #endregion

        #region Tim kiem
        private void txbMaKhachHang_TimKiem_TextChanged(object sender, EventArgs e)
        {
            //Khong cho phep dien ten co dau, chu re
            txbTenChuRe_TimKiem.Text = "";
            txbTenCoDau_TimKiem.Text = "";

            if (txbMaKhachHang_TimKiem.Text == " ")
            {
                txbMaKhachHang_TimKiem.Text = "";
                return;
            }

            dgvDanhSachKhachHang.DataSource = BUS_KhachHang.SearchKhachHangTheoMa(txbMaKhachHang_TimKiem.Text);
        }

        private void txbTenChuRe_TimKiem_TextChanged(object sender, EventArgs e)
        {
            //Khong cho phep dien ma
            txbMaKhachHang_TimKiem.Text = "";

            if (txbTenChuRe_TimKiem.Text == " ")
            {
                txbTenChuRe_TimKiem.Text = "";
                return;
            }
            dgvDanhSachKhachHang.DataSource = BUS_KhachHang.SearchKhachHangTheoTen(txbTenChuRe_TimKiem.Text, txbTenCoDau_TimKiem.Text);
        }
        private void txbTenCoDau_TimKiem_TextChanged(object sender, EventArgs e)
        {
            //Khong cho phep dien ma
            txbMaKhachHang_TimKiem.Text = "";

            if (txbTenCoDau_TimKiem.Text == " ")
            {
                txbTenCoDau_TimKiem.Text = "";
                return;
            }
            dgvDanhSachKhachHang.DataSource = BUS_KhachHang.SearchKhachHangTheoTen(txbTenChuRe_TimKiem.Text, txbTenCoDau_TimKiem.Text);
        }
        #endregion




        #region Xoa dau cach " "
        private void txtTenChuRe_TextChanged(object sender, EventArgs e)
        {
            if (txtTenChuRe.Text == " ") txtTenChuRe.Text = "";
        }

        private void txtTenCoDau_TextChanged(object sender, EventArgs e)
        {
            if (txtTenCoDau.Text == " ") txtTenCoDau.Text = "";
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (txtDienThoai.Text == " ") txtDienThoai.Text = "";
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == " ") txtDiaChi.Text = "";
        }


        #endregion

        
    }
}

