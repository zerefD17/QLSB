using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanBanh
{
    public partial class GiaoDien : Form
    {
        private int childFormNumber = 0;
        public static string quyen;
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        
        private void GiaoDien_Load(object sender, EventArgs e)
        {

            if (quyen == null)
            {
                menu_NghiepVu.Enabled = false;
                TSMI_QuanLyNhanSu.Enabled = false;

            }
            if (quyen == "Admin")
            {
                menu_NghiepVu.Enabled = true;
                TSMI_QuanLyNhanSu.Enabled = true;
                TSMI_DatSan.Enabled = true;
                TSMI_DichVu.Enabled = true;
                TSMI_TinhTien.Enabled = true;
                TSMI_QuanLySan.Enabled = true;
                
            }
            else if (quyen == "user")
            {
                menu_NghiepVu.Enabled = true;
                TSMI_QuanLyNhanSu.Enabled = false;
                TSMI_DatSan.Enabled = true;
                TSMI_DichVu.Enabled = false;
                TSMI_TinhTien.Enabled = true;
                TSMI_QuanLySan.Enabled = false;

            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýĐặtSânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDatSan fc = new QuanLyDatSan();
            panel1.Show();
            panel1.Controls.Clear();
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            panel1.Controls.Add(fc);
            fc.Show();
        }

        private void TSMI_TinhTien_Click(object sender, EventArgs e)
        {
            frmTinhTien fc = new frmTinhTien();
            panel1.Show();
            panel1.Controls.Clear();
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            panel1.Controls.Add(fc);
            fc.Show();
        }

        private void TSMI_QuanLySan_Click(object sender, EventArgs e)
        {
            frmQuanLySan fc = new frmQuanLySan();
            panel1.Show();
            panel1.Controls.Clear();
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            panel1.Controls.Add(fc);
            fc.Show();
        }

        private void TSMI_DichVu_Click(object sender, EventArgs e)
        {
            frmDichVu fc = new frmDichVu();
            panel1.Show();
            panel1.Controls.Clear();
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            panel1.Controls.Add(fc);
            fc.Show();
        }

        private void TSMI_DangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.ShowDialog();
            dn.Show();
        }

        private void TSMI_QuanLyNhanSu_Click(object sender, EventArgs e)
        {
            FrmQuanLyNhanSu fns = new FrmQuanLyNhanSu();
            panel1.Show();
            panel1.Controls.Clear();
            fns.TopLevel = false;
            fns.Dock = DockStyle.Fill;
            panel1.Controls.Add(fns);
            fns.Show();
        }
    }
}
