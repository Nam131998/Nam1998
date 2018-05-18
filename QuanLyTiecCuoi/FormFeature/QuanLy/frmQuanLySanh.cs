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
    public partial class frmQuanLySanh : Form
    {
        private MODE mCurrentMode = MODE.NORMAL;
        private const int MaxSLBanToiDa = 300;
        enum MODE
        {
            NORMAL,
            INSERT,
            EDIT,
            CELLSELECTED
        }
        public frmQuanLySanh()
        {
            InitializeComponent();
            BUS_QuanLySanh.Init();

            myToolTip.SetToolTip(txtSoLuongBanTD, "Số lượng bàn tối đa từ 1 đến " + MaxSLBanToiDa);
            myToolTip.SetToolTip(lblSoLuongBanTD, "Số lượng bàn tối đa từ 1 đến " + MaxSLBanToiDa);
            txtSoLuongBanTD.TextChanged += txtSoLuongBanTD_TextChanged;       
        }
     

        void txtSoLuongBanTD_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuongBanTD.Text == "0")
            {
                txtSoLuongBanTD.Text = "";
                return;
            }
            if (txtSoLuongBanTD.Text != "" && int.Parse(txtSoLuongBanTD.Text) > MaxSLBanToiDa)
            {
                txtSoLuongBanTD.Text = MaxSLBanToiDa.ToString();
                txtSoLuongBanTD.SelectionStart = txtSoLuongBanTD.Text.Length;
            }
        }

        private void frmQuanLySanh_Load(object sender, EventArgs e)
        {
            SetDisplayControls(MODE.NORMAL);
            dgvQuanLySanh.DataSource = BUS_QuanLySanh.GetQLSanhTable();

            dgvQuanLySanh.Columns[0].Visible = false;
            dgvQuanLySanh.Columns[1].HeaderText = "Tên sảnh";
            dgvQuanLySanh.Columns[2].HeaderText = "Loại sảnh";
            dgvQuanLySanh.Columns[3].HeaderText = "Số lượng bàn tối đa";
            dgvQuanLySanh.Columns[4].HeaderText = "Đơn giá bàn tối thiểu";
            dgvQuanLySanh.Columns[5].HeaderText = "Ghi chú";

            cbbLoaiSanh.DataSource = BUS_QuanLySanh.GetListTenLoaiSanh();
            cbbDonGiaBanTT.DataSource = BUS_QuanLySanh.GetListDonGiaBanTT();
        }

        private void SetDisplayControls(MODE mode)
        {
            switch (mode)
            {
                case MODE.NORMAL:
                    {
                        DisableAllInputs();
                        btnThem.Enabled = true;
                        btnXoa.Enabled = false;
                        btnSua.Enabled = false;
                        dgvQuanLySanh.Enabled = true;
                        break;
                    }
                case MODE.INSERT:
                    {
                        EnableAllInputs();
                        btnThem.Enabled = false;
                        btnXoa.Enabled = false;
                        btnSua.Enabled = false;
                        txtTenSanh.Focus();
                        dgvQuanLySanh.Enabled = false;
                        break;
                    }
                case MODE.EDIT:
                    {
                        EnableAllInputs();
                        btnThem.Enabled = true;
                        btnXoa.Enabled = false;
                        btnSua.Enabled = false;
                        dgvQuanLySanh.Enabled = false;
                        break;
                    }
                case MODE.CELLSELECTED:
                    {
                        DisableAllInputs();
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        btnSua.Enabled = true;
                        dgvQuanLySanh.Enabled = true;
                        break;
                    }
                default:
                    break;
            }
        }

        private void DisableAllInputs()
        {
            txtTenSanh.ReadOnly = true;
            cbbLoaiSanh.Enabled = false;
            cbbDonGiaBanTT.Enabled = false;
            txtSoLuongBanTD.ReadOnly = true;
            txtGhiChu.ReadOnly = true;
        }
        private void EnableAllInputs()
        {
            txtTenSanh.ReadOnly = false;
            cbbLoaiSanh.Enabled = true;
            cbbDonGiaBanTT.Enabled = true;
            txtSoLuongBanTD.ReadOnly = false;
            txtGhiChu.ReadOnly = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SetDisplayControls(MODE.INSERT);
            ClearAllInputs();
            dgvQuanLySanh.ClearSelection();
            mCurrentMode = MODE.INSERT;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvQuanLySanh.Focus();
            string tenSanh = dgvQuanLySanh.CurrentRow.Cells[1].Value.ToString();
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa sảnh '" + tenSanh + "' không?", "Xóa sảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int i = dgvQuanLySanh.CurrentCell.RowIndex;
                DTO_Sanh sanh = new DTO_Sanh();
                sanh.maSanh = int.Parse(dgvQuanLySanh.CurrentRow.Cells["MaSanh"].Value.ToString());
                BUS_QuanLySanh.DeleteSanh(sanh);
                dgvQuanLySanh.DataSource = BUS_QuanLySanh.GetQLSanhTable();
                ClearAllInputs();
                MessageBox.Show("Xóa thành công sảnh '" + tenSanh + "' !");
            }
        }
      

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetDisplayControls(MODE.EDIT);
            mCurrentMode = MODE.EDIT;
            txtTenSanh.Text = dgvQuanLySanh.CurrentRow.Cells["TenSanh"].Value.ToString();
            txtSoLuongBanTD.Text = dgvQuanLySanh.CurrentRow.Cells["SoLuongBanToiDa"].Value.ToString();
            cbbDonGiaBanTT.SelectedIndex = cbbDonGiaBanTT.Items.IndexOf(dgvQuanLySanh.CurrentRow.Cells["DonGiaBanToiThieu"].Value.ToString());
            txtGhiChu.Text = dgvQuanLySanh.CurrentRow.Cells["GhiChu"].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenSanh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSanh.Focus();
                return;
            }
            if (txtSoLuongBanTD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongBanTD.Focus();
                return;
            }
            int temp;
            if (!int.TryParse(txtSoLuongBanTD.Text, out temp))
            {
                MessageBox.Show("'Số lượng bàn tối đa' phải là số nguyên, vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongBanTD.Focus();
                txtSoLuongBanTD.SelectAll();
                return;
            }

            //DialogResult dr = MessageBox.Show("Bạn có muốn lưu không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dr == DialogResult.No)
            //    return;

            switch (mCurrentMode)
            {
                case MODE.INSERT:
                    {
                        int maloaiSanh = int.Parse(BUS_QuanLySanh.GetListMaLoaiSanh()[cbbLoaiSanh.SelectedIndex]);
                        DTO_Sanh sanh = new DTO_Sanh(txtTenSanh.Text, maloaiSanh, int.Parse(txtSoLuongBanTD.Text), txtGhiChu.Text);
                        BUS_QuanLySanh.InsertSanh(sanh);

                        dgvQuanLySanh.DataSource = BUS_QuanLySanh.GetQLSanhTable();
                        MessageBox.Show("Thêm thành công sảnh '" + sanh.tenSanh + "' !");
                        SetDisplayControls(MODE.NORMAL);
                        mCurrentMode = MODE.NORMAL;
                        break;
                    }
                case MODE.EDIT:
                    {
                        int maloaiSanh = int.Parse(BUS_QuanLySanh.GetListMaLoaiSanh()[cbbLoaiSanh.SelectedIndex]);
                        DTO_Sanh sanh = new DTO_Sanh(txtTenSanh.Text, maloaiSanh, int.Parse(txtSoLuongBanTD.Text), txtGhiChu.Text);
                        sanh.maSanh = int.Parse(dgvQuanLySanh.CurrentRow.Cells["MaSanh"].Value.ToString());
                        BUS_QuanLySanh.UpdateSanh(sanh);

                        dgvQuanLySanh.DataSource = BUS_QuanLySanh.GetQLSanhTable();
                        MessageBox.Show("Sửa thành công sảnh '" + sanh.tenSanh + "' !");
                        SetDisplayControls(MODE.NORMAL);
                        mCurrentMode = MODE.NORMAL;
                        break;
                    }
                default:
                    break;
            }
            ClearAllInputs();
            dgvQuanLySanh.ClearSelection();
        }

        private void ClearAllInputs()
        {
            txtTenSanh.Text = "";
            txtSoLuongBanTD.Text = "";
            txtGhiChu.Text = "";          
        }

        private void cbbDonGiaBanTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiSanh.Items.Count > 0)
                cbbLoaiSanh.SelectedIndex = cbbDonGiaBanTT.SelectedIndex;
        }

        private void cbbLoaiSanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDonGiaBanTT.Items.Count > 0)
                cbbDonGiaBanTT.SelectedIndex = cbbLoaiSanh.SelectedIndex;
        }

        private void txtSoLuongBanTD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void dgvQuanLySanh_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvQuanLySanh.ClearSelection();
        }

        private void dgvQuanLySanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            SetDisplayControls(mCurrentMode = MODE.CELLSELECTED);

            int row = e.RowIndex;
            txtTenSanh.Text = dgvQuanLySanh[1, row].Value.ToString();
            cbbLoaiSanh.Text = dgvQuanLySanh[2, row].Value.ToString();
            txtSoLuongBanTD.Text = dgvQuanLySanh[3, row].Value.ToString();
            txtGhiChu.Text = dgvQuanLySanh[5, row].Value.ToString();
        }

        private void txtGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender == null)
                return;

            if (e.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void frmQuanLySanh_Shown(object sender, EventArgs e)
        {
            if (BUS_QuanLySanh.mIsLoaiSanhDataEmpty)
            {
                MessageBox.Show("Không có dữ liệu Loại Sảnh nào, vui lòng thêm vào để sử dụng chức năng này!\n\nĐể thêm, truy cập: QUY ĐỊNH > Quản lý loại sảnh", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void grpThongTinSanh_Enter(object sender, EventArgs e)
        {

        }
    }
}
