using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Controller
{
    class Controllers
    {
        DataAccess da = new DataAccess();
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
