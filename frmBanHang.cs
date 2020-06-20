using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangNuocNgot
{
    public partial class frmBanHang : Form
    {
        SqlConnection connnection = new SqlConnection(@"Data Source=DESKTOP-H9PGTJJ\SQLEXPRESS;Initial Catalog=NuocNgotStore_3;Integrated Security=True");
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void btnTongTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSLBan.Text))
                MessageBox.Show("Vui lòng nhập số lượng bán");
            else
            {
                int Gia = Int32.Parse(txtGiaBan.Text);
                int SoLuongBan = Int32.Parse(txtSLBan.Text);
                txtTongTien.Text = (Gia * SoLuongBan).ToString();
                int a;
                bool d = Int32.TryParse(txtThanhToan.Text, out a);
                a += Int32.Parse(txtTongTien.Text);
                txtThanhToan.Text = (a).ToString();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult kq3 = MessageBox.Show("Giá trị của đơn hàng này là " + txtThanhToan.Text + "", "Thông báo", MessageBoxButtons.YesNo);
            if (kq3 == DialogResult.Yes)
            {
                MessageBox.Show("Hóa đơn đã được thanh toán thành công");
                Application.Exit();
            }
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            connnection.Open();
            HienThi();
            connnection.Close();
        }
        public void HienThi()
        {
            string sqlSelect = "Select * From SanPham";
            SqlCommand cmd = new SqlCommand(sqlSelect, connnection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvBanHang.DataSource = dt;
        }

        private void dgvBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //hiện thị dl trong dgv lên textbox
            int index = dgvBanHang.CurrentCell.RowIndex;
            txtMaSP.Text = dgvBanHang.Rows[index].Cells["MaSP"].Value.ToString();
            txtTenSP.Text = dgvBanHang.Rows[index].Cells["TenSP"].Value.ToString();
            txtGiaBan.Text = dgvBanHang.Rows[index].Cells["Gia"].Value.ToString();
            txtDVT.Text = dgvBanHang.Rows[index].Cells["DonVi"].Value.ToString();
            txtSLTon.Text = dgvBanHang.Rows[index].Cells["SoLuongTon"].Value.ToString();
            txtNgayBan.Text = dgvBanHang.Rows[index].Cells["Ngay"].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {           
            connnection.Open();
            //bán sản phẩm cập nhật lại số lượng tồn
            int SoLuongTon = Int32.Parse(txtSLTon.Text);
            int SoLuongBan = Int32.Parse(txtSLBan.Text);
            txtSLTon.Text = (SoLuongTon - SoLuongBan).ToString();

            //Sửa, cập nhật ngày
            string sqlCapNhat = "Update SanPham Set TenSP=@TenSP, Gia=@Gia, SoLuongTon=@SoLuongTon, Ngay=@Ngay, NgayBan=@NgayBan, DonVi=@DonVi Where MaSP=@MaSP ";
            SqlCommand cmd = new SqlCommand(sqlCapNhat, connnection);
            cmd.Parameters.AddWithValue("MaSP", txtMaSP.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("Gia", txtGiaBan.Text);
            cmd.Parameters.AddWithValue("SoLuongTon", txtSLTon.Text);
            cmd.Parameters.AddWithValue("Ngay", txtNgayBan.Text);
            cmd.Parameters.AddWithValue("NgayBan", txtNgayBan.Text);
            cmd.Parameters.AddWithValue("DonVi", txtDVT.Text);
            cmd.ExecuteNonQuery();                    
            MessageBox.Show("Cập nhật thành công");
            HienThi();            
            connnection.Close();
        }
    }
}
