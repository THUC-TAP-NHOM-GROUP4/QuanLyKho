namespace QuanLyKho.View
{
    partial class UC_TrangChu_DanhSach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTrangChu_DanhSach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTrangChu_PhieuNhap = new System.Windows.Forms.ComboBox();
            this.dtpTrangChu_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbbTrangChu_HangHoa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrangChu_DanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrangChu_DanhSach
            // 
            this.dgvTrangChu_DanhSach.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTrangChu_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrangChu_DanhSach.Location = new System.Drawing.Point(-9, 81);
            this.dgvTrangChu_DanhSach.Name = "dgvTrangChu_DanhSach";
            this.dgvTrangChu_DanhSach.ReadOnly = true;
            this.dgvTrangChu_DanhSach.Size = new System.Drawing.Size(937, 450);
            this.dgvTrangChu_DanhSach.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(34, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hàng hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(299, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phiếu nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(585, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày nhập";
            // 
            // cbbTrangChu_PhieuNhap
            // 
            this.cbbTrangChu_PhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTrangChu_PhieuNhap.FormattingEnabled = true;
            this.cbbTrangChu_PhieuNhap.Location = new System.Drawing.Point(302, 33);
            this.cbbTrangChu_PhieuNhap.Name = "cbbTrangChu_PhieuNhap";
            this.cbbTrangChu_PhieuNhap.Size = new System.Drawing.Size(178, 24);
            this.cbbTrangChu_PhieuNhap.TabIndex = 4;
            this.cbbTrangChu_PhieuNhap.SelectedIndexChanged += new System.EventHandler(this.cbbTrangChu_PhieuNhap_SelectedIndexChanged);
            // 
            // dtpTrangChu_NgayNhap
            // 
            this.dtpTrangChu_NgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpTrangChu_NgayNhap.Location = new System.Drawing.Point(588, 34);
            this.dtpTrangChu_NgayNhap.Name = "dtpTrangChu_NgayNhap";
            this.dtpTrangChu_NgayNhap.Size = new System.Drawing.Size(200, 23);
            this.dtpTrangChu_NgayNhap.TabIndex = 5;
            // 
            // cbbTrangChu_HangHoa
            // 
            this.cbbTrangChu_HangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTrangChu_HangHoa.FormattingEnabled = true;
            this.cbbTrangChu_HangHoa.Location = new System.Drawing.Point(37, 33);
            this.cbbTrangChu_HangHoa.Name = "cbbTrangChu_HangHoa";
            this.cbbTrangChu_HangHoa.Size = new System.Drawing.Size(178, 24);
            this.cbbTrangChu_HangHoa.TabIndex = 6;
            this.cbbTrangChu_HangHoa.SelectedIndexChanged += new System.EventHandler(this.cbbTrangChu_HangHoa_SelectedIndexChanged);
            // 
            // UC_TrangChu_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbbTrangChu_HangHoa);
            this.Controls.Add(this.dtpTrangChu_NgayNhap);
            this.Controls.Add(this.cbbTrangChu_PhieuNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTrangChu_DanhSach);
            this.MaximumSize = new System.Drawing.Size(931, 534);
            this.MinimumSize = new System.Drawing.Size(931, 534);
            this.Name = "UC_TrangChu_DanhSach";
            this.Size = new System.Drawing.Size(931, 534);
            this.Load += new System.EventHandler(this.UC_TrangChu_DanhSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrangChu_DanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrangChu_DanhSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTrangChu_PhieuNhap;
        private System.Windows.Forms.DateTimePicker dtpTrangChu_NgayNhap;
        private System.Windows.Forms.ComboBox cbbTrangChu_HangHoa;
    }
}
