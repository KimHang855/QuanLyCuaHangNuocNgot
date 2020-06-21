namespace QuanLyCuaHangNuocNgot
{
    partial class frmNCC
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbMaNCC = new System.Windows.Forms.Label();
            this.lbTenNCC = new System.Windows.Forms.Label();
            this.lbSLMua = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbGC = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtSLMua = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtGC = new System.Windows.Forms.TextBox();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.btnTong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÀ CUNG CẤP";
            // 
            // lbMaNCC
            // 
            this.lbMaNCC.AutoSize = true;
            this.lbMaNCC.Location = new System.Drawing.Point(24, 68);
            this.lbMaNCC.Name = "lbMaNCC";
            this.lbMaNCC.Size = new System.Drawing.Size(59, 17);
            this.lbMaNCC.TabIndex = 1;
            this.lbMaNCC.Text = "Mã NCC";
            // 
            // lbTenNCC
            // 
            this.lbTenNCC.AutoSize = true;
            this.lbTenNCC.Location = new System.Drawing.Point(18, 121);
            this.lbTenNCC.Name = "lbTenNCC";
            this.lbTenNCC.Size = new System.Drawing.Size(65, 17);
            this.lbTenNCC.TabIndex = 2;
            this.lbTenNCC.Text = "Tên NCC";
            // 
            // lbSLMua
            // 
            this.lbSLMua.AutoSize = true;
            this.lbSLMua.Location = new System.Drawing.Point(213, 71);
            this.lbSLMua.Name = "lbSLMua";
            this.lbSLMua.Size = new System.Drawing.Size(95, 17);
            this.lbSLMua.TabIndex = 3;
            this.lbSLMua.Text = "Số lượng mua";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(278, 121);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(30, 17);
            this.lbGia.TabIndex = 4;
            this.lbGia.Text = "Giá";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(448, 71);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(51, 17);
            this.lbDiaChi.TabIndex = 5;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // lbGC
            // 
            this.lbGC.AutoSize = true;
            this.lbGC.Location = new System.Drawing.Point(442, 122);
            this.lbGC.Name = "lbGC";
            this.lbGC.Size = new System.Drawing.Size(57, 17);
            this.lbGC.TabIndex = 6;
            this.lbGC.Text = "Ghi chú";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(89, 66);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(100, 22);
            this.txtMaNCC.TabIndex = 7;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(89, 119);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(100, 22);
            this.txtTenNCC.TabIndex = 8;
            // 
            // txtSLMua
            // 
            this.txtSLMua.Location = new System.Drawing.Point(314, 68);
            this.txtSLMua.Name = "txtSLMua";
            this.txtSLMua.Size = new System.Drawing.Size(100, 22);
            this.txtSLMua.TabIndex = 9;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(314, 118);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 22);
            this.txtGia.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(505, 68);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 22);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtGC
            // 
            this.txtGC.Location = new System.Drawing.Point(505, 119);
            this.txtGC.Name = "txtGC";
            this.txtGC.Size = new System.Drawing.Size(100, 22);
            this.txtGC.TabIndex = 12;
            // 
            // dgvNCC
            // 
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvNCC.Location = new System.Drawing.Point(2, 170);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowTemplate.Height = 24;
            this.dgvNCC.Size = new System.Drawing.Size(872, 264);
            this.dgvNCC.TabIndex = 13;
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(197, 454);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 48);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(339, 454);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 48);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(473, 454);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 48);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(747, 454);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 48);
            this.btnDong.TabIndex = 17;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(51, 454);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 48);
            this.btnTim.TabIndex = 20;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(606, 454);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 48);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Location = new System.Drawing.Point(758, 121);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(104, 22);
            this.txtThanhToan.TabIndex = 53;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(651, 113);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(101, 35);
            this.btnThanhToan.TabIndex = 52;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(758, 61);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(104, 22);
            this.txtTong.TabIndex = 51;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(651, 52);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(101, 36);
            this.btnTong.TabIndex = 50;
            this.btnTong.Text = "Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // frmNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 528);
            this.Controls.Add(this.txtThanhToan);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
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
            this.Name = "frmNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNCC";
            this.Load += new System.EventHandler(this.frmNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaNCC;
        private System.Windows.Forms.Label lbTenNCC;
        private System.Windows.Forms.Label lbSLMua;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbGC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtSLMua;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtGC;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Button btnTong;
    }
}