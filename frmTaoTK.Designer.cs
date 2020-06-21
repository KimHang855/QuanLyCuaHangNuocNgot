namespace QuanLyCuaHangNuocNgot
{
    partial class frmTaoTK
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
            this.lbTaoTK = new System.Windows.Forms.Label();
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.btHuy = new System.Windows.Forms.Button();
            this.btTao = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTaoTK
            // 
            this.lbTaoTK.AutoSize = true;
            this.lbTaoTK.BackColor = System.Drawing.SystemColors.Control;
            this.lbTaoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbTaoTK.ForeColor = System.Drawing.Color.Red;
            this.lbTaoTK.Location = new System.Drawing.Point(177, 27);
            this.lbTaoTK.Name = "lbTaoTK";
            this.lbTaoTK.Size = new System.Drawing.Size(218, 29);
            this.lbTaoTK.TabIndex = 7;
            this.lbTaoTK.Text = "TẠO TÀI KHOẢN";
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTenDangNhap.Location = new System.Drawing.Point(29, 110);
            this.lbTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(119, 20);
            this.lbTenDangNhap.TabIndex = 8;
            this.lbTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTenDangNhap.Location = new System.Drawing.Point(182, 109);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(222, 23);
            this.txtTenDangNhap.TabIndex = 9;
            // 
            // btHuy
            // 
            this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btHuy.Location = new System.Drawing.Point(309, 233);
            this.btHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(95, 55);
            this.btHuy.TabIndex = 14;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btTao
            // 
            this.btTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btTao.Location = new System.Drawing.Point(162, 233);
            this.btTao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTao.Name = "btTao";
            this.btTao.Size = new System.Drawing.Size(97, 55);
            this.btTao.TabIndex = 13;
            this.btTao.Text = "Tạo ";
            this.btTao.UseVisualStyleBackColor = true;
            this.btTao.Click += new System.EventHandler(this.btTao_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtMatKhau.Location = new System.Drawing.Point(182, 167);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(222, 23);
            this.txtMatKhau.TabIndex = 11;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMatKhau.Location = new System.Drawing.Point(62, 170);
            this.lbMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(77, 20);
            this.lbMatKhau.TabIndex = 10;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // frmTaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 346);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btTao);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lbTenDangNhap);
            this.Controls.Add(this.lbTaoTK);
            this.Name = "frmTaoTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTaoTK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTaoTK;
        private System.Windows.Forms.Label lbTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btTao;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lbMatKhau;
    }
}