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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrangChu_DanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrangChu_DanhSach
            // 
            this.dgvTrangChu_DanhSach.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTrangChu_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrangChu_DanhSach.Location = new System.Drawing.Point(3, 0);
            this.dgvTrangChu_DanhSach.Name = "dgvTrangChu_DanhSach";
            this.dgvTrangChu_DanhSach.Size = new System.Drawing.Size(925, 472);
            this.dgvTrangChu_DanhSach.TabIndex = 0;
            // 
            // UC_TrangChu_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTrangChu_DanhSach);
            this.MaximumSize = new System.Drawing.Size(931, 534);
            this.MinimumSize = new System.Drawing.Size(931, 534);
            this.Name = "UC_TrangChu_DanhSach";
            this.Size = new System.Drawing.Size(931, 534);
            this.Load += new System.EventHandler(this.UC_TrangChu_DanhSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrangChu_DanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrangChu_DanhSach;
    }
}
