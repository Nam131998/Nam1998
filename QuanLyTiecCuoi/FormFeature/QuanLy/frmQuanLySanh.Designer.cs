namespace QuanLyTiecCuoiUI
{
    partial class frmQuanLySanh
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
            this.components = new System.ComponentModel.Container();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnThem = new System.Windows.Forms.Button();
            this.grpDanhSachSanh = new System.Windows.Forms.GroupBox();
            this.dgvQuanLySanh = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpThongTinSanh = new System.Windows.Forms.GroupBox();
            this.txtSoLuongBanTD = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblSoLuongBanTD = new System.Windows.Forms.Label();
            this.lblDonGiaBanTT = new System.Windows.Forms.Label();
            this.lblLoaiSanh = new System.Windows.Forms.Label();
            this.lblTenSanh = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cbbDonGiaBanTT = new System.Windows.Forms.ComboBox();
            this.cbbLoaiSanh = new System.Windows.Forms.ComboBox();
            this.txtTenSanh = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.grpDanhSachSanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLySanh)).BeginInit();
            this.grpThongTinSanh.SuspendLayout();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(6, 32);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "     Thêm";
            this.myToolTip.SetToolTip(this.btnThem, "Thêm sảnh mới");
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // grpDanhSachSanh
            // 
            this.grpDanhSachSanh.Controls.Add(this.dgvQuanLySanh);
            this.grpDanhSachSanh.Location = new System.Drawing.Point(0, 236);
            this.grpDanhSachSanh.Name = "grpDanhSachSanh";
            this.grpDanhSachSanh.Size = new System.Drawing.Size(643, 203);
            this.grpDanhSachSanh.TabIndex = 36;
            this.grpDanhSachSanh.TabStop = false;
            this.grpDanhSachSanh.Text = "Danh sách sảnh";
            // 
            // dgvQuanLySanh
            // 
            this.dgvQuanLySanh.AllowUserToAddRows = false;
            this.dgvQuanLySanh.AllowUserToDeleteRows = false;
            this.dgvQuanLySanh.AllowUserToResizeRows = false;
            this.dgvQuanLySanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLySanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLySanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuanLySanh.EnableHeadersVisualStyles = false;
            this.dgvQuanLySanh.Location = new System.Drawing.Point(3, 16);
            this.dgvQuanLySanh.MultiSelect = false;
            this.dgvQuanLySanh.Name = "dgvQuanLySanh";
            this.dgvQuanLySanh.ReadOnly = true;
            this.dgvQuanLySanh.RowHeadersVisible = false;
            this.dgvQuanLySanh.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvQuanLySanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanLySanh.Size = new System.Drawing.Size(637, 184);
            this.dgvQuanLySanh.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Arial", 9.2F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(7, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Các mục (*) không được để trống";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(136, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(144, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(75, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(73, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "*";
            // 
            // grpThongTinSanh
            // 
            this.grpThongTinSanh.Controls.Add(this.label5);
            this.grpThongTinSanh.Controls.Add(this.label4);
            this.grpThongTinSanh.Controls.Add(this.label3);
            this.grpThongTinSanh.Controls.Add(this.label2);
            this.grpThongTinSanh.Controls.Add(this.label1);
            this.grpThongTinSanh.Controls.Add(this.txtSoLuongBanTD);
            this.grpThongTinSanh.Controls.Add(this.lblGhiChu);
            this.grpThongTinSanh.Controls.Add(this.lblSoLuongBanTD);
            this.grpThongTinSanh.Controls.Add(this.lblDonGiaBanTT);
            this.grpThongTinSanh.Controls.Add(this.lblLoaiSanh);
            this.grpThongTinSanh.Controls.Add(this.lblTenSanh);
            this.grpThongTinSanh.Controls.Add(this.txtGhiChu);
            this.grpThongTinSanh.Controls.Add(this.cbbDonGiaBanTT);
            this.grpThongTinSanh.Controls.Add(this.cbbLoaiSanh);
            this.grpThongTinSanh.Controls.Add(this.txtTenSanh);
            this.grpThongTinSanh.Font = new System.Drawing.Font("Arial", 10F);
            this.grpThongTinSanh.Location = new System.Drawing.Point(0, 2);
            this.grpThongTinSanh.Name = "grpThongTinSanh";
            this.grpThongTinSanh.Size = new System.Drawing.Size(523, 226);
            this.grpThongTinSanh.TabIndex = 34;
            this.grpThongTinSanh.TabStop = false;
            this.grpThongTinSanh.Text = "Thông tin sảnh";
            // 
            // txtSoLuongBanTD
            // 
            this.txtSoLuongBanTD.Location = new System.Drawing.Point(165, 117);
            this.txtSoLuongBanTD.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongBanTD.MaxLength = 3;
            this.txtSoLuongBanTD.Name = "txtSoLuongBanTD";
            this.txtSoLuongBanTD.Size = new System.Drawing.Size(101, 23);
            this.txtSoLuongBanTD.TabIndex = 3;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(7, 152);
            this.lblGhiChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(57, 16);
            this.lblGhiChu.TabIndex = 39;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // lblSoLuongBanTD
            // 
            this.lblSoLuongBanTD.AutoSize = true;
            this.lblSoLuongBanTD.Location = new System.Drawing.Point(7, 120);
            this.lblSoLuongBanTD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuongBanTD.Name = "lblSoLuongBanTD";
            this.lblSoLuongBanTD.Size = new System.Drawing.Size(133, 16);
            this.lblSoLuongBanTD.TabIndex = 38;
            this.lblSoLuongBanTD.Text = "Số lượng bàn tối đa";
            // 
            // lblDonGiaBanTT
            // 
            this.lblDonGiaBanTT.AutoSize = true;
            this.lblDonGiaBanTT.Location = new System.Drawing.Point(7, 89);
            this.lblDonGiaBanTT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonGiaBanTT.Name = "lblDonGiaBanTT";
            this.lblDonGiaBanTT.Size = new System.Drawing.Size(140, 16);
            this.lblDonGiaBanTT.TabIndex = 37;
            this.lblDonGiaBanTT.Text = "Đơn giá bàn tối thiểu";
            // 
            // lblLoaiSanh
            // 
            this.lblLoaiSanh.AutoSize = true;
            this.lblLoaiSanh.Location = new System.Drawing.Point(7, 57);
            this.lblLoaiSanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiSanh.Name = "lblLoaiSanh";
            this.lblLoaiSanh.Size = new System.Drawing.Size(70, 16);
            this.lblLoaiSanh.TabIndex = 36;
            this.lblLoaiSanh.Text = "Loại sảnh";
            // 
            // lblTenSanh
            // 
            this.lblTenSanh.AutoSize = true;
            this.lblTenSanh.Location = new System.Drawing.Point(7, 26);
            this.lblTenSanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSanh.Name = "lblTenSanh";
            this.lblTenSanh.Size = new System.Drawing.Size(68, 16);
            this.lblTenSanh.TabIndex = 35;
            this.lblTenSanh.Text = "Tên sảnh";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(165, 148);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(121, 48);
            this.txtGhiChu.TabIndex = 4;
            // 
            // cbbDonGiaBanTT
            // 
            this.cbbDonGiaBanTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDonGiaBanTT.FormattingEnabled = true;
            this.cbbDonGiaBanTT.Location = new System.Drawing.Point(165, 85);
            this.cbbDonGiaBanTT.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDonGiaBanTT.Name = "cbbDonGiaBanTT";
            this.cbbDonGiaBanTT.Size = new System.Drawing.Size(101, 24);
            this.cbbDonGiaBanTT.TabIndex = 2;
            this.cbbDonGiaBanTT.SelectedIndexChanged += new System.EventHandler(this.cbbDonGiaBanTT_SelectedIndexChanged);
            // 
            // cbbLoaiSanh
            // 
            this.cbbLoaiSanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiSanh.FormattingEnabled = true;
            this.cbbLoaiSanh.Location = new System.Drawing.Point(165, 54);
            this.cbbLoaiSanh.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiSanh.Name = "cbbLoaiSanh";
            this.cbbLoaiSanh.Size = new System.Drawing.Size(101, 24);
            this.cbbLoaiSanh.TabIndex = 1;
            this.cbbLoaiSanh.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiSanh_SelectedIndexChanged);
            // 
            // txtTenSanh
            // 
            this.txtTenSanh.Location = new System.Drawing.Point(165, 19);
            this.txtTenSanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSanh.MaxLength = 100;
            this.txtTenSanh.Name = "txtTenSanh";
            this.txtTenSanh.Size = new System.Drawing.Size(101, 23);
            this.txtTenSanh.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(7, 105);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(7, 69);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Controls.Add(this.btnSua);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Location = new System.Drawing.Point(529, 2);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(114, 226);
            this.grpChucNang.TabIndex = 35;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            // 
            // frmQuanLySanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 489);
            this.Controls.Add(this.grpDanhSachSanh);
            this.Controls.Add(this.grpThongTinSanh);
            this.Controls.Add(this.grpChucNang);
            this.Name = "frmQuanLySanh";
            this.Text = "Quản lý sảnh";
            this.Load += new System.EventHandler(this.frmQuanLySanh_Load);
            this.grpDanhSachSanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLySanh)).EndInit();
            this.grpThongTinSanh.ResumeLayout(false);
            this.grpThongTinSanh.PerformLayout();
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip myToolTip;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grpDanhSachSanh;
        private System.Windows.Forms.DataGridView dgvQuanLySanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpThongTinSanh;
        private System.Windows.Forms.TextBox txtSoLuongBanTD;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblSoLuongBanTD;
        private System.Windows.Forms.Label lblDonGiaBanTT;
        private System.Windows.Forms.Label lblLoaiSanh;
        private System.Windows.Forms.Label lblTenSanh;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.ComboBox cbbDonGiaBanTT;
        private System.Windows.Forms.ComboBox cbbLoaiSanh;
        private System.Windows.Forms.TextBox txtTenSanh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox grpChucNang;
    }
}