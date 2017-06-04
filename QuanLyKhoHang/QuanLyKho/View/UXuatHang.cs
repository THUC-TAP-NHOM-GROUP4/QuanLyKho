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
        DataTable dt = new DataTable();
        public UXuatHang()
        {
            InitializeComponent();
        }
        private void tabPhieuXuatload()
        {

            dt.Columns.Add("mã hàng", typeof(string));
            dt.Columns.Add("mã kho", typeof(string));
            dt.Columns.Add("số lượng", typeof(string));
            dt.Columns.Add("thành tiền", typeof(string));

            PhieuXuat px = new PhieuXuat();
            lbMaPhieuXuat.Text = "Mã Phiếu Xuất: "+control.get_PXma(px);
            cbbPhieuXuatMaNhanVien.DataSource = control.getList_NhanVien();
            cbbPhieuXuatMaNhanVien.DisplayMember = "ma";
            cbbPhieuXuatMaNhanVien.ValueMember = "ma";
            gridControlXuatHang.DataSource = dt;
           
        }
        private void UXuatHang_Load(object sender, EventArgs e)
        {
            tabPhieuXuatload();
            cbbPhieuXuatMaKhachHang.DataSource = control.getList_KhachHang_Ma();
            cbbPhieuXuatMaKhachHang.DisplayMember = "ma";
            cbbPhieuXuatMaKhachHang.ValueMember = "ma";
            cbbPhieuXuatMaKho.DataSource = control.getList_Kho();
            cbbPhieuXuatMaKho.DisplayMember = "ma";
            cbbPhieuXuatMaKho.ValueMember = "ma";
            cbbPhieuXuatMaHang.DataSource = control.getList_HangHoaPhieuXuat();
            cbbPhieuXuatMaHang.DisplayMember = "ma";
            cbbPhieuXuatMaHang.ValueMember = "ma";          
            gridControlXuatHang.DataSource = lsHTPX;

        }
        public bool KiemTra()
        {

            if (cbbPhieuXuatMaNhanVien.Text.ToString().Trim().Equals(""))
            {
                errMaNguoiXuatHang.SetError(cbbPhieuXuatMaNhanVien, "Nhap ma nguoi xuat");
                return false;
            }
            errMaNguoiXuatHang.Clear();
           
            errMaNguoiNhanHang.Clear();

            if (cbbPhieuXuatMaKhachHang.Text.ToString().Trim().Equals(""))
            {
                errMaKhachHang.SetError(cbbPhieuXuatMaKhachHang, "Nhap ma nguoi nhan");
                return false;
            }
            errMaKhachHang.Clear();

            if (cbbPhieuXuatMaHang.Text.ToString().Trim().Equals(""))
            {
                errMaHangHoa.SetError(cbbPhieuXuatMaHang, "Nhap ma hang");
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

            if (cbbPhieuXuatMaKho.Text.ToString().Trim().Equals(""))
            {
                errMaKho.SetError(cbbPhieuXuatMaKho, "Nhap ten hang");
                return false;
            }
            errMaKho.Clear();

            if (cbbNoiDungXuat.Text.ToString().Trim().Equals(""))
            {
                errNoiDungXuatHang.SetError(cbbNoiDungXuat, "chọn nội dung xuất");
                return false;
            }
            errNoiDungXuatHang.Clear();
            return true;
        }

        double tongtienpx = 0;
        
        private void btnThemXuatHang_Click(object sender, EventArgs e)
        {
         
            HangHoa hh = new HangHoa();

            if (KiemTra())
            {
                if (int.Parse(txtSoLuongHangXuat.Text.ToString().Trim()) == 0)
                    MessageBox.Show("Vui lòng kiểm tra lại số lượng!");
                else
                {
                    int row = gridViewXuatHang.DataRowCount + 1;
                    double soluong = 0, dongia = 0, thanhtien = 0;
                
                    double.TryParse(txtSoLuongHangXuat.Text, out soluong);
                    double.TryParse(txtPhieuXuatDonGia.Text, out dongia);


                    ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat();
                    ctpx.HangHoaMa = cbbPhieuXuatMaHang.Text.ToString().Trim();
                    ctpx.SoLuong = int.Parse(txtSoLuongHangXuat.Text.ToString().Trim());
                    ctpx.KhoMa = cbbPhieuXuatMaKho.Text.ToString().Trim();
                    gridControlXuatHang.DataSource = dt;
                     thanhtien = soluong * dongia;
                    ctpx.ThanhTien = thanhtien;
                    dt.Rows.Add(ctpx.HangHoaMa,ctpx.KhoMa, ctpx.SoLuong.ToString(), ctpx.ThanhTien.ToString());
                    tongtienpx += thanhtien;
                }
            }
            txtPhieuXuatTongTien.Text = tongtienpx.ToString();
        }
      
        private void btnSuaXuat_Click(object sender, EventArgs e)
        {

        }

        private void cbbPhieuXuatMaKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPhieuXuatTenKhachHang.Text = control.getTenKhachHang(cbbPhieuXuatMaKhachHang.Text.ToString().Trim());
        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbbPhieuXuatMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtTenHang.Text = control.getTenHang(cbbPhieuXuatMaHang.Text.ToString().Trim());
            txtPhieuXuatDonGia.Text = control.getDonGia(cbbPhieuXuatMaHang.Text.ToString().Trim());
            cbbPhieuXuatMaKho.Text = control.getKhoMa(cbbPhieuXuatMaHang.Text.ToString());

        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {

            PhieuXuat px = new PhieuXuat();
            px.Ma = control.get_PXma(px);
            px.KhachHangMa = cbbPhieuXuatMaKhachHang.SelectedValue.ToString().Trim();
            px.NoiDung = cbbNoiDungXuat.Text.ToString().Trim();
            px.KhoMa = cbbPhieuXuatMaKho.Text.ToString().Trim();
            px.NhanVienMa = cbbPhieuXuatMaNhanVien.SelectedValue.ToString().Trim();
            if (txtPhieuXuatTongTien.Text == "")
            {
                MessageBox.Show("Yêu cầu kiểm tra thông tin xuất hàng");
            }
            else
            {
                px.TongTien = float.Parse(txtPhieuXuatTongTien.Text.ToString().Trim());

                control.insertPX(px);
               // int hesoquydoi = 0;
                ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat();
                foreach (DataRow row in dt.Rows)
                {

                    ctpx.HangHoaMa = row[0].ToString();
                    ctpx.KhoMa = row[1].ToString();
                    ctpx.SoLuong = int.Parse(row[2].ToString());
                    double dongia = 0;
                    double.TryParse(row[3].ToString(), out dongia);
                    ctpx.DonGia = dongia;
                    control.insertChiTietPX(ctpx, px.Ma);


                }

                MessageBox.Show("Đã lưu hóa đơn!");
            }
         }

        private void sbtnHuyXuat_Click(object sender, EventArgs e)
        {
            this.gridControlXuatHang.DataSource = null;

        }

        private void txtSoLuongHangXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
