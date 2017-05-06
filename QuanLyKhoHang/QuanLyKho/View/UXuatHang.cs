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
using QuanLyKho.Model;

namespace QuanLyKho.View
{
    public partial class UXuatHang : UserControl
    {

        Controllers control = new Controllers();
        List<HienThiPhieuXuat> lsHTPX = new List<Model.HienThiPhieuXuat>();

        public UXuatHang()
        {
            InitializeComponent();
        }

        private void UXuatHang_Load(object sender, EventArgs e)
        {
            lsHTPX = control.getHTPX();
            gridControlXuatHang.DataSource = lsHTPX;

        }
        public bool KiemTra()
        {

            if (txtMaNguoiXuatHang.Text.ToString().Trim().Equals(""))
            {
                errMaNguoiXuatHang.SetError(txtMaNguoiXuatHang, "Nhap ma nguoi xuat");
                return false;
            }
            errMaNguoiXuatHang.Clear();
            if (txtMaNguoiNhanHang.Text.ToString().Trim().Equals(""))
            {
                errMaNguoiNhanHang.SetError(txtMaNguoiNhanHang, "Nhap ma nguoi nhan");
                return false;
            }
            errMaNguoiNhanHang.Clear();

            if (txtMaKhachHang.Text.ToString().Trim().Equals(""))
            {
                errMaKhachHang.SetError(txtMaKhachHang, "Nhap ma nguoi nhan");
                return false;
            }
            errMaKhachHang.Clear();

            if (txtMaHangHoaXuat.Text.ToString().Trim().Equals(""))
            {
                errMaHangHoa.SetError(txtMaHangHoaXuat, "Nhap ma hang");
                return false;
            }
            errMaHangHoa.Clear();

            if (txtTenHang.Text.ToString().Trim().Equals(""))
            {
                errTenHangHoa.SetError(txtTenHang, "Nhap ten hang");
                return false;
            }
            errTenHangHoa.Clear();


            if (txtSoLuongHangXuat.Text.ToString().Trim().Equals(""))
            {
                errSoLuongHang.SetError(txtSoLuongHangXuat, "Nhap ten hang");
                return false;
            }
            errSoLuongHang.Clear();

            if (cbbMaKho.Text.ToString().Trim().Equals(""))
            {
                errMaKho.SetError(cbbMaKho, "Nhap ten hang");
                return false;
            }
            errMaKho.Clear();

            if (rtbNoiDungXuatHang.Text.ToString().Trim().Equals(""))
            {
                errNoiDungXuatHang.SetError(rtbNoiDungXuatHang, "Nhap ten hang");
                return false;
            }
            errNoiDungXuatHang.Clear();
            return true;
        }
        private void btnThemXuatHang_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                PhieuXuat px = new PhieuXuat();

                px.KhoMa = cbbMaKho.Text.ToString().Trim();
                px.NguoiNhanMa = txtMaNguoiNhanHang.Text.ToString().Trim();
                px.NhanVienMa = txtMaNguoiXuatHang.Text.ToString().Trim();
                px.NoiDung = rtbNoiDungXuatHang.Text.ToString().Trim();
                px.KhachHangMa = txtMaKhachHang.Text.ToString().Trim();
                ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat();
                ctpx.HangHoaMa = txtMaHangHoaXuat.Text.ToString().Trim();
                ctpx.SoLuong = int.Parse(txtSoLuongHangXuat.Text.ToString().Trim());
                if (control.addPhieuXuat(px, ctpx))
                {
                    lsHTPX = control.getHTPX();
                    gridControlXuatHang.DataSource = lsHTPX;
                }
                else
                {
                    MessageBox.Show("Nhap phieu xuat khong thanh cong");
                }

            }
        }
    }
}
