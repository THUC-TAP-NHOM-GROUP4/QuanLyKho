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
    public partial class UC_ThongKe_Chung : UserControl
    {
        private Controllers control;
        public UC_ThongKe_Chung()
        {
            InitializeComponent();
            this.control = new Controllers();
        }

        private void UC_ThongKe_Nam_Load(object sender, EventArgs e)
        {
            chartDoanhThu_Nam.Series["Nhập"].Points.Clear();
            chartDoanhThu_Nam.Series["Xuất"].Points.Clear();
            int[] nam = control.getNam();
            int i;
            for(i= 0; i< nam.Length; i++)
            {
                chartDoanhThu_Nam.Series["Nhập"].Points.AddXY("Năm " + nam[i], control.getDoanhThu_Nhap(nam[i]));
                chartDoanhThu_Nam.Series["Xuất"].Points.AddXY("Năm " + nam[i], control.getDoanhThu_Xuat(nam[i]));
            }

        }
    }
}
