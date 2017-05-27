using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Controller
{
    class Controllers
    {
        DataAccess da = new DataAccess();
        public NhanVien[] getList_NhanVien()
        {
            DataTable table = da.Query("select *from NhanVien");
            int n = table.Rows.Count;
            int i, gioitinh = 0;
            if (n == 0) return null;
            NhanVien[] list = new NhanVien[n];
            NhanVien nv = new NhanVien();
            for (i = 0; i < n; i++)
            {
                nv = new NhanVien();
                nv.Ma = table.Rows[i]["ma"].ToString().Trim();
                nv.Ten = table.Rows[i]["ten"].ToString().Trim();
              
                list[i] = nv;

            }
            return list;
        }
        public void insertChiTietPX(ChiTietPhieuXuat ctpx, string ma)
        {
            SqlParameter[] para =
        {
                new SqlParameter("phieuxuatma",ma),
                new SqlParameter("hanghoama",ctpx.HangHoaMa),
                new SqlParameter("soluong",ctpx.SoLuong),             
                new SqlParameter("dongia",ctpx.DonGia)


            };
            da.Query("procedure_insertChiTietPhieuXuat", para);

        }
        public void insertPX(PhieuXuat px)
        {
            SqlParameter[] para =
            {
               
               new SqlParameter("khoma",px.KhoMa),
               new SqlParameter("noidung",px.NoiDung),
               new SqlParameter("khachhangma",px.KhachHangMa),
               new SqlParameter("nhanvienma",px.NhanVienMa),
               new SqlParameter("tongtien",px.TongTien)

            };
            da.Query("procedure_insertPhieuXuat", para);
            
        }

        public string get_PXma(PhieuXuat px)
        {
            DataTable table = da.Query(" select dbo.auto_maPhieuXuat()as ma");
            string ma = "";
            if (table.Rows.Count == 1)
                return table.Rows[0]["ma"].ToString().Trim();
            return ma;
        }

        public List<HienThiPhieuXuat> getHTPX()
        {
            List<HienThiPhieuXuat> lsHTPX = new List<Model.HienThiPhieuXuat>();
            DataTable table = da.Query("select px.ma,px.khoma,px.khachhangma,px.manguoinhan,px.nhanvienma,px.noidung,ctpx.hanghoama,ctpx.soluong,ctpx.thanhtien from PhieuXuat px inner join ChiTietPhieuXuat ctpx on px.ma = ctpx.phieuxuatma");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;

            for (i = 0; i < n; i++)
            {
              
                lsHTPX.Add(getPX(table.Rows[i]));
            }
            return lsHTPX;
        }
        public HienThiPhieuXuat getPX(DataRow row)
        {
            HienThiPhieuXuat htpx = new HienThiPhieuXuat();
            htpx.maphieuxuat = row["ma"].ToString().Trim();
            htpx.makho = row["khoma"].ToString().Trim();

            htpx.makhachhang = row["khachhangma"].ToString().Trim();
            htpx.manguoinhan = row["manguoinhan"].ToString().Trim();
            htpx.manguoixuat = row["nhanvienma"].ToString().Trim();
            htpx.noidungxuat = row["noidung"].ToString().Trim();
            htpx.mahanghoa = row["hanghoama"].ToString().Trim();
            // htpx.tenhanghoa = row["tenhanghoa"].ToString().Trim();
            htpx.soluong = int.Parse(row["soluong"].ToString().Trim());
            float thanhtien = 0;
            float.TryParse(row["thanhtien"].ToString().Trim(), out thanhtien);
            htpx.thanhtien = thanhtien;

            return htpx;
        }
        public HangHoaNhap[] getList_HangHoa()
        {
            DataTable table = da.Query("select distinct hh.ma, hh.ten, pn.ma as [phieunhapma], ct.ma as [chitietphieunhapma], pn.ngay, ct.soluong, "
                + " ct.dongia, ct.thanhtien, nv.ten as [tennhanvien]  from hanghoa hh "
                + " inner join chitietphieunhap ct on ct.hanghoama = hh.ma "
                + " inner join PhieuNhap pn on pn.ma = ct.phieunhapma "
                + " inner join NhanVien nv on nv.ma = pn.nhanvienma  "
                + " group by hh.ma, hh.ten, pn.ma, ct.ma, pn.ngay, ct.soluong, ct.dongia, ct.thanhtien, nv.ten");

            int n = table.Rows.Count;
            if (n == 0) return new HangHoaNhap[0];
            HangHoaNhap[] list = new HangHoaNhap[n];
            DateTime ngay = DateTime.Now;
            int i = 0;
            Double temp = 0;
            for (i = 0; i < n; i++)
                list[i] = getHangHoa(table.Rows[i]);
            return list;
        }
        public HangHoaNhap[] getList_HangHoa(String hanghoama, String phieunhanma)
        {
            String str = "select distinct hh.ma, hh.ten, pn.ma as [phieunhapma], ct.ma as [chitietphieunhapma], pn.ngay, ct.soluong, "
                + " ct.dongia, ct.thanhtien, nv.ten as [tennhanvien]  from hanghoa hh "
                + " inner join chitietphieunhap ct on ct.hanghoama = hh.ma "
                + " inner join PhieuNhap pn on pn.ma = ct.phieunhapma "
                + " inner join NhanVien nv on nv.ma = pn.nhanvienma  ";
            DataTable table;
            if (hanghoama == "tất cả" && phieunhanma == "tất cả") return getList_HangHoa();
            if (hanghoama == "tất cả") 
                    str += " where pn.ma = '" + phieunhanma + "'  group by hh.ma, hh.ten, pn.ma, ct.ma, pn.ngay, ct.soluong, ct.dongia, ct.thanhtien, nv.ten";

            else str += " where hh.ma = '" + hanghoama + "'  group by hh.ma, hh.ten, pn.ma, ct.ma, pn.ngay, ct.soluong, ct.dongia, ct.thanhtien, nv.ten";
            

            table = da.Query(str);
            int n = table.Rows.Count;
            if (n == 0) return new HangHoaNhap[0];
            HangHoaNhap[] list = new HangHoaNhap[n];
            DateTime ngay = DateTime.Now;
            int i = 0;
            Double temp = 0;
            for (i = 0; i < n; i++)
                list[i] = getHangHoa(table.Rows[i]);
            return list;
        }
        private HangHoaNhap getHangHoa(DataRow row)
        {
            DateTime ngay = DateTime.Now;
            Double temp = 0;
            HangHoaNhap hanghoanhap = new HangHoaNhap();
            hanghoanhap.Ma = row["ma"].ToString().Trim();
            hanghoanhap.Ten = row["ten"].ToString().Trim();
            hanghoanhap.PhieuNhapMa = row["phieunhapma"].ToString().Trim();
            hanghoanhap.ChiTietPhieuNhapMa = row["chitietphieunhapma"].ToString().Trim();
            if (DateTime.TryParse(row["ngay"].ToString().Trim(), out ngay))
            {
                hanghoanhap.NgayNhap = ngay;
            }
            if (Double.TryParse(row["soluong"].ToString().Trim(), out temp)) { hanghoanhap.SoLuong = temp; temp = 0; }
            if (Double.TryParse(row["thanhtien"].ToString().Trim(), out temp)) { hanghoanhap.ThanhTien = temp; temp = 0; }
            if (Double.TryParse(row["dongia"].ToString().Trim(), out temp)) { hanghoanhap.DonGia = temp; temp = 0; }

            hanghoanhap.TenNhanVien = row["tennhanvien"].ToString().Trim();

            return hanghoanhap;
        }
        public String[] getList_PhieuNhap()
        {
            DataTable table = da.Query("select ma from phieunhap");
            int n = table.Rows.Count;
            String[] list = new String[n  + 1];
            int i = 0;
            for (i = 0; i < n; i++)
            {
                list[i] = table.Rows[i]["ma"].ToString().Trim();
            }
            list[n] = "tất cả";
            return list;
        }
        public String[] getList_PhieuNhap(String HangHoaMa)
        {
            String str = "";
            if (HangHoaMa == "tất cả") str = "  select DISTINCT PN.MA from PhieuNhap pn ";
            else str = "  select DISTINCT PN.MA from PhieuNhap pn inner join ChiTietPhieuNhap ct"
                + " on  pn.ma = ct.phieunhapma  where CT.hanghoama = '" + HangHoaMa + "' ";
            DataTable table = da.Query(str);
            int n = table.Rows.Count;
            String[] list = new String[n + 1];
            int i = 0;
            for (i = 0; i < n; i++)
            {
                list[i] = table.Rows[i]["ma"].ToString().Trim();
            }
            list[n] = "tất cả";
            return list;
        }
        public KhachHang[] getList_KhachHang_Ma()
        {
            DataTable table = da.Query("select *from KhachHang");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            KhachHang[] list = new KhachHang[n];

            for (i = 0; i < n; i++)
            {
                list[i] = new KhachHang();
                list[i].ma = table.Rows[i]["ma"].ToString().Trim();
                list[i].ten = table.Rows[i]["ten"].ToString().Trim();
                list[i].diachi = table.Rows[i]["diachi"].ToString().Trim();
                list[i].dienthoai = table.Rows[i]["dienthoai"].ToString().Trim();
                list[i].email = table.Rows[i]["email"].ToString().Trim();

            }
            return list;

        }
        public string getTenHang(string ma)
        {
            DataTable table = da.Query("select ten from HangHoa where ma='" + ma + "'");
            string ten = "";
            if (table.Rows.Count == 1)
                return table.Rows[0]["ten"].ToString().Trim();
            return ten;
        }
        public string getTenKhachHang(string ma)
        {
            DataTable table = da.Query("select ten from KhachHang where ma='" + ma + "'");
            string ten = "";
            if (table.Rows.Count == 1)
                return table.Rows[0]["ten"].ToString().Trim();
            return ten;
        }
        public string getDonGia(string ma)
        {
            DataTable table = da.Query("select dongia from HangHoa where ma='" + ma + "'");
            string dongia = "";
            if (table.Rows.Count == 1)
                return table.Rows[0]["dongia"].ToString().Trim();
            return dongia;
        }
        public string getKhoMa(string hanghoama)
        {
            DataTable table = da.Query("select khoma from ChiTietPhieuNhap where hanghoama='" + hanghoama + "'");
            string khoma = "";
            if(table.Rows.Count==1)
            {
                return table.Rows[0]["khoma"].ToString().Trim();

            }
            return khoma;
        }
        public Kho[] getList_Kho()
        {
            DataTable table = da.Query("select *from Kho");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            Kho[] list = new Kho[n];

            for (i = 0; i < n; i++)
            {
                list[i] = new Kho();
                list[i].ma = table.Rows[i]["ma"].ToString().Trim();
                list[i].ten = table.Rows[i]["ten"].ToString().Trim();
                
            }
            return list;
        }
        public HangHoa[] getList_HangHoaPhieuXuat()
        {
            DataTable table = da.Query("select *from HangHoa");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            HangHoa[] list = new HangHoa[n];

            for (i = 0; i < n; i++)
            {
                list[i] = new HangHoa();
                list[i].Ma = table.Rows[i]["ma"].ToString().Trim();
                list[i].Ten = table.Rows[i]["ten"].ToString().Trim();
               // int soluong = 0;
               // int.TryParse(table.Rows[i]["soluong"].ToString().Trim(), out soluong);
               // list[i].Soluong = soluong;
               //// list[i]. = table.Rows[i]["noisanxuat"].ToString().Trim();
                float dongia = 0;
                float.TryParse(table.Rows[i]["dongia"].ToString().Trim(), out dongia);
                list[i].Dongia = dongia;
            }
            return list;
        }
        public String[] getList_HangHoa_Ma()
        {
            DataTable table = da.Query("select ma from hanghoa");
            int n = table.Rows.Count;
            String[] list = new String[n + 1];
            int i = 0;
            for (i = 0; i < n; i++)
            {
                list[i] = table.Rows[i]["ma"].ToString().Trim();
            }
            list[n] = "tất cả";
            return list;
        }
        public String[] getList_HangHoa_Ma(String PhieuNhapMa)
        {
            if (PhieuNhapMa == "tất cả") return getList_HangHoa_Ma();
            DataTable table = da.Query("select hanghoa.ma from hanghoa inner join ChiTietPhieuNhap on HangHoa.ma = ChiTietPhieuNhap.hanghoama " 
                + " where ChiTietPhieuNhap.phieunhapma = '" + PhieuNhapMa + "'");
            int n = table.Rows.Count;
            String[] list = new String[n];
            int i = 0;
            for (i = 0; i < n; i++)
            {
                list[i] = table.Rows[i]["ma"].ToString().Trim();
            }
            return list;
        }
        public double getDoanhThu_Nhap(int thang, int nam)
        {
            Double DoanhThu = 0;
            if (thang < 1 || thang > 12) return 0;
            String thang_str = "Jan";
            switch (thang)
            {
                case 1: thang_str = "Jan"; break;
                case 2: thang_str = "Feb"; break;
                case 3: thang_str = "Mar"; break;
                case 4: thang_str = "Apr"; break;
                case 5: thang_str = "May"; break;
                case 6: thang_str = "Jun"; break;
                case 7: thang_str = "Jul"; break;
                case 8: thang_str = "Aug"; break;
                case 9: thang_str = "Sep"; break;
                case 10: thang_str = "Oct"; break;
                case 11: thang_str = "Nov"; break;
                case 12: thang_str = "Dec"; break;
            }
            DataTable table = da.Query("select  sum(chitietphieunhap.thanhtien) as [Tổng tiền] from PhieuNhap "
                + " inner join chitietphieunhap on PhieuNhap.ma = ChiTietPhieuNhap.phieunhapma "
                + " where CONVERT(CHAR(4), ngay, 100) = '" + thang_str + "' and CONVERT(CHAR(4), ngay, 120) = " + nam);
            if (Double.TryParse(table.Rows[0]["Tổng tiền"].ToString().Trim(), out DoanhThu))
            {
                return DoanhThu;
            }
            return DoanhThu;
        }
        public double getDoanhThu_Xuat(int thang, int nam)
        {
            Double DoanhThu = 0;
            if (thang < 1 || thang > 12) return 0;
            String thang_str = "Jan";
            switch (thang)
            {
                case 1: thang_str = "Jan"; break;
                case 2: thang_str = "Feb"; break;
                case 3: thang_str = "Mar"; break;
                case 4: thang_str = "Apr"; break;
                case 5: thang_str = "May"; break;
                case 6: thang_str = "Jun"; break;
                case 7: thang_str = "Jul"; break;
                case 8: thang_str = "Aug"; break;
                case 9: thang_str = "Sep"; break;
                case 10: thang_str = "Oct"; break;
                case 11: thang_str = "Nov"; break;
                case 12: thang_str = "Dec"; break;
            }
            DataTable table = da.Query("select  sum(chitietphieuxuat.thanhtien) as [Tổng tiền] from PhieuXuat "
                + " inner join ChiTietPhieuXuat  on PhieuXuat.ma = ChiTietPhieuXuat.phieuXuatMa "
                + " where CONVERT(CHAR(4), ngay, 100) = '" + thang_str + "' and CONVERT(CHAR(4), ngay, 120) = " + nam);
            if (Double.TryParse(table.Rows[0]["Tổng tiền"].ToString().Trim(), out DoanhThu))
            {
                return DoanhThu;
            }
            return DoanhThu;
        }

        public double getDoanhThu_Xuat(int nam)
        {
            Double DoanhThu = 0;

            DataTable table = da.Query("select sum(ChiTietPhieuXuat.thanhtien) as[Tổng tiền] from PhieuXuat "
                            + " inner join ChiTietPhieuXuat on PhieuXuat.ma = ChiTietPhieuXuat.phieuxuatma "
                            + "  where CONVERT(CHAR(4), ngay, 120) =  " + nam);
            if (Double.TryParse(table.Rows[0]["Tổng tiền"].ToString().Trim(), out DoanhThu))
            {
                return DoanhThu;
            }
            return DoanhThu;
        }
        public double getDoanhThu_Nhap(int nam)
        {
            Double DoanhThu = 0;

            DataTable table = da.Query("select sum(ChiTietPhieuNhap.thanhtien) as[Tổng tiền] from PhieuNhap "
                            + " inner join ChiTietPhieuNhap on PhieuNhap.ma = ChiTietPhieuNhap.phieunhapma "
                            + "  where CONVERT(CHAR(4), ngay, 120) =  " + nam);
            if (Double.TryParse(table.Rows[0]["Tổng tiền"].ToString().Trim(), out DoanhThu))
            {
                return DoanhThu;
            }
            return DoanhThu;
        }
        public int[] getNam()
        {
            DataTable table = da.Query("select distinct CONVERT(CHAR(4), ngay, 120) as [nam]  from PhieuNhap ");
            DataTable table1 = da.Query("select distinct CONVERT(CHAR(4), ngay, 120) as [nam]  from PhieuXuat ");
            int n = table.Rows.Count;
            int n1 = table1.Rows.Count;
            int[] nam = new int[n + n1];
            double min = 0, max = 0, temp;
            int i, j = 0;
            if (n == 0 && n1 == 0) return new int[0];

            for (i = 0; i < n; i++)
                nam[i] = int.Parse(table.Rows[i]["nam"].ToString().Trim());
            j = 0;
            for (i = n; i < n + n1; i++)
            {
                nam[i] = int.Parse(table1.Rows[j]["nam"].ToString().Trim());
                if (j == n1) break;
                j++;
            }
            nam = nam.Distinct().ToArray();
            Array.Sort(nam);
            return nam;
        }
    }
}
