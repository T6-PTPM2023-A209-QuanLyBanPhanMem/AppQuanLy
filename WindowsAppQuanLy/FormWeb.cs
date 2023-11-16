using CefSharp.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GUI
{
    public partial class FormWeb : FormCon
    {
        public FormWeb(Form form) : base(form)
        {
            InitializeComponent();

            chromiumWebBrowser1.LoadUrl("https://qlbanphanmem.azurewebsites.net/");

            DocBanner();

            this.cbxPhanMem.DataSource = new DAL_PhanMem().Doc();
            this.cbxPhanMem.DisplayMember = "TENPM";
            this.cbxPhanMem.ValueMember = "MAPM";
            this.pbHinh.SizeMode = PictureBoxSizeMode.StretchImage;

            this.btnChon.Click += BtnChon_Click;
            this.btnThem.Click += BtnThem_Click;
            this.btnCapNhat.Click += BtnCapNhat_Click;
            this.btnXoa.Click += BtnXoa_Click;
            this.dgvBanner.SelectionChanged += DgvBanner_SelectionChanged;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (!DAL_Banner.Xoa(Convert.ToInt32(dgvBanner.CurrentRow.Cells["BN_MaBN"].Value)))
            {
                MessageBox.Show("Xóa thất bại");
            }
            else
            {
                dgvBanner.Rows.Remove(dgvBanner.CurrentRow);
            }
        }

        private async void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (btnCapNhat.Text == "Cập nhật")
            {
                this.btnCapNhat.Text = "Lưu";
                this.cbxPhanMem.Enabled = true;
                this.btnChon.Visible = true;
                this.dgvBanner.Enabled = false;
            }
            else
            {
                try
                {
                    Banner banner = new Banner();

                    banner.MaBN = Convert.ToInt32(dgvBanner.CurrentRow.Cells["BN_MaBN"].Value);
                    banner.MaPM = Convert.ToInt32(cbxPhanMem.SelectedValue);
                    banner.HINHANH = pbHinh.Location.ToString();

                    if (!await DAL_Banner.CapNhatAsync(banner))
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                    else
                    {
                        DocBanner();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ");
                }

                this.btnCapNhat.Text = "Cập nhật";
                this.cbxPhanMem.Enabled = false;
                this.btnChon.Visible = false;
                this.dgvBanner.Enabled = true;
            }
        }

        private async void BtnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                this.btnThem.Text = "Lưu";
                this.cbxPhanMem.Enabled = true;
                this.btnChon.Visible = true;
                this.dgvBanner.Enabled = false;
            }
            else
            {
                try
                {
                    Banner banner = new Banner();

                    banner.MaPM = Convert.ToInt32(cbxPhanMem.SelectedValue);
                    banner.HINHANH = pbHinh.ImageLocation.ToString();


                    if (!await DAL_Banner.ThemAsync(banner))
                    {
                        MessageBox.Show("Thêm thất bại");
                        dgvBanner.Rows[0].Selected = true;
                    }
                    else
                    {
                        DocBanner();
                        dgvBanner.Rows[dgvBanner.Rows.Count - 1].Selected = true;
                        DgvBanner_SelectionChanged(this, null);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ");
                }

                this.btnThem.Text = "Thêm";
                this.cbxPhanMem.Enabled = false;
                this.btnChon.Visible = false;
                this.dgvBanner.Enabled = true;
            }
        }

        private void DgvBanner_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBanner.CurrentRow != null)
            {
                this.cbxPhanMem.SelectedValue = Convert.ToInt32(dgvBanner.CurrentRow.Cells["BN_MaPM"].Value);

                if (dgvBanner.CurrentRow.Cells["BN_HinhAnh"].Value.ToString() == String.Empty)
                {
                    pbHinh.ImageLocation = "Images/ho_so.png";
                }
                else
                {
                    pbHinh.ImageLocation = dgvBanner.CurrentRow.Cells["BN_HinhAnh"].Value.ToString();
                }
            }
        }

        private void BtnChon_Click(object sender, EventArgs e)
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

        private void DocBanner()
        {
            List<Banner> dsBanner = DAL_Banner.Doc();

            DataTable dt = new DataTable();
            dt.Columns.Add("MaBN");
            dt.Columns.Add("MaPM");
            dt.Columns.Add("TenPM");
            dt.Columns.Add("HinhAnh");

            foreach (Banner b in dsBanner)
            {
                DataRow row = dt.NewRow();
                row["MaBN"] = b.MaBN;
                row["MaPM"] = b.MaPM;
                row["TenPM"] = b.PHANMEM.TENPM;
                row["HinhAnh"] = b.HINHANH;
                dt.Rows.Add(row);
            }

            this.dgvBanner.DataSource = dt;
        }
    }
}
