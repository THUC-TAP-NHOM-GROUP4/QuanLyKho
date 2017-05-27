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
using System.Data.SqlClient;

namespace QuanLyKho.View
{
    public partial class UC_NhapHang : UserControl
    {
        public UC_NhapHang()
        {
            InitializeComponent();
            gridControlNhapHang.DataSource = da.Query("ProcGetList");
        }
        DataAccess da = new DataAccess();

        private void UC_NhapHang_Load(object sender, EventArgs e)
        {
            cbbmakho.DataSource = hl.Convert(da.Query("select ma from Kho"));
            cbbmanguoinhaphang.DataSource = hl.Convert(da.Query("select ma from NhanVien"));
            cbbmanhacungcap.DataSource = hl.Convert(da.Query("select ma from NhaCungCap"));
            cbbmanhom.DataSource = hl.Convert(da.Query("select ma from Nhom"));
        }
        Hepl hl = new Hepl();
       
        private void btnThemNhapHang_Click(object sender, EventArgs e)
        {
            string[] str = { txtMaNguoiGiaoNhapHang.Text, cbbmanguoinhaphang.Text, txtMaHangHoaNhap.Text, txtTenHangHoaNhap.Text, txtSoLuongNhapHang.Text, txtdongia.Text, cbbmakho.Text, cbbmanhom.Text, rtbNoiDungNhapHang.Text };
            if (hl.Dieukhien(str) == 1)
            {
                PhieuNhap pn = new PhieuNhap();
                HangHoa hh = new HangHoa();
               
                pn.NguoiGiaoMa = txtMaNguoiGiaoNhapHang.Text;
                pn.NhaCungCapMa = cbbmanhacungcap.Text;
                pn.NhanVienMa = cbbmanguoinhaphang.Text;
                pn.NoiDung = rtbNoiDungNhapHang.Text;
                pn.KhoMa = cbbmakho.Text;
                hh.Ma = txtMaHangHoaNhap.Text;
                hh.Ten = txtTenHangHoaNhap.Text;
                hh.NhomMa = cbbmanhom.Text;
                hh.Soluong = int.Parse(txtSoLuongNhapHang.Text);
                hh.Dongia = float.Parse(txtdongia.Text);
                pn.Ngay = DateTime.Parse(txtngaynhap.Text);
                da.NonQuery("ProcInsert", new SqlParameter("@manguoigiaohang", pn.NguoiGiaoMa),
                                        new SqlParameter("@manguoinhaphang", pn.NhanVienMa),
                                        new SqlParameter("@mahanghoa", hh.Ma),
                                        new SqlParameter("@tenhanghoa", hh.Ten),
                                        new SqlParameter("@soluong", hh.Soluong),
                                        new SqlParameter("@manhom", hh.NhomMa),
                                        new SqlParameter("@dongia", hh.Dongia),
                                        new SqlParameter("@manhacungcap", pn.NhaCungCapMa),
                                        new SqlParameter("@makho", pn.KhoMa),
                                        new SqlParameter("@ngaynhap", pn.Ngay),
                                        new SqlParameter("@noidungnhap", pn.NoiDung));
                MessageBox.Show("Thành công");
                gridControlNhapHang.DataSource = da.Query("ProcGetList");

            }
             else
                MessageBox.Show("Vui long dien day du thong tin");
        }


        private void txtSoLuongNhapHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                txtSoLuongNhapHang.Text = " ";
        }

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                txtdongia.Text = " ";
        }

        private void txtngaynhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuyNhapHang_Click(object sender, EventArgs e)
        {
            txtMaHangHoaNhap.Text = "";
            txtMaNguoiGiaoNhapHang.Text = "";
            txtngaynhap.Text = "";
            txtdongia.Text = "";
            txtSoLuongNhapHang.Text = "";
            rtbNoiDungNhapHang.Text = "";
            txtTenHangHoaNhap.Text = "";
        }
    }
}
