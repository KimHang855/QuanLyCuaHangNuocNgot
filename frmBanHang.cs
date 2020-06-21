﻿using System;
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
            if (string.IsNullOrEmpty(txtMaSP.Text))
                MessageBox.Show("Vui lòng chọn sản phẩm trước");
            else
            if (string.IsNullOrEmpty(txtSLBan.Text))
                MessageBox.Show("Vui lòng nhập số lượng bán");

            else
            {
                int b;
                bool o = int.TryParse(txtSLBan.Text, out b);

                if (!o)
                    MessageBox.Show("Vui lòng nhập số lượng là một số");
                else
                {
                    int ban = Int32.Parse(txtSLBan.Text);
                    int ton = Int32.Parse(txtSLTon.Text);
                    if (ban > ton)
                        MessageBox.Show("Số lượng bán không đủ");
                    else
                    {
                        int Gia = Int32.Parse(txtGiaBan.Text);
                        int SoLuongBan = Int32.Parse(txtSLBan.Text);
                        txtTongTien.Text = (Gia * SoLuongBan).ToString();

                        int a;
                        // int b = Int32.Parse(txtTongTien.Text);
                        bool d = Int32.TryParse(txtThanhToan.Text, out a);
                        a += Int32.Parse(txtTongTien.Text);
                        txtThanhToan.Text = (a).ToString();

                    }
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtThanhToan.Text))
                MessageBox.Show("Thông tin hóa đơn rỗng","Thông báo");
            //if (string.IsNullOrEmpty(txtThanhToan.Text))
            //    MessageBox.Show("Vui lòng nhập thông tin đơn hàng");

            else
            {
                DialogResult kq3 = MessageBox.Show("Giá trị của đơn hàng này là " + txtThanhToan.Text + "", "Thông báo", MessageBoxButtons.YesNo);
                if (kq3 == DialogResult.Yes)
                {
                    MessageBox.Show("Hóa đơn đã được thanh toán thành công");
                    connnection.Open();
                    int SoLuongTon = Int32.Parse(txtSLTon.Text);
                    int SoLuongBan = Int32.Parse(txtSLBan.Text);
                    txtSLTon.Text = (SoLuongTon - SoLuongBan).ToString();
                    string sqlCapNhat = "Update SanPham Set TenSP=@TenSP, Gia=@Gia, SoLuongTon=@SoLuongTon, Ngay=@Ngay, DonVi=@DonVi, NgayBan=@NgayBan Where MaSP=@MaSP ";
                    SqlCommand cmd = new SqlCommand(sqlCapNhat, connnection);
                    cmd.Parameters.AddWithValue("MaSP", txtMaSP.Text);
                    cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
                    cmd.Parameters.AddWithValue("Gia", txtGiaBan.Text);
                    cmd.Parameters.AddWithValue("SoLuongTon", txtSLTon.Text);
                    cmd.Parameters.AddWithValue("Ngay", txtNgayBan.Text);
                    cmd.Parameters.AddWithValue("NgayBan", txtNgayBan.Text);
                    cmd.Parameters.AddWithValue("DonVi", txtDVT.Text);
                    cmd.ExecuteNonQuery();
                    HienThi();
                    connnection.Close();
                    //Application.Exit();
                }
            }
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nuocNgotStore_3DataSet1.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.nuocNgotStore_3DataSet1.SanPham);
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

            //Sửa, cập nhật ngày, số lượng tồn
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

        private void button1_Click(object sender, EventArgs e)
        {
            connnection.Open();
            txtMaSP.Text = null;
            txtTenSP.Text = null;
            txtDVT.Text = null;
            txtGiaBan.Text = null;
            txtSLTon.Text = null;
            txtNgayBan.Text = null;
            txtTongTien.Text = null;
            txtThanhToan.Text = null;
            txtSLBan.Text = null;
            HienThi();
            connnection.Close();
        }

        private void txtSLBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        
    }
}
