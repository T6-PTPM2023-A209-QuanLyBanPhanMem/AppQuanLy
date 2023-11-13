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
    public partial class FormNPH : FormCon
    {
        List<NHAPHATHANH> dsNhaPhatHanh = new List<NHAPHATHANH>();
        List<PHANMEM> dsPhanMem = new List<PHANMEM>();
        public FormNPH(Form form) : base(form)
        {
            InitializeComponent();
            DocNhaPhatHanh();

            this.dgvNPH.SelectionChanged += DgvNPH_SelectionChanged;
            this.btnThem.Click += BtnThem_Click;
            this.btnCapNhat.Click += BtnCapNhat_Click;
            this.btnXoa.Click += BtnXoa_Click;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DAL_NPH service = new DAL_NPH();

            if (!service.Xoa(Convert.ToInt32(txtMaNPH.Text)))
            {
                MessageBox.Show("Xóa thất bại");
            }
            else
            {
                dgvNPH.Rows.Remove(dgvNPH.SelectedRows[0]);
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (btnCapNhat.Text == "Cập nhật")
            {
                this.btnCapNhat.Text = "Lưu";
                this.txtTenNPH.ReadOnly = false;
                this.dgvNPH.Enabled = false;
            }
            else
            {
                DAL_NPH service = new DAL_NPH();

                if (!service.CapNhat(new NHAPHATHANH() { MANPH = Convert.ToInt32(txtMaNPH.Text), TENNPH = txtTenNPH.Text }))
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
                else
                {
                    dgvNPH.Rows[dgvNPH.SelectedRows[0].Index].Cells[1].Value = txtTenNPH.Text;
                }

                this.txtTenNPH.Clear();
                this.txtTenNPH.ReadOnly = true;
                this.btnCapNhat.Text = "Cập nhật";
                this.dgvNPH.Enabled = true;
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                this.btnThem.Text = "Lưu";
                this.txtMaNPH.Clear();
                this.txtTenNPH.Clear();
                this.txtTenNPH.ReadOnly = false;
                this.dgvNPH.Enabled = false;
            }
            else
            {
                DAL_NPH service = new DAL_NPH();

                if (!service.Them(new NHAPHATHANH() { TENNPH = txtTenNPH.Text}))
                {
                    MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    DataTable dt = (DataTable)this.dgvNPH.DataSource;
                    DataRow dr = dt.NewRow();
                    dr[0] = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString()) + 1;
                    dr[1] = txtTenNPH.Text;
                    dt.Rows.Add(dr);
                }

                this.txtTenNPH.Clear();
                this.txtTenNPH.ReadOnly = true;
                this.btnThem.Text = "Thêm";
                this.dgvNPH.Enabled = true;
            }
        }

        private void DgvNPH_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNPH.CurrentRow != null)
            {
                int maNPH = Convert.ToInt32(dgvNPH.CurrentRow.Cells["NPH_MaNPH"].Value.ToString());

                DocPhanMem(maNPH);

                this.txtTongDoanhThu.Text = new DAL_CTHD().TinhTongDoanhThuTheoNPH(maNPH).ToString();
                this.txtGiaTriTonKhoa.Text = new DAL_PhanMem().TinhGiaTriTonKhoTheoNPH(maNPH).ToString();
                this.txtSoSanPham.Text = new DAL_PhanMem().DemSoLuongTheoNPH(maNPH).ToString();

                this.txtMaNPH.Text = maNPH.ToString();
                this.txtTenNPH.Text = dgvNPH.CurrentRow.Cells["NPH_TenNPH"].Value.ToString();
            }
        }

        // Đọc dữ liệu nhà phát hành từ CSDL rồi thêm vào Data Grid View
        public void DocNhaPhatHanh()
        {
            this.dsNhaPhatHanh = new DAL_NPH().Doc();
            this.dgvNPH.DataSource = dsNhaPhatHanh;
        }

        // Đọc dữ liệu phần mềm thuộc nhà phát hành đang chọn từ CSDL rồi thêm vào Data Grid View
        public void DocPhanMem(int ma)
        {
            this.dsPhanMem = new DAL_PhanMem().DocTheoNPH(ma);

            DataTable dt = new DataTable();
            dt.Columns.Add("MaPM");
            dt.Columns.Add("TenPM");

            foreach (PHANMEM pm in dsPhanMem)
            {
                DataRow row = dt.NewRow();
                row["MaPM"] = pm.MAPM;
                row["TenPM"] = pm.TENPM;
                dt.Rows.Add(row);
            }

            this.dgvPhanMem.DataSource = dt;
        }
    }
}
