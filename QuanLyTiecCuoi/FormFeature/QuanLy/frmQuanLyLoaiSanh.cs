using BUS;
using DTO;
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
    public partial class frmQuanLyLoaiSanh : Form
    {
        private MODE mCurrentMode = MODE.AT_HOME;
        public frmQuanLyLoaiSanh()
        {
            InitializeComponent();
        }
        enum MODE
        {
            AT_HOME,
            INSERTING,
            EDITING,
            CELL_SELECTING
        }
        private void frmQuanLyLoaiSanh_Load(object sender, EventArgs e)
        {
            SetDisplayControls(MODE.AT_HOME);
            dgvQuanLyLoaiSanh.DataSource = BUS_QuanLyLoaiSanh.GetLoaiSanhTable();
            dgvQuanLyLoaiSanh.Columns["MaLoaiSanh"].Visible = false;
            dgvQuanLyLoaiSanh.Columns["TenLoaiSanh"].HeaderText = "Tên loại sảnh";
            dgvQuanLyLoaiSanh.Columns["DonGiaBanToiThieu"].HeaderText = "Đơn giá bàn tối thiểu";

        }
        private void DisableAllInputs()
        {
            txtTenLoaiSanh.ReadOnly = true;
            txtDonGiaBanTT.ReadOnly = true;
        }
        private void EnableAllInputs()
        {
            txtTenLoaiSanh.ReadOnly = false;
            txtDonGiaBanTT.ReadOnly = false;
        }
        private void SetDisplayControls(MODE mode)
        {
            switch (mode)
            {
                case MODE.AT_HOME:
                    {
                        DisableAllInputs();
                        btnThem.Enabled = true;
                        btnXoa.Enabled = false;
                        btnSua.Enabled = false;
                        dgvQuanLyLoaiSanh.Enabled = true;
                        break;
                    }
                case MODE.INSERTING:
                    {
                        EnableAllInputs();
                        btnThem.Enabled = false;
                        btnXoa.Enabled = false;
                        btnSua.Enabled = false;
                        txtTenLoaiSanh.Focus();
                        dgvQuanLyLoaiSanh.Enabled = false;
                        break;
                    }
                case MODE.EDITING:
                    {
                        EnableAllInputs();
                        btnThem.Enabled = true;
                        btnXoa.Enabled = false;
                        btnSua.Enabled = false;
                        dgvQuanLyLoaiSanh.Enabled = false;
                        break;
                    }
                case MODE.CELL_SELECTING:
                    {
                        DisableAllInputs();
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        btnSua.Enabled = true;
                        dgvQuanLyLoaiSanh.Enabled = true;
                        break;
                    }
                default:
                    break;
            }
        }
        #region Them, sua, xoa
        private void btnThem_Click(object sender, EventArgs e)
        {
            SetDisplayControls(MODE.INSERTING);
            mCurrentMode = MODE.INSERTING;
            ClearAllInputs();
            dgvQuanLyLoaiSanh.ClearSelection();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetDisplayControls(MODE.EDITING);
            mCurrentMode = MODE.EDITING;

            //dgvQuanLyLoaiSanh.Focus();
            //txtTenLoaiSanh.Text = dgvQuanLyLoaiSanh.CurrentRow.Cells["TenLoaiSanh"].Value.ToString();
            //txtDonGiaBanTT.Text = dgvQuanLyLoaiSanh.CurrentRow.Cells["DonGiaBanToiThieu"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvQuanLyLoaiSanh.Focus();
            DTO_LoaiSanh loaiSanh = new DTO_LoaiSanh();
            loaiSanh.tenLoaiSanh = dgvQuanLyLoaiSanh.CurrentRow.Cells["TenLoaiSanh"].Value.ToString();
            loaiSanh.maLoaiSanh = int.Parse(dgvQuanLyLoaiSanh.CurrentRow.Cells["MaLoaiSanh"].Value.ToString());

            DialogResult dr = MessageBox.Show(string.Format("Bạn có muốn xóa loại sảnh '{0}' không?", loaiSanh.tenLoaiSanh), "Xóa loại sảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
                return;
            if (BUS_QuanLyLoaiSanh.DeleteLoaiSanh(loaiSanh))
            {
                dgvQuanLyLoaiSanh.DataSource = BUS_QuanLyLoaiSanh.GetLoaiSanhTable();
                MessageBox.Show("Xóa loại sảnh '" + loaiSanh.tenLoaiSanh + "' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAllInputs();
            }
            else
                MessageBox.Show(string.Format("Không thể xóa, vui lòng xóa dữ liệu liên qua đến loại sảnh '{0}' trong bảng 'Sảnh' trước.",
                    loaiSanh.tenLoaiSanh),
                    "Lỗi khóa ngoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        private void ClearAllInputs()
        {
            txtTenLoaiSanh.Text = "";
            txtDonGiaBanTT.Text = "";
        }
        #endregion

        #region Luu
        // có code lưu này mới chạy đc thêm, sửa, xóa
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiSanh.Text == "" || txtDonGiaBanTT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int temp;
            if (!int.TryParse(txtDonGiaBanTT.Text, out temp))
            {
                MessageBox.Show("'Đơn giá bàn tối đa' phải là số nguyên, vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaBanTT.Focus();
                txtDonGiaBanTT.SelectAll();
                return;
            }

            switch (mCurrentMode)
            {
                case MODE.AT_HOME:
                    break;
                case MODE.INSERTING:
                    {
                        DialogResult dr = MessageBox.Show("Bạn có muốn lưu loại sảnh '" + txtTenLoaiSanh.Text + "' không?", "Thêm loại sảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.No)
                            return;
                        DTO_LoaiSanh loaiSanh = new DTO_LoaiSanh(txtTenLoaiSanh.Text, decimal.Parse(txtDonGiaBanTT.Text));
                        if (BUS_QuanLyLoaiSanh.InsertLoaiSanh(loaiSanh))
                        {
                            dgvQuanLyLoaiSanh.DataSource = BUS_QuanLyLoaiSanh.GetLoaiSanhTable();
                            ClearAllInputs();
                            MessageBox.Show("Thêm loại sảnh '" + loaiSanh.tenLoaiSanh + "' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SetDisplayControls(MODE.AT_HOME);
                            mCurrentMode = MODE.AT_HOME;
                        }
                        else
                        {
                            MessageBox.Show("Loại sảnh '" + loaiSanh.tenLoaiSanh + "' đã tồn tại. Vui lòng sửa lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtTenLoaiSanh.Focus();
                            txtTenLoaiSanh.SelectAll();
                        }

                        break;
                    }
                case MODE.EDITING:
                    {
                        DialogResult dr = MessageBox.Show("Bạn có muốn lưu lại không?", "Sửa loại sảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.No)
                            return;
                        DTO_LoaiSanh loaiSanh = new DTO_LoaiSanh(txtTenLoaiSanh.Text, decimal.Parse(txtDonGiaBanTT.Text));
                        loaiSanh.maLoaiSanh = int.Parse(dgvQuanLyLoaiSanh.CurrentRow.Cells["MaLoaiSanh"].Value.ToString());
                        if (BUS_QuanLyLoaiSanh.UpdateLoaiSanh(loaiSanh))
                        {
                            dgvQuanLyLoaiSanh.DataSource = BUS_QuanLyLoaiSanh.GetLoaiSanhTable();
                            ClearAllInputs();
                            MessageBox.Show("Sửa loại sảnh '" + loaiSanh.tenLoaiSanh + "' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SetDisplayControls(MODE.AT_HOME);
                            mCurrentMode = MODE.AT_HOME;
                        }
                        else
                        {
                            MessageBox.Show("Loại sảnh '" + loaiSanh.tenLoaiSanh + "' đã tồn tại. Vui lòng sửa lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtTenLoaiSanh.Focus();
                            txtTenLoaiSanh.SelectAll();
                        }

                        break;
                    }
                default:
                    break;
            }
            dgvQuanLyLoaiSanh.ClearSelection();
        }
        #endregion 


        private void txtDonGiaBanTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTenLoaiSanh_TextChanged(object sender, EventArgs e)
        {
            if (txtTenLoaiSanh.Text == " ")
                txtTenLoaiSanh.Text = "";
        }

        private void txtDonGiaBanTT_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaBanTT.Text == "0")
                txtDonGiaBanTT.Text = "";
        }

        private void dgvQuanLyLoaiSanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            SetDisplayControls(mCurrentMode = MODE.CELL_SELECTING);

            int row = e.RowIndex;
            txtTenLoaiSanh.Text = dgvQuanLyLoaiSanh[1, row].Value.ToString();
            txtDonGiaBanTT.Text = dgvQuanLyLoaiSanh[2, row].Value.ToString();
        }

        private void dgvQuanLyLoaiSanh_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvQuanLyLoaiSanh.ClearSelection();
        }
    }
}
