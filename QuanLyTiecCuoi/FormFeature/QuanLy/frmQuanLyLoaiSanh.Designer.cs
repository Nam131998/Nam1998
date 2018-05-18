namespace QuanLyTiecCuoiUI
{
    partial class frmQuanLyLoaiSanh
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
            this.lblDonGiaBanToiThieu = new System.Windows.Forms.Label();
            this.lblMaLoaiSanh = new System.Windows.Forms.Label();
            this.dgvQuanLyLoaiSanh = new System.Windows.Forms.DataGridView();
            this.grpThongTinLoaiSanh = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonGiaBanTT = new System.Windows.Forms.TextBox();
            this.txtTenLoaiSanh = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grpTinhNangQuanLy = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grpDanhSachLoaiSanh = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyLoaiSanh)).BeginInit();
            this.grpThongTinLoaiSanh.SuspendLayout();
            this.grpTinhNangQuanLy.SuspendLayout();
            this.grpDanhSachLoaiSanh.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDonGiaBanToiThieu
            // 
            this.lblDonGiaBanToiThieu.AutoSize = true;
            this.lblDonGiaBanToiThieu.Location = new System.Drawing.Point(7, 85);
            this.lblDonGiaBanToiThieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonGiaBanToiThieu.Name = "lblDonGiaBanToiThieu";
            this.lblDonGiaBanToiThieu.Size = new System.Drawing.Size(144, 16);
            this.lblDonGiaBanToiThieu.TabIndex = 36;
            this.lblDonGiaBanToiThieu.Text = "Đơn giá bàn tối thiểu:";
            // 
            // lblMaLoaiSanh
            // 
            this.lblMaLoaiSanh.AutoSize = true;
            this.lblMaLoaiSanh.Location = new System.Drawing.Point(7, 29);
            this.lblMaLoaiSanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLoaiSanh.Name = "lblMaLoaiSanh";
            this.lblMaLoaiSanh.Size = new System.Drawing.Size(98, 16);
            this.lblMaLoaiSanh.TabIndex = 35;
            this.lblMaLoaiSanh.Text = "Tên loại sảnh:";
            // 
            // dgvQuanLyLoaiSanh
            // 
            this.dgvQuanLyLoaiSanh.AllowUserToAddRows = false;
            this.dgvQuanLyLoaiSanh.AllowUserToDeleteRows = false;
            this.dgvQuanLyLoaiSanh.AllowUserToResizeRows = false;
            this.dgvQuanLyLoaiSanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyLoaiSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyLoaiSanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuanLyLoaiSanh.Location = new System.Drawing.Point(3, 19);
            this.dgvQuanLyLoaiSanh.Name = "dgvQuanLyLoaiSanh";
            this.dgvQuanLyLoaiSanh.ReadOnly = true;
            this.dgvQuanLyLoaiSanh.RowHeadersVisible = false;
            this.dgvQuanLyLoaiSanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanLyLoaiSanh.Size = new System.Drawing.Size(394, 154);
            this.dgvQuanLyLoaiSanh.TabIndex = 7;
            // 
            // grpThongTinLoaiSanh
            // 
            this.grpThongTinLoaiSanh.Controls.Add(this.label1);
            this.grpThongTinLoaiSanh.Controls.Add(this.label5);
            this.grpThongTinLoaiSanh.Controls.Add(this.label4);
            this.grpThongTinLoaiSanh.Controls.Add(this.txtDonGiaBanTT);
            this.grpThongTinLoaiSanh.Controls.Add(this.lblDonGiaBanToiThieu);
            this.grpThongTinLoaiSanh.Controls.Add(this.lblMaLoaiSanh);
            this.grpThongTinLoaiSanh.Controls.Add(this.txtTenLoaiSanh);
            this.grpThongTinLoaiSanh.Font = new System.Drawing.Font("Arial", 10F);
            this.grpThongTinLoaiSanh.Location = new System.Drawing.Point(0, 2);
            this.grpThongTinLoaiSanh.Name = "grpThongTinLoaiSanh";
            this.grpThongTinLoaiSanh.Size = new System.Drawing.Size(213, 216);
            this.grpThongTinLoaiSanh.TabIndex = 38;
            this.grpThongTinLoaiSanh.TabStop = false;
            this.grpThongTinLoaiSanh.Text = "Thông tin loại sảnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(148, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Arial", 9.2F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(7, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Các mục (*) không được để trống.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(103, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "*";
            // 
            // txtDonGiaBanTT
            // 
            this.txtDonGiaBanTT.Location = new System.Drawing.Point(10, 106);
            this.txtDonGiaBanTT.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGiaBanTT.MaxLength = 18;
            this.txtDonGiaBanTT.Name = "txtDonGiaBanTT";
            this.txtDonGiaBanTT.Size = new System.Drawing.Size(196, 23);
            this.txtDonGiaBanTT.TabIndex = 1;
            // 
            // txtTenLoaiSanh
            // 
            this.txtTenLoaiSanh.Location = new System.Drawing.Point(10, 50);
            this.txtTenLoaiSanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLoaiSanh.MaxLength = 100;
            this.txtTenLoaiSanh.Name = "txtTenLoaiSanh";
            this.txtTenLoaiSanh.Size = new System.Drawing.Size(197, 23);
            this.txtTenLoaiSanh.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(41, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "     Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(41, 67);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // grpTinhNangQuanLy
            // 
            this.grpTinhNangQuanLy.Controls.Add(this.btnThem);
            this.grpTinhNangQuanLy.Controls.Add(this.btnSua);
            this.grpTinhNangQuanLy.Controls.Add(this.btnXoa);
            this.grpTinhNangQuanLy.Location = new System.Drawing.Point(219, 3);
            this.grpTinhNangQuanLy.Name = "grpTinhNangQuanLy";
            this.grpTinhNangQuanLy.Size = new System.Drawing.Size(181, 215);
            this.grpTinhNangQuanLy.TabIndex = 39;
            this.grpTinhNangQuanLy.TabStop = false;
            this.grpTinhNangQuanLy.Text = "Tính năng quản lý";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(41, 103);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // grpDanhSachLoaiSanh
            // 
            this.grpDanhSachLoaiSanh.Controls.Add(this.dgvQuanLyLoaiSanh);
            this.grpDanhSachLoaiSanh.Location = new System.Drawing.Point(0, 224);
            this.grpDanhSachLoaiSanh.Name = "grpDanhSachLoaiSanh";
            this.grpDanhSachLoaiSanh.Size = new System.Drawing.Size(400, 176);
            this.grpDanhSachLoaiSanh.TabIndex = 40;
            this.grpDanhSachLoaiSanh.TabStop = false;
            this.grpDanhSachLoaiSanh.Text = "Danh sách các loại sảnh";
            // 
            // frmQuanLyLoaiSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 404);
            this.Controls.Add(this.grpThongTinLoaiSanh);
            this.Controls.Add(this.grpTinhNangQuanLy);
            this.Controls.Add(this.grpDanhSachLoaiSanh);
            this.Name = "frmQuanLyLoaiSanh";
            this.Text = "Quản lý loại sảnh";
            this.Load += new System.EventHandler(this.frmQuanLyLoaiSanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyLoaiSanh)).EndInit();
            this.grpThongTinLoaiSanh.ResumeLayout(false);
            this.grpThongTinLoaiSanh.PerformLayout();
            this.grpTinhNangQuanLy.ResumeLayout(false);
            this.grpDanhSachLoaiSanh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDonGiaBanToiThieu;
        private System.Windows.Forms.Label lblMaLoaiSanh;
        private System.Windows.Forms.DataGridView dgvQuanLyLoaiSanh;
        private System.Windows.Forms.GroupBox grpThongTinLoaiSanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonGiaBanTT;
        private System.Windows.Forms.TextBox txtTenLoaiSanh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox grpTinhNangQuanLy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox grpDanhSachLoaiSanh;
    }
}