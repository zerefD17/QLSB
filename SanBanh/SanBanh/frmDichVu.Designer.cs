
namespace SanBanh
{
    partial class frmDichVu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Madv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Tendv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Dongia = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã dịch vụ";
            // 
            // txt_Madv
            // 
            this.txt_Madv.Location = new System.Drawing.Point(137, 33);
            this.txt_Madv.Name = "txt_Madv";
            this.txt_Madv.Size = new System.Drawing.Size(147, 20);
            this.txt_Madv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên dịch vụ";
            // 
            // txt_Tendv
            // 
            this.txt_Tendv.Location = new System.Drawing.Point(137, 59);
            this.txt_Tendv.Name = "txt_Tendv";
            this.txt_Tendv.Size = new System.Drawing.Size(147, 20);
            this.txt_Tendv.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá";
            // 
            // txt_Dongia
            // 
            this.txt_Dongia.Location = new System.Drawing.Point(137, 85);
            this.txt_Dongia.Name = "txt_Dongia";
            this.txt_Dongia.Size = new System.Drawing.Size(147, 20);
            this.txt_Dongia.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 262);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::SanBanh.Properties.Resources.Modify;
            this.btn_Sua.Location = new System.Drawing.Point(414, 33);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(48, 46);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = global::SanBanh.Properties.Resources.Delete;
            this.btn_Xoa.Location = new System.Drawing.Point(360, 33);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(48, 46);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::SanBanh.Properties.Resources.Add;
            this.btn_Them.Location = new System.Drawing.Point(310, 33);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(44, 46);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Dongia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Tendv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Madv);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDichVu";
            this.Text = "frmDichVu";
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Madv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Tendv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Dongia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
    }
}