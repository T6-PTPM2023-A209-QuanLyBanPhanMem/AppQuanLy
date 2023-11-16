using Firebase.Storage;
using IronXL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhanMem
    {
        public DAL_PhanMem()
        {
            
        }

        public DataTable Xem()
        {
            return new DataTable();
        }

        public List<PHANMEM> Doc()
        {
            return DAL_SQL.GetDataContext().PHANMEMs.ToList();
        }

        public List<PHANMEM> DocTheoNPH(int maNPH)
        {
            return DAL_SQL.GetDataContext().PHANMEMs.Where(e => e.MANPH == maNPH).ToList();
        }

        public List<PHANMEM> DocTheoLoai(int maLoai)
        {
            return DAL_SQL.GetDataContext().PHANMEMs.Where(e => e.THUOCLOAIPMs.Any(a => a.MALOAI == maLoai)).ToList();
        }

        public int DemSoLuongTheoNPH(int maNPH)
        {
            return DocTheoNPH(maNPH).Count();
        }

        public int TinhGiaTriTonKhoTheoNPH(int maNPH)
        {
            List<PHANMEM> dsPhanMem = DocTheoNPH(maNPH);
            return dsPhanMem.Count > 0 ? dsPhanMem.Sum(e => e.DONGIA * e.SOLUONG) : 0;
        }

        public int DemSoLuongTheoLoai(int maLoai)
        {
            return DocTheoLoai(maLoai).Count();
        }

        public int TinhGiaTriTonKhoTheoLoai(int maLoai)
        {
            List<PHANMEM> dsPhanMem = DocTheoLoai(maLoai);
            return dsPhanMem.Count > 0 ? dsPhanMem.Sum(e => e.DONGIA * e.SOLUONG) : 0;
        }

        public async Task<bool> ThemAsync(PHANMEM pm)
        {
            try
            {
                var stream = File.Open(pm.HINHANH, FileMode.Open);

                var task = new FirebaseStorage("chatapp-c35ec.appspot.com")
                 .Child("prductImage")
                 .Child(pm.TENPM)
                 .PutAsync(stream);

                var downloadUrl = await task;

                pm.HINHANH = downloadUrl;

                DALDataContext dal = DAL_SQL.GetDataContext();
                dal.PHANMEMs.InsertOnSubmit(pm);
                dal.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> CapNhatAsync(PHANMEM pm)
        {
            try
            {
                DALDataContext dal = DAL_SQL.GetDataContext();
                PHANMEM temp = dal.PHANMEMs.FirstOrDefault(e => e.MAPM == pm.MAPM);

                var stream = File.Open(pm.HINHANH, FileMode.Open);

                var task = new FirebaseStorage("chatapp-c35ec.appspot.com")
                 .Child("prductImage")
                 .Child(pm.TENPM)
                 .PutAsync(stream);

                var downloadUrl = await task;

                pm.HINHANH = downloadUrl;

                temp.TENPM = pm.TENPM;
                temp.MOTA = pm.MOTA;
                temp.MANPH = pm.MANPH;
                temp.NGAYPHATHANH = pm.NGAYPHATHANH;
                temp.THOIHAN = pm.THOIHAN;
                temp.DONVITHOIHAN = pm.DONVITHOIHAN;
                temp.SOLUONG = pm.SOLUONG;
                temp.HINHANH = pm.HINHANH;
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
                PHANMEM temp = dal.PHANMEMs.FirstOrDefault(e => e.MAPM == id);
                dal.PHANMEMs.DeleteOnSubmit(temp);
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

            WorkSheet workSheet = workBook.GetWorkSheet("Phần mềm");

            if (workSheet == null)
            {
                workSheet = workBook.CreateWorkSheet("Phần mềm");
            }

            List<PHANMEM> dsPhanMem = new DAL_PhanMem().Doc();

            workSheet["A1"].Value = "Mã phần mềm";
            workSheet["B1"].Value = "Tên phần mềm";
            workSheet["C1"].Value = "Nhà phát hành";
            workSheet["D1"].Value = "Ngày phát hành";
            workSheet["E1"].Value = "Thời hạn";
            workSheet["F1"].Value = "Số lượng tồn kho";
            workSheet["G1"].Value = "Đơn giá";
            workSheet["H1"].Value = "Tổng doanh thu";

            for (int i = 2; i <= dsPhanMem.Count + 1; i++)
            {
                workSheet["A" + i].Value = dsPhanMem[i - 2].MAPM;
                workSheet["B" + i].Value = dsPhanMem[i - 2].TENPM;
                workSheet["C" + i].Value = dsPhanMem[i - 2].NHAPHATHANH.TENNPH;
                workSheet["D" + i].Value = dsPhanMem[i - 2].NGAYPHATHANH.Value.ToShortDateString();
                workSheet["E" + i].Value = dsPhanMem[i - 2].THOIHAN + " " + dsPhanMem[i - 2].DONVITHOIHAN;
                workSheet["F" + i].Value = dsPhanMem[i - 2].SOLUONG;
                workSheet["G" + i].Value = dsPhanMem[i - 2].DONGIA;
                workSheet["H" + i].Value = dsPhanMem[i - 2].CTHDs.Sum(x => x.THANHTIEN);
            }

            workSheet.AutoSizeColumn(0);
            workSheet.AutoSizeColumn(1);
            workSheet.AutoSizeColumn(2);
            workSheet.AutoSizeColumn(3);
            workSheet.AutoSizeColumn(4);
            workSheet.AutoSizeColumn(5);
            workSheet.AutoSizeColumn(6);
            workSheet.AutoSizeColumn(7);

            workBook.SaveAs(duongDan + @"\ThongKe.xlsx");
        }
    }
}
