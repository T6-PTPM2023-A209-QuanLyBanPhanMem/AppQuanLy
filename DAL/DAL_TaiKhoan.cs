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
    }
}
