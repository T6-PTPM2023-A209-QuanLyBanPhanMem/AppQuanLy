using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CTHD
    {
        public DAL_CTHD()
        {
            
        }

        public List<CTHD> DocTheoHoaDon(string maHD)
        {
            return DAL_SQL.GetDataContext().CTHDs.Where(e => e.MAHD == maHD).ToList();
        }

        public int DemCTHD(string maHD)
        {
            return DAL_SQL.GetDataContext().CTHDs.Where(e => e.MAHD == maHD).Count();
        }

        public int TinhTongDoanhThuTheoHD(string maHD)
        {
            List<CTHD> dsCTHD = DAL_SQL.GetDataContext().CTHDs.Where(e => e.MAHD == maHD).ToList();
            return dsCTHD.Count > 0 ? dsCTHD.Sum(a => a.THANHTIEN) : 0;
        }

        public int TinhTongDoanhThuTheoNPH(int maNPH)
        {
            List<CTHD> dsCTHD = DAL_SQL.GetDataContext().CTHDs.Where(e => e.PHANMEM.MANPH == maNPH).ToList();
            return dsCTHD.Count > 0 ? dsCTHD.Sum(a => a.THANHTIEN) : 0;
        }

        public int TinhTongDoanhThuTheoLoai(int maLoai)
        {
            List<CTHD> dsCTHD = DAL_SQL.GetDataContext().CTHDs.Where(e => e.PHANMEM.THUOCLOAIPMs.Any(a => a.MALOAI == maLoai)).ToList();
            return dsCTHD.Count > 0 ? dsCTHD.Sum(a => a.THANHTIEN) : 0;
        }
    }
}
