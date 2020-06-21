﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCuaHangNuocNgot
{
    public partial class frmSanPham : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-H9PGTJJ\SQLEXPRESS;Initial Catalog=NuocNgotStore_3;Integrated Security=True");
        SqlDataAdapter da;

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            cn.Open();
            HienThi();
            cn.Close();
        }
        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            cn.Close();
        }
        public void HienThi()
        {
            string sql = "Select * From SanPham";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            dt.Load(dr);
            //hoặc da.Fill(dt);
            //Đổ kết quả từ câu lệnh sql vào table            
            dgvSanPham.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cn.Open();

            string sqlInsert = "Insert Into SanPham Values(@MaSP,@TenSP,@Gia,@SoLuongTon,@Ngay,@DonVi,@NgayBan)";
            //string sqlInsert = "Insert Into Product values('"+txtMaSP.Text+"','"+txtTenSP.Text+ "','"+txtGiaBan.Text+ "','"+txtSLTon.Text+ "','"+txtSLBan.Text+"','"+txtDVT.Text+ "','"+txtMaLoai.Text+ "','"+txtNCC.Text+ "','"+txtNgayBan.Text+"')";
            SqlCommand cmd = new SqlCommand(sqlInsert, cn);
            cmd.Parameters.AddWithValue("MaSP", txtMaSP.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("Gia", txtGiaBan.Text);
            cmd.Parameters.AddWithValue("SoLuongTon", txtSLTon.Text);
            cmd.Parameters.AddWithValue("Ngay", txtNgay.Text);
            cmd.Parameters.AddWithValue("DonVi", txtDVT.Text);
            cmd.Parameters.AddWithValue("NgayBan", txtNgayBan.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm sản phẩm thành công");
            HienThi();
            ResetValues();
            cn.Close();
        }

        private void ResetValues()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaBan.Text = "";
            txtSLTon.Text = "";
            txtDVT.Text = "";
            txtNgay.Text = "";
            txtNgayBan.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cn.Open();
            string sqlCapNhat = "Update SanPham Set TenSP=@TenSP, Gia=@Gia, SoLuongTon=@SoLuongTon, Ngay=@Ngay, NgayBan=@NgayBan, DonVi=@DonVi Where MaSP=@MaSP ";
            SqlCommand cmd = new SqlCommand(sqlCapNhat, cn);
            cmd.Parameters.AddWithValue("MaSP", txtMaSP.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("Gia", txtGiaBan.Text);
            cmd.Parameters.AddWithValue("SoLuongTon", txtSLTon.Text);
            cmd.Parameters.AddWithValue("Ngay", txtNgayBan.Text);
            cmd.Parameters.AddWithValue("NgayBan", txtNgayBan.Text);
            cmd.Parameters.AddWithValue("DonVi", txtDVT.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thông tin sản phẩm thành công");
            HienThi();
            //ResetValues();
            cn.Close();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cn.Open();
            string sqlDelete = "Delete From SanPham Where MaSP = @MaSP";
            SqlCommand cmd = new SqlCommand(sqlDelete, cn);
            cmd.Parameters.AddWithValue("MaSP", txtMaSP.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("Gia", txtGiaBan.Text);
            cmd.Parameters.AddWithValue("SoLuongTon", txtSLTon.Text);
            cmd.Parameters.AddWithValue("Ngay", txtNgay.Text);
            cmd.Parameters.AddWithValue("DonVi", txtDVT.Text);
            cmd.Parameters.AddWithValue("NgayBan", txtNgayBan.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa sản phẩm thành công");
            HienThi();
            ResetValues();
            cn.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            cn.Open();
            string sqlSearch = "Select * From SanPham Where TenSP =@TenSP or MaSP=@MaSP ";
            SqlCommand cmd = new SqlCommand(sqlSearch, cn);
            cmd.Parameters.AddWithValue("MaSP", txtMaSP.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("Gia", txtGiaBan.Text);
            cmd.Parameters.AddWithValue("SoLuongTon", txtSLTon.Text);
            cmd.Parameters.AddWithValue("Ngay", txtNgay.Text);
            cmd.Parameters.AddWithValue("DonVi", txtDVT.Text);
            cmd.Parameters.AddWithValue("NgayBan", txtNgayBan.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvSanPham.DataSource = dt;
            cn.Close();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //hiện thị dl trong dgv lên textbox
            int index = dgvSanPham.CurrentCell.RowIndex;
            txtMaSP.Text = dgvSanPham.Rows[index].Cells["MaSP"].Value.ToString();
            txtTenSP.Text = dgvSanPham.Rows[index].Cells["TenSP"].Value.ToString();
            txtGiaBan.Text = dgvSanPham.Rows[index].Cells["Gia"].Value.ToString();
            txtDVT.Text = dgvSanPham.Rows[index].Cells["DonVi"].Value.ToString();
            txtSLTon.Text = dgvSanPham.Rows[index].Cells["SoLuongTon"].Value.ToString();
            txtNgay.Text = dgvSanPham.Rows[index].Cells["Ngay"].Value.ToString();
            txtNgayBan.Text = dgvSanPham.Rows[index].Cells["NgayBan"].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = null;
            txtTenSP.Text = null;
            txtDVT.Text = null;
            txtGiaBan.Text = null;
            txtSLTon.Text = null;
            txtNgayBan.Text = null;
        }
    }
}
