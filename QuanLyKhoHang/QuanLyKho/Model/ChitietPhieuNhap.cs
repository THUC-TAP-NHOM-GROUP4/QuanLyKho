using QuanLyKho.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    class ChitietPhieuNhap
    {
       public string ma { get; set; }
        public string phieunhapma { get; set; }
        public string hanghoama { get; set; }
        public string khoma { get; set; }
        public int soluong { get; set; }
        public float dongia { get; set; }
        public double thanhtien { get; set; }
        public List<ChitietPhieuNhap> DSChiTietPhieuNhap { get; set; }
        DataAccess da = new DataAccess();
        public void ThemVaoChitiet(string hanghoama, string khoma, int soluong, float dongia)
        {
            da.NonQuery("ThemVaoChiTietPhieuNhap", new SqlParameter("@hanghoama", hanghoama),
                                                   new SqlParameter("@khoma", khoma),
                                                   new SqlParameter("@soluong", soluong),
                                                   new SqlParameter("@dongia", dongia));
        }
    }
}
