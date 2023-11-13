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
    public partial class FormTheLoai : FormCon
    {
        List<LOAIPHANMEM> dsLoaiPhanMem = new List<LOAIPHANMEM>();
        public FormTheLoai(Form form) : base(form)
        {
            InitializeComponent();
            DocLoai();

            this.dgvLoai.SelectionChanged += DgvLoai_SelectionChanged;
            this.btnThem.Click += BtnThem_Click;
            this.btnCapNhat.Click += BtnCapNhat_Click;
            this.btnXoa.Click += BtnXoa_Click;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DAL_LoaiPM service = new DAL_LoaiPM();

            if (!service.Xoa(Convert.ToInt32(txtMaLoai.Text)))
            {
                MessageBox.Show("Xóa thất bại");
            }
            else
            {
                dgvLoai.Rows.Remove(dgvLoai.SelectedRows[0]);
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (btnCapNhat.Text == "Cập nhật")
            {
                this.btnCapNhat.Text = "Lưu";
                this.txtTenLoai.ReadOnly = false;
                this.dgvLoai.Enabled = false;
            }
            else
            {
                if (!new DAL_LoaiPM().CapNhat(new LOAIPHANMEM() { MALOAI = Convert.ToInt32(txtMaLoai.Text), TENLOAI = txtTenLoai.Text }))
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
                else
                {
                    dgvLoai.Rows[dgvLoai.CurrentRow.Index].Cells[1].Value = txtTenLoai.Text;
                }

                this.txtTenLoai.Clear();
                this.txtTenLoai.ReadOnly = true;
                this.btnCapNhat.Text = "Cập nhật";
                this.dgvLoai.Enabled = true;
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                this.btnThem.Text = "Lưu";
                this.txtMaLoai.Clear();
                this.txtTenLoai.Clear();
                this.txtTenLoai.ReadOnly = false;
                this.dgvLoai.Enabled = false;
            }
            else
            {
                DAL_LoaiPM service = new DAL_LoaiPM();

                if (!service.Them(new LOAIPHANMEM() { TENLOAI = txtTenLoai.Text}))
                {
                    MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    DataTable dt = (DataTable)this.dgvLoai.DataSource;
                    DataRow dr = dt.NewRow();
                    dr[0] = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString()) + 1;
                    dr[1] = txtTenLoai.Text;
                    dt.Rows.Add(dr);
                }

                this.txtTenLoai.Clear();
                this.txtTenLoai.ReadOnly = true;
                this.btnThem.Text = "Thêm";
                this.dgvLoai.Enabled = true;
            }
        }

        private void DgvLoai_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoai.CurrentRow != null)
            {
                int maLoai = Convert.ToInt32(dgvLoai.CurrentRow.Cells["MaLoai"].Value.ToString());

                DocPhanMem(maLoai);

                this.txtTongDoanhThu.Text = new DAL_CTHD().TinhTongDoanhThuTheoLoai(maLoai).ToString();
                this.txtGiaTriTonKhoa.Text = new DAL_PhanMem().TinhGiaTriTonKhoTheoLoai(maLoai).ToString();
                this.txtSoSanPham.Text = new DAL_PhanMem().DemSoLuongTheoLoai(maLoai).ToString();

                this.txtMaLoai.Text = maLoai.ToString();
                this.txtTenLoai.Text = dgvLoai.CurrentRow.Cells["TenLoai"].Value.ToString();
            }
        }

        // Đọc dữ liệu nhà phát hàn từ CSDL rồi thêm vào Data Grid View
        public void DocLoai()
        {
            this.dsLoaiPhanMem = new DAL_LoaiPM().Doc();

            DataTable dt = new DataTable();
            dt.Columns.Add("MaLoai");
            dt.Columns.Add("TenLoai");

            foreach (LOAIPHANMEM nph in dsLoaiPhanMem)
            {
                DataRow row = dt.NewRow();
                row["MaLoai"] = nph.MALOAI;
                row["TenLoai"] = nph.TENLOAI;
                dt.Rows.Add(row);
            }

            this.dgvLoai.DataSource = dt;
        }

        public void DocPhanMem(int ma)
        {
            List<PHANMEM> dsPhanMem = new DAL_PhanMem().DocTheoLoai(ma);

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
