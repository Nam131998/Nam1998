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

namespace QuanLyTiecCuoiUI.FormFeature.QuanLy
{
    public partial class frmQuanLyNhanVien : Form
    {
        private string IDTable = "NV";

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

        //Khoi tao
        public frmQuanLyNhanVien()
        {
            InitializeComponent();

            LoadDataGridView();

            ClearDuLieuNhap();

            rbtNam.Checked = true;
            lblThongTinMaNhanVien.Text = GetNextID(ResultTable);
        }
        private void LoadDataGridView()
        {
            ResultTable = BUS_QuanLyNhanVien.GetDataTable();
            dgvDanhSachNhanVien.DataSource = ResultTable;
            dgvDanhSachNhanVien.Columns[0].HeaderText = "Mã NV";
            dgvDanhSachNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvDanhSachNhanVien.Columns[2].HeaderText = "Giới tính";
            dgvDanhSachNhanVien.Columns[3].HeaderText = "Ngày sinh";
            dgvDanhSachNhanVien.Columns[4].HeaderText = "Chức vụ";
            dgvDanhSachNhanVien.Columns[5].HeaderText = "Số điện thoại";
            dgvDanhSachNhanVien.Columns[6].HeaderText = "Địa chỉ";


            dgvDanhSachNhanVien.ReadOnly = true;
            dgvDanhSachNhanVien.MultiSelect = false;
        }

        //Update datagridview
        private void UpDateDataGridView()
        {
            ResultTable = BUS_QuanLyNhanVien.GetDataTable();
            dgvDanhSachNhanVien.DataSource = ResultTable;
        }

        void ClearDuLieuNhap()
        {
            
            txtTenNhanVien.Text = "";
            rbtNam.Checked = true;
            dtpNgaySinh.Value = new DateTime(1998, 2, 2, 0, 0, 0);
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
            lblThongTinMaNhanVien.Text = GetNextID(ResultTable);

            ClearDuLieuNhap();
        }

        //Them
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNhanVien.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "" )
            {
                ShowKetQua("Không thể thực hiện, vui lòng kiểm tra thông tin nhập.", false);
                return;
            }
            DTO_NhanVien nhanVien = new DTO_NhanVien();

        }


        #endregion


    }
}
