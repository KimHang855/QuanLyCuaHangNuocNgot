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
    public partial class frmNCC : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-H9PGTJJ\SQLEXPRESS;Initial Catalog=NuocNgotStore_3;Integrated Security=True");
        public frmNCC()
        {
            InitializeComponent();
        }

        public void HienThi()
        {
            
            string sql = "Select * From NCC";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Load(dr);
            //hoặc da.Fill(dt);  //Đổ kết quả từ câu lệnh sql vào table            
            dgvNCC.DataSource = dt;
        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            cn.Open();
            HienThi();
            cn.Close();
        }       

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvNCC.CurrentCell.RowIndex;
            txtMaNCC.Text = dgvNCC.Rows[i].Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNCC.Rows[i].Cells[1].Value.ToString();
            txtSLMua.Text = dgvNCC.Rows[i].Cells[2].Value.ToString();
            txtGia.Text = dgvNCC.Rows[i].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvNCC.Rows[i].Cells[4].Value.ToString();
            txtGC.Text = dgvNCC.Rows[i].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cn.Open();
            string sqlInsert = "Insert Into NCC Values(@MaNCC,@TenNCC,@SoLuongMua,@Gia,@DiaChi,@GhiChu)";
            SqlCommand cmd = new SqlCommand(sqlInsert, cn);
            cmd.Parameters.AddWithValue("MaNCC", txtMaNCC.Text);
            cmd.Parameters.AddWithValue("TenNCC", txtTenNCC.Text);
            cmd.Parameters.AddWithValue("Gia", txtGia.Text);
            cmd.Parameters.AddWithValue("SoLuongMua", txtSLMua.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtGC.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            HienThi();
            ResetValues();
            cn.Close();
        }

        private void ResetValues()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtGia.Text = "";
            txtSLMua.Text = "";
            txtDiaChi.Text = "";
            txtGC.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cn.Open();
            string sqlInsert = "Update NCC Set TenNCC=@TenNCC, Gia=@Gia, SoLuongMua=@SoLuongMua, DiaChi=@DiaChi,GhiChu=@GhiChu Where MaNCC=@MaNCC ";
            SqlCommand cmd = new SqlCommand(sqlInsert, cn);
            cmd.Parameters.AddWithValue("MaNCC", txtMaNCC.Text);
            cmd.Parameters.AddWithValue("TenNCC", txtTenNCC.Text);
            cmd.Parameters.AddWithValue("Gia", txtGia.Text);
            cmd.Parameters.AddWithValue("SoLuongMua", txtSLMua.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtGC.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công");
            HienThi();
            ResetValues();
            cn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cn.Open();
            string sqlDelete = "Delete From NCC Where MaNCC = @MaNCC";
            SqlCommand cmd = new SqlCommand(sqlDelete, cn);
            cmd.Parameters.AddWithValue("MaNCC", txtMaNCC.Text);
            cmd.Parameters.AddWithValue("TenNCC", txtTenNCC.Text);
            cmd.Parameters.AddWithValue("Gia", txtGia.Text);
            cmd.Parameters.AddWithValue("SoLuongMua", txtSLMua.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtGC.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");
            HienThi();
            ResetValues();
            cn.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                //Application.Exit();
                this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            cn.Open();
            string sqlSearch = "Select * From NCC Where TenNCC =@TenNCC or MaNCC=@MaNCC ";
            SqlCommand cmd = new SqlCommand(sqlSearch, cn);
            cmd.Parameters.AddWithValue("MaNCC", txtMaNCC.Text);
            cmd.Parameters.AddWithValue("TenNCC", txtTenNCC.Text);
            cmd.Parameters.AddWithValue("Gia", txtGia.Text);
            cmd.Parameters.AddWithValue("SoLuongMua", txtSLMua.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtGC.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvNCC.DataSource = dt;
            cn.Close();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSLMua.Text))
                MessageBox.Show("Vui lòng nhập số lượng bán");
            else
            {
                int Gia = Int32.Parse(txtGia.Text);
                int SoLuongMua = Int32.Parse(txtSLMua.Text);
                txtTong.Text = (Gia * SoLuongMua).ToString();

            }            
        }
    }
}
