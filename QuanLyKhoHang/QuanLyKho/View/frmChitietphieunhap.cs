using QuanLyKho.Controller;
using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho.View
{
    public partial class frmChitietphieunhap : Form
    {
        public frmChitietphieunhap()
        {
            InitializeComponent();
            cbbmakho.DataSource = hl.Convert(da.Query("select ma from Kho"));
            cbbmahanghoa.DataSource = hl.Convert(da.Query("select ma from Hanghoa"));
            dgvdanhsachchitietphieunhap.DataSource = da.Query("DanhSachChiTietPhieuNhap");
        }
        Hepl hl = new Hepl();
        DataAccess da = new DataAccess();
        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            string[] str = { cbbmahanghoa.Text, cbbmakho.Text, txtdongia.Text, txtsoluong.Text };
            if(hl.Dieukhien(str)==1)
            {
                ChitietPhieuNhap chitiet = new ChitietPhieuNhap();
                chitiet.hanghoama = cbbmahanghoa.Text;
                chitiet.khoma = cbbmakho.Text;
                chitiet.dongia = float.Parse(txtdongia.Text);
                chitiet.soluong = int.Parse(txtsoluong.Text);
                chitiet.ThemVaoChitiet(chitiet.hanghoama, chitiet.khoma, chitiet.soluong, chitiet.dongia);
                MessageBox.Show("Thành công");
                dgvdanhsachchitietphieunhap.DataSource = da.Query("DanhSachChiTietPhieuNhap");
            }
        }

        private void frmChitietphieunhap_Load(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
