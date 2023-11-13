using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_QuanTriVien
    {
        public DAL_QuanTriVien() { }


        public static List<TAIKHOAN_QUANTRI> Doc()
        {
            return DAL_SQL.GetDataContext().TAIKHOAN_QUANTRIs.ToList();
        }

        public static bool KiemTraTaiKhoan(string TaiKhoan, string MatKhau)
        {
            DALDataContext db = DAL_SQL.GetDataContext();

            foreach (var tk in db.TAIKHOAN_QUANTRIs)
            {
                if (tk.TENTK == TaiKhoan && tk.MATKHAU == MatKhau)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Them(TAIKHOAN_QUANTRI tk, string MaQuanTri)
        {
            try
            {
                DALDataContext dal = DAL_SQL.GetDataContext();

                if (dal.DANHMUCs.Any(x => x.TEN == "Mã quản trị" && x.GIATRI == MaQuanTri))
                {
                    dal.TAIKHOAN_QUANTRIs.InsertOnSubmit(tk);
                    dal.SubmitChanges(); return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public static bool CapNhat(TAIKHOAN_QUANTRI tk, string MaQuanTri)
        {
            try
            {
                DALDataContext dal = DAL_SQL.GetDataContext();

                if (dal.DANHMUCs.Any(x => x.TEN == "Mã quản trị" && x.GIATRI == MaQuanTri))
                {
                    TAIKHOAN_QUANTRI temp = dal.TAIKHOAN_QUANTRIs.FirstOrDefault(e => e.TENTK == tk.TENTK);
                    temp.MATKHAU = tk.MATKHAU;
                    dal.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(string id, string MaQuanTri)
        {
            try
            {
                DALDataContext dal = DAL_SQL.GetDataContext();

                if (dal.DANHMUCs.Any(x => x.TEN == "Mã quản trị" && x.GIATRI == MaQuanTri))
                {
                    TAIKHOAN_QUANTRI temp = dal.TAIKHOAN_QUANTRIs.FirstOrDefault(e => e.TENTK == id);
                    dal.TAIKHOAN_QUANTRIs.DeleteOnSubmit(temp);
                    dal.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
