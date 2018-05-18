namespace QuanLyTiecCuoiUI
{
    partial class frmQuanLyKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDanhSachKhachHang = new System.Windows.Forms.Label();
            this.lblThongTinMaKhachHang = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenCoDau = new System.Windows.Forms.TextBox();
            this.txtTenChuRe = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblTenCoDau = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblTenChuRe = new System.Windows.Forms.Label();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.txbMaKhachHang_TimKiem = new System.Windows.Forms.TextBox();
            this.txbTenCoDau_TimKiem = new System.Windows.Forms.TextBox();
            this.txbTenChuRe_TimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.dgvDanhSachKhachHang = new System.Windows.Forms.DataGridView();
            this.grpThongTinKhachHang = new System.Windows.Forms.GroupBox();
            this.llbThemMoi = new System.Windows.Forms.LinkLabel();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.grbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhachHang)).BeginInit();
            this.grpThongTinKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDanhSachKhachHang
            // 
            this.lblDanhSachKhachHang.AutoSize = true;
            this.lblDanhSachKhachHang.Location = new System.Drawing.Point(308, 127);
            this.lblDanhSachKhachHang.Name = "lblDanhSachKhachHang";
            this.lblDanhSachKhachHang.Size = new System.Drawing.Size(119, 13);
            this.lblDanhSachKhachHang.TabIndex = 7;
            this.lblDanhSachKhachHang.Text = "Danh sách khách hàng";
            // 
            // lblThongTinMaKhachHang
            // 
            this.lblThongTinMaKhachHang.AutoSize = true;
            this.lblThongTinMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinMaKhachHang.Location = new System.Drawing.Point(115, 33);
            this.lblThongTinMaKhachHang.Name = "lblThongTinMaKhachHang";
            this.lblThongTinMaKhachHang.Size = new System.Drawing.Size(44, 16);
            this.lblThongTinMaKhachHang.TabIndex = 9;
            this.lblThongTinMaKhachHang.Text = "KH01";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(6, 278);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(285, 23);
            this.txtDiaChi.TabIndex = 8;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(6, 205);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(285, 23);
            this.txtDienThoai.TabIndex = 7;
            this.txtDienThoai.TextChanged += new System.EventHandler(this.txtDienThoai_TextChanged);
            // 
            // txtTenCoDau
            // 
            this.txtTenCoDau.Location = new System.Drawing.Point(7, 139);
            this.txtTenCoDau.Name = "txtTenCoDau";
            this.txtTenCoDau.Size = new System.Drawing.Size(284, 23);
            this.txtTenCoDau.TabIndex = 6;
            this.txtTenCoDau.TextChanged += new System.EventHandler(this.txtTenCoDau_TextChanged);
            // 
            // txtTenChuRe
            // 
            this.txtTenChuRe.Location = new System.Drawing.Point(6, 84);
            this.txtTenChuRe.Name = "txtTenChuRe";
            this.txtTenChuRe.Size = new System.Drawing.Size(285, 23);
            this.txtTenChuRe.TabIndex = 5;
            this.txtTenChuRe.TextChanged += new System.EventHandler(this.txtTenChuRe_TextChanged);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(6, 248);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(51, 17);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(6, 179);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(72, 17);
            this.lblDienThoai.TabIndex = 3;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // lblTenCoDau
            // 
            this.lblTenCoDau.AutoSize = true;
            this.lblTenCoDau.Location = new System.Drawing.Point(6, 119);
            this.lblTenCoDau.Name = "lblTenCoDau";
            this.lblTenCoDau.Size = new System.Drawing.Size(80, 17);
            this.lblTenCoDau.TabIndex = 2;
            this.lblTenCoDau.Text = "Tên cô dâu";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(9, 328);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(69, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "     Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(99, 328);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(60, 30);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "     Sửa";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Visible = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(189, 328);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 30);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblTenChuRe
            // 
            this.lblTenChuRe.AutoSize = true;
            this.lblTenChuRe.Location = new System.Drawing.Point(3, 64);
            this.lblTenChuRe.Name = "lblTenChuRe";
            this.lblTenChuRe.Size = new System.Drawing.Size(77, 17);
            this.lblTenChuRe.TabIndex = 1;
            this.lblTenChuRe.Text = "Tên chú rể";
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.lbMaKH);
            this.grbTimKiem.Controls.Add(this.txbMaKhachHang_TimKiem);
            this.grbTimKiem.Controls.Add(this.txbTenCoDau_TimKiem);
            this.grbTimKiem.Controls.Add(this.txbTenChuRe_TimKiem);
            this.grbTimKiem.Controls.Add(this.label1);
            this.grbTimKiem.Controls.Add(this.label2);
            this.grbTimKiem.Location = new System.Drawing.Point(308, 12);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(586, 112);
            this.grbTimKiem.TabIndex = 5;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(21, 22);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(82, 13);
            this.lbMaKH.TabIndex = 12;
            this.lbMaKH.Text = "Mã khách hàng";
            // 
            // txbMaKhachHang_TimKiem
            // 
            this.txbMaKhachHang_TimKiem.Location = new System.Drawing.Point(24, 38);
            this.txbMaKhachHang_TimKiem.Name = "txbMaKhachHang_TimKiem";
            this.txbMaKhachHang_TimKiem.Size = new System.Drawing.Size(117, 20);
            this.txbMaKhachHang_TimKiem.TabIndex = 11;
            this.txbMaKhachHang_TimKiem.TextChanged += new System.EventHandler(this.txbMaKhachHang_TimKiem_TextChanged);
            // 
            // txbTenCoDau_TimKiem
            // 
            this.txbTenCoDau_TimKiem.Location = new System.Drawing.Point(269, 57);
            this.txbTenCoDau_TimKiem.Name = "txbTenCoDau_TimKiem";
            this.txbTenCoDau_TimKiem.Size = new System.Drawing.Size(258, 20);
            this.txbTenCoDau_TimKiem.TabIndex = 10;
            this.txbTenCoDau_TimKiem.TextChanged += new System.EventHandler(this.txbTenCoDau_TimKiem_TextChanged);
            // 
            // txbTenChuRe_TimKiem
            // 
            this.txbTenChuRe_TimKiem.Location = new System.Drawing.Point(269, 19);
            this.txbTenChuRe_TimKiem.Name = "txbTenChuRe_TimKiem";
            this.txbTenChuRe_TimKiem.Size = new System.Drawing.Size(258, 20);
            this.txbTenChuRe_TimKiem.TabIndex = 9;
            this.txbTenChuRe_TimKiem.TextChanged += new System.EventHandler(this.txbTenChuRe_TimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên cô dâu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên chú rể";
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Location = new System.Drawing.Point(6, 33);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(105, 17);
            this.lblMaKhachHang.TabIndex = 0;
            this.lblMaKhachHang.Text = "Mã khách hàng";
            // 
            // dgvDanhSachKhachHang
            // 
            this.dgvDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKhachHang.Location = new System.Drawing.Point(308, 147);
            this.dgvDanhSachKhachHang.Name = "dgvDanhSachKhachHang";
            this.dgvDanhSachKhachHang.Size = new System.Drawing.Size(586, 291);
            this.dgvDanhSachKhachHang.TabIndex = 6;
            this.dgvDanhSachKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachKhachHang_CellClick);
            // 
            // grpThongTinKhachHang
            // 
            this.grpThongTinKhachHang.Controls.Add(this.llbThemMoi);
            this.grpThongTinKhachHang.Controls.Add(this.btnXoa);
            this.grpThongTinKhachHang.Controls.Add(this.btnCapNhat);
            this.grpThongTinKhachHang.Controls.Add(this.btnThem);
            this.grpThongTinKhachHang.Controls.Add(this.lblThongTinMaKhachHang);
            this.grpThongTinKhachHang.Controls.Add(this.txtDiaChi);
            this.grpThongTinKhachHang.Controls.Add(this.txtDienThoai);
            this.grpThongTinKhachHang.Controls.Add(this.txtTenCoDau);
            this.grpThongTinKhachHang.Controls.Add(this.txtTenChuRe);
            this.grpThongTinKhachHang.Controls.Add(this.lblDiaChi);
            this.grpThongTinKhachHang.Controls.Add(this.lblDienThoai);
            this.grpThongTinKhachHang.Controls.Add(this.lblTenCoDau);
            this.grpThongTinKhachHang.Controls.Add(this.lblTenChuRe);
            this.grpThongTinKhachHang.Controls.Add(this.lblMaKhachHang);
            this.grpThongTinKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpThongTinKhachHang.Location = new System.Drawing.Point(5, 8);
            this.grpThongTinKhachHang.Name = "grpThongTinKhachHang";
            this.grpThongTinKhachHang.Size = new System.Drawing.Size(297, 417);
            this.grpThongTinKhachHang.TabIndex = 4;
            this.grpThongTinKhachHang.TabStop = false;
            this.grpThongTinKhachHang.Text = "Thông tin khách hàng";
            // 
            // llbThemMoi
            // 
            this.llbThemMoi.AutoSize = true;
            this.llbThemMoi.Location = new System.Drawing.Point(205, 33);
            this.llbThemMoi.Name = "llbThemMoi";
            this.llbThemMoi.Size = new System.Drawing.Size(70, 17);
            this.llbThemMoi.TabIndex = 10;
            this.llbThemMoi.TabStop = true;
            this.llbThemMoi.Text = "Thêm mới";
            this.llbThemMoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbThemMoi_LinkClicked);
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(308, 445);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(73, 13);
            this.lbKetQua.TabIndex = 8;
            this.lbKetQua.Text = "Show ket qua";
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 470);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.lblDanhSachKhachHang);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.dgvDanhSachKhachHang);
            this.Controls.Add(this.grpThongTinKhachHang);
            this.Name = "frmQuanLyKhachHang";
            this.Text = "Quản lý khách hàng";
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhachHang)).EndInit();
            this.grpThongTinKhachHang.ResumeLayout(false);
            this.grpThongTinKhachHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhSachKhachHang;
        private System.Windows.Forms.Label lblThongTinMaKhachHang;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtTenCoDau;
        private System.Windows.Forms.TextBox txtTenChuRe;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblTenCoDau;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblTenChuRe;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.DataGridView dgvDanhSachKhachHang;
        private System.Windows.Forms.GroupBox grpThongTinKhachHang;
        private System.Windows.Forms.TextBox txbTenCoDau_TimKiem;
        private System.Windows.Forms.TextBox txbTenChuRe_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.TextBox txbMaKhachHang_TimKiem;
        private System.Windows.Forms.LinkLabel llbThemMoi;
    }
}