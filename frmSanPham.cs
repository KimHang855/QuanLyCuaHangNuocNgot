using System;
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
        //SqlDataAdapter da;        

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
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Load(dr);
            //hoặc da.Fill(dt);  //Đổ kết quả từ câu lệnh sql vào table            
            dgvSanPham.DataSource = dt;
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            cn.Open();
                       
            string sqlInsert = "Insert Into SanPham Values(@MaSP,@TenSP,@Gia,@SoLuongTon,@SoLuongBan,@Ngay,@DonVi)";
            //string sqlInsert = "Insert Into Product values('"+txtMaSP.Text+"','"+txtTenSP.Text+ "','"+txtGiaBan.Text+ "','"+txtSLTon.Text+ "','"+txtSLBan.Text+"','"+txtDVT.Text+ "','"+txtMaLoai.Text+ "','"+txtNCC.Text+ "','"+txtNgayBan.Text+"')";
            SqlCommand cmd = new SqlCommand(sqlInsert,cn);
            cmd.Parameters.AddWithValue("MaSP", txtMaSP.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("Gia", txtGiaBan.Text);
            cmd.Parameters.AddWithValue("SoLuongTon", txtSLTon.Text);
            cmd.Parameters.AddWithValue("SoLuongBan", txtSLBan.Text);
            cmd.Parameters.AddWithValue("Ngay", txtNgay.Text);
            cmd.Parameters.AddWithValue("DonVi", txtDVT.Text);
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
            txtSLBan.Text = "";
            txtDVT.Text = "";
            txtNgay.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cn.Open();
            string sqlUpdate = "Update SanPham Set TenSP=@TenSP, Gia=@Gia, SoLuongTon=@SoLuongTon, SoLuongBan=@SoLuongBan,/* Ngay=@Ngay,*/ DonVi=@DonVi Where MaSP=@MaSP ";
            //string sqlUpdate = "Update SanPham Set TenSP= N'" + txtTenSP.Text + "',Gia='" + txtGiaBan.Text + "',SoLuongTon='" + txtSLTon.Text + "',SoLuongBan='" + txtSLBan.Text + "',Ngay='" + txtNgay.Text + "',DonVi='" + txtDVT.Text + "' Where MaSP = '"+txtMaSP+"'";
            SqlCommand cmd = new SqlCommand(sqlUpdate, cn);
            cmd.Parameters.AddWithValue("MaSP", txtMaSP.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("Gia", txtGiaBan.Text);
            cmd.Parameters.AddWithValue("SoLuongTon", txtSLTon.Text);
            cmd.Parameters.AddWithValue("SoLuongBan", txtSLBan.Text);
            //cmd.Parameters.AddWithValue("Ngay", txtNgay.Text); //lỗi ngày
            cmd.Parameters.AddWithValue("DonVi", txtDVT.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thông tin sản phẩm thành công");
            HienThi();
            ResetValues();
            //cn.Close();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }      

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlDelete = "Delete From SanPham Where MaSP = @MaSP";
            SqlCommand cmd = new SqlCommand(sqlDelete, cn);
            cmd.Parameters.AddWithValue("MaSP", txtMaSP.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("Gia", txtGiaBan.Text);
            cmd.Parameters.AddWithValue("SoLuongTon", txtSLTon.Text);
            cmd.Parameters.AddWithValue("SoLuongBan", txtSLBan.Text);
            cmd.Parameters.AddWithValue("Ngay", txtNgay.Text); 
            cmd.Parameters.AddWithValue("DonVi", txtDVT.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa sản phẩm thành công");
            HienThi();
            ResetValues();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sqlSearch = "Select * From SanPham Where TenSP =@TenSP or MaSP=@MaSP ";
            SqlCommand cmd = new SqlCommand(sqlSearch, cn);
            cmd.Parameters.AddWithValue("MaSP", txtMaSP.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("Gia", txtGiaBan.Text);
            cmd.Parameters.AddWithValue("SoLuongTon", txtSLTon.Text);
            cmd.Parameters.AddWithValue("Ngay", txtNgay.Text);
            cmd.Parameters.AddWithValue("DonVi", txtDVT.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);                    
            dgvSanPham.DataSource = dt;            
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
            DialogResult kq = MessageBox.Show("Giá trị của đơn hàng này là " + txtThanhToan.Text + "", "Thông báo", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                MessageBox.Show("Hóa đơn đã được thanh toán thành công");
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = null;
            txtTenSP.Text = null;
            txtDVT.Text = null;
            txtGiaBan.Text = null;
            txtSLTon.Text = null;
            txtSLBan.Text = null;

        }
        
    }
}
