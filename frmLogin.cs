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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmTaoTK n2 = new frmTaoTK();
            n2.ShowDialog();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            SqlConnection connnection = new SqlConnection(@"Data Source=DESKTOP-H9PGTJJ\SQLEXPRESS;Initial Catalog=NuocNgotStore_3;Integrated Security=True");
            try
            {

                connnection.Open();
                string tk = txtUsername.Text;
                string mk = txtPassword.Text;
                string sql = "Select * From TaiKhoan Where TenTK ='" + tk + "'and MatKhau ='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, connnection);
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 n3 = new Form1();
                    n3.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connnection.Close();
                // dùng cho câu lệnh insert, update
                // cmd.ExecuteNonQuery();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối ");
            }
        }

        private void chckShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = chckShow.Checked;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn reset lại password ??", "Thông báo", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                this.Hide();
                frmDoiMatKhau n6 = new frmDoiMatKhau();
                n6.ShowDialog();

                //string sqlReset = "Update TaiKhoan Set MatKhau ="";
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
        //    if (MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
        //        Application.Exit();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }
    }
}
