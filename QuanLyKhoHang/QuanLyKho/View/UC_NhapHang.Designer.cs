namespace QuanLyKho.View
{
    partial class UC_NhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_NhapHang));
            this.lbcNhapKho = new DevExpress.XtraEditors.LabelControl();
            this.gridControlNhapHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaNguoiGiaoNhapHang = new System.Windows.Forms.TextBox();
            this.txtMaNguoiNhapHang = new System.Windows.Forms.TextBox();
            this.txtTenHangHoaNhap = new System.Windows.Forms.TextBox();
            this.txtMaHangHoaNhap = new System.Windows.Forms.TextBox();
            this.cbbMaKho = new System.Windows.Forms.ComboBox();
            this.rtbNoiDungNhapHang = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuongNhapHang = new System.Windows.Forms.TextBox();
            this.btnTimkiemNhapHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaNhapHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaNhapHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuyNhapHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemNhapHang = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbcNhapKho
            // 
            this.lbcNhapKho.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbcNhapKho.Location = new System.Drawing.Point(383, 3);
            this.lbcNhapKho.Name = "lbcNhapKho";
            this.lbcNhapKho.Size = new System.Drawing.Size(113, 18);
            this.lbcNhapKho.TabIndex = 7;
            this.lbcNhapKho.Text = "Phiếu nhập kho";
            // 
            // gridControlNhapHang
            // 
            this.gridControlNhapHang.Location = new System.Drawing.Point(5, 194);
            this.gridControlNhapHang.MainView = this.gridView1;
            this.gridControlNhapHang.Name = "gridControlNhapHang";
            this.gridControlNhapHang.Size = new System.Drawing.Size(923, 275);
            this.gridControlNhapHang.TabIndex = 8;
            this.gridControlNhapHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlNhapHang;
            this.gridView1.Name = "gridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã người giao hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã người nhập hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(376, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nội dung nhập hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(21, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã hàng hóa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(21, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tên hàng hóa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(376, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã kho:";
            // 
            // txtMaNguoiGiaoNhapHang
            // 
            this.txtMaNguoiGiaoNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNguoiGiaoNhapHang.Location = new System.Drawing.Point(156, 30);
            this.txtMaNguoiGiaoNhapHang.Name = "txtMaNguoiGiaoNhapHang";
            this.txtMaNguoiGiaoNhapHang.Size = new System.Drawing.Size(175, 22);
            this.txtMaNguoiGiaoNhapHang.TabIndex = 15;
            // 
            // txtMaNguoiNhapHang
            // 
            this.txtMaNguoiNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNguoiNhapHang.Location = new System.Drawing.Point(156, 62);
            this.txtMaNguoiNhapHang.Name = "txtMaNguoiNhapHang";
            this.txtMaNguoiNhapHang.Size = new System.Drawing.Size(175, 22);
            this.txtMaNguoiNhapHang.TabIndex = 16;
            // 
            // txtTenHangHoaNhap
            // 
            this.txtTenHangHoaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenHangHoaNhap.Location = new System.Drawing.Point(156, 134);
            this.txtTenHangHoaNhap.Name = "txtTenHangHoaNhap";
            this.txtTenHangHoaNhap.Size = new System.Drawing.Size(175, 22);
            this.txtTenHangHoaNhap.TabIndex = 18;
            // 
            // txtMaHangHoaNhap
            // 
            this.txtMaHangHoaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHangHoaNhap.Location = new System.Drawing.Point(156, 98);
            this.txtMaHangHoaNhap.Name = "txtMaHangHoaNhap";
            this.txtMaHangHoaNhap.Size = new System.Drawing.Size(175, 22);
            this.txtMaHangHoaNhap.TabIndex = 19;
            // 
            // cbbMaKho
            // 
            this.cbbMaKho.FormattingEnabled = true;
            this.cbbMaKho.Location = new System.Drawing.Point(541, 30);
            this.cbbMaKho.Name = "cbbMaKho";
            this.cbbMaKho.Size = new System.Drawing.Size(175, 21);
            this.cbbMaKho.TabIndex = 21;
            // 
            // rtbNoiDungNhapHang
            // 
            this.rtbNoiDungNhapHang.Location = new System.Drawing.Point(541, 64);
            this.rtbNoiDungNhapHang.Name = "rtbNoiDungNhapHang";
            this.rtbNoiDungNhapHang.Size = new System.Drawing.Size(386, 129);
            this.rtbNoiDungNhapHang.TabIndex = 22;
            this.rtbNoiDungNhapHang.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(21, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Số lượng:";
            // 
            // txtSoLuongNhapHang
            // 
            this.txtSoLuongNhapHang.Location = new System.Drawing.Point(156, 171);
            this.txtSoLuongNhapHang.Name = "txtSoLuongNhapHang";
            this.txtSoLuongNhapHang.Size = new System.Drawing.Size(175, 20);
            this.txtSoLuongNhapHang.TabIndex = 24;
            // 
            // btnTimkiemNhapHang
            // 
            this.btnTimkiemNhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiemNhapHang.Image")));
            this.btnTimkiemNhapHang.Location = new System.Drawing.Point(722, 469);
            this.btnTimkiemNhapHang.Name = "btnTimkiemNhapHang";
            this.btnTimkiemNhapHang.Size = new System.Drawing.Size(103, 44);
            this.btnTimkiemNhapHang.TabIndex = 28;
            this.btnTimkiemNhapHang.Text = "Tìm Kiếm";
            // 
            // btnXoaNhapHang
            // 
            this.btnXoaNhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNhapHang.Image")));
            this.btnXoaNhapHang.Location = new System.Drawing.Point(618, 469);
            this.btnXoaNhapHang.Name = "btnXoaNhapHang";
            this.btnXoaNhapHang.Size = new System.Drawing.Size(103, 44);
            this.btnXoaNhapHang.TabIndex = 27;
            this.btnXoaNhapHang.Text = "Xóa";
            // 
            // btnSuaNhapHang
            // 
            this.btnSuaNhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaNhapHang.Image")));
            this.btnSuaNhapHang.Location = new System.Drawing.Point(514, 469);
            this.btnSuaNhapHang.Name = "btnSuaNhapHang";
            this.btnSuaNhapHang.Size = new System.Drawing.Size(103, 44);
            this.btnSuaNhapHang.TabIndex = 26;
            this.btnSuaNhapHang.Text = "Sửa";
            // 
            // btnHuyNhapHang
            // 
            this.btnHuyNhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyNhapHang.Image")));
            this.btnHuyNhapHang.Location = new System.Drawing.Point(825, 469);
            this.btnHuyNhapHang.Name = "btnHuyNhapHang";
            this.btnHuyNhapHang.Size = new System.Drawing.Size(103, 44);
            this.btnHuyNhapHang.TabIndex = 29;
            this.btnHuyNhapHang.Text = "Hủy";
            // 
            // btnThemNhapHang
            // 
            this.btnThemNhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhapHang.Image")));
            this.btnThemNhapHang.Location = new System.Drawing.Point(410, 470);
            this.btnThemNhapHang.Name = "btnThemNhapHang";
            this.btnThemNhapHang.Size = new System.Drawing.Size(103, 44);
            this.btnThemNhapHang.TabIndex = 25;
            this.btnThemNhapHang.Text = "Thêm";
            // 
            // UC_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.btnHuyNhapHang);
            this.Controls.Add(this.btnTimkiemNhapHang);
            this.Controls.Add(this.btnXoaNhapHang);
            this.Controls.Add(this.btnSuaNhapHang);
            this.Controls.Add(this.btnThemNhapHang);
            this.Controls.Add(this.txtSoLuongNhapHang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbNoiDungNhapHang);
            this.Controls.Add(this.cbbMaKho);
            this.Controls.Add(this.txtMaHangHoaNhap);
            this.Controls.Add(this.txtTenHangHoaNhap);
            this.Controls.Add(this.txtMaNguoiNhapHang);
            this.Controls.Add(this.txtMaNguoiGiaoNhapHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControlNhapHang);
            this.Controls.Add(this.lbcNhapKho);
            this.Name = "UC_NhapHang";
            this.Size = new System.Drawing.Size(931, 534);
            this.Load += new System.EventHandler(this.UC_NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbcNhapKho;
        private DevExpress.XtraGrid.GridControl gridControlNhapHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaNguoiGiaoNhapHang;
        private System.Windows.Forms.TextBox txtMaNguoiNhapHang;
        private System.Windows.Forms.TextBox txtTenHangHoaNhap;
        private System.Windows.Forms.TextBox txtMaHangHoaNhap;
        private System.Windows.Forms.ComboBox cbbMaKho;
        private System.Windows.Forms.RichTextBox rtbNoiDungNhapHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuongNhapHang;
        private DevExpress.XtraEditors.SimpleButton btnTimkiemNhapHang;
        private DevExpress.XtraEditors.SimpleButton btnXoaNhapHang;
        private DevExpress.XtraEditors.SimpleButton btnSuaNhapHang;
        private DevExpress.XtraEditors.SimpleButton btnHuyNhapHang;
        private DevExpress.XtraEditors.SimpleButton btnThemNhapHang;
    }
}
