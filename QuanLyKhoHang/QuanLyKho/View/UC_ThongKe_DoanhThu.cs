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
            int[] nam = control.getNam();
            cbbThongKe_nam.DataSource = control.getNam();
            chartDoanhThu.Series["Nhập"].Points.Clear();
            chartDoanhThu.Series["Xuất"].Points.Clear();
            for (int i = 1; i <= 12; i++)
            {
                chartDoanhThu.Series["Nhập"].Points.AddXY("Tháng " + (i + 1), control.getDoanhThu_Nhap(i, nam[0]));
                chartDoanhThu.Series["Xuất"].Points.AddXY("Tháng " + (i + 1), control.getDoanhThu_Xuat(i, nam[0]));
            }
        }

        private void cbbThongKe_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartDoanhThu.Series["Nhập"].Points.Clear();
            chartDoanhThu.Series["Xuất"].Points.Clear();
            for (int i = 0; i < 12; i++)
            {
                chartDoanhThu.Series["Nhập"].Points.AddXY("Tháng " + (i+1), control.getDoanhThu_Nhap(i, int.Parse(cbbThongKe_nam.Text.ToString())));
                chartDoanhThu.Series["Xuất"].Points.AddXY("Tháng " + (i+1), control.getDoanhThu_Xuat(i, int.Parse(cbbThongKe_nam.Text.ToString())));
            }
        }
    }
}
