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

        public double getDoanhThu_Nhap(int thang, int nam)
        {
            Double DoanhThu = 0;
            if (thang < 1 || thang > 12) return 0;
            String thang_str = "Jan";
            switch (thang)
            {
                case 1: thang_str = "Jan";break;
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
            DataTable table =  da.Query("select  sum(chitietphieuxuat.thanhtien) as [Tổng tiền] from PhieuXuat " 
                + " inner join chitietphieuxuat on PhieuXuat.ma = ChiTietPhieuXuat.phieuxuatma " 
                + " where CONVERT(CHAR(4), ngay, 100) = '"+ thang_str+ "' and CONVERT(CHAR(4), ngay, 120) = " + nam );
           if (Double.TryParse(table.Rows[0]["Tổng tiền"].ToString().Trim(), out DoanhThu)){
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
                + " where CONVERT(CHAR(4), ngay, 100) = '"+ thang_str + "' and CONVERT(CHAR(4), ngay, 120) = " + nam);
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
            int[] nam = new int[n+ n1];
            double min = 0, max = 0, temp;
            int i, j= 0;
            if (n == 0 && n1== 0) return new int[0];
            
            for (i = 0; i < n; i++)
                nam[i] = int.Parse(table.Rows[i]["nam"].ToString().Trim());
            j = 0;
            for (i = n; i < n + n1; i++)
            {
                nam[i] = int.Parse(table1.Rows[j]["nam"].ToString().Trim());
                if (j == n1 ) break;
                j++;
            }
            nam = nam.Distinct().ToArray();
            return nam;
        }
    }
}
