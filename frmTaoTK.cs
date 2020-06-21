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
    public partial class frmTaoTK : Form
    {
        public frmTaoTK()
        {
            InitializeComponent();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private int CheckPass()
        {
            int count = 0;
            for (int i = 0; i < txtMatKhau.TextLength; i++)
            {
                count++;
            }
            if (count < 6 && count > 0)
                MessageBox.Show("Mật khẩu tối thiểu 6 ký tự");
            return count;
        }

        private void btTao_Click(object sender, EventArgs e)
        {
            SqlConnection connnection = new SqlConnection(@"Data Source=DESKTOP-H9PGTJJ\SQLEXPRESS;Initial Catalog=NuocNgotStore_3;Integrated Security=True");
            connnection.Open();
            if ((string.IsNullOrEmpty(txtTenDangNhap.Text)) || (string.IsNullOrEmpty(txtMatKhau.Text)))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ", "Thông báo");
            }
            
            if (txtTenDangNhap.Text != null && txtMatKhau.Text != null)
            {
                string sqlTen = "Select TenTK From TaiKhoan Where TenTK='" + txtTenDangNhap.Text + "'";

                SqlCommand cmd = new SqlCommand(sqlTen, connnection);
                SqlDataReader dr = cmd.ExecuteReader();
                if ((dr.Read()))
                {
                    MessageBox.Show("Tài khoản này đã có người sử dụng, vui lòng chọn tài khoản khác", "Thông báo");
                }


                else
                {
                    if (!dr.Read() && CheckPass() >= 6)
                    {
                        dr.Close();

                        string sqlCreateAcc = "Insert Into TaiKhoan Values('" + txtTenDangNhap.Text + "','" + txtMatKhau.Text + "')";
                        SqlCommand cmd1 = new SqlCommand(sqlCreateAcc, connnection);
                        cmd1.Parameters.AddWithValue("TenTK", txtTenDangNhap.Text);
                        cmd1.Parameters.AddWithValue("MatKhau", txtMatKhau.Text);
                        //cmd1.Parameters.AddWithValue("GhiChu", txtGhiChu.Text);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Tạo tài khoản thành công");
                        connnection.Close();
                        Form1 n3 = new Form1();
                        n3.ShowDialog();

                    }
                }
            }
            }
        }
    }

    
