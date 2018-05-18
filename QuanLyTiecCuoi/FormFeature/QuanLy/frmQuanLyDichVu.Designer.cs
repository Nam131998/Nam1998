namespace QuanLyTiecCuoiUI
{
    partial class frmQuanLyDichVu
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
            this.btMaDichVu = new System.Windows.Forms.Button();
            this.btTenDichVu = new System.Windows.Forms.Button();
            this.btDonGia = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnhaplai = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenDichVu = new System.Windows.Forms.TextBox();
            this.txtMaDichVu = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgdanhsachdichvu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdanhsachdichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // btMaDichVu
            // 
            this.btMaDichVu.Location = new System.Drawing.Point(6, 41);
            this.btMaDichVu.Name = "btMaDichVu";
            this.btMaDichVu.Size = new System.Drawing.Size(75, 23);
            this.btMaDichVu.TabIndex = 0;
            this.btMaDichVu.Text = "Mã Dịch Vụ";
            this.btMaDichVu.UseVisualStyleBackColor = true;
            // 
            // btTenDichVu
            // 
            this.btTenDichVu.Location = new System.Drawing.Point(6, 91);
            this.btTenDichVu.Name = "btTenDichVu";
            this.btTenDichVu.Size = new System.Drawing.Size(75, 23);
            this.btTenDichVu.TabIndex = 1;
            this.btTenDichVu.Text = "Tên Dịch Vụ";
            this.btTenDichVu.UseVisualStyleBackColor = true;
            // 
            // btDonGia
            // 
            this.btDonGia.Location = new System.Drawing.Point(6, 138);
            this.btDonGia.Name = "btDonGia";
            this.btDonGia.Size = new System.Drawing.Size(75, 23);
            this.btDonGia.TabIndex = 2;
            this.btDonGia.Text = "Đơn Giá";
            this.btDonGia.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtTenDichVu);
            this.groupBox1.Controls.Add(this.txtMaDichVu);
            this.groupBox1.Controls.Add(this.btMaDichVu);
            this.groupBox1.Controls.Add(this.btDonGia);
            this.groupBox1.Controls.Add(this.btTenDichVu);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnhaplai);
            this.groupBox2.Controls.Add(this.btxoa);
            this.groupBox2.Controls.Add(this.btsua);
            this.groupBox2.Controls.Add(this.btthem);
            this.groupBox2.Location = new System.Drawing.Point(17, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 194);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnhaplai
            // 
            this.btnhaplai.Location = new System.Drawing.Point(17, 154);
            this.btnhaplai.Name = "btnhaplai";
            this.btnhaplai.Size = new System.Drawing.Size(75, 23);
            this.btnhaplai.TabIndex = 3;
            this.btnhaplai.Text = "Nhập Lại";
            this.btnhaplai.UseVisualStyleBackColor = true;
            this.btnhaplai.Click += new System.EventHandler(this.btnhaplai_Click_1);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(17, 115);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 2;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(17, 71);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 1;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click_1);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(17, 31);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 0;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(117, 141);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 5;
            // 
            // txtTenDichVu
            // 
            this.txtTenDichVu.Location = new System.Drawing.Point(117, 93);
            this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.Size = new System.Drawing.Size(100, 20);
            this.txtTenDichVu.TabIndex = 4;
            // 
            // txtMaDichVu
            // 
            this.txtMaDichVu.Location = new System.Drawing.Point(117, 44);
            this.txtMaDichVu.Name = "txtMaDichVu";
            this.txtMaDichVu.Size = new System.Drawing.Size(100, 20);
            this.txtMaDichVu.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgdanhsachdichvu);
            this.groupBox3.Location = new System.Drawing.Point(307, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 417);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dach Sách Dịch Vụ";
            // 
            // dtgdanhsachdichvu
            // 
            this.dtgdanhsachdichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdanhsachdichvu.Location = new System.Drawing.Point(29, 22);
            this.dtgdanhsachdichvu.Name = "dtgdanhsachdichvu";
            this.dtgdanhsachdichvu.Size = new System.Drawing.Size(441, 360);
            this.dtgdanhsachdichvu.TabIndex = 0;
            // 
            // frmQuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLyDichVu";
            this.Text = "frmQuanLyDichVu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdanhsachdichvu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMaDichVu;
        private System.Windows.Forms.Button btTenDichVu;
        private System.Windows.Forms.Button btDonGia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnhaplai;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenDichVu;
        private System.Windows.Forms.TextBox txtMaDichVu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgdanhsachdichvu;
    }
}