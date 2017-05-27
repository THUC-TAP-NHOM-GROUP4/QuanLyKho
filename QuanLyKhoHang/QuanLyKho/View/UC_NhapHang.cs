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
            cbbhanghoama.DataSource = hl.Convert(da.Query("select ma from Hanghoa"));
        }
        Hepl hl = new Hepl();
        List<ChitietPhieuNhap> lst = new List<ChitietPhieuNhap>();
        private void btnThemNhapHang_Click(object sender, EventArgs e)
        {
            string[] str = { txtMaNguoiGiaoNhapHang.Text, cbbmanguoinhaphang.Text, cbbhanghoama.Text,  txtSoLuongNhapHang.Text, txtdongia.Text, cbbmakho.Text, cbbmanhom.Text, rtbNoiDungNhapHang.Text };
            if (hl.Dieukhien(str) == 1)
            {
                PhieuNhap pn = new PhieuNhap();
                HangHoa hh = new HangHoa();

                ChitietPhieuNhap ctpn = new ChitietPhieuNhap();
                ctpn.hanghoama = cbbhanghoama.Text;
                ctpn.khoma = cbbmakho.Text;
                ctpn.soluong =int.Parse( txtSoLuongNhapHang.Text);
                ctpn.dongia = float.Parse(txtdongia.Text);
                lst.Add(ctpn);
                MessageBox.Show("Thành công");
               

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
            cbbhanghoama.Text = "";
            txtMaNguoiGiaoNhapHang.Text = "";
            txtngaynhap.Text = "";
            txtdongia.Text = "";
            txtSoLuongNhapHang.Text = "";
            rtbNoiDungNhapHang.Text = "";
           
        }

        private void btnLuulai_Click(object sender, EventArgs e)
        {
            PhieuNhap pn = new PhieuNhap();
            pn.NhanVienMa = cbbmanguoinhaphang.Text;
            pn.Ngay = DateTime.Parse(txtngaynhap.Text);
            pn.NhaCungCapMa = cbbmanhacungcap.Text;
            pn.NguoiGiaoMa = txtMaNguoiGiaoNhapHang.Text;
            pn.NoiDung = rtbNoiDungNhapHang.Text;
            pn.KhoMa = cbbmakho.Text;
            pn.ThemPhieuNhap(pn.NhanVienMa, pn.Ngay, pn.NhaCungCapMa, pn.NguoiGiaoMa, pn.NoiDung, pn.KhoMa);
            foreach(var item in lst)
            {
                ChitietPhieuNhap chitiet = new ChitietPhieuNhap();
                chitiet.hanghoama = item.hanghoama;
                chitiet.soluong = item.soluong;
                chitiet.dongia = item.dongia;
                chitiet.ThemVaoChitiet(chitiet.hanghoama, chitiet.soluong, chitiet.dongia);
            }
            MessageBox.Show("Thanh cong");
            gridControlNhapHang.DataSource = da.Query("ProcGetList");
        }
    }
}
