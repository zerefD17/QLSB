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
    public partial class frmDichVu : Form
    {
        SqlConnection con;
        XULYCSDL xl = new XULYCSDL();
        DataTable dd;
        public frmDichVu()
        {
            InitializeComponent();
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            dd = xl.DocCSDL("select * from DICHVU");
            dataGridView1.DataSource = dd;
            DVBiding();
        }
        void DVBiding()
        {
            txt_Madv.DataBindings.Add("Text", dd, "MADV");
            txt_Tendv.DataBindings.Add("Text", dd, "TENDV");
            txt_Dongia.DataBindings.Add("Text", dd, "GIA");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string intsert = string.Format("INSERT INTO DICHVU VALUES('{0}', N'{1}', {2})", txt_Madv.Text, txt_Tendv.Text, txt_Dongia.Text);

            if (xl.AddDelUp(intsert) > 0)
                MessageBox.Show("Thêm Dịch vụ thành công!");
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string del = string.Format("delete DICHVU where MADV='{0}'", txt_Madv.Text);

            if (xl.AddDelUp(del) > 0)
                MessageBox.Show("Xóa dịch vụ thành công!");
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string up = string.Format("update NHANVIEN set TENDV=N'{0}', GIA={1} where MADV='{2}'", txt_Tendv.Text, txt_Dongia.Text, txt_Madv.Text);
            

            if (xl.AddDelUp(up) > 0)
                MessageBox.Show("Sữa dịch vụ thành công!");
            dataGridView1.Refresh();
        }
    }
}
