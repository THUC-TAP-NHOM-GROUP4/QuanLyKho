using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    public class NhanVien
    {
        public String Ma { get; set; }
        public String Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public String DiaChi { get; set; }
        public String DienThoai { get; set; }
        public String ChucVu { get; set; }
    }
}
