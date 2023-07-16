
namespace SanBanh
{
    partial class FrmQuanLyNhanSu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SoDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Moi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(139, 29);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(97, 20);
            this.txt_MaNV.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // txt_tenNV
            // 
            this.txt_tenNV.Location = new System.Drawing.Point(139, 55);
            this.txt_tenNV.Name = "txt_tenNV";
            this.txt_tenNV.Size = new System.Drawing.Size(148, 20);
            this.txt_tenNV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số điện thoại";
            // 
            // txt_SoDT
            // 
            this.txt_SoDT.Location = new System.Drawing.Point(139, 81);
            this.txt_SoDT.Name = "txt_SoDT";
            this.txt_SoDT.Size = new System.Drawing.Size(97, 20);
            this.txt_SoDT.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa chỉ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(448, 29);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(97, 20);
            this.txt_DiaChi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày sinh";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CustomFormat = "MM / dd / yyyy";
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(448, 55);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(97, 20);
            this.dtp_NgaySinh.TabIndex = 3;
            // 
            // cbb_GioiTinh
            // 
            this.cbb_GioiTinh.FormattingEnabled = true;
            this.cbb_GioiTinh.Location = new System.Drawing.Point(448, 85);
            this.cbb_GioiTinh.Name = "cbb_GioiTinh";
            this.cbb_GioiTinh.Size = new System.Drawing.Size(121, 21);
            this.cbb_GioiTinh.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giới tính";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = global::SanBanh.Properties.Resources.remove_user;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(427, 154);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::SanBanh.Properties.Resources.edit_user;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(331, 154);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::SanBanh.Properties.Resources.add_user;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(221, 154);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Moi
            // 
            this.btn_Moi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Moi.BackgroundImage = global::SanBanh.Properties.Resources.xanh;
            this.btn_Moi.Image = global::SanBanh.Properties.Resources.upload;
            this.btn_Moi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Moi.Location = new System.Drawing.Point(117, 154);
            this.btn_Moi.Name = "btn_Moi";
            this.btn_Moi.Size = new System.Drawing.Size(75, 23);
            this.btn_Moi.TabIndex = 5;
            this.btn_Moi.Text = "Mới";
            this.btn_Moi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Moi.UseVisualStyleBackColor = false;
            this.btn_Moi.Click += new System.EventHandler(this.btn_Moi_Click);
            // 
            // FrmQuanLyNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Moi);
            this.Controls.Add(this.cbb_GioiTinh);
            this.Controls.Add(this.dtp_NgaySinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_SoDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tenNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmQuanLyNhanSu";
            this.Text = "FrmQuanLyNhanSu";
            this.Load += new System.EventHandler(this.FrmQuanLyNhanSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SoDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.ComboBox cbb_GioiTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Moi;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
    }
}