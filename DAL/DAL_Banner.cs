using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Banner
    {
        public DAL_Banner()
        {
            
        }
        public static List<Banner> Doc()
        {
            return DAL_SQL.GetDataContext().Banners.ToList();
        }

        public static async Task<bool> ThemAsync(Banner b)
        {
            try
            {
                DALDataContext dal = DAL_SQL.GetDataContext();

                var stream = File.Open(b.HINHANH, FileMode.Open);

                var task = new FirebaseStorage("chatapp-c35ec.appspot.com")
                 .Child("bannerImage")
                 .Child(b.MaBN.ToString())
                 .PutAsync(stream);

                var downloadUrl = await task;

                b.HINHANH = downloadUrl;

                dal.Banners.InsertOnSubmit(b);
                dal.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static async Task<bool> CapNhatAsync(Banner b)
        {
            try
            {
                DALDataContext dal = DAL_SQL.GetDataContext();
                Banner temp = dal.Banners.FirstOrDefault(e => e.MaBN == b.MaBN);

                if (b.HINHANH != temp.HINHANH)
                {
                    var stream = File.Open(b.HINHANH, FileMode.Open);

                    var task = new FirebaseStorage("chatapp-c35ec.appspot.com")
                     .Child("bannerImage")
                     .Child(b.MaBN.ToString())
                     .PutAsync(stream);

                    var downloadUrl = await task;

                    temp.HINHANH = downloadUrl;
                }

                temp.MaPM = b.MaPM;  
                dal.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Xoa(int id)
        {
            try
            {
                DALDataContext dal = DAL_SQL.GetDataContext();
                Banner temp = dal.Banners.FirstOrDefault(e => e.MaBN == id);
                dal.Banners.DeleteOnSubmit(temp);
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
