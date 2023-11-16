using Krypton.Toolkit;
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
    public partial class FormMain : FormChung
    {       
        public FormMain()
        {
            InitializeComponent();

            this.btnKey.Click += BtnTongQuan_Click;
            this.btnTaiKhoan.Click += BtnTaiKhoan_Click;
            this.btnNPH.Click += BtnNPH_Click;
            this.btnTheLoai.Click += BtnTheLoai_Click;
            this.btnSanPham.Click += BtnSanPham_Click;
            this.btnHoaDon.Click += BtnHoaDon_Click;
            this.btnThongKe.Click += BtnHeThong_Click;

            this.Load += FormMain_Load;
        }

        private void BtnHeThong_Click(object sender, EventArgs e)
        {
            Program.DisplayChildForm(Program.formHeThong);
        }

        private void BtnHoaDon_Click(object sender, EventArgs e)
        {
            Program.DisplayChildForm(Program.formHoaDon);
        }

        private void BtnSanPham_Click(object sender, EventArgs e)
        {
            Program.DisplayChildForm(Program.formSanPham);
        }

        private void BtnTheLoai_Click(object sender, EventArgs e)
        {
            Program.DisplayChildForm(Program.formTheLoai);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Program.DisplayChildForm(Program.formTongQuan);
        }

        private void BtnTaiKhoan_Click(object sender, EventArgs e)
        {
            Program.DisplayChildForm(Program.formTaiKhoan);
        } 

        private void BtnTongQuan_Click(object sender, EventArgs e)
        {
            Program.DisplayChildForm(Program.formKeySanPham);
        }

        private void BtnNPH_Click(object sender, EventArgs e)
        {
            Program.DisplayChildForm(Program.formNPH);
        }

        

        
    }
}
