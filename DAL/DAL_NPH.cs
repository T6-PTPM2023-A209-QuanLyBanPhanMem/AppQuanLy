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
    }
}
