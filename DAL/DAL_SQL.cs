using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_SQL
    {
        public static bool KiemTraKetNoi()
        {
            try
            {
                var con = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).FilePath;
                if (ConfigurationManager.ConnectionStrings["MyCS"] == null)
                {
                    return false;
                }

                return GetDataContext().DatabaseExists();
            }
            catch (Exception e)
            {

                return false;
            }
        }

        public static List<string> DocDanhSachCSDL(string mayChu, string taiKhoan, string matKhau)
        {
            List<string> dsCSDL = new List<string>();

            if (taiKhoan != string.Empty && matKhau != string.Empty)
            {
                string connectionString = @"Data Source=" + mayChu + @";Persist Security Info=True;User ID=" + taiKhoan + @";Password=" + matKhau;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();

                        // Set up a command with the given query and associate
                        // this with the current connection.
                        using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                        {
                            using (SqlDataReader dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    dsCSDL.Add(dr[0].ToString());
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }

            return dsCSDL;
        }

        public static bool LuuThongTinKetNoi(string mayChu, string csdl, string taiKhoan, string matKhau)
        {
            string connectionString = @"Data Source=" + mayChu + @";Initial Catalog=" + csdl + @";Persist Security Info=True;User ID=" + taiKhoan + @";Password=" + matKhau;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings.Remove("MyCS");
            config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("MyCS", connectionString));
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");

            string connection = ConfigurationManager.ConnectionStrings["MyCS"].ConnectionString;

            return true;
        }

        public static DALDataContext GetDataContext()
        {
            Console.WriteLine(ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).FilePath);
            return new DALDataContext(ConfigurationManager.ConnectionStrings["MyCS"].ConnectionString);
        }
    }
}
