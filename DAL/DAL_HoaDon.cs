using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDon
    {
        public DAL_HoaDon()
        {
            
        }

        public List<HOADON> Doc()
        {
            return DAL_SQL.GetDataContext().HOADONs.ToList();
        }

        public List<HOADON> DocTheoPhanMem(int maPM)
        {
            List<CTHD> dsCTHD = DAL_SQL.GetDataContext().CTHDs.Where(e => e.MAPM == maPM).ToList();

            List<HOADON> dsHoaDon = new List<HOADON>();

            foreach (CTHD cthd in dsCTHD)
            {
                if (!dsHoaDon.Any(e => e.MAHD == cthd.MAHD))
                {
                    dsHoaDon.Add(cthd.HOADON);
                }
            }

            return dsHoaDon;
        }
    }
}
