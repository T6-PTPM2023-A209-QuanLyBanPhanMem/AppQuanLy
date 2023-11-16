using IronXL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        public DAL_TaiKhoan()
        {
            
        }

        public List<TAIKHOAN> Doc()
        {
            return DAL_SQL.GetDataContext().TAIKHOANs.ToList();
        }

        public int TongSoDu()
        {
            int? soDu = DAL_SQL.GetDataContext().TAIKHOANs.Sum(e => e.SODU);
            return soDu == null ? 0 : (int) soDu;
        }

        public int TongSoTaiKhoan()
        {
            return DAL_SQL.GetDataContext().TAIKHOANs.Count();
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

            WorkSheet workSheet = workBook.GetWorkSheet("Tài khoản người dùng");

            if (workSheet == null)
            {
                workSheet = workBook.CreateWorkSheet("Tài khoản người dùng");
            }

            List<TAIKHOAN> dsTaiKhoan = new DAL_TaiKhoan().Doc();

            workSheet["A1"].Value = "Mã tài khoản";
            workSheet["B1"].Value = "Tên tài khoản";
            workSheet["C1"].Value = "Họ tên";
            workSheet["D1"].Value = "CCCD";
            workSheet["E1"].Value = "Email";
            workSheet["F1"].Value = "Số điện thoại";
            workSheet["G1"].Value = "Địa chỉ";
            workSheet["H1"].Value = "Số dư";
            workSheet["I1"].Value = "Doanh thu phát sinh";

            for (int i = 2; i <= dsTaiKhoan.Count + 1; i++)
            {
                workSheet["A" + i].Value = dsTaiKhoan[i - 2].MATK;
                workSheet["B" + i].Value = dsTaiKhoan[i - 2].TENTK;
                workSheet["C" + i].Value = dsTaiKhoan[i - 2].HOTEN;
                workSheet["D" + i].Value = dsTaiKhoan[i - 2].CCCD;
                workSheet["E" + i].Value = dsTaiKhoan[i - 2].EMAIL;
                workSheet["F" + i].Value = dsTaiKhoan[i - 2].SDT;
                workSheet["G" + i].Value = dsTaiKhoan[i - 2].DIACHI;
                workSheet["H" + i].Value = dsTaiKhoan[i - 2].SODU;
                workSheet["I" + i].Value = dsTaiKhoan[i - 2].HOADONs.Sum(x => x.TONGTIEN);
            }

            workSheet.AutoSizeColumn(0);
            workSheet.AutoSizeColumn(1);
            workSheet.AutoSizeColumn(2);
            workSheet.AutoSizeColumn(3);
            workSheet.AutoSizeColumn(4);
            workSheet.AutoSizeColumn(5);
            workSheet.AutoSizeColumn(6);
            workSheet.AutoSizeColumn(7);
            workSheet.AutoSizeColumn(8);

            workBook.SaveAs(duongDan + @"\ThongKe.xlsx");
        }
    }
}
