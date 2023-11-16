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
    public partial class FormThongKe : FormCon
    {
        public FormThongKe(Form form) : base(form)
        {
            InitializeComponent();

            btnChon.Click += BtnChon_Click;
            btnPhanMem.Click += BtnPhanMem_Click;
            btnNPH.Click += BtnNPH_Click;
            btnHoaDon.Click += BtnHoaDon_Click;
            btnLoaiPM.Click += BtnLoaiPM_Click;
            btnCTPM.Click += BtnCTPM_Click;
            btnTaiKhoan.Click += BtnTaiKhoan_Click;
            btnTatCa.Click += BtnTatCa_Click;
        }

        private void BtnTatCa_Click(object sender, EventArgs e)
        {
            DAL_TaiKhoan.xuatExcel(txtDuongDan.Text);
            DAL_ChiTietPhanMem.xuatExcel(txtDuongDan.Text);
            DAL_LoaiPM.xuatExcel(txtDuongDan.Text);
            DAL_HoaDon.xuatExcel(txtDuongDan.Text);
            DAL_NPH.xuatExcel(txtDuongDan.Text);
            DAL_PhanMem.xuatExcel(txtDuongDan.Text);
        }

        private void BtnTaiKhoan_Click(object sender, EventArgs e)
        {
            DAL_TaiKhoan.xuatExcel(txtDuongDan.Text);
        }

        private void BtnCTPM_Click(object sender, EventArgs e)
        {
            DAL_ChiTietPhanMem.xuatExcel(txtDuongDan.Text);
        }

        private void BtnLoaiPM_Click(object sender, EventArgs e)
        {
            DAL_LoaiPM.xuatExcel(txtDuongDan.Text);
        }

        private void BtnHoaDon_Click(object sender, EventArgs e)
        {
            DAL_HoaDon.xuatExcel(txtDuongDan.Text);
        }

        private void BtnNPH_Click(object sender, EventArgs e)
        {
            DAL_NPH.xuatExcel(txtDuongDan.Text);
        }

        private void BtnPhanMem_Click(object sender, EventArgs e)
        {
            DAL_PhanMem.xuatExcel(txtDuongDan.Text);
        }

        private void BtnChon_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog1 = new FolderBrowserDialog();

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            this.txtDuongDan.Text = openFileDialog1.SelectedPath;

            if (txtDuongDan.Text != String.Empty)
            {
                btnPhanMem.Enabled = true;
                btnCTPM.Enabled = true;
                btnHoaDon.Enabled = true;
                btnLoaiPM.Enabled = true;
                btnNPH.Enabled = true;
                btnTaiKhoan.Enabled = true;
                btnTatCa.Enabled = true;
            }
            else
            {
                btnPhanMem.Enabled = false;
                btnCTPM.Enabled = false;
                btnHoaDon.Enabled = false;
                btnLoaiPM.Enabled = false;
                btnNPH.Enabled = false;
                btnTaiKhoan.Enabled = false;
                btnTatCa.Enabled = false;
            }
        }
    }
}
