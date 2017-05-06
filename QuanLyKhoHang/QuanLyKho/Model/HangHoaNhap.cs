using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    public  class HangHoaNhap
    {
        public String Ma { get; set; }
        public String Ten { get; set; }
        public String PhieuNhapMa { get; set;}
        public String ChiTietPhieuNhapMa { get; set; }
        public DateTime NgayNhap { get; set; }
        public Double SoLuong { get; set; }
        public Double DonGia { get; set; }
        public Double ThanhTien { get; set; }
        public String TenNhanVien { get; set; }
    }
}
