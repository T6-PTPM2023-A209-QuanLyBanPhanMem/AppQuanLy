using IronXL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Excel
    {
        public static void xuatExcel_PhanMem(string duongDan)
        {
            WorkBook workBook = WorkBook.Create();
            WorkSheet workSheet = workBook.DefaultWorkSheet;

            List<PHANMEM> dsPhanMem = new DAL_PhanMem().Doc();

            workSheet["A1"].Value = "Mã phần mềm";
            workSheet["B1"].Value = "Tên phần mềm";
            workSheet["C1"].Value = "Nhà phát hành";
            workSheet["D1"].Value = "Ngày phát hành";
            workSheet["E1"].Value = "Thời hạn";
            workSheet["F1"].Value = "Số lượng tồn kho";
            workSheet["G1"].Value = "Đơn giá";
            workSheet["H1"].Value = "Tổng doanh thu";
            workSheet["I1"].Value = "Đường dẫn hình ảnh";

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
                workSheet["I" + i].Value = dsPhanMem[i - 2].HINHANH;
            }

            // Save Changes
            workBook.SaveAs(duongDan + @"\DanhSachPhanMem.xlsx");
        }
    }
}
