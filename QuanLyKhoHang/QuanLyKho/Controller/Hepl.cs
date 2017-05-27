using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Controller
{
 public  class Hepl
    {
        public int Dieukhien(params string[] str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == "")
                    return 0;
                else
                    continue;
            }
            return 1;
        }
      public List<Object> Convert(DataTable dt)
        {
            List<object> lst = new List<object>();
            foreach (DataRow dr in dt.Rows)
                foreach (DataColumn dc in dt.Columns)
                    lst.Add(dr[dc]);
            return lst;
        }
    }
}
