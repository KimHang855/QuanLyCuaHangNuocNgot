namespace QuanLyCuaHangNuocNgot
{
    partial class frmDThu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.lbDT = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.lbNgay = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDThu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDThu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTong);
            this.groupBox1.Controls.Add(this.txtDT);
            this.groupBox1.Controls.Add(this.lbDT);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(this.lbNgay);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập ngày";
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(381, 82);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(144, 42);
            this.btnTong.TabIndex = 5;
            this.btnTong.Text = "Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(127, 82);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(200, 22);
            this.txtDT.TabIndex = 4;
            // 
            // lbDT
            // 
            this.lbDT.AutoSize = true;
            this.lbDT.Location = new System.Drawing.Point(38, 85);
            this.lbDT.Name = "lbDT";
            this.lbDT.Size = new System.Drawing.Size(41, 17);
            this.lbDT.TabIndex = 3;
            this.lbDT.Text = "Tổng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(381, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(144, 42);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(127, 33);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpNgay.TabIndex = 1;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Location = new System.Drawing.Point(38, 38);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(41, 17);
            this.lbNgay.TabIndex = 0;
            this.lbNgay.Text = "Ngày";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDThu);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 330);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả báo cáo";
            // 
            // dgvDThu
            // 
            this.dgvDThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDThu.Location = new System.Drawing.Point(3, 18);
            this.dgvDThu.Name = "dgvDThu";
            this.dgvDThu.RowTemplate.Height = 24;
            this.dgvDThu.Size = new System.Drawing.Size(672, 309);
            this.dgvDThu.TabIndex = 0;
            // 
            // frmDThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDThu";
            this.Text = "frmDThu";
            this.Load += new System.EventHandler(this.frmDThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label lbDT;
        private System.Windows.Forms.DataGridView dgvDThu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTong;
    }
}