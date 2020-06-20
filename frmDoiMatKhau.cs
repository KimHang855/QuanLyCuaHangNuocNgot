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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            SqlConnection connnection = new SqlConnection(@"Data Source=LAPTOP-EFEOHQTE\SQLEXPRESS;Initial Catalog=QuanLyCuaHang1;Integrated Security=True");
            connnection.Open();
            //string sqlUpdate = "Update TaiKhoan Set MatKhau='" + txtMK.Text + "'Where TenTaiKhoan='" + txtTentk.Text + "'";
            //"update Taikhoan set MatKhau = '"+txtMK.Text+"' where TenTaiKhoan = '"+txtTentk.Text+"'";
            string sqlUpdate = "Update Taikhoan Set MatKhau = '" + txtMK.Text + "' where TenTaiKhoan = '" + txtTentk.Text + "'";
            string sqlSelect = "Select TenTaiKhoan From TaiKhoan Where TenTaiKhoan='" + txtTentk.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlUpdate, connnection);
            SqlCommand cmd1 = new SqlCommand(sqlSelect, connnection);
            SqlDataReader dr6 = cmd1.ExecuteReader();
            if ((!dr6.Read()))
            {
                MessageBox.Show("Tài khoản này không tồn tại", "Thông báo");
            }
            else if (string.IsNullOrEmpty(txtTentk.Text) || string.IsNullOrEmpty(txtMK.Text) || string.IsNullOrEmpty(txtXacNhanMK.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            else if (txtMK.Text != txtXacNhanMK.Text)

                MessageBox.Show("Vui lòng xác nhận lại mật khẩu", "Thông báo");

            //else if ((!dr6.Read()))
            //{
            //    MessageBox.Show("Tài khoản này không tồn tại", "Thông báo");
            //}
            else
            {
                cmd.Parameters.AddWithValue("MatKhau", txtMK.Text);
                MessageBox.Show("Reset password thành công");
                connnection.Close();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
