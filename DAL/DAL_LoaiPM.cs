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
    }
}
