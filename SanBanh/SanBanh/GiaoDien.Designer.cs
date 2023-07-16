
namespace SanBanh
{
    partial class GiaoDien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_DangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_NghiepVu = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DatSan = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_TinhTien = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TSMI_QuanLySan = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_QuanLyNhanSu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_DangNhap,
            this.menu_NghiepVu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(892, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menu_DangNhap
            // 
            this.menu_DangNhap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_DangNhap,
            this.TSMI_QuanLyNhanSu});
            this.menu_DangNhap.Name = "menu_DangNhap";
            this.menu_DangNhap.Size = new System.Drawing.Size(60, 20);
            this.menu_DangNhap.Text = "Quản lý";
            // 
            // TSMI_DangNhap
            // 
            this.TSMI_DangNhap.Name = "TSMI_DangNhap";
            this.TSMI_DangNhap.Size = new System.Drawing.Size(180, 22);
            this.TSMI_DangNhap.Text = "Đăng nhập";
            this.TSMI_DangNhap.Click += new System.EventHandler(this.TSMI_DangNhap_Click);
            // 
            // menu_NghiepVu
            // 
            this.menu_NghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_DatSan,
            this.TSMI_TinhTien,
            this.TSMI_DichVu,
            this.TSMI_QuanLySan});
            this.menu_NghiepVu.Name = "menu_NghiepVu";
            this.menu_NghiepVu.Size = new System.Drawing.Size(77, 20);
            this.menu_NghiepVu.Text = "Nghiệp vụ ";
            // 
            // TSMI_DatSan
            // 
            this.TSMI_DatSan.Name = "TSMI_DatSan";
            this.TSMI_DatSan.Size = new System.Drawing.Size(180, 22);
            this.TSMI_DatSan.Text = "Quản lý đặt sân";
            this.TSMI_DatSan.Click += new System.EventHandler(this.quảnLýĐặtSânToolStripMenuItem_Click);
            // 
            // TSMI_TinhTien
            // 
            this.TSMI_TinhTien.Name = "TSMI_TinhTien";
            this.TSMI_TinhTien.Size = new System.Drawing.Size(180, 22);
            this.TSMI_TinhTien.Text = "Tính tiền";
            this.TSMI_TinhTien.Click += new System.EventHandler(this.TSMI_TinhTien_Click);
            // 
            // TSMI_DichVu
            // 
            this.TSMI_DichVu.Name = "TSMI_DichVu";
            this.TSMI_DichVu.Size = new System.Drawing.Size(180, 22);
            this.TSMI_DichVu.Text = "Dịch Vụ";
            this.TSMI_DichVu.Click += new System.EventHandler(this.TSMI_DichVu_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(892, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 396);
            this.panel1.TabIndex = 6;
            // 
            // TSMI_QuanLySan
            // 
            this.TSMI_QuanLySan.Name = "TSMI_QuanLySan";
            this.TSMI_QuanLySan.Size = new System.Drawing.Size(180, 22);
            this.TSMI_QuanLySan.Text = "Sân";
            this.TSMI_QuanLySan.Click += new System.EventHandler(this.TSMI_QuanLySan_Click);
            // 
            // TSMI_QuanLyNhanSu
            // 
            this.TSMI_QuanLyNhanSu.Name = "TSMI_QuanLyNhanSu";
            this.TSMI_QuanLyNhanSu.Size = new System.Drawing.Size(180, 22);
            this.TSMI_QuanLyNhanSu.Text = "Quản lý nhân sự";
            this.TSMI_QuanLyNhanSu.Click += new System.EventHandler(this.TSMI_QuanLyNhanSu_Click);
            // 
            // GiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(892, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "GiaoDien";
            this.Text = "GiaoDien";
            this.Load += new System.EventHandler(this.GiaoDien_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem menu_DangNhap;
        private System.Windows.Forms.ToolStripMenuItem menu_NghiepVu;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DatSan;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TinhTien;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DichVu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DangNhap;
        private System.Windows.Forms.ToolStripMenuItem TSMI_QuanLySan;
        private System.Windows.Forms.ToolStripMenuItem TSMI_QuanLyNhanSu;
    }
}



