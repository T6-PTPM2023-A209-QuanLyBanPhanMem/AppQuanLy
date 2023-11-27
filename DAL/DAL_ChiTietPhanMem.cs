using IronXL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietPhanMem
    {
        public static List<KEYPM> Doc()
        {
            return DAL_SQL.GetDataContext().KEYPMs.ToList();
        }

        public static List<KEYPM> Doc(int MaPM)
        {
            return DAL_SQL.GetDataContext().KEYPMs.Where(x => x.MAPM == MaPM).ToList();
        }

        public static int Dem(int MaPM)
        {
            return DAL_SQL.GetDataContext().KEYPMs.Where(x => x.MAPM == MaPM).ToList().Count();
        }

        public static int DemKey(int MaPM)
        {
            return DAL_SQL.GetDataContext().KEYPMs.Where(x => x.MAPM == MaPM && x.GIATRI != null).ToList().Count();
        }

        public static int DemTaiKhoan(int MaPM)
        {
            return DAL_SQL.GetDataContext().KEYPMs.Where(x => x.MAPM == MaPM && x.TAIKHOAN != null).ToList().Count();
        }

        public static bool Them(KEYPM ctpm)
        {
            try
            {
                DALDataContext dal = DAL_SQL.GetDataContext();
                dal.KEYPMs.InsertOnSubmit(ctpm);
                dal.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CapNhat(KEYPM ctpm)
        {
            try
            {
                DALDataContext dal = DAL_SQL.GetDataContext();
                KEYPM temp = dal.KEYPMs.FirstOrDefault(e => e.MAPM == ctpm.MAPM && e.MAKEY == ctpm.MAKEY);
                temp.TINHTRANG = ctpm.TINHTRANG;
                dal.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(int MaPM, int MaKey)
        {
            try
            {
                DALDataContext dal = DAL_SQL.GetDataContext();
                KEYPM temp = dal.KEYPMs.FirstOrDefault(e => e.MAPM == MaPM && e.MAKEY == MaKey);
                dal.KEYPMs.DeleteOnSubmit(temp);
                dal.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
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

            WorkSheet workSheet = workBook.GetWorkSheet("Chi tiết phần mềm");

            if (workSheet == null)
            {
                workSheet = workBook.CreateWorkSheet("Chi tiết phần mềm");
            }

            List<KEYPM> dsCTPM = Doc();

            workSheet["A1"].Value = "Mã chi tiết phần mềm";
            workSheet["B1"].Value = "Tên phần mềm";
            workSheet["C1"].Value = "Tình trạng";
            workSheet["D1"].Value = "Mã hóa đơn";
            workSheet["E1"].Value = "Thời gian bán";
            workSheet["F1"].Value = "Tài khoản mua";

            for (int i = 2; i <= dsCTPM.Count + 1; i++)
            {
                workSheet["A" + i].Value = dsCTPM[i - 2].MAKEY;
                workSheet["B" + i].Value = dsCTPM[i - 2].PHANMEM.TENPM;
                workSheet["C" + i].Value = dsCTPM[i - 2].TINHTRANG == 0 ? "Chưa bán" : "Đã bán";
                workSheet["D" + i].Value = dsCTPM[i - 2].CTHD_KEYs.Count == 0 ? "" : dsCTPM[i - 2].CTHD_KEYs[0].MAHD;
                workSheet["E" + i].Value = dsCTPM[i - 2].CTHD_KEYs.Count == 0 ? "" : dsCTPM[i - 2].CTHD_KEYs[0].HOADON.THOIGIANLAP.ToShortDateString();
                workSheet["F" + i].Value = dsCTPM[i - 2].CTHD_KEYs.Count == 0 ? "" : dsCTPM[i - 2].CTHD_KEYs[0].HOADON.TAIKHOAN.TENTK;
            }

            workSheet.AutoSizeColumn(0);
            workSheet.AutoSizeColumn(1);
            workSheet.AutoSizeColumn(2);
            workSheet.AutoSizeColumn(3);
            workSheet.AutoSizeColumn(4);
            workSheet.AutoSizeColumn(5);

            workBook.SaveAs(duongDan + @"\ThongKe.xlsx");
        }
    }
}
