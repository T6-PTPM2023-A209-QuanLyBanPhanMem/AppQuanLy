using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVienControls;
using DAL;

namespace WindowsAppQuanLy.GUI
{
    public partial class FormHoaDon : FormCon
    {
        List<HOADON> dsHoaDon = new List<HOADON>();
        List<CTHD> dsCTHD = new List<CTHD>();
        public FormHoaDon(Form form) : base(form)
        {
            InitializeComponent();

            DocHoaDon();

            this.dgvHoaDon.SelectionChanged += DgvHoaDon_SelectionChanged;
        }

        private void DgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null)
            {
                DocCTHD(dgvHoaDon.CurrentRow.Cells["MaHD"].Value.ToString());

                this.txtMaHD.Text = dgvHoaDon.CurrentRow.Cells["MaHD"].Value.ToString();
                this.txtTenTK.Text = dgvHoaDon.CurrentRow.Cells["TenTK"].Value.ToString();
                this.txtThoiGianLap.Text = dgvHoaDon.CurrentRow.Cells["ThoiGianLap"].Value.ToString();
                this.txtThanhTien.Text = dgvHoaDon.CurrentRow.Cells["TongTien"].Value.ToString();
            }
        }

        // Đọc dữ liệu hóa đơn từ CSDL rồi thêm vào Data Grid View
        public void DocHoaDon()
        {
            this.dsHoaDon = new DAL_HoaDon().Doc();

            DataTable dt = new DataTable();
            dt.Columns.Add("MaHD");
            dt.Columns.Add("TenTK");
            dt.Columns.Add("ThoiGianLap");
            dt.Columns.Add("TongTien");
            dt.Columns.Add("TinhTrang");

            foreach (HOADON hd in dsHoaDon)
            {
                DataRow row = dt.NewRow();
                row["MaHD"] = hd.MAHD;
                row["TenTK"] = hd.TAIKHOAN.TENTK;
                row["TongTien"] = hd.TONGTIEN;
                row["ThoiGianLap"] = hd.THOIGIANLAP;
                row["TinhTrang"] = hd.TINHTRANG;
                dt.Rows.Add(row);
            }

            this.dgvHoaDon.DataSource = dt;
        }

        // Đọc dữ liệu chi tiết hóa đơn đang chọn từ CSDL rồi thêm vào Data Grid View
        public void DocCTHD(string ma)
        {
            this.dsCTHD = new DAL_CTHD().DocTheoHoaDon(ma);

            DataTable dt = new DataTable();
            dt.Columns.Add("MaPM");
            dt.Columns.Add("TenPM");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("ThanhTien");

            foreach (CTHD cthd in dsCTHD)
            {
                DataRow row = dt.NewRow();
                row["MaPM"] = cthd.MAPM;
                row["TenPM"] = cthd.PHANMEM.TENPM;
                row["SoLuong"] = cthd.SOLUONG;
                row["ThanhTien"] = cthd.THANHTIEN;
                dt.Rows.Add(row);
            }

            this.dgvCTHD.DataSource = dt;
        }
    }


}
