using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.Controller;

namespace QuanLyKho.View
{
    public partial class UC_TrangChu_DanhSach : UserControl
    {
        private Controllers control;
        public UC_TrangChu_DanhSach()
        {
            InitializeComponent();
            this.control = new Controllers();
        }

        private void UC_TrangChu_DanhSach_Load(object sender, EventArgs e)
        {
            dgvTrangChu_DanhSach.DataSource = control.getList_HangHoa();

            dgvTrangChu_DanhSach.Columns["ma"].HeaderText = "Mã";
            dgvTrangChu_DanhSach.Columns["ten"].HeaderText = "Tên hàng hóa";
            dgvTrangChu_DanhSach.Columns["phieunhapma"].HeaderText = "Phiếu nhập";
            dgvTrangChu_DanhSach.Columns["chitietphieunhapma"].HeaderText = "Chi tiết phiếu nhập(mã)";
            dgvTrangChu_DanhSach.Columns["ngaynhap"].HeaderText = "Ngày nhập";
            dgvTrangChu_DanhSach.Columns["soluong"].HeaderText = "Số lượng";
            dgvTrangChu_DanhSach.Columns["dongia"].HeaderText = "Đơn giá";
            dgvTrangChu_DanhSach.Columns["thanhtien"].HeaderText = "Thành tiền";
            dgvTrangChu_DanhSach.Columns["tennhanvien"].HeaderText = "Nhân viên";

            dgvTrangChu_DanhSach.Columns["ma"].Width = 50;
            dgvTrangChu_DanhSach.Columns["soluong"].Width = 80;
            dgvTrangChu_DanhSach.Columns["chitietphieunhapma"].Width = 150;
        }
    }
}
