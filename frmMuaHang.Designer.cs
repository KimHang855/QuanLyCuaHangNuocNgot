﻿namespace QuanLyCuaHangNuocNgot
{
    partial class frmMuaHang
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
            this.txtSLTon = new System.Windows.Forms.TextBox();
            this.lbSLTon = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtGC = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSLMua = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lbGC = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbSLMua = new System.Windows.Forms.Label();
            this.lbTenNCC = new System.Windows.Forms.Label();
            this.lbMaNCC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSLTon
            // 
            this.txtSLTon.Location = new System.Drawing.Point(605, 53);
            this.txtSLTon.Name = "txtSLTon";
            this.txtSLTon.ReadOnly = true;
            this.txtSLTon.Size = new System.Drawing.Size(100, 22);
            this.txtSLTon.TabIndex = 53;
            // 
            // lbSLTon
            // 
            this.lbSLTon.AutoSize = true;
            this.lbSLTon.Location = new System.Drawing.Point(475, 56);
            this.lbSLTon.Name = "lbSLTon";
            this.lbSLTon.Size = new System.Drawing.Size(88, 17);
            this.lbSLTon.TabIndex = 52;
            this.lbSLTon.Text = "Số lượng tồn";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dgvSanPham.Location = new System.Drawing.Point(450, 226);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(424, 246);
            this.dgvSanPham.TabIndex = 51;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Location = new System.Drawing.Point(607, 163);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(104, 22);
            this.txtThanhToan.TabIndex = 49;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(478, 157);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(101, 35);
            this.btnThanhToan.TabIndex = 48;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(607, 103);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(104, 22);
            this.txtTong.TabIndex = 46;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(478, 94);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(101, 36);
            this.btnTong.TabIndex = 45;
            this.btnTong.Text = "Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(760, 56);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 38);
            this.btnSua.TabIndex = 42;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvNCC
            // 
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvNCC.Location = new System.Drawing.Point(29, 226);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowTemplate.Height = 24;
            this.dgvNCC.Size = new System.Drawing.Size(388, 246);
            this.dgvNCC.TabIndex = 40;
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // txtGC
            // 
            this.txtGC.Location = new System.Drawing.Point(328, 152);
            this.txtGC.Name = "txtGC";
            this.txtGC.Size = new System.Drawing.Size(100, 22);
            this.txtGC.TabIndex = 39;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(328, 95);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(100, 22);
            this.txtDiaChi.TabIndex = 38;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(328, 55);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(100, 22);
            this.txtGia.TabIndex = 37;
            // 
            // txtSLMua
            // 
            this.txtSLMua.Location = new System.Drawing.Point(127, 152);
            this.txtSLMua.Name = "txtSLMua";
            this.txtSLMua.Size = new System.Drawing.Size(100, 22);
            this.txtSLMua.TabIndex = 36;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(127, 105);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.ReadOnly = true;
            this.txtTenNCC.Size = new System.Drawing.Size(100, 22);
            this.txtTenNCC.TabIndex = 35;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(127, 51);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.ReadOnly = true;
            this.txtMaNCC.Size = new System.Drawing.Size(100, 22);
            this.txtMaNCC.TabIndex = 34;
            // 
            // lbGC
            // 
            this.lbGC.AutoSize = true;
            this.lbGC.Location = new System.Drawing.Point(259, 152);
            this.lbGC.Name = "lbGC";
            this.lbGC.Size = new System.Drawing.Size(57, 17);
            this.lbGC.TabIndex = 33;
            this.lbGC.Text = "Ghi chú";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(259, 106);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(51, 17);
            this.lbDiaChi.TabIndex = 32;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(259, 53);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(30, 17);
            this.lbGia.TabIndex = 31;
            this.lbGia.Text = "Giá";
            // 
            // lbSLMua
            // 
            this.lbSLMua.AutoSize = true;
            this.lbSLMua.Location = new System.Drawing.Point(26, 157);
            this.lbSLMua.Name = "lbSLMua";
            this.lbSLMua.Size = new System.Drawing.Size(95, 17);
            this.lbSLMua.TabIndex = 30;
            this.lbSLMua.Text = "Số lượng mua";
            // 
            // lbTenNCC
            // 
            this.lbTenNCC.AutoSize = true;
            this.lbTenNCC.Location = new System.Drawing.Point(26, 108);
            this.lbTenNCC.Name = "lbTenNCC";
            this.lbTenNCC.Size = new System.Drawing.Size(65, 17);
            this.lbTenNCC.TabIndex = 29;
            this.lbTenNCC.Text = "Tên NCC";
            // 
            // lbMaNCC
            // 
            this.lbMaNCC.AutoSize = true;
            this.lbMaNCC.Location = new System.Drawing.Point(26, 58);
            this.lbMaNCC.Name = "lbMaNCC";
            this.lbMaNCC.Size = new System.Drawing.Size(59, 17);
            this.lbMaNCC.TabIndex = 28;
            this.lbMaNCC.Text = "Mã NCC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 39);
            this.label1.TabIndex = 27;
            this.label1.Text = "MUA HÀNG";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(760, 126);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 48);
            this.btnDong.TabIndex = 54;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 484);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.txtSLTon);
            this.Controls.Add(this.lbSLTon);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.txtThanhToan);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvNCC);
            this.Controls.Add(this.txtGC);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtSLMua);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.lbGC);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbSLMua);
            this.Controls.Add(this.lbTenNCC);
            this.Controls.Add(this.lbMaNCC);
            this.Controls.Add(this.label1);
            this.Name = "frmMuaHang";
            this.Text = "frmMuaHang";
            this.Load += new System.EventHandler(this.frmMuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSLTon;
        private System.Windows.Forms.Label lbSLTon;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.TextBox txtGC;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSLMua;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label lbGC;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbSLMua;
        private System.Windows.Forms.Label lbTenNCC;
        private System.Windows.Forms.Label lbMaNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDong;
    }
}