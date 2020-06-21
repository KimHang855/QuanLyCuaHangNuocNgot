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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNgayBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.lbNgayBan = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtSLTon = new System.Windows.Forms.TextBox();
            this.lbDVT = new System.Windows.Forms.Label();
            this.lbSLTon = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nuocNgotStore_3DataSet = new QuanLyCuaHangNuocNgot.NuocNgotStore_3DataSet();
            this.nuocNgotStore3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuocNgotStore_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuocNgotStore3DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
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
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(624, 33);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 44);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(746, 33);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 44);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(493, 33);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 44);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(371, 33);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 44);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(249, 33);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 44);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(127, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNgayBan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbGia);
            this.panel2.Controls.Add(this.txtNgay);
            this.panel2.Controls.Add(this.lbNgayBan);
            this.panel2.Controls.Add(this.txtDVT);
            this.panel2.Controls.Add(this.txtSLTon);
            this.panel2.Controls.Add(this.lbDVT);
            this.panel2.Controls.Add(this.lbSLTon);
            this.panel2.Controls.Add(this.txtGiaBan);
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
            // txtNgayBan
            // 
            this.txtNgayBan.Location = new System.Drawing.Point(794, 60);
            this.txtNgayBan.Name = "txtNgayBan";
            this.txtNgayBan.Size = new System.Drawing.Size(169, 22);
            this.txtNgayBan.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Ngày Bán";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(106, 146);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(30, 17);
            this.lbGia.TabIndex = 58;
            this.lbGia.Text = "Giá";
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(490, 150);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(163, 22);
            this.txtNgay.TabIndex = 57;
            // 
            // lbNgayBan
            // 
            this.lbNgayBan.AutoSize = true;
            this.lbNgayBan.Location = new System.Drawing.Point(409, 150);
            this.lbNgayBan.Name = "lbNgayBan";
            this.lbNgayBan.Size = new System.Drawing.Size(79, 17);
            this.lbNgayBan.TabIndex = 56;
            this.lbNgayBan.Text = "Ngày Nhập";
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(490, 107);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(163, 22);
            this.txtDVT.TabIndex = 55;
            // 
            // txtSLTon
            // 
            this.txtSLTon.Location = new System.Drawing.Point(490, 65);
            this.txtSLTon.Name = "txtSLTon";
            this.txtSLTon.Size = new System.Drawing.Size(163, 22);
            this.txtSLTon.TabIndex = 53;
            // 
            // lbDVT
            // 
            this.lbDVT.AutoSize = true;
            this.lbDVT.Location = new System.Drawing.Point(409, 107);
            this.lbDVT.Name = "lbDVT";
            this.lbDVT.Size = new System.Drawing.Size(82, 17);
            this.lbDVT.TabIndex = 52;
            this.lbDVT.Text = "Đơn Vị Tính";
            // 
            // lbSLTon
            // 
            this.lbSLTon.AutoSize = true;
            this.lbSLTon.Location = new System.Drawing.Point(357, 63);
            this.lbSLTon.Name = "lbSLTon";
            this.lbSLTon.Size = new System.Drawing.Size(127, 17);
            this.lbSLTon.TabIndex = 50;
            this.lbSLTon.Text = "Số Lượng Tồn Kho";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(144, 141);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(138, 22);
            this.txtGiaBan.TabIndex = 49;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(144, 98);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(138, 22);
            this.txtTenSP.TabIndex = 48;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(144, 58);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(138, 22);
            this.txtMaSP.TabIndex = 47;
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Location = new System.Drawing.Point(36, 103);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(102, 17);
            this.lbTenSP.TabIndex = 46;
            this.lbTenSP.Text = "Tên Sản Phẩm";
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Location = new System.Drawing.Point(40, 61);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(96, 17);
            this.lbMaSP.TabIndex = 45;
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
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // nuocNgotStore_3DataSet
            // 
            this.nuocNgotStore_3DataSet.DataSetName = "NuocNgotStore_3DataSet";
            this.nuocNgotStore_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nuocNgotStore3DataSetBindingSource
            // 
            this.nuocNgotStore3DataSetBindingSource.DataSource = this.nuocNgotStore_3DataSet;
            this.nuocNgotStore3DataSetBindingSource.Position = 0;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản Phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSanPham_FormClosing);
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuocNgotStore_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuocNgotStore3DataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.Label lbNgayBan;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtSLTon;
        private System.Windows.Forms.Label lbDVT;
        private System.Windows.Forms.Label lbSLTon;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.Label lbGia;
        private NuocNgotStore_3DataSet nuocNgotStore_3DataSet;
        private System.Windows.Forms.BindingSource nuocNgotStore3DataSetBindingSource;
        private System.Windows.Forms.TextBox txtNgayBan;
        private System.Windows.Forms.Label label2;
    }
}