using IronXL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NPH
    {
        public DAL_NPH()
        {
            
        }

        public List<NHAPHATHANH> Doc()
        {
            return DAL_SQL.GetDataContext().NHAPHATHANHs.ToList();
        }

        public bool Them(NHAPHATHANH nph)
        {
            try
            {
                DALDataContext dal = DAL_SQL.GetDataContext();
                dal.NHAPHATHANHs.InsertOnSubmit(nph);
                dal.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CapNhat(NHAPHATHANH nph)
        {
            try
            {
                DALDataContext dal = DAL_SQL.GetDataContext();
                NHAPHATHANH temp = dal.NHAPHATHANHs.FirstOrDefault(e => e.MANPH == nph.MANPH);
                temp.TENNPH = nph.TENNPH;
                dal.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Xoa(int id)
        {
            try
            {
                DALDataContext dal = DAL_SQL.GetDataContext();
                NHAPHATHANH temp = dal.NHAPHATHANHs.FirstOrDefault(e => e.MANPH == id);
                dal.NHAPHATHANHs.DeleteOnSubmit(temp);
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

            WorkSheet workSheet = workBook.GetWorkSheet("Nhà phát hành");

            if (workSheet == null)
            {
                workSheet = workBook.CreateWorkSheet("Nhà phát hành");
            }

            List<NHAPHATHANH> dsNPH = new DAL_NPH().Doc();

            workSheet["A1"].Value = "Mã nhà phát hành";
            workSheet["B1"].Value = "Tên nhà phát hành";
            workSheet["C1"].Value = "Số lượng phần mềm";
            workSheet["D1"].Value = "Số lượng tồn kho";
            workSheet["E1"].Value = "Doanh số bán ra";

            for (int i = 2; i <= dsNPH.Count + 1; i++)
            {
                workSheet["A" + i].Value = dsNPH[i - 2].MANPH;
                workSheet["B" + i].Value = dsNPH[i - 2].TENNPH;
                workSheet["C" + i].Value = dsNPH[i - 2].PHANMEMs.Count;
                workSheet["D" + i].Value = dsNPH[i - 2].PHANMEMs.Sum(x => x.SOLUONG);
                workSheet["E" + i].Value = dsNPH[i - 2].PHANMEMs.Sum(x => x.CTHDs.Sum(y => y.THANHTIEN));
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
