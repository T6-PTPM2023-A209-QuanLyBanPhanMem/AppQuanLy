using DAL;
using ExcelDataReader;
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

namespace GUI
{
    public partial class FormKeyPhanMem : FormCon
    {
        public FormKeyPhanMem(Form form) : base(form)
        {
            InitializeComponent();

            DocPhanMem();

            this.dgvPhanMem.SelectionChanged += DgvPhanMem_SelectionChanged;
            this.dgvCTPM.DataSource = DAL_ChiTietPhanMem.Doc();

            this.btnThem.Click += BtnThem_Click;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = @".\";
                openFileDialog1.Filter = "Excel files (*.XLSX)|*.XLSX| All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 0;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                this.txtMaNPH.Text = openFileDialog1.FileName;

                if (this.txtMaNPH.Text != String.Empty)
                {
                    using (var stream = File.Open(this.txtMaNPH.Text, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            txtTenNPH.Text = (reader.RowCount - 1).ToString();
                        }
                    }

                    btnThem.Text = "Lưu";
                }
            }
            else
            {
                using (var stream = File.Open(this.txtMaNPH.Text, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        reader.Read();

                        if (reader.GetString(0).Trim() == "MAPM" && reader.GetString(1).Trim() == "GIATRI"
                            && reader.GetString(2).Trim() == "TAIKHOAN" && reader.GetString(3).Trim() == "MATKHAU")
                        {
                            while (reader.Read())
                            {
                                KEYPM key = new KEYPM();
                                key.MAPM = Convert.ToInt32(reader.GetDouble(0));
                                key.GIATRI = reader.GetString(1);
                                key.TAIKHOAN = reader.GetString(2);
                                key.MATKHAU = reader.GetString(3);
                                key.TINHTRANG = 0;

                                DAL_ChiTietPhanMem.Them(key);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cấu trúc dữ liệu không khớp");
                        }
                    }
                }

                DgvPhanMem_SelectionChanged(this, null);
                txtMaNPH.Clear();
                btnThem.Text = "Thêm";
            }
        }

        private void DgvPhanMem_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhanMem.CurrentRow != null)
            {
                DocChiTietPhanMem(Convert.ToInt32(dgvPhanMem.CurrentRow.Cells["TK_MAPM"].Value));
            }
        }

        private void DocPhanMem()
        {
            List<PHANMEM> dsPhanMem = new DAL_PhanMem().Doc();

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

        private void DocChiTietPhanMem(int MaPM)
        {
            List<KEYPM> dsCTPM = DAL_ChiTietPhanMem.Doc(MaPM);

            DataTable dt = new DataTable();
            dt.Columns.Add("MaKey");
            dt.Columns.Add("TinhTrang");

            foreach (KEYPM key in dsCTPM)
            {
                DataRow row = dt.NewRow();
                row["MaKey"] = key.MAKEY;
                row["TinhTrang"] = key.TINHTRANG == 0 ? "Chưa bán" : "Đã bán";
                dt.Rows.Add(row);
            }

            this.dgvCTPM.DataSource = dt;
        }
    }
}
