using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyTiecCuoiUI
{
    public partial class frmCa : Form
    {
        private int mInsertOrEdit = 0; // Insert=1 , Edit=2
        public frmCa()
        {
            InitializeComponent();
        }
        enum DISPLAY
        {
            HOME,
            INSERTING,
            EDITING,
            CELL_CLICKED
        }
        private void LoadDataGridView()
        {
            dgvTableShow.DataSource = BUS_Ca.GetDataTable();
            dgvTableShow.Columns["MaCa"].HeaderText = "Mã ca";
            dgvTableShow.Columns["TenCa"].HeaderText = "Tên ca";
            dgvTableShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTableShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void SetDisplay(DISPLAY display)
        {
            if (display == DISPLAY.HOME)
            {
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                txtTenCa.ReadOnly = true;
                dgvTableShow.Enabled = true;
            }
            else if (display == DISPLAY.INSERTING)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                txtTenCa.ReadOnly = false;
                dgvTableShow.Enabled = false;
            }
            else if (display == DISPLAY.EDITING)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                txtTenCa.ReadOnly = false;
                dgvTableShow.Enabled = false;
            }
            else if (display == DISPLAY.CELL_CLICKED)
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtTenCa.ReadOnly = true;
                dgvTableShow.Enabled = true;
            }
        }

        private void frmCa_Load(object sender, EventArgs e)
        {
            SetDisplay(DISPLAY.HOME);
            LoadDataGridView();
            lblMaCa.Text = "-";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            mInsertOrEdit = 1;
            txtTenCa.Text = "";
            SetDisplay(DISPLAY.INSERTING);
        }
        private void InsertCa()
        {
            DTO_Ca ca = new DTO_Ca();
            //verified infor
            if (txtTenCa.Text == "")
            {
                MessageBox.Show("Tên ca còn trống. Vui lòng nhập lại.");
                txtTenCa.Focus();
                return;
            }
            //get infor to object
            ca.TenCa = txtTenCa.Text;

            DialogResult resultDialog = MessageBox.Show("Bạn có muốn lưu ca này lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.Yes)
            {
                bool InsertState = BUS_Ca.InsertCa(ca);
                if (InsertState)
                {
                    dgvTableShow.DataSource = BUS_Ca.GetDataTable();
                    SetDisplay(DISPLAY.HOME);
                    MessageBox.Show("Thêm thành công");

                }
                else
                    MessageBox.Show("Thêm thất bại, thử lại");
            }
            else
                return;
        }

        private void dgvTableShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetDisplay(DISPLAY.CELL_CLICKED);
            int rowSelected = e.RowIndex;
            lblMaCa.Text = dgvTableShow["MaCa", rowSelected].Value.ToString();
            txtTenCa.Text = dgvTableShow["TenCa", rowSelected].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rowSelect = -1;
            rowSelect = dgvTableShow.CurrentCell.RowIndex;
            //rowSelect = dgvTableShow.GetCellCount(DataGridViewElementStates.Selected);
            DTO_Ca ca = new DTO_Ca();
            ca.MaCa = Int32.Parse(dgvTableShow["MaCa", rowSelect].Value.ToString());
            DialogResult resultDialog = MessageBox.Show("Bạn có muốn xóa ca này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.Yes)
            {
                bool InsertState = BUS_Ca.DeleteCa(ca);
                if (InsertState)
                {
                    dgvTableShow.DataSource = BUS_Ca.GetDataTable();
                    SetDisplay(DISPLAY.HOME);
                    MessageBox.Show("Xóa thành công");
                }
                else
                    MessageBox.Show("Xóa thất bại, thử lại");
            }
            else
                return;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            mInsertOrEdit = 2;
            SetDisplay(DISPLAY.EDITING);
        }

        private void UpdateCa()
        {
            int rowSelect = -1;
            rowSelect = dgvTableShow.CurrentCell.RowIndex;
            DTO_Ca ca = new DTO_Ca();
            //verified infor 
            if (txtTenCa.Text == "")
            {
                MessageBox.Show("Tên ca còn trống. Vui lòng nhập lại.");
                return;
            }
            //get new object 
            ca.TenCa = txtTenCa.Text;
            ca.MaCa = Int32.Parse(dgvTableShow["MaCa", rowSelect].Value.ToString());
            DialogResult resultDialog = MessageBox.Show("Bạn có muốn sửa dữ liệu ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.Yes)
            {
                bool UpdateState = BUS_Ca.UpdateCa(ca);
                if (UpdateState)
                {
                    dgvTableShow.DataSource = BUS_Ca.GetDataTable();
                    SetDisplay(DISPLAY.HOME);
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                    MessageBox.Show("Cập nhật thất bại");
            }
            else
                return;
        }

       

        private void dgvTableShow_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvTableShow.ClearSelection();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (mInsertOrEdit == 1)
                InsertCa();
            else if (mInsertOrEdit == 2)
                UpdateCa();

            txtTenCa.Text = "";
            lblMaCa.Text = "-";
        }
    }
}
