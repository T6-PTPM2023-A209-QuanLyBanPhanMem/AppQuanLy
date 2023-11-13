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
    }
}
