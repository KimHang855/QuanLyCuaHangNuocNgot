namespace QuanLyCuaHangNuocNgot
{
    partial class frmSanPham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.lbNgayBan = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtSLBan = new System.Windows.Forms.TextBox();
            this.txtSLTon = new System.Windows.Forms.TextBox();
            this.lbDVT = new System.Windows.Forms.Label();
            this.lbSLBan = new System.Windows.Forms.Label();
            this.lbSLTon = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.lbGiaBan = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.btnTongTien = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 499);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(693, 34);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 44);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(571, 34);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 44);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(449, 34);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 44);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(327, 34);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 44);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(205, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtThanhToan);
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.btnTongTien);
            this.panel2.Controls.Add(this.txtNgay);
            this.panel2.Controls.Add(this.lbNgayBan);
            this.panel2.Controls.Add(this.txtDVT);
            this.panel2.Controls.Add(this.txtSLBan);
            this.panel2.Controls.Add(this.txtSLTon);
            this.panel2.Controls.Add(this.lbDVT);
            this.panel2.Controls.Add(this.lbSLBan);
            this.panel2.Controls.Add(this.lbSLTon);
            this.panel2.Controls.Add(this.txtGiaBan);
            this.panel2.Controls.Add(this.lbGiaBan);
            this.panel2.Controls.Add(this.txtTenSP);
            this.panel2.Controls.Add(this.txtMaSP);
            this.panel2.Controls.Add(this.lbTenSP);
            this.panel2.Controls.Add(this.lbMaSP);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 197);
            this.panel2.TabIndex = 1;
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(745, 61);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.ReadOnly = true;
            this.txtNgay.Size = new System.Drawing.Size(163, 22);
            this.txtNgay.TabIndex = 22;
            // 
            // lbNgayBan
            // 
            this.lbNgayBan.AutoSize = true;
            this.lbNgayBan.Location = new System.Drawing.Point(638, 61);
            this.lbNgayBan.Name = "lbNgayBan";
            this.lbNgayBan.Size = new System.Drawing.Size(70, 17);
            this.lbNgayBan.TabIndex = 19;
            this.lbNgayBan.Text = "Ngày Bán";
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(449, 139);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.ReadOnly = true;
            this.txtDVT.Size = new System.Drawing.Size(130, 22);
            this.txtDVT.TabIndex = 15;
            // 
            // txtSLBan
            // 
            this.txtSLBan.Location = new System.Drawing.Point(449, 98);
            this.txtSLBan.Name = "txtSLBan";
            this.txtSLBan.Size = new System.Drawing.Size(130, 22);
            this.txtSLBan.TabIndex = 14;
            // 
            // txtSLTon
            // 
            this.txtSLTon.Location = new System.Drawing.Point(449, 58);
            this.txtSLTon.Name = "txtSLTon";
            this.txtSLTon.ReadOnly = true;
            this.txtSLTon.Size = new System.Drawing.Size(130, 22);
            this.txtSLTon.TabIndex = 13;
            // 
            // lbDVT
            // 
            this.lbDVT.AutoSize = true;
            this.lbDVT.Location = new System.Drawing.Point(306, 142);
            this.lbDVT.Name = "lbDVT";
            this.lbDVT.Size = new System.Drawing.Size(75, 17);
            this.lbDVT.TabIndex = 9;
            this.lbDVT.Text = "Đơn vị tính";
            // 
            // lbSLBan
            // 
            this.lbSLBan.AutoSize = true;
            this.lbSLBan.Location = new System.Drawing.Point(304, 101);
            this.lbSLBan.Name = "lbSLBan";
            this.lbSLBan.Size = new System.Drawing.Size(98, 17);
            this.lbSLBan.TabIndex = 8;
            this.lbSLBan.Text = "Số Lượng Bán";
            // 
            // lbSLTon
            // 
            this.lbSLTon.AutoSize = true;
            this.lbSLTon.Location = new System.Drawing.Point(304, 58);
            this.lbSLTon.Name = "lbSLTon";
            this.lbSLTon.Size = new System.Drawing.Size(127, 17);
            this.lbSLTon.TabIndex = 7;
            this.lbSLTon.Text = "Số Lượng Tồn Kho";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(116, 141);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.ReadOnly = true;
            this.txtGiaBan.Size = new System.Drawing.Size(138, 22);
            this.txtGiaBan.TabIndex = 6;
            // 
            // lbGiaBan
            // 
            this.lbGiaBan.AutoSize = true;
            this.lbGiaBan.Location = new System.Drawing.Point(12, 144);
            this.lbGiaBan.Name = "lbGiaBan";
            this.lbGiaBan.Size = new System.Drawing.Size(59, 17);
            this.lbGiaBan.TabIndex = 5;
            this.lbGiaBan.Text = "Giá Bán";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(116, 98);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(138, 22);
            this.txtTenSP.TabIndex = 4;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(116, 58);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(138, 22);
            this.txtMaSP.TabIndex = 3;
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Location = new System.Drawing.Point(8, 103);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(102, 17);
            this.lbTenSP.TabIndex = 2;
            this.lbTenSP.Text = "Tên Sản Phẩm";
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Location = new System.Drawing.Point(12, 61);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(96, 17);
            this.lbMaSP.TabIndex = 1;
            this.lbMaSP.Text = "Mã Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(388, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "SẢN PHẨM";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 197);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(1000, 302);
            this.dgvSanPham.TabIndex = 2;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // btnTongTien
            // 
            this.btnTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTongTien.Location = new System.Drawing.Point(626, 103);
            this.btnTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.btnTongTien.Name = "btnTongTien";
            this.btnTongTien.Size = new System.Drawing.Size(107, 29);
            this.btnTongTien.TabIndex = 23;
            this.btnTongTien.Text = "Tổng tiền";
            this.btnTongTien.UseVisualStyleBackColor = true;
            this.btnTongTien.Click += new System.EventHandler(this.btnTongTien_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(745, 107);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(163, 22);
            this.txtTongTien.TabIndex = 24;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThanhToan.Location = new System.Drawing.Point(626, 149);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(107, 32);
            this.btnThanhToan.TabIndex = 25;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Location = new System.Drawing.Point(745, 155);
            this.txtThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.ReadOnly = true;
            this.txtThanhToan.Size = new System.Drawing.Size(163, 22);
            this.txtThanhToan.TabIndex = 26;
            this.txtThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 599);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSanPham";
            this.Text = "Sản Phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSanPham_FormClosing);
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label lbNgayBan;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtSLBan;
        private System.Windows.Forms.TextBox txtSLTon;
        private System.Windows.Forms.Label lbDVT;
        private System.Windows.Forms.Label lbSLBan;
        private System.Windows.Forms.Label lbSLTon;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label lbGiaBan;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnTongTien;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}