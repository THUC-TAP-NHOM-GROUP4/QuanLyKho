using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    public class PhieuXuat
    {
        public PhieuXuat() { }
        public string Ma { get; set; }
        public DateTime Ngay { get; set; }
        public string KhoMa { get; set; }
        public string NoiDung { get; set; }
        public string KhachHangMa { get; set; }
        public string NhanVienMa { get; set; }
        public double TongTien { get; set; }
    }
}
