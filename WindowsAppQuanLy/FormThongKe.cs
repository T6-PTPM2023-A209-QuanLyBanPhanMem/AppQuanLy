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
            }
        }
    }
}
