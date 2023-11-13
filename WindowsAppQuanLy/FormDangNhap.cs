using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVienControls;

namespace WindowsAppQuanLy.GUI
{
    public partial class FormDangNhap : Krypton.Toolkit.KryptonForm
    {
        public FormDangNhap()
        {
            InitializeComponent();

            this.AcceptButton = btnDangNhap;

            btnDangNhap.Click += BtnDangNhap_Click;
            btnDangNhap.GotFocus += BtnDangNhap_GotFocus;
        }

        private void BtnDangNhap_GotFocus(object sender, EventArgs e)
        {

        }



        public void BtnDangNhap_Click(object sender, EventArgs e)
        {
            if (DAL_QuanTriVien.KiemTraTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                this.Hide();
                Program.formMain.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}
