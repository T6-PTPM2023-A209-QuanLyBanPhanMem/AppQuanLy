using IronXL;
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

        public static void xuatExcel(string duongDan)
        {
            WorkBook workBook;

            try
            {
                workBook = WorkBook.Load(duongDan + @"\ThongKe.xlsx");
            }
            catch (Exception)
            {
                workBook = WorkBook.Create();
            }

            WorkSheet workSheet = workBook.GetWorkSheet("Hóa đơn");

            if (workSheet == null)
            {
                workSheet = workBook.CreateWorkSheet("Hóa đơn");
            }

            List<HOADON> dsHoaDon = new DAL_HoaDon().Doc();

            workSheet["A1"].Value = "Mã hóa đơn";
            workSheet["B1"].Value = "Tên tài khoản";
            workSheet["C1"].Value = "Thời gian lập";
            workSheet["D1"].Value = "Tổng tiền";
            workSheet["E1"].Value = "Số lượng phần mềm";

            for (int i = 2; i <= dsHoaDon.Count + 1; i++)
            {
                workSheet["A" + i].Value = dsHoaDon[i - 2].MAHD;
                workSheet["B" + i].Value = dsHoaDon[i - 2].TAIKHOAN.TENTK;
                workSheet["C" + i].Value = dsHoaDon[i - 2].THOIGIANLAP;
                workSheet["D" + i].Value = dsHoaDon[i - 2].TONGTIEN;
                workSheet["E" + i].Value = dsHoaDon[i - 2].CTHDs.Count;
            }

            workSheet.AutoSizeColumn(0);
            workSheet.AutoSizeColumn(1);
            workSheet.AutoSizeColumn(2);
            workSheet.AutoSizeColumn(3);
            workSheet.AutoSizeColumn(4);

            workBook.SaveAs(duongDan + @"\ThongKe.xlsx");
        }
    }
}
