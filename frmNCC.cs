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
            int index = dgvNCC.CurrentCell.RowIndex;
            txtMaNCC.Text = dgvNCC.Rows[index].Cells["MaNCC"].Value.ToString();
            txtTenNCC.Text = dgvNCC.Rows[index].Cells["TenNCC"].Value.ToString();
            txtGia.Text = dgvNCC.Rows[index].Cells["Gia"].Value.ToString();
            txtDiaChi.Text = dgvNCC.Rows[index].Cells["DiaChi"].Value.ToString();
            txtSLMua.Text = dgvNCC.Rows[index].Cells["SoLuongMua"].Value.ToString();
            txtGC.Text = dgvNCC.Rows[index].Cells["GhiChu"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cn.Open();
            string sqlSelect = "Select * From NCC Where MaNCC='" + txtMaNCC.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sqlSelect, cn);
            SqlDataReader dr = cmd1.ExecuteReader();
            if ((dr.Read()))
            {
                MessageBox.Show("Mã NCC đã tồn tại, vui lòng nhập lại mã NCC", "Thông báo");
            }
            else
            if (string.IsNullOrEmpty(txtMaNCC.Text) || string.IsNullOrEmpty(txtTenNCC.Text) || string.IsNullOrEmpty(txtSLMua.Text) || string.IsNullOrEmpty(txtGia.Text) || string.IsNullOrEmpty(txtDiaChi.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            else
            {
                dr.Close();
                int b;
                float c;
                bool o = int.TryParse(txtSLMua.Text, out b);
                bool l = float.TryParse(txtGia.Text, out c);

                if (!o)
                    MessageBox.Show("Vui lòng nhập số lượng là một số");
                else if (!l)
                    MessageBox.Show("Vui lòng nhập giá là một số");

                else
                {
                    string sqlInsert = "Insert Into NCC Values(@MaNCC,@TenNCC,@SoLuongMua,@Gia,@DiaChi,@GhiChu)";
                    SqlCommand cmd = new SqlCommand(sqlInsert, cn);
                    cmd.Parameters.AddWithValue("MaNCC", txtMaNCC.Text);
                    cmd.Parameters.AddWithValue("TenNCC", txtTenNCC.Text);
                    cmd.Parameters.AddWithValue("Gia", txtGia.Text);
                    cmd.Parameters.AddWithValue("SoLuongMua", txtSLMua.Text);
                    cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("GhiChu", txtGC.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm NCC thành công");
                    HienThi();
                    ResetValues();                    
                }
            }
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
            txtTong.Text = "";
            txtThanhToan.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cn.Open();
            string sqlSelect = "Select * From NCC Where MaNCC='" + txtMaNCC.Text + "'";
            SqlCommand cmd7 = new SqlCommand(sqlSelect, cn);
            SqlDataReader dr = cmd7.ExecuteReader();
            if (!(dr.Read()))
            {
                MessageBox.Show("Mã NCC không tồn tại, vui lòng nhập lại mã NCC", "Thông báo");
            }
            else
            if (string.IsNullOrEmpty(txtMaNCC.Text) || string.IsNullOrEmpty(txtTenNCC.Text) || string.IsNullOrEmpty(txtSLMua.Text) || string.IsNullOrEmpty(txtGia.Text) || string.IsNullOrEmpty(txtDiaChi.Text) )
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            else
            {
                dr.Close();
                int b;
                float c;
                bool o = int.TryParse(txtSLMua.Text, out b);
                bool l = float.TryParse(txtGia.Text, out c);

                if (!o)
                    MessageBox.Show("Vui lòng nhập số lượng là một số");
                else if (!l)
                    MessageBox.Show("Vui lòng nhập giá là một số");

                else
                {
                    string sqlUpdate = "Update NCC Set MaNCC=@MaNCC,TenNCC=@TenNCC,SoLuongMua=@SoLuongMua,Gia=@Gia,DiaChi=@DiaChi,GhiChu=@GhiChu Where MaNCC=@MaNCC";
                    SqlCommand cmd = new SqlCommand(sqlUpdate, cn);
                    cmd.Parameters.AddWithValue("MaNCC", txtMaNCC.Text);
                    cmd.Parameters.AddWithValue("TenNCC", txtTenNCC.Text);
                    cmd.Parameters.AddWithValue("Gia", txtGia.Text);
                    cmd.Parameters.AddWithValue("SoLuongMua", txtSLMua.Text);
                    cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("GhiChu", txtGC.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin NCC thành công");
                    HienThi();
                }

            }
            cn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cn.Open();
            if ((string.IsNullOrEmpty(txtMaNCC.Text)))
                MessageBox.Show("Vui lòng chọn NCC cần xóa");
            else {
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
                ResetValues(); }
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
            if ((string.IsNullOrEmpty(txtMaNCC.Text)))
                MessageBox.Show("Vui lòng chọn NCC cần tìm");
            else
            {
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
            }
            cn.Close();
        }
       
        private void btnClear_Click(object sender, EventArgs e)
        {
            cn.Open();
            txtMaNCC.Text = null;
            txtTenNCC.Text = null;
            txtSLMua.Text = null;
            txtGia.Text = null;
            txtDiaChi.Text = null;
            txtGC.Text = null;
            txtTong.Text = null;
            txtThanhToan.Text = null;
            HienThi();
            cn.Close();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSLMua.Text))
                MessageBox.Show("Vui lòng nhập số lượng mua");
            else
            {
                int Gia = Int32.Parse(txtGia.Text);
                int SoLuongMua = Int32.Parse(txtSLMua.Text);
                txtTong.Text = (Gia * SoLuongMua).ToString();
                int a;
                bool d = Int32.TryParse(txtThanhToan.Text, out a);
                a += Int32.Parse(txtTong.Text);
                txtThanhToan.Text = (a).ToString();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Giá trị của đơn hàng này là " + txtThanhToan.Text + "", "Thông báo", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                MessageBox.Show("Hóa đơn đã được thanh toán thành công");
                Application.Exit();
            }
        }
    }
}
