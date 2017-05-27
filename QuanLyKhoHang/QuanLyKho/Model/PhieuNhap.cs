using QuanLyKho.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    public class PhieuNhap
    {
        public String Ma { get; set; }
        public DateTime Ngay { get; set; }
        public String NhaCungCapMa { get; set; }
        public String NguoiGiaoMa { get; set; }
        public String NoiDung { get; set; }
        public String KhoMa { get; set; }
        public String NhanVienMa { get; set; }
        
        DataAccess da = new DataAccess();
        public void ThemPhieuNhap(string nhanvienma, DateTime ngay, string nhacungcapma, string nguoigiao, string noidung,string khoma)
        {
            da.NonQuery("ThemPhieuNhap", new SqlParameter("@nhanvienma", nhanvienma),
                                         new SqlParameter("@ngay", ngay),
                                         new SqlParameter("@nhacungcapma", nhacungcapma),
                                         new SqlParameter("@nguoigiaoma", nguoigiao),
                                         new SqlParameter("@noidung", noidung),
                                         new SqlParameter("@khoma", khoma));
        }

    }
}
