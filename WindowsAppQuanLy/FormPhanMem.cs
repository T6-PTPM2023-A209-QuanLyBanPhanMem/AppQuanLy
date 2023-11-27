using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVienControls;
using DAL;

namespace WindowsAppQuanLy.GUI
{
    public partial class FormPhanMem : FormCon
    {
        Dictionary<string, string> DanhMucThoiHan = new Dictionary<string, string>()
            {
                { "Ngày", "Ngày"},
                { "Tuần", "Tuần"},
                { "Tháng", "Tháng"},
                { "Năm", "Năm"},
                { "Vĩnh viễn", "Vĩnh viễn"}
            };

        List<PHANMEM> dsPhanMem = new List<PHANMEM>();
        List<HOADON> dsHoaDon = new List<HOADON>();

        public FormPhanMem(Form form) : base(form)
        {
            InitializeComponent();
            DocPhanMem();
            DocNPH();

            this.btnHinh.Visible = false;
            this.cbxDonViThoiHan.DisplayMember = "Key";
            this.cbxDonViThoiHan.ValueMember = "Value";
            this.cbxDonViThoiHan.DataSource = DanhMucThoiHan.ToList();
            this.pbHinh.SizeMode = PictureBoxSizeMode.StretchImage;
            this.dgvPhanMem.SelectionChanged += DgvPhanMem_SelectionChanged;
            this.btnHinh.Click += BtnHinh_Click;
            this.btnThem.Click += BtnThem_Click;
            this.btnCapNhat.Click += BtnCapNhat_Click;
            this.btnXoa.Click += BtnXoa_Click;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DAL_PhanMem service = new DAL_PhanMem();

            if (!service.Xoa(Convert.ToInt32(dgvPhanMem.CurrentRow.Cells["MaPM"].Value.ToString())))
            {
                MessageBox.Show("Xóa thất bại");
            }
            else
            {
                dgvHoaDon.Rows.Remove(dgvPhanMem.CurrentRow);
            }
        }

        private async void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (btnCapNhat.Text == "Cập nhật")
            {
                this.btnCapNhat.Text = "Lưu";
                this.txtTenPM.ReadOnly = false;
                this.txtMoTa.ReadOnly = false;
                this.txtThoiHan.ReadOnly = false;
                this.txtDonGia.ReadOnly = false;
                this.dgvPhanMem.Enabled = false;
                this.btnHinh.Visible = true;
            }
            else
            {
                try
                {
                    DAL_PhanMem service = new DAL_PhanMem();

                    PHANMEM pm = new PHANMEM();
                    pm.MAPM = Convert.ToInt32(dgvPhanMem.CurrentRow.Cells["MaPM"].Value.ToString());
                    pm.TENPM = txtTenPM.Text;
                    pm.MOTA = txtMoTa.Text;
                    pm.THOIHAN = Convert.ToInt32(txtThoiHan.Text);
                    pm.DONVITHOIHAN = cbxDonViThoiHan.SelectedText;
                    pm.MANPH = Convert.ToInt32(cbxNPH.SelectedValue.ToString());
                    pm.NGAYPHATHANH = dtpNgayPhatHanh.Value;
                    pm.DONGIA = Convert.ToInt32(txtDonGia.Text);
                    pm.HINHANH = this.pbHinh.ImageLocation;

                    if (!await service.CapNhatAsync(pm))
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                    else
                    {
                        DocPhanMem();
                    }

                    
                }
                catch (Exception)
                {

                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ");
                }

                this.txtTenPM.ReadOnly = true;
                this.txtMoTa.ReadOnly = true;
                this.txtThoiHan.ReadOnly = true;
                this.txtDonGia.ReadOnly = true;
                this.dgvPhanMem.Enabled = true;
                this.btnCapNhat.Text = "Cập nhật";
                this.dgvPhanMem.Enabled = true;
                this.btnHinh.Visible = false;
            }
        }

        private async void BtnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                this.btnThem.Text = "Lưu";
                this.txtTenPM.Clear();
                this.txtMoTa.Clear();
                this.txtDonGia.Clear();
                this.txtSoLuong.Text = "0";
                this.txtThoiHan.Clear();
                this.txtTenPM.ReadOnly = false;
                this.txtMoTa.ReadOnly = false;
                this.txtThoiHan.ReadOnly = false;
                this.txtDonGia.ReadOnly = false;
                this.dgvPhanMem.Enabled = false;
                this.btnHinh.Visible = true;
            }
            else
            {
                try
                {
                    DAL_PhanMem service = new DAL_PhanMem();

                    PHANMEM pm = new PHANMEM();
                    pm.TENPM = txtTenPM.Text;
                    pm.MOTA = txtMoTa.Text;
                    pm.THOIHAN = Convert.ToInt32(txtThoiHan.Text);
                    pm.DONVITHOIHAN = cbxDonViThoiHan.SelectedText;
                    pm.MANPH = Convert.ToInt32(cbxNPH.SelectedValue.ToString());
                    pm.NGAYPHATHANH = dtpNgayPhatHanh.Value;
                    pm.DONGIA = Convert.ToInt32(txtDonGia.Text);
                    pm.HINHANH = this.pbHinh.ImageLocation;


                    if (!await service.ThemAsync(pm))
                    {
                        MessageBox.Show("Thêm thất bại");
                        dgvPhanMem.Rows[0].Selected = true;
                    }
                    else
                    {
                        DocPhanMem();
                        dgvPhanMem.Rows[dgvPhanMem.Rows.Count - 1].Selected = true;
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ");
                }

                this.txtTenPM.ReadOnly = true;
                this.txtMoTa.ReadOnly = true;
                this.txtThoiHan.ReadOnly = true;
                this.txtDonGia.ReadOnly = true;
                this.dgvPhanMem.Enabled = true;
                this.btnThem.Text = "Thêm";
                this.dgvPhanMem.Enabled = true;
                this.btnHinh.Visible = false;
            }
        }

        private void BtnHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image Files (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG| All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            this.pbHinh.ImageLocation = openFileDialog1.FileName;
        }

        private async Task ThemHinh()
        {
            if (dgvPhanMem.CurrentRow.Cells["HinhAnh"].Value.ToString() == String.Empty)
            {
                pbHinh.ImageLocation = "Images/ho_so.png";
            }
            else
            {
                pbHinh.ImageLocation = dgvPhanMem.CurrentRow.Cells["HinhAnh"].Value.ToString();
            }
        }

        private void DgvPhanMem_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhanMem.CurrentRow != null)
            {
                int maPM = Convert.ToInt32(dgvPhanMem.CurrentRow.Cells["MaPM"].Value.ToString());
                DocHoaDon(maPM);

                ThemHinh();

                this.txtTenPM.Text = dgvPhanMem.CurrentRow.Cells["TenPM"].Value.ToString();
                this.txtMoTa.Text = dgvPhanMem.CurrentRow.Cells["MoTa"].Value.ToString();
                this.txtDonGia.Text = dgvPhanMem.CurrentRow.Cells["DonGia"].Value.ToString();
                this.txtSoLuong.Text = dgvPhanMem.CurrentRow.Cells["SoLuong"].Value.ToString();
                this.dtpNgayPhatHanh.Value = DateTime.Parse(dgvPhanMem.CurrentRow.Cells["NgayPhatHanh"].Value.ToString());
                this.cbxNPH.SelectedValue = Convert.ToInt32(dgvPhanMem.CurrentRow.Cells["MaNPH"].Value.ToString());
                this.txtThoiHan.Text = dgvPhanMem.CurrentRow.Cells["ThoiHan"].Value.ToString();
                this.cbxDonViThoiHan.SelectedValue = dgvPhanMem.CurrentRow.Cells["DonViThoiHan"].Value.ToString();

                txtSoLuotMua.Text = DAL_PhanMem.DemSoLuongDaBan(maPM).ToString();
                txtSoLuongTonKho.Text = DAL_PhanMem.DemSoLuongTonKho(maPM).ToString();
                txtTongDoanhThu.Text = DAL_PhanMem.TinhDoanhThu(maPM).ToString();
            }
        }

        public void DocPhanMem()
        {
            this.dsPhanMem = new DAL_PhanMem().Doc();

            DataTable dt = new DataTable();
            dt.Columns.Add("MaPM");
            dt.Columns.Add("TenPM");
            dt.Columns.Add("TenNPH");
            dt.Columns.Add("MoTa");
            dt.Columns.Add("NgayPhatHanh");
            dt.Columns.Add("ThoiHan");
            dt.Columns.Add("DonViThoiHan");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("HinhAnh");
            dt.Columns.Add("MaNPH");

            foreach (PHANMEM pm in dsPhanMem)
            {
                DataRow row = dt.NewRow();
                row["MaPM"] = pm.MAPM;
                row["TenPM"] = pm.TENPM;
                row["TenNPH"] = pm.NHAPHATHANH.TENNPH;
                row["MaNPH"] = pm.MANPH;
                row["MoTa"] = pm.MOTA;
                row["NgayPhatHanh"] = ((DateTime)pm.NGAYPHATHANH).ToShortDateString();
                row["ThoiHan"] = pm.THOIHAN;
                row["DonViThoiHan"] = pm.DONVITHOIHAN;
                row["DonGia"] = pm.DONGIA;
                row["SoLuong"] = pm.SOLUONG;
                row["HinhAnh"] = pm.HINHANH;
                dt.Rows.Add(row);
            }

            this.dgvPhanMem.DataSource = dt;
        }   

        public void DocNPH()
        {
            this.cbxNPH.DisplayMember = "TENNPH";
            this.cbxNPH.ValueMember = "MANPH";
            this.cbxNPH.DataSource = new DAL_NPH().Doc();
        }

        public void DocHoaDon(int ma)
        {
            this.dsHoaDon = new DAL_HoaDon().DocTheoPhanMem(ma);

            DataTable dt = new DataTable();
            dt.Columns.Add("MaHD");
            dt.Columns.Add("ThoiGianLap");

            foreach (HOADON hd in dsHoaDon)
            {
                DataRow row = dt.NewRow();
                row["MaHD"] = hd.MAHD;
                row["ThoiGianLap"] = hd.THOIGIANLAP;
                dt.Rows.Add(row);
            }

            this.dgvHoaDon.DataSource = dt;
        }
    }
}
