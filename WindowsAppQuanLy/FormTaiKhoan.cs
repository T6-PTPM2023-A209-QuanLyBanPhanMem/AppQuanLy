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
using DAL;

namespace WindowsAppQuanLy.GUI
{
    public partial class FormTaiKhoan : FormCon
    {
        List<TAIKHOAN> dsTaiKhoan = new List<TAIKHOAN>();
        public FormTaiKhoan(Form form) : base(form)
        {
            InitializeComponent();

            this.txtSoluong.Text = new DAL_TaiKhoan().TongSoTaiKhoan().ToString();
            this.txtSoDu.Text = new DAL_TaiKhoan().TongSoDu().ToString();
            this.dgvTaiKhoan.DataSource = new DAL_TaiKhoan().Doc();
            this.dgvTaiKhoanQuanTri.DataSource = DAL_QuanTriVien.Doc();

            this.btnThem.Click += BtnThem_Click;
            this.dgvTaiKhoanQuanTri.SelectionChanged += DgvTaiKhoanQuanTri_SelectionChanged;
        }

        private void DgvTaiKhoanQuanTri_SelectionChanged(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = dgvTaiKhoanQuanTri.CurrentRow.Cells["TK_TenTaiKhoanQuanTri"].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoanQuanTri.CurrentRow.Cells["TK_MatKhauTaiKhoanQuanTri"].Value.ToString();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            

            if (btnThem.Text == "Thêm")
            {
                this.btnThem.Text = "Lưu";
                this.txtTaiKhoan.Clear();
                this.txtMatKhau.Clear();
                this.txtTaiKhoan.ReadOnly = false;
                this.txtMatKhau.ReadOnly = false;
                this.dgvTaiKhoanQuanTri.Enabled = false;
            }
            else
            {
                try
                {
                    TAIKHOAN_QUANTRI tk = new TAIKHOAN_QUANTRI();
                    tk.TENTK = txtTaiKhoan.Text;
                    tk.MATKHAU = l.Text;

                    if (!DAL_QuanTriVien.Them(tk, txtMaQuanTri.Text))
                    {
                        MessageBox.Show("Thêm thất bại");
                        dgvTaiKhoanQuanTri.Rows[0].Selected = true;
                        DgvTaiKhoanQuanTri_SelectionChanged(this, null);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ");
                }

                this.btnThem.Text = "Thêm";
                this.txtTaiKhoan.ReadOnly = true;
                this.txtMatKhau.ReadOnly = true;
                this.dgvTaiKhoanQuanTri.Enabled = true;
            }
        }
    }
}
