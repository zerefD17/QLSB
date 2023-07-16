using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SanBanh
{
    public partial class FrmQuanLyNhanSu : Form
    {
        SqlConnection con;        
        XULYCSDL xl = new XULYCSDL();
        DataTable dd;
        public FrmQuanLyNhanSu()
        {
            InitializeComponent();
        }
        private void FrmQuanLyNhanSu_Load(object sender, EventArgs e)
        {
            dd = xl.DocCSDL("select * from NHANVIEN");
            dataGridView1.DataSource = dd;
            NVBiding();
        }
        void NVBiding()
        {
            txt_MaNV.DataBindings.Add("Text", dd, "MANV");
            txt_tenNV.DataBindings.Add("Text", dd, "TENNV");
            txt_SoDT.DataBindings.Add("Text", dd, "SDT");
            txt_DiaChi.DataBindings.Add("Text", dd, "DIACHI");
            dtp_NgaySinh.DataBindings.Add("Text", dd, "NGAYSINH");
            cbb_GioiTinh.DataBindings.Add("Text", dd, "GIOITINH");
        }
        void refresh1()
        {
            dd = xl.DocCSDL("select * from NHANVIEN");
            dataGridView1.DataSource = dd;
            //NVBiding();
            dataGridView1.Refresh();
        }
        private void btn_Moi_Click(object sender, EventArgs e)
        {
            txt_DiaChi.Clear();
            txt_MaNV.Clear();
            txt_SoDT.Clear();
            txt_tenNV.Clear();
            //txt_MaNV.DataBindings.Clear();
            //txt_tenNV.DataBindings.Clear();
            //txt_SoDT.DataBindings.Clear();
            //txt_DiaChi.DataBindings.Clear();
            //dtp_NgaySinh.DataBindings.Clear();
            //cbb_GioiTinh.DataBindings.Clear();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {        
            string intsert = string.Format("INSERT INTO NHANVIEN VALUES('{0}', N'{1}', '{2}', N'{3}', '{4}', '{5}')",txt_MaNV.Text,txt_tenNV.Text,txt_SoDT.Text,txt_DiaChi.Text,dtp_NgaySinh.Text,cbb_GioiTinh.Text);
            
            if (xl.AddDelUp(intsert) > 0)
                MessageBox.Show("Thêm nhân viên thành công!");
            refresh1();
            

        }
        
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string up = string.Format("update NHANVIEN set TENNV=N'{0}', SDT='{1}',DIACHI=N'{2}',NGAYSINH='{3}',GIOITINH='{4}' where MANV='{5}'", txt_tenNV.Text, txt_SoDT.Text, txt_DiaChi.Text, dtp_NgaySinh.Text, cbb_GioiTinh.Text,txt_MaNV.Text);
            if (xl.AddDelUp(up) > 0)
                MessageBox.Show("Sữa nhân viên thành công!");
            
            refresh1();

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string del = string.Format("delete NHANVIEN where MANV='{0}'",txt_MaNV.Text);
            if (xl.AddDelUp(del) > 0)
                MessageBox.Show("Xóa thành công!");
            
            refresh1();
        }
        
        
    }
}
