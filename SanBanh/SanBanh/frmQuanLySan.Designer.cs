
namespace SanBanh
{
    partial class frmQuanLySan
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
            this.txt_MaSan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_LoaiSan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenSan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_GiaSan = new System.Windows.Forms.TextBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sân";
            // 
            // txt_MaSan
            // 
            this.txt_MaSan.Location = new System.Drawing.Point(142, 40);
            this.txt_MaSan.Name = "txt_MaSan";
            this.txt_MaSan.Size = new System.Drawing.Size(143, 20);
            this.txt_MaSan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại sân";
            // 
            // txt_LoaiSan
            // 
            this.txt_LoaiSan.Location = new System.Drawing.Point(142, 66);
            this.txt_LoaiSan.Name = "txt_LoaiSan";
            this.txt_LoaiSan.Size = new System.Drawing.Size(143, 20);
            this.txt_LoaiSan.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sân";
            // 
            // txt_TenSan
            // 
            this.txt_TenSan.Location = new System.Drawing.Point(424, 40);
            this.txt_TenSan.Name = "txt_TenSan";
            this.txt_TenSan.Size = new System.Drawing.Size(132, 20);
            this.txt_TenSan.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá sân";
            // 
            // txt_GiaSan
            // 
            this.txt_GiaSan.Location = new System.Drawing.Point(424, 66);
            this.txt_GiaSan.Name = "txt_GiaSan";
            this.txt_GiaSan.Size = new System.Drawing.Size(132, 20);
            this.txt_GiaSan.TabIndex = 2;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackgroundImage = global::SanBanh.Properties.Resources.xanh1;
            this.btn_Sua.Image = global::SanBanh.Properties.Resources.Modify;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Sua.Location = new System.Drawing.Point(253, 119);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(59, 48);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackgroundImage = global::SanBanh.Properties.Resources.xanh1;
            this.btn_Xoa.Image = global::SanBanh.Properties.Resources.Delete;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Xoa.Location = new System.Drawing.Point(170, 119);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(59, 48);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackgroundImage = global::SanBanh.Properties.Resources.xanh1;
            this.btn_Them.Image = global::SanBanh.Properties.Resources.Add;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Them.Location = new System.Drawing.Point(93, 119);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(59, 48);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // frmQuanLySan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(671, 410);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_GiaSan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_TenSan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_LoaiSan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaSan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLySan";
            this.Text = "frmQuanLySan";
            this.Load += new System.EventHandler(this.frmQuanLySan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaSan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_LoaiSan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenSan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_GiaSan;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
    }
}