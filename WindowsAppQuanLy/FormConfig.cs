using DAL;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Bson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppQuanLy;

namespace GUI
{
    public partial class FormConfig : Krypton.Toolkit.KryptonForm
    {
        public FormConfig()
        {
            InitializeComponent();

            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            servers.Columns.Add("Path");

            foreach (DataRow row in servers.Rows)
            {
                row["Path"] = row["ServerName"] + @"\" + row["InstanceName"];
            }

            cbxMayChu.DataSource = servers;
            cbxMayChu.DisplayMember = "Path";
            cbxMayChu.ValueMember = "Path";

            cbxMayChu.SelectedValueChanged += CbxMayChu_SelectedValueChanged;
            cbxCSDL.DropDown += CbxCSDL_DropDown;
            txtTenTaiKhoan.KeyPress += TxtTenTaiKhoan_KeyPress;
            txtMatKhau.KeyPress += TxtMatKhau_KeyPress;
            btnTimKiem.Click += BtnTimKiem_Click;
            btnKetNoi.Click += BtnKetNoi_Click;
        }

        private void TxtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            TimKiemCSDL();
        }

        private void TxtTenTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            TimKiemCSDL();
        }

        private void BtnKetNoi_Click(object sender, EventArgs e)
        {
            if (DAL_SQL.LuuThongTinKetNoi(cbxMayChu.Text, cbxCSDL.Text, txtTenTaiKhoan.Text, txtMatKhau.Text))
            {
                Hide();
                Program.InitForm();
                Program.formDangNhap.Show();
            }
        }

        private void CbxCSDL_DropDown(object sender, EventArgs e)
        {
            TimKiemCSDL();
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemCSDL();
        }

        private void CbxMayChu_SelectedValueChanged(object sender, EventArgs e)
        {
            TimKiemCSDL();
        }

        void TimKiemCSDL()
        {
            List<string> dsCSDL = DAL_SQL.DocDanhSachCSDL(cbxMayChu.Text, txtTenTaiKhoan.Text, txtMatKhau.Text);
            cbxCSDL.DataSource = dsCSDL;
            btnKetNoi.Enabled = !dsCSDL.IsNullOrEmpty();
        }

        private void kryptonPalette1_PalettePaint(object sender, Krypton.Toolkit.PaletteLayoutEventArgs e)
        {

        }
    }
}
