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
            this.txtTenHangHoaNhap = new System.Windows.Forms.TextBox();
            this.txtMaHangHoaNhap = new System.Windows.Forms.TextBox();
            this.rtbNoiDungNhapHang = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuongNhapHang = new System.Windows.Forms.TextBox();
            this.btnHuyNhapHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemNhapHang = new DevExpress.XtraEditors.SimpleButton();
            this.lbnhomma = new System.Windows.Forms.Label();
            this.lbdongia = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtngaynhap = new System.Windows.Forms.TextBox();
            this.cbbmanguoinhaphang = new System.Windows.Forms.ComboBox();
            this.cbbmanhom = new System.Windows.Forms.ComboBox();
            this.cbbmakho = new System.Windows.Forms.ComboBox();
            this.lbmanhacungcap = new System.Windows.Forms.Label();
            this.cbbmanhacungcap = new System.Windows.Forms.ComboBox();
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
            this.gridControlNhapHang.Location = new System.Drawing.Point(4, 253);
            this.gridControlNhapHang.MainView = this.gridView1;
            this.gridControlNhapHang.Name = "gridControlNhapHang";
            this.gridControlNhapHang.Size = new System.Drawing.Size(923, 210);
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
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Người giao hàng:";
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
            this.label3.Location = new System.Drawing.Point(380, 140);
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
            this.label6.Location = new System.Drawing.Point(380, 112);
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
            // rtbNoiDungNhapHang
            // 
            this.rtbNoiDungNhapHang.Location = new System.Drawing.Point(523, 160);
            this.rtbNoiDungNhapHang.Name = "rtbNoiDungNhapHang";
            this.rtbNoiDungNhapHang.Size = new System.Drawing.Size(386, 87);
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
            this.txtSoLuongNhapHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongNhapHang_KeyPress);
            // 
            // btnHuyNhapHang
            // 
            this.btnHuyNhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyNhapHang.Image")));
            this.btnHuyNhapHang.Location = new System.Drawing.Point(824, 460);
            this.btnHuyNhapHang.Name = "btnHuyNhapHang";
            this.btnHuyNhapHang.Size = new System.Drawing.Size(103, 44);
            this.btnHuyNhapHang.TabIndex = 29;
            this.btnHuyNhapHang.Text = "Hủy";
            this.btnHuyNhapHang.Click += new System.EventHandler(this.btnHuyNhapHang_Click);
            // 
            // btnThemNhapHang
            // 
            this.btnThemNhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhapHang.Image")));
            this.btnThemNhapHang.Location = new System.Drawing.Point(720, 460);
            this.btnThemNhapHang.Name = "btnThemNhapHang";
            this.btnThemNhapHang.Size = new System.Drawing.Size(103, 44);
            this.btnThemNhapHang.TabIndex = 25;
            this.btnThemNhapHang.Text = "Thêm";
            this.btnThemNhapHang.Click += new System.EventHandler(this.btnThemNhapHang_Click);
            // 
            // lbnhomma
            // 
            this.lbnhomma.AutoSize = true;
            this.lbnhomma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbnhomma.Location = new System.Drawing.Point(24, 211);
            this.lbnhomma.Name = "lbnhomma";
            this.lbnhomma.Size = new System.Drawing.Size(63, 16);
            this.lbnhomma.TabIndex = 30;
            this.lbnhomma.Text = "Mã nhóm";
            // 
            // lbdongia
            // 
            this.lbdongia.AutoSize = true;
            this.lbdongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbdongia.Location = new System.Drawing.Point(380, 85);
            this.lbdongia.Name = "lbdongia";
            this.lbdongia.Size = new System.Drawing.Size(54, 16);
            this.lbdongia.TabIndex = 32;
            this.lbdongia.Text = "Đơn giá";
            // 
            // txtdongia
            // 
            this.txtdongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdongia.Location = new System.Drawing.Point(523, 85);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(175, 22);
            this.txtdongia.TabIndex = 33;
            this.txtdongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongia_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(380, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Ngày nhập";
            // 
            // txtngaynhap
            // 
            this.txtngaynhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtngaynhap.Location = new System.Drawing.Point(523, 59);
            this.txtngaynhap.Name = "txtngaynhap";
            this.txtngaynhap.Size = new System.Drawing.Size(175, 22);
            this.txtngaynhap.TabIndex = 36;
            this.txtngaynhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtngaynhap_KeyPress);
            // 
            // cbbmanguoinhaphang
            // 
            this.cbbmanguoinhaphang.FormattingEnabled = true;
            this.cbbmanguoinhaphang.Location = new System.Drawing.Point(157, 68);
            this.cbbmanguoinhaphang.Name = "cbbmanguoinhaphang";
            this.cbbmanguoinhaphang.Size = new System.Drawing.Size(174, 21);
            this.cbbmanguoinhaphang.TabIndex = 37;
            // 
            // cbbmanhom
            // 
            this.cbbmanhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbmanhom.FormattingEnabled = true;
            this.cbbmanhom.Location = new System.Drawing.Point(156, 211);
            this.cbbmanhom.Name = "cbbmanhom";
            this.cbbmanhom.Size = new System.Drawing.Size(175, 24);
            this.cbbmanhom.TabIndex = 38;
            // 
            // cbbmakho
            // 
            this.cbbmakho.FormattingEnabled = true;
            this.cbbmakho.Location = new System.Drawing.Point(523, 111);
            this.cbbmakho.Name = "cbbmakho";
            this.cbbmakho.Size = new System.Drawing.Size(175, 21);
            this.cbbmakho.TabIndex = 39;
            // 
            // lbmanhacungcap
            // 
            this.lbmanhacungcap.AutoSize = true;
            this.lbmanhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbmanhacungcap.Location = new System.Drawing.Point(383, 37);
            this.lbmanhacungcap.Name = "lbmanhacungcap";
            this.lbmanhacungcap.Size = new System.Drawing.Size(110, 16);
            this.lbmanhacungcap.TabIndex = 40;
            this.lbmanhacungcap.Text = "Mã nhà cung cấp";
            // 
            // cbbmanhacungcap
            // 
            this.cbbmanhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbmanhacungcap.FormattingEnabled = true;
            this.cbbmanhacungcap.Location = new System.Drawing.Point(523, 30);
            this.cbbmanhacungcap.Name = "cbbmanhacungcap";
            this.cbbmanhacungcap.Size = new System.Drawing.Size(175, 24);
            this.cbbmanhacungcap.TabIndex = 41;
            // 
            // UC_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.cbbmanhacungcap);
            this.Controls.Add(this.lbmanhacungcap);
            this.Controls.Add(this.cbbmakho);
            this.Controls.Add(this.cbbmanhom);
            this.Controls.Add(this.cbbmanguoinhaphang);
            this.Controls.Add(this.txtngaynhap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.lbdongia);
            this.Controls.Add(this.lbnhomma);
            this.Controls.Add(this.btnHuyNhapHang);
            this.Controls.Add(this.btnThemNhapHang);
            this.Controls.Add(this.txtSoLuongNhapHang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbNoiDungNhapHang);
            this.Controls.Add(this.txtMaHangHoaNhap);
            this.Controls.Add(this.txtTenHangHoaNhap);
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
        private System.Windows.Forms.TextBox txtTenHangHoaNhap;
        private System.Windows.Forms.TextBox txtMaHangHoaNhap;
        private System.Windows.Forms.RichTextBox rtbNoiDungNhapHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuongNhapHang;
        private DevExpress.XtraEditors.SimpleButton btnHuyNhapHang;
        private DevExpress.XtraEditors.SimpleButton btnThemNhapHang;
        private System.Windows.Forms.Label lbnhomma;
        private System.Windows.Forms.Label lbdongia;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtngaynhap;
        private System.Windows.Forms.ComboBox cbbmanguoinhaphang;
        private System.Windows.Forms.ComboBox cbbmanhom;
        private System.Windows.Forms.ComboBox cbbmakho;
        private System.Windows.Forms.Label lbmanhacungcap;
        private System.Windows.Forms.ComboBox cbbmanhacungcap;
    }
}
