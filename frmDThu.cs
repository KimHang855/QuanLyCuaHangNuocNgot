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
    public partial class frmDThu : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-H9PGTJJ\SQLEXPRESS;Initial Catalog=NuocNgotStore_3;Integrated Security=True");
        private object dgvSanPham;

        public frmDThu()
        {
            InitializeComponent();
        }      

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }

        public void HienThi()
        {
            cn.Open();
            string sql = "Select * From SanPham";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Load(dr);
            //hoặc da.Fill(dt);  //Đổ kết quả từ câu lệnh sql vào table            
            dgvDThu.DataSource = dt;
            cn.Close();
        }
        private void frmDThu_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            //foreach(DataGridViewRow item in dgvDThu.Rows)
            //{
            //    int n = item.Index;
            //    dgvDThu.Rows[n].Cells[2].Value =
            //        (Double.Parse(dgvDThu.Rows[n].Cells[2].Value.ToString()) *
            //        Double.Parse(dgvDThu.Rows[n].Cells[4].Value.ToString())).ToString();
            //}
            //txtDT.Text = "0";
            //foreach (DataGridViewRow item in dgvDThu.Rows)
            //{
            //    int n = item.Index;
            //    txtDT.Text =
            //        (Double.Parse(dgvDThu.Rows[n].Cells[2].Value.ToString()) *
            //        Double.Parse(dgvDThu.Rows[n].Cells[4].Value.ToString())).ToString();
            //}
        }

        private void txtNgayBan_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            string sqlSearch = "Select * From SanPham Where NgayBan=@NgayBan ";
            SqlCommand cmd = new SqlCommand(sqlSearch, cn);            
            cmd.Parameters.AddWithValue("NgayBan", txtNgayBan.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvDThu.DataSource = dt;
            cn.Close();
        }
    }
}
