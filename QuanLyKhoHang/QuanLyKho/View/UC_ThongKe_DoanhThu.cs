using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.View;
using QuanLyKho.Controller;

namespace QuanLyKho.View
{
    public partial class UC_ThongKe_DoanhThu : UserControl
    {
        Controllers control = new Controllers();
        public UC_ThongKe_DoanhThu()
        {
            InitializeComponent();
        }

        private void UC_ThongKe_DoanhThu_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                chartDoanhThu.Series["Nhập"].Points.AddXY("Tháng " + i, control.getDoanhThu_Nhap(i, 2015));
                chartDoanhThu.Series["Xuất"].Points.AddXY("Tháng " + i, control.getDoanhThu_Xuat(i, 2015));
            }
        }
    }
}
