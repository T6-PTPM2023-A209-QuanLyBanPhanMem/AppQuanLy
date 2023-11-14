using System;
using System.Windows.Forms;
using WindowsAppQuanLy.GUI;
using DAL;
using GUI;
using CustomControls;
using System.Linq.Expressions;

namespace WindowsAppQuanLy
{
    internal static class Program
    {
        public static FormDangNhap formDangNhap;
        public static FormConfig formConfig;
        public static FormMain formMain;
        public static FormTaiKhoan formTaiKhoan;
        public static FormHeThong formTongQuan;
        public static FormNPH formNPH;
        public static FormTheLoai formTheLoai;
        public static FormPhanMem formSanPham;
        public static FormKeyPhanMem formKeySanPham;
        public static FormHoaDon formHoaDon;
        public static FormHeThong formHeThong;
        public static LoadingScreen loadingScreen;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //formMain = new FormMain();
            //InitChildForm();
            //formConfig = new FormConfig();
            //Application.Run(formConfig);
            if (DAL_SQL.KiemTraKetNoi())
            {
                InitForm();
                Application.Run(formDangNhap);
            }
            else
            {
                LoadingScreen.ShowSplashScreen();
                formConfig = new FormConfig();
                LoadingScreen.CloseForm();          
                Application.Run(formConfig);
            }

        }

        public static void DisplayChildForm(Form f)
        {
            formMain.LayoutMdi(MdiLayout.Cascade);
            f.Show();
            f.BringToFront();
        }

        public static void InitForm()
        {
            formDangNhap = new FormDangNhap();
            formMain = new FormMain();
            formTaiKhoan = new FormTaiKhoan(formMain);
            formTongQuan = new FormHeThong(formMain);
            formNPH = new FormNPH(formMain);
            formTheLoai = new FormTheLoai(formMain);
            formSanPham = new FormPhanMem(formMain);
            formKeySanPham = new FormKeyPhanMem(formMain);
            formHoaDon = new FormHoaDon(formMain);
            formHeThong = new FormHeThong(formMain);
        }
    }
}