namespace QuanLyKho.View
{
    partial class frmChitietphieunhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbmahanghoa = new System.Windows.Forms.ComboBox();
            this.cbbmakho = new System.Windows.Forms.ComboBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvdanhsachchitietphieunhap = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachchitietphieunhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // cbbmahanghoa
            // 
            this.cbbmahanghoa.FormattingEnabled = true;
            this.cbbmahanghoa.Location = new System.Drawing.Point(152, 37);
            this.cbbmahanghoa.Name = "cbbmahanghoa";
            this.cbbmahanghoa.Size = new System.Drawing.Size(164, 21);
            this.cbbmahanghoa.TabIndex = 4;
            // 
            // cbbmakho
            // 
            this.cbbmakho.FormattingEnabled = true;
            this.cbbmakho.Location = new System.Drawing.Point(152, 89);
            this.cbbmakho.Name = "cbbmakho";
            this.cbbmakho.Size = new System.Drawing.Size(164, 21);
            this.cbbmakho.TabIndex = 5;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(490, 30);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(162, 20);
            this.txtdongia.TabIndex = 6;
            this.txtdongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongia_KeyPress);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(490, 85);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(162, 20);
            this.txtsoluong.TabIndex = 7;
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Danh sách";
            // 
            // dgvdanhsachchitietphieunhap
            // 
            this.dgvdanhsachchitietphieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsachchitietphieunhap.Location = new System.Drawing.Point(-2, 186);
            this.dgvdanhsachchitietphieunhap.Name = "dgvdanhsachchitietphieunhap";
            this.dgvdanhsachchitietphieunhap.Size = new System.Drawing.Size(769, 174);
            this.dgvdanhsachchitietphieunhap.TabIndex = 9;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(506, 371);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 40);
            this.btnthem.TabIndex = 10;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(579, 371);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 40);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frmChitietphieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 418);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvdanhsachchitietphieunhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.cbbmakho);
            this.Controls.Add(this.cbbmahanghoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChitietphieunhap";
            this.Text = "frmChitietphieunhap";
            this.Load += new System.EventHandler(this.frmChitietphieunhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachchitietphieunhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbmahanghoa;
        private System.Windows.Forms.ComboBox cbbmakho;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvdanhsachchitietphieunhap;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnthoat;
    }
}