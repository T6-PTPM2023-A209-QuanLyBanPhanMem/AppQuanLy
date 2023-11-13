using Firebase.Storage;
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
                // Get any Stream — it can be FileStream, MemoryStream or any other type of Stream
                var stream = File.Open(pm.HINHANH, FileMode.Open);

                // Construct FirebaseStorage with path to where you want to upload the file and put it there
                var task = new FirebaseStorage("chatapp-c35ec.appspot.com")
                 .Child("prductImage")
                 .Child(pm.TENPM)
                 .PutAsync(stream);

                // Await the task to wait until upload is completed and get the download url
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

                // Get any Stream — it can be FileStream, MemoryStream or any other type of Stream
                var stream = File.Open(pm.HINHANH, FileMode.Open);

                // Construct FirebaseStorage with path to where you want to upload the file and put it there
                var task = new FirebaseStorage("chatapp-c35ec.appspot.com")
                 .Child("prductImage")
                 .Child(pm.TENPM)
                 .PutAsync(stream);

                // Await the task to wait until upload is completed and get the download url
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
    }
}
