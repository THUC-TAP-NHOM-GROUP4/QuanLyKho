﻿using QuanLyKho.Model;
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
		 public bool addPhieuXuat(PhieuXuat px,ChiTietPhieuXuat ctpx)
        {
            SqlParameter[] para =
            {
               
               new SqlParameter("khoma",px.KhoMa),
               new SqlParameter("manguoinhan",px.NguoiNhanMa),
               new SqlParameter("noidung",px.NoiDung),
               new SqlParameter("khachhangma",px.KhachHangMa),
               new SqlParameter("nhanvienma",px.NhanVienMa),
               new SqlParameter("hanghoama",ctpx.HangHoaMa),
               new SqlParameter("soluong",ctpx.SoLuong)

            };
            da.Query("procedure_insertPhieuXuat", para);
            return true;
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
            {
                list[i] = new HangHoaNhap();
                list[i].Ma = table.Rows[i]["ma"].ToString().Trim();
                list[i].Ten = table.Rows[i]["ten"].ToString().Trim();
                list[i].PhieuNhapMa = table.Rows[i]["phieunhapma"].ToString().Trim();
                list[i].ChiTietPhieuNhapMa = table.Rows[i]["chitietphieunhapma"].ToString().Trim();
                if (DateTime.TryParse(table.Rows[i]["ngay"].ToString().Trim(), out ngay))
                {
                    list[i].NgayNhap = ngay;
                }
                if (Double.TryParse(table.Rows[i]["soluong"].ToString().Trim(), out temp)) { list[i].SoLuong = temp; temp = 0; }
                if (Double.TryParse(table.Rows[i]["thanhtien"].ToString().Trim(), out temp)) { list[i].ThanhTien = temp; temp = 0; }
                if (Double.TryParse(table.Rows[i]["dongia"].ToString().Trim(), out temp)) { list[i].DonGia = temp; temp = 0; }

                list[i].TenNhanVien = table.Rows[i]["tennhanvien"].ToString().Trim();


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
