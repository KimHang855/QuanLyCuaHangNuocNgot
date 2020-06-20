using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangNuocNgot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham frmSanPham = new frmSanPham(); //Khởi tạo đối tượng
            frmSanPham.ShowDialog(); //Hiển thị
        }       

        private void mnuNCC_Click(object sender, EventArgs e)
        {
            frmNCC frmNCC = new frmNCC();
            frmNCC.ShowDialog();
        }

        private void mnuDT_Click(object sender, EventArgs e)
        {
            frmDThu frmDThu = new frmDThu();
            frmDThu.ShowDialog();
        }

        private void mnuThoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void mnuBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang frmBanHang = new frmBanHang();
            frmBanHang.ShowDialog();
        }
    }
}
