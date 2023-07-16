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
    public partial class frmQuanLySan : Form
    {
        SqlConnection con;
        XULYCSDL xl = new XULYCSDL();
        DataTable dd;
        public frmQuanLySan()
        {
            InitializeComponent();
        }
        private void frmQuanLySan_Load(object sender, EventArgs e)
        {
            dd = xl.DocCSDL("select * from SANBONG");
            dataGridView1.DataSource = dd;
            SanBiding();
        }
        void SanBiding()
        {
            txt_MaSan.DataBindings.Add("Text", dd, "MASAN");
            txt_TenSan.DataBindings.Add("Text", dd, "TENSAN");
            txt_LoaiSan.DataBindings.Add("Text", dd, "LOAISAN");
            txt_GiaSan.DataBindings.Add("Text", dd, "GIASAN");
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string intsert = string.Format("INSERT INTO SANBONG VALUES(N'{0}', N'{1}', '{2}', {3}) ", txt_MaSan.Text, txt_TenSan.Text, txt_LoaiSan.Text,txt_GiaSan.Text);

            if (xl.AddDelUp(intsert) > 0)
                MessageBox.Show("Thêm sân thành công!");
            dataGridView1.Refresh();
        }

        

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string del = string.Format("delete SANBONG where MASAN='{0}'", txt_MaSan.Text);

            if (xl.AddDelUp(del) > 0)
                MessageBox.Show("Xóa sân thành công!");
            dataGridView1.Refresh();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string up = string.Format("update SANBONG set TENSAN=N'{0}', LOAISAN='{1}',GIASAN={2} where MASAN='{3}'",  txt_TenSan.Text, txt_LoaiSan.Text, txt_GiaSan.Text, txt_MaSan.Text);
            if (xl.AddDelUp(up) > 0)
                MessageBox.Show("Sữa sân thành công!");
            dataGridView1.Refresh();
        }
    }
}
