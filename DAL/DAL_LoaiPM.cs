using IronXL;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_LoaiPM
    {
        
        public DAL_LoaiPM()
        {
            
        }
        public List<LOAIPHANMEM> Doc()
        {
            return DAL_SQL.GetDataContext().LOAIPHANMEMs.ToList();
        }

        public bool Them(LOAIPHANMEM loai)
        {
            try
            {
                DALDataContext dal = DAL_SQL.GetDataContext();
                dal.LOAIPHANMEMs.InsertOnSubmit(loai);
                dal.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CapNhat(LOAIPHANMEM loai)
        {
            try
            {
                DALDataContext dal = DAL_SQL.GetDataContext();
                LOAIPHANMEM temp = dal.LOAIPHANMEMs.FirstOrDefault(e => e.MALOAI == loai.MALOAI);
                temp.TENLOAI = loai.TENLOAI;
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
                LOAIPHANMEM temp = dal.LOAIPHANMEMs.FirstOrDefault(e => e.MALOAI == id);
                dal.LOAIPHANMEMs.DeleteOnSubmit(temp);
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

            WorkSheet workSheet = workBook.GetWorkSheet("Loại phần mềm");

            if (workSheet == null)
            {
                workSheet = workBook.CreateWorkSheet("Loại phần mềm");
            }

            List<LOAIPHANMEM> dsLoaiPM = new DAL_LoaiPM().Doc();

            workSheet["A1"].Value = "Mã loại phần mềm";
            workSheet["B1"].Value = "Tên loại phần mềm";
            workSheet["C1"].Value = "Số lượng phần mềm";
            workSheet["D1"].Value = "Số lượng tồn kho";
            workSheet["E1"].Value = "Doanh số bán ra";

            for (int i = 2; i <= dsLoaiPM.Count + 1; i++)
            {
                workSheet["A" + i].Value = dsLoaiPM[i - 2].MALOAI;
                workSheet["B" + i].Value = dsLoaiPM[i - 2].TENLOAI;
                workSheet["C" + i].Value = dsLoaiPM[i - 2].THUOCLOAIPMs.Count;
                workSheet["D" + i].Value = dsLoaiPM[i - 2].THUOCLOAIPMs.Sum(x => x.PHANMEM.SOLUONG);
                workSheet["E" + i].Value = dsLoaiPM[i - 2].THUOCLOAIPMs.Sum(x => x.PHANMEM.CTHDs.Sum(y => y.THANHTIEN));
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
