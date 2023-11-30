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
        string mqt = "";
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
                    tk.MATKHAU = txtMatKhau.Text;

                    if (!DAL_QuanTriVien.Them(tk, txtMaQuanTri.Text))
                    {
                        MessageBox.Show("Thêm thất bại");
                        dgvTaiKhoanQuanTri.Rows[0].Selected = true;
                        DgvTaiKhoanQuanTri_SelectionChanged(this, null);
                    }

                    this.dgvTaiKhoanQuanTri.DataSource = DAL_QuanTriVien.Doc();
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (btnCapNhat.Text == "Cập nhật")
            {
                this.btnCapNhat.Text = "Lưu";
                this.txtMatKhau.Clear();
                this.txtMatKhau.ReadOnly = false;
                this.dgvTaiKhoanQuanTri.Enabled = false;
            }
            else
            {
                try
                {
                    TAIKHOAN_QUANTRI tk = new TAIKHOAN_QUANTRI();
                    tk.TENTK = dgvTaiKhoanQuanTri.CurrentRow.Cells["TK_TenTaiKhoanQuanTri"].Value.ToString();
                    tk.MATKHAU = txtMatKhau.Text;

                    if (!DAL_QuanTriVien.CapNhat(tk, txtMaQuanTri.Text))
                    {
                        MessageBox.Show("Cập nhật thất bại");
                        dgvTaiKhoanQuanTri.Rows[0].Selected = true;
                        DgvTaiKhoanQuanTri_SelectionChanged(this, null);
                    }

                    this.dgvTaiKhoanQuanTri.DataSource = DAL_QuanTriVien.Doc();
                }
                catch (Exception)
                {

                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ");
                }

                this.btnCapNhat.Text = "Cập nhật";
                this.txtMatKhau.ReadOnly = true;
                this.dgvTaiKhoanQuanTri.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!DAL_QuanTriVien.Xoa(dgvTaiKhoanQuanTri.CurrentRow.Cells["TK_TenTaiKhoanQuanTri"].Value.ToString(), txtMaQuanTri.Text))
            {
                MessageBox.Show("Xóa thất bại");
            }
            else
            {
                dgvTaiKhoanQuanTri.Rows.Remove(dgvTaiKhoanQuanTri.CurrentRow);
            }
        }

        private void btnDoiMa_Click(object sender, EventArgs e)
        {


            if (btnDoiMa.Text == "Đổi mã" && DAL_QuanTriVien.KiemTraMaQuanTri(txtMaQuanTri.Text))
            {
                this.btnDoiMa.Text = "Lưu";
                mqt = txtMaQuanTri.Text;
                txtMaQuanTri.Clear();
            }
            else
            {
                try
                {
                    if (!DAL_QuanTriVien.DoiMaQuanTri(mqt, txtMaQuanTri.Text))
                    {
                        MessageBox.Show("Đổi mã quản trị thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Đổi mã quản trị thành công");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ");
                }

                mqt = "";
                this.btnDoiMa.Text = "Đổi mã";
            }
        }
    }
}
