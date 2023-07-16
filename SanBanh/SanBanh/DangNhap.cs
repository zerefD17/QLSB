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
using System.Data.Sql;
namespace SanBanh
{
    public partial class DangNhap : Form
    {
        SqlConnection Con;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=SanBanh;Integrated Security=True";
            Con.Open();
            string select = "Select * From TUSER where TAIKHOAN='" + txt_TaiKhoan.Text + "' and MATKHAU='" + txt_MatKhau.Text + "' and QUYEN='Admin'";
            SqlCommand cmd = new SqlCommand(select, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Read();
                MessageBox.Show("Đăng nhập vào hệ thống (Quyền Admin) !", "Thông báo !");
                GiaoDien.quyen = "Admin";
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập vào hệ thống (Quyền user) !", "Thông báo !");
                GiaoDien.quyen = "user";
                this.Hide();
                this.Close();
            }
            GiaoDien frm = new GiaoDien();
            //frm.Show();
            frm.ShowDialog();
            cmd.Dispose();
            reader.Close();
            reader.Dispose();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txt_MatKhau.UseSystemPasswordChar = true;
        }
    }
}
